/* Copyright (c) 2016 Stefan Baumann
 * This code is distributed under the terms of the MIT License (https://opensource.org/licenses/MIT)
 * GitHub Repository: https://github.com/stefan-baumann/MultislitSimulator
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultislitSimulator.Rendering
{
    /// <summary>
    /// A base class for UI elements which rely on high-speed rendering and complete userpaint.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public abstract class RenderingSurfaceBase
        : Control
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderingSurfaceBase"/> class.
        /// </summary>
        protected RenderingSurfaceBase()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
        }

        /// <summary>
        /// Renders the content to specified <see cref="Graphics"/> object.
        /// </summary>
        /// <param name="g">The <see cref="Graphics"/> object.</param>
        protected abstract void Render(Graphics g);

        /// <summary>
        /// Renders the content of this <see cref="RenderingSurfaceBase"/> to a bitmap.
        /// </summary>
        /// <returns>A bitmap with a rendering of the content of this <see cref="RenderingSurfaceBase"/>.</returns>
        public Bitmap RenderToBitmap()
        {
            Bitmap result = new Bitmap(this.Width, this.Height);
            using (Graphics g = Graphics.FromImage(result))
            {
                this.Render(g);
            }
            return result;
        }

        /// <summary>
        /// Paints this <see cref="RenderingSurfaceBase"/> to the screen.
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            //Additional graphics buffering even though the control is already double-buffered itself - just to be sure
            using (BufferedGraphics g = BufferedGraphicsManager.Current.Allocate(e.Graphics, new Rectangle(Point.Empty, this.Size)))
            {
                this.Render(g.Graphics);

                g.Render();
            }

            base.OnPaint(e);
        }
    }
}
