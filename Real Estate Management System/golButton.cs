using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System
{
    class golButton:Button
    {
        
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(3,3,ClientSize.Width-7,ClientSize.Height-7);
           
            this.Region = new System.Drawing.Region(gp);
            base.OnPaint(pevent);
            
        }
        [Browsable(true)]

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // golButton
            // 
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter += new System.EventHandler(this.golButton_Enter);
            this.MouseEnter += new System.EventHandler(this.golButton_MouseEnter);
            this.ResumeLayout(false);

        }

        private void golButton_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void golButton_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            this.ForeColor = Color.Black;
        }

        
        
    }
}
