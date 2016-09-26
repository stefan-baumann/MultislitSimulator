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
        /// Paints this <see cref="RenderingSurfaceBase"/> to the screen.
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            //Additional graphics buffering even though the control is already double-buffered itself - just to be sure
            using (BufferedGraphics g = BufferedGraphicsManager.Current.Allocate(e.Graphics, new Rectangle(Point.Empty, this.Size)))
            {
                this.Render(g.Graphics);

                //"Copyright notice" :P
                g.Graphics.DrawString("Stefan Baumann", this.Font, Brushes.White, new Rectangle(Point.Empty, new Size(this.Width - 10, this.Height - 5)), new StringFormat() { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Far });

                g.Render();
            }

            base.OnPaint(e);
        }
    }
}
