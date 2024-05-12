using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }
        public void showForm(Form f)
        {
            pnForms.Controls.Clear();
            f.TopLevel = false;
            pnForms.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        private void removePic() 
        {
            pnMenue.BackgroundImage = pnTopDb.BackgroundImage = null;
            foreach (Control c in pnMenue.Controls)
            {
                if (c is Button) { c.BackgroundImage = null; }
            }  
            
        }
        private void assignPic()
        {
            pnMenue.BackgroundImage = Properties.Resources.menuBG;
            pnTopDb.BackgroundImage = Properties.Resources.bgTop;
            foreach (Control c in pnMenue.Controls)
            {
                if (c is Button) { c.BackgroundImage = Properties.Resources.menuBG; }
            }            
        }
        private void gThemecc()
        {
            removePic();
            pnForms.BackColor = cbTheem.BackColor  = Color.MediumSeaGreen;
            pbLogo.Image = Properties.Resources.REMS_2_Green;
            pnTopDb.BackColor = pnMenue.BackColor = pbSetting.BackColor = Color.SeaGreen;
            foreach (Control c in pnMenue.Controls)
            {
                if (c is Button) { c.BackColor = Color.SeaGreen; }
            }
        }
        private void dThemecc()
        {
            assignPic();
            pbSetting.BackColor= pnForms.BackColor = cbTheem.BackColor = Color.DodgerBlue;
            pbLogo.Image = Properties.Resources.REMS_2_Defult;
        }
        private void pThemecc()
        {
            removePic();
            pnForms.BackColor = cbTheem.BackColor  = Color.Orchid;
            pbLogo.Image = Properties.Resources.REMS_2_pink;
            pnTopDb.BackColor = pnMenue.BackColor = pbSetting.BackColor = Color.Fuchsia;
            foreach (Control c in pnMenue.Controls)
            {
                if (c is Button) { c.BackColor = Color.Fuchsia; }
            }
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
            lbProp.Text = Properties.Settings.Default.TotalProp.ToString();
            lbSellerss.Text = Properties.Settings.Default.TotalSeller.ToString();
            lbBuyerss.Text = Properties.Settings.Default.TotalBuyer.ToString();
            queryClass.pnn = pnForms;
            if (Properties.Settings.Default.Theme == "Default")
            {
                pnMenue.BackgroundImage = Properties.Resources.menuBG ;
                dThemecc();
            }
            if (Properties.Settings.Default.Theme == "Green")
            {
                gThemecc();
            }
            if (Properties.Settings.Default.Theme == "Pink")
            {
                pThemecc();
            }
           
        }


        


        private void btnDb_Click(object sender, EventArgs e)
        {
            pnForms.Controls.Clear();
            pnForms.Controls.Add(pnTopDb);
            Dashbord_Load(null,null);
            pnForms.Controls.Add(pnDbcontrols);
            pnForms.Controls.Add(pnbuttonsrep);
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            propRegForm pr = new propRegForm();
            showForm(pr);
        }

        private void btnBuyer_Click(object sender, EventArgs e)
        {
            Buyers buy = new Buyers();
            showForm(buy);
        }

        private void btnSeller_Click(object sender, EventArgs e)
        {
            seller slr = new seller();
            showForm(slr);
        }

        private void btnDb_MouseEnter(object sender, EventArgs e)
        {
            btnDb.ForeColor = Color.OrangeRed;
            btnDb.BackColor = pnForms.BackColor;
            btnDb.Image = Properties.Resources.dbIconR;
        }

        private void btnDb_MouseLeave(object sender, EventArgs e)
        {
            btnDb.ForeColor = Color.White;
            btnDb.BackColor = pnMenue.BackColor;
            btnDb.Image = Properties.Resources.dbIconW;
        }

        private void btnProperties_MouseEnter(object sender, EventArgs e)
        {
            btnProperties.ForeColor = Color.OrangeRed;
            btnProperties.BackColor = pnForms.BackColor;
            btnProperties.Image = Properties.Resources.PropertyR;
        }

        private void btnProperties_MouseLeave(object sender, EventArgs e)
        {
            btnProperties.ForeColor = Color.White;
            btnProperties.BackColor = pnMenue.BackColor;
            btnProperties.Image = Properties.Resources.PropertyW;
        }

        private void btnBuyer_MouseEnter(object sender, EventArgs e)
        {
            btnBuyer.ForeColor = Color.OrangeRed;
            btnBuyer.BackColor = pnForms.BackColor;
            btnBuyer.Image = Properties.Resources.buyersR;
        }

        private void btnBuyer_MouseLeave(object sender, EventArgs e)
        {
            btnBuyer.ForeColor = Color.White;
            btnBuyer.BackColor = pnMenue.BackColor;
            btnBuyer.Image = Properties.Resources.buyersW;
        }

        private void btnSeller_MouseEnter(object sender, EventArgs e)
        {
            btnSeller.ForeColor = Color.OrangeRed;
            btnSeller.BackColor = pnForms.BackColor;
            btnSeller.Image = Properties.Resources.selerR;
        }

        private void btnSeller_MouseLeave(object sender, EventArgs e)
        {
            btnSeller.ForeColor = Color.White;
            btnSeller.BackColor = pnMenue.BackColor;
            btnSeller.Image = Properties.Resources.selerW;
        }

        private void btnReports_MouseLeave(object sender, EventArgs e)
        {
            btnReports.ForeColor = Color.White;
            btnReports.BackColor = pnMenue.BackColor;
            btnReports.Image = Properties.Resources.reportW;
        }

        private void btnReports_MouseEnter(object sender, EventArgs e)
        {
            btnReports.ForeColor = Color.OrangeRed;
            btnReports.BackColor = pnForms.BackColor;
            btnReports.Image = Properties.Resources.reportR;
        }


        private void btnReports_Click(object sender, EventArgs e)
        {
            if (btnBuYrRep.Visible == false) { showRepBut(); }
            else hideRepBut();
            
        }

        private void cbTheem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "Default" || Convert.ToString(cbTheem.SelectedItem) == "Default")
            {
                Properties.Settings.Default.Theme = "Default";
                dThemecc();

            }
            if (Properties.Settings.Default.Theme == "Green" || Convert.ToString(cbTheem.SelectedItem) == "Green")
            {
                Properties.Settings.Default.Theme = "Green";
                gThemecc();
            }
            if (Properties.Settings.Default.Theme == "Pink" || Convert.ToString(cbTheem.SelectedItem) == "Pink")
            {
                Properties.Settings.Default.Theme = "Pink";
                pThemecc();
            }
            Properties.Settings.Default.Save();
           // btnDb_Click(null, null);
            cbTheem.Visible = false;
            //Dashbord_Load(null,null);
            
            
        }
        public void showRepBut() 
        {
            btnReports.Image = Properties.Resources.reportR;
            btnBuYrRep.Show();
            btnSellrRep.Show();
            btnPropRp.Show();
        }
        public void hideRepBut() 
        {
            btnBuYrRep.Hide();
            btnSellrRep.Hide();
            btnPropRp.Hide();
        }
        private void btnPropRp_Click(object sender, EventArgs e)
        {
            hideRepBut();
            PropRep pr = new PropRep();
            showForm(pr);
        }

        private void btnBuYrRep_Click(object sender, EventArgs e)
        {
            hideRepBut();
            Buyer_Report br = new Buyer_Report();
            showForm(br);
        }

        private void btnSellrRep_Click(object sender, EventArgs e)
        {
            hideRepBut();
            sellerRep sr = new sellerRep();
            showForm(sr);
        }

        private void btnPropRp_MouseEnter(object sender, EventArgs e)
        {
            btnPropRp.ForeColor = Color.OrangeRed;
            btnPropRp.BackColor = pnForms.BackColor;
            btnPropRp.Image = Properties.Resources.pRepR;
        }

        private void btnPropRp_MouseLeave(object sender, EventArgs e)
        {
            btnPropRp.ForeColor = Color.White;
            btnPropRp.BackColor = pnMenue.BackColor;
            btnPropRp.Image = Properties.Resources.pRepW;
        }

        private void btnBuYrRep_MouseEnter(object sender, EventArgs e)
        {
            btnBuYrRep.ForeColor = Color.OrangeRed;
            btnBuYrRep.BackColor = pnForms.BackColor;
            btnBuYrRep.Image = Properties.Resources.bRepR;
        }

        private void btnBuYrRep_MouseLeave(object sender, EventArgs e)
        {
            btnBuYrRep.ForeColor = Color.White;
            btnBuYrRep.BackColor = pnMenue.BackColor;
            btnBuYrRep.Image = Properties.Resources.bRepW;
        }

        private void btnSellrRep_MouseEnter(object sender, EventArgs e)
        {
            btnSellrRep.ForeColor = Color.OrangeRed;
            btnSellrRep.BackColor = pnForms.BackColor;
            btnSellrRep.Image = Properties.Resources.sRepR;
        }

        private void btnSellrRep_MouseLeave(object sender, EventArgs e)
        {
            btnSellrRep.ForeColor = Color.White;
            btnSellrRep.BackColor = pnMenue.BackColor;
            btnSellrRep.Image = Properties.Resources.sRepW;
        }

        private void btnpType_MouseEnter(object sender, EventArgs e)
        {
            btnpType.ForeColor = Color.OrangeRed;
            btnpType.BackColor = pnForms.BackColor;
            btnpType.Image = Properties.Resources.PropertyR;
        }

        private void btnpType_MouseLeave(object sender, EventArgs e)
        {
            btnpType.ForeColor = Color.White;
            btnpType.BackColor = pnMenue.BackColor;
            btnpType.Image = Properties.Resources.PropertyW;
        }

        private void btnpType_Click(object sender, EventArgs e)
        {
            propertyType pt = new propertyType();
            showForm(pt);
        }

        private void pbSetting_Click(object sender, EventArgs e)
        {
            if(cbTheem.Visible == false)
            cbTheem.Visible = true;
            else
                cbTheem.Visible = false;
        }

        private void pbSetting_MouseEnter(object sender, EventArgs e)
        {
            pbSetting.Image = Properties.Resources.setting;
        }

        private void pbSetting_MouseLeave(object sender, EventArgs e)
        {
            pbSetting.Image = Properties.Resources.settingW;

        }





    }
}
