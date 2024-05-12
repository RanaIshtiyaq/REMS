using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System
{
   public partial class roundText : TextBox
    { 

        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // X-coordinate of upper-left corner or padding at start
            int nTopRect,// Y-coordinate of upper-left corner or padding at the top of the textbox
            int nRightRect, // X-coordinate of lower-right corner or Width of the object
            int nBottomRect,// Y-coordinate of lower-right corner or Height of the object
            //RADIUS, how round do you want it to be?
            int nheightRect, //height of ellipse 
            int nweightRect //width of ellipse
        );
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 2, this.Width-1, this.Height-1, 20, 40)); //play with these values till you are happy
            
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // roundText
            // 
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            //this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Size = new System.Drawing.Size(202, 24);
            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Enter += new System.EventHandler(this.roundText_Enter);
            this.Leave += new System.EventHandler(this.roundText_Leave);
            this.ResumeLayout(false);

        }
       public roundText()
        {
            InitializeComponent();
        }       
       private void roundText_Enter(object sender, EventArgs e)
       {
           if (this.BackColor == Color.DodgerBlue)
           {
               this.BackColor = Color.DarkBlue;
           }
           if (this.BackColor == Color.Orchid)
           {
               this.BackColor = Color.Fuchsia;
           }
           if (this.BackColor == Color.MediumSeaGreen)
           {
               this.BackColor = Color.SeaGreen;
           }           
       }
       private void roundText_Leave(object sender, EventArgs e)
       {
           if (this.BackColor == Color.DarkBlue)
           {
               this.BackColor = Color.DodgerBlue;
           }
           if (this.BackColor == Color.Fuchsia)
           {
               this.BackColor = Color.Orchid;
           }
           if (this.BackColor == Color.SeaGreen)
           {
               this.BackColor = Color.MediumSeaGreen;
           }
          
       }


       
      
    }
}