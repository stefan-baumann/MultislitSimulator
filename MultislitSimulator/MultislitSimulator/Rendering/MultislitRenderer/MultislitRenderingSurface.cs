/* Copyright (c) 2016 Stefan Baumann
 * This code is distributed under the terms of the MIT License (https://opensource.org/licenses/MIT)
 * GitHub Repository: https://github.com/stefan-baumann/MultislitSimulator
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultislitSimulator.Rendering
{
    /// <summary>
    /// A control which can render multislit configurations.
    /// </summary>
    /// <seealso cref="MultislitSimulator.Rendering.RenderingSurfaceBase" />
    public class MultislitRenderingSurface
        : RenderingSurfaceBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultislitRenderingSurface"/> class.
        /// </summary>
        public MultislitRenderingSurface()
        {
            this.BackColor = Color.FromArgb(10, 10, 10);
        }

        private MultislitConfiguration configuration = new MultislitConfiguration(2, 1, Enumerable.Empty<WavelengthColorPair>());
        /// <summary>
        /// Gets or sets the multislit configuration.
        /// </summary>
        /// <value>
        /// The multislit configuration.
        /// </value>
        /// <exception cref="NullReferenceException">The configuration must not be null.</exception>
        public MultislitConfiguration Configuration
        {
            get
            {
                return this.configuration;
            }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("The configuration must not be null.");
                }

                if (value != this.configuration)
                {
                    this.configuration = value;
                    this.ReRender();
                }
            }
        }

        private bool rendering = true;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="MultislitRenderingSurface"/> is currently rendering.
        /// </summary>
        /// <value>
        ///   <c>true</c> if rendering; otherwise, <c>false</c>.
        /// </value>
        protected bool Rendering
        {
            get
            {
                return this.rendering;
            }
            set
            {
                if (value != this.rendering)
                {
                    this.rendering = value;
                    this.Invalidate();
                }
            }
        }



        /// <summary>
        /// The render thread in which all of the simulation and rendering work is done asynchronously.
        /// </summary>
        /// <value>
        /// The render thread.
        /// </value>
        protected Thread RenderThread { get; set; }

        /// <summary>
        /// Starts the re-rendering of the current simulation result.
        /// </summary>
        protected void ReRender()
        {
            if (this.RenderThread != null && this.RenderThread.IsAlive)
            {
                this.RenderThread.Abort();
            }

            this.RenderThread = new Thread((ThreadStart)(() =>
            {
                try
                {
                    this.Invoke((Action)(() => this.Rendering = true));
                    Bitmap result = this.RenderInternal();
                    this.Invoke((Action)(() =>
                    {
                        this.CurrentState = result;
                        this.Rendering = false;
                    }));
                }
                catch (ThreadAbortException e)
                {
                    //Is thrown when the thread is aborted due to another re-rendering starting; just swallow the exception
                }
                catch (Exception e)
                {
                    //Swallow the exception for now (for improved user experience) - will probably add a proper exception handling method later on
                }
            }))
            { IsBackground = true, Name = "MultislitSimulator-RenderThread", Priority = ThreadPriority.AboveNormal };

            this.RenderThread.Start();
        }

        /// <summary>
        /// The internal, overridable method in which all of the rendering takes place.
        /// </summary>
        /// <returns>The current rendering of the simulation.</returns>
        protected virtual Bitmap RenderInternal()
        {
            return MultislitRenderer.Render(this.configuration, this.Size, 1);
        }



        private object CurrentStateLockObject = new object();
        private Bitmap currentState = null;

        /// <summary>
        /// Gets or sets the latest rendering.
        /// </summary>
        /// <value>
        /// The state of the latest rendering.
        /// </value>
        protected Bitmap CurrentState
        {
            get
            {
                lock (this.CurrentStateLockObject)
                {
                    return this.currentState;
                }
            }
            set
            {
                lock (this.CurrentStateLockObject)
                {
                    if (this.currentState != value && this.currentState != null)
                    {
                        this.currentState.Dispose();
                    }
                    this.currentState = value;
                }
            }
        }

        private Brush OverlayBrush { get; set; } = new SolidBrush(Color.FromArgb(128, 0, 0, 0));
        /// <summary>
        /// Renders the content to specified <see cref="Graphics" /> object.
        /// </summary>
        /// <param name="g">The <see cref="Graphics" /> object.</param>
        protected override void Render(Graphics g)
        {
            if (this.CurrentState != null)
            {
                if (this.Size != this.CurrentState.Size)
                {
                    //Complete re-rendering for now - will add a separate method for just rendering the needed sections later
                    this.ReRender();
                }

                g.DrawImage(this.CurrentState, new Rectangle((this.Width - this.CurrentState.Width) / 2, (this.Height - this.CurrentState.Height) / 2, this.CurrentState.Width, this.CurrentState.Height));

                if (this.Rendering)
                {
                    g.FillRectangle(this.OverlayBrush, new Rectangle(0, 0, this.Width, this.Height));
                    g.DrawString("Rendering...", this.Font, Brushes.White, new Rectangle(Point.Empty, this.Size), new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                }
            }
            else
            {
                if (!this.Rendering)
                {
                    this.ReRender();
                }
            }
        }
    }
}
