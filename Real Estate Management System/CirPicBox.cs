using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System
{
    class CirPicBox:PictureBox
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, ClientSize.Width-1, ClientSize.Height-1);

            this.Region = new System.Drawing.Region(gp);
            base.OnPaint(pevent);

        }
    }
}
