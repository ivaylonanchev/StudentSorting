using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PresentationLayer
{
    public class RoundedPanel : Panel
    {
        public int BorderRadius { get; set; } = 25;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rect = new RectangleF(0, 0, this.Width, this.Height);
            using (GraphicsPath path = GetRoundedRect(rect, BorderRadius))
            {
                e.Graphics.FillPath(new SolidBrush(this.BackColor), path);

                if (this.BorderStyle == BorderStyle.FixedSingle)
                {
                    using (Pen pen = new Pen(this.ForeColor, 1))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }
        }

        private GraphicsPath GetRoundedRect(RectangleF rect, float radius)
        {
            float diameter = radius * 2;
            RectangleF arcRect = new RectangleF(rect.Location, new SizeF(diameter, diameter));
            GraphicsPath path = new GraphicsPath();

            path.AddArc(arcRect, 180, 90);
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
