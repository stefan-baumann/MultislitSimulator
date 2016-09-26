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
    public abstract class RenderingSurfaceBase
        : Control
    {
        protected RenderingSurfaceBase()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
        }

        protected abstract void Render(Graphics g);

        protected override void OnPaint(PaintEventArgs e)
        {
            //e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            using (BufferedGraphics g = BufferedGraphicsManager.Current.Allocate(e.Graphics, new Rectangle(Point.Empty, this.Size)))
            {
                //g.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                this.Render(g.Graphics);

                g.Graphics.DrawString("Stefan Baumann", this.Font, Brushes.White, new Rectangle(Point.Empty, new Size(this.Width - 10, this.Height - 5)), new StringFormat() { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Far });

                g.Render();
            }

            base.OnPaint(e);
        }
    }
}
