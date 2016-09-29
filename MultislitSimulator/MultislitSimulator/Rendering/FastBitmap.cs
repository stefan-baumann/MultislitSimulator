/* Copyright (c) 2016 Stefan Baumann
 * This code is distributed under the terms of the MIT License (https://opensource.org/licenses/MIT)
 * GitHub Repository: https://github.com/stefan-baumann/MultislitSimulator
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace MultislitSimulator.Rendering
{
    /// <summary>
    /// A wrapper for a <see cref="Bitmap"/> with heavily accelerated single pixel access.
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public class FastBitmap
        : IDisposable
    {
        /// <summary>
        /// Creates a new <see cref="FastBitmap"/> with the specified size and a black background.
        /// </summary>
        /// <param name="size">The size of the <see cref="FastBitmap"/> to be created.</param>
        public FastBitmap(Size size)
            : this(size.Width, size.Height)
        { }

        /// <summary>
        /// Creates a new <see cref="FastBitmap"/> with the specified size and a black background.
        /// </summary>
        /// <param name="width">The width of the <see cref="FastBitmap"/> to be created.</param>
        /// <param name="height">The height of the <see cref="FastBitmap"/> to be created.</param>
        public FastBitmap(int width, int height)
            : this(width, height, Color.Black)
        { }

        /// <summary>
        /// Creates a new <see cref="FastBitmap"/> with the specified size and background color.
        /// </summary>
        /// <param name="width">The width of the <see cref="FastBitmap"/> to be created.</param>
        /// <param name="height">The height of the <see cref="FastBitmap"/> to be created.</param>
        /// <param name="background">The initial background color of this <see cref="FastBitmap"/>.</param>
        public FastBitmap(int width, int height, Color background)
        {
            this.Width = width;
            this.Height = height;
            
            this.InternalBitmap = new Bitmap(this.Width, this.Height, PixelFormat.Format24bppRgb);
            using (Graphics g = Graphics.FromImage(this.InternalBitmap))
            {
                g.Clear(Color.FromArgb(255, background.R, background.G, background.B));
            }

            this.LockBitmap();
        }

        /// <summary>
        /// Creates a new <see cref="FastBitmap"/> with the specified size and background color.
        /// </summary>
        /// <param name="size">The size of the <see cref="FastBitmap"/> to be created.</param>
        /// <param name="background">The initial background color of this <see cref="FastBitmap"/>.</param>
        public FastBitmap(Size size, Color background)
            : this(size.Width, size.Height, background)
        { }



        /// <summary>
        /// Internally used variable describing the byte layout in the 24bppRgb pixel format (if it is RGB or BGR)
        /// </summary>
        protected internal static readonly bool IsRgb;

        /// <summary>
        /// Statically initializes the <see cref="FastBitmap"/> class.
        /// </summary>
        /// <exception cref="Exception">Unable to detect bitmap pixel layout.</exception>
        static unsafe FastBitmap()
        {
            //Check the byte layout in the 24bppRgb format
            using (Bitmap bmp = new Bitmap(1, 1, PixelFormat.Format24bppRgb))
            {
                bmp.SetPixel(0, 0, Color.Red);
                BitmapData data = bmp.LockBits(new Rectangle(0, 0, 1, 1), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                byte* bmpPtr = (byte*)data.Scan0;

                if (bmpPtr[0] == 0xFF)
                {
                    Debug.WriteLine("FastBitmap: RGB bitmap pixel layout detected.");
                    FastBitmap.IsRgb = true;
                }
                else if (bmpPtr[2] == 0xFF)
                {
                    Debug.WriteLine("FastBitmap: BGR bitmap pixel layout detected.");
                    FastBitmap.IsRgb = false;
                }
                else
                {
                    Debug.WriteLine("FastBitmap: Unable to detect bitmap pixel layout.");
                    throw new Exception("Unable to detect bitmap pixel layout.");
                }

                bmp.UnlockBits(data);
            }
        }



        /// <summary>
        /// Gets or sets the width of this <see cref="FastBitmap"/>.
        /// </summary>
        /// <value>
        /// The width of this <see cref="FastBitmap"/>.
        /// </value>
        public int Width { get; protected set; }

        /// <summary>
        /// Gets or sets the height of this <see cref="FastBitmap" />.
        /// </summary>
        /// <value>
        /// The height of this <see cref="FastBitmap" />.
        /// </value>
        public int Height { get; protected set; }

        private object pixelAccessLock = new object();
        /// <summary>
        /// Gets the <see cref="FastColor" /> value at the specified coordinates of this <see cref="FastBitmap" />.
        /// </summary>
        /// <value>
        /// The <see cref="FastColor" /> value at the specified coordinates of this <see cref="FastBitmap" />.
        /// </value>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <returns>
        /// The <see cref="FastColor" /> value at the specified coordinates of this <see cref="FastBitmap" />.
        /// </returns>
        public unsafe FastColor this[int x, int y]
        {
            get
            {
                if (x < 0 || x >= this.Width)
                {
                    throw new ArgumentOutOfRangeException("x");
                }
                if (y < 0 || y >= this.Height)
                {
                    throw new ArgumentOutOfRangeException("y");
                }

                //lock (this.PixelAccessLock)
                {
                    if (!this.Locked)
                    {
                        this.LockBitmap();
                    }

                    byte* pointer = ((byte*)this.BitmapData.Scan0 + y * this.BitmapData.Stride + x * 3);
                    if (FastBitmap.IsRgb)
                    {
                        return new FastColor(pointer[2], pointer[1], pointer[0]);
                    }
                    else
                    {
                        return ((FastColor*)pointer)[0];
                    }
                }
            }
            set
            {
                if (x < 0 || x >= this.Width)
                {
                    throw new ArgumentOutOfRangeException("x");
                }
                if (y < 0 || y >= this.Height)
                {
                    throw new ArgumentOutOfRangeException("y");
                }

                //lock (this.PixelAccessLock)
                {
                    if (!this.Locked)
                    {
                        this.LockBitmap();
                    }
                    
                    byte* pointer = ((byte*)this.BitmapData.Scan0 + y * this.BitmapData.Stride + x * 3);
                    if (FastBitmap.IsRgb)
                    {
                        pointer[2] = value.R;
                        pointer[1] = value.G;
                        pointer[0] = value.B;
                    }
                    else
                    {
                        ((FastColor*)pointer)[0] = value;
                    }
                }
            }
        }



        /// <summary>
        /// The internal <see cref="Bitmap" />.
        /// </summary>
        /// <value>
        /// The internal bitmap.
        /// </value>
        public Bitmap InternalBitmap { get; protected internal set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="FastBitmap" /> is locked.
        /// </summary>
        /// <value>
        /// <c>true</c> if this <see cref="FastBitmap" /> is locked; otherwise, <c>false</c>.
        /// </value>
        protected internal bool Locked { get; set; }

        /// <summary>
        /// Gets or sets the internal bitmap data.
        /// </summary>
        /// <value>
        /// The internal bitmap data.
        /// </value>
        protected internal BitmapData BitmapData { get; set; }

        private readonly object bitmapLockLockObject = new object();

        /// <summary>
        /// Locks the internal bitmap for access to its data.
        /// </summary>
        protected internal virtual void LockBitmap()
        {
            if (!this.Locked)
            {
                lock (this.bitmapLockLockObject)
                {
                    if (!this.Locked)
                    {
                        if (this.InternalBitmap == null || this.IsDisposed)
                        {
                            throw new NullReferenceException("Unable to lock the internal bitmap.");
                        }

                        this.BitmapData = this.InternalBitmap.LockBits(new Rectangle(0, 0, this.InternalBitmap.Width, this.InternalBitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                        this.Locked = true;
                    }
                }
            }
        }

        /// <summary>
        /// Unlocks the internal bitmap.
        /// </summary>
        protected internal virtual void UnlockBitmap()
        {
            if (this.Locked)
            {
                lock (this.bitmapLockLockObject)
                {
                    if (this.Locked)
                    {
                        if (this.InternalBitmap == null || this.IsDisposed)
                        {
                            throw new NullReferenceException("Unable to unlock the internal bitmap.");
                        }

                        this.InternalBitmap.UnlockBits(this.BitmapData);
                        this.Locked = false;
                        this.BitmapData = null;
                    }
                }
            }
        }

        /// <summary>
        /// Creates a clone of the the internal <see cref="Bitmap" />.
        /// </summary>
        /// <returns>
        /// A clone of the the internal <see cref="Bitmap" />.
        /// </returns>
        protected internal virtual Bitmap CloneInternalBitmap()
        {
            if (this.Locked)
            {
                this.UnlockBitmap();
            }

            return (Bitmap)this.InternalBitmap.Clone();
        }



        /// <summary>
        /// Gets a value indicating whether this <see cref="FastBitmap"/> is disposed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if disposed; otherwise, <c>false</c>.
        /// </value>
        public bool IsDisposed { get; private set; }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            lock (this.bitmapLockLockObject)
            {
                if (!this.IsDisposed)
                {
                    if (disposing)
                    {
                        if (this.Locked)
                        {
                            this.UnlockBitmap();
                        }

                        this.InternalBitmap.Dispose();
                    }

                    this.IsDisposed = true;
                }
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
        }
    }
}
