using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System
{
    public partial class seller : Form
    {
        public seller()
        {
            InitializeComponent();
        }
        int al;
        public void show()
        {
            try{
            queryClass.selectds("Select * from sellers");
            dgvSellers.DataSource = queryClass.ds.Tables[0];
            al = queryClass.ds.Tables[0].Rows.Count;
            Properties.Settings.Default.TotalSeller = al.ToString();
            Properties.Settings.Default.Save();
            } 
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void pbUp_Click(object sender, EventArgs e)
        {
            queryClass.controlMaxi(dgvSellers, pnlHeadings, pbUp, pbDown);
        }

        private void pbDown_Click(object sender, EventArgs e)
        {
            queryClass.controlMini(dgvSellers, pnlHeadings, pbUp, pbDown);
        }

        private void pnlHeadings_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pbUp_MouseEnter(object sender, EventArgs e)
        {
            lbHmax.Visible = true;
        }

        private void pbUp_MouseLeave(object sender, EventArgs e)
        {
            lbHmax.Visible = false;
        }

        private void pbDown_MouseEnter(object sender, EventArgs e)
        {
            lbHmin.Visible = true;
        }

        private void pbDown_MouseLeave(object sender, EventArgs e)
        {
            lbHmin.Visible = false;
        }

        private void tbPrID_MouseEnter(object sender, EventArgs e)
        {
            queryClass.enter(tbPrID,pnlPrid,lbPid);
            pbPrid.Image = Properties.Resources.pidC;
           
        }
        
        private void tbPrType_MouseEnter(object sender, EventArgs e)
        {
       
 
            queryClass.enter(tbPrType, pnlPType, lbPrType);
            pbPType.Image = Properties.Resources.pType1;

            pbPropName.Visible = false;
            dgvPropID.Visible = true;
        }

        private void pnlPrid_MouseEnter(object sender, EventArgs e)
        {
            dgvPropID.Visible = true;
        }

        private void pnAddNew_MouseEnter(object sender, EventArgs e)
        {            
            try
            {
                dgvPropID.Visible = false;
                queryClass.selectds("Select prId,pName,length,width,price,rooms,address from properties ");
                dgvPropID.DataSource = queryClass.ds.Tables[0];
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void pnAddNew_MouseClick(object sender, MouseEventArgs e)
        {
            this.ActiveControl = pnAddNew;
        }

        private void tbPrType_Leave(object sender, EventArgs e)
        {
            queryClass.leave(pnlPType, lbPrType);
            pbPType.Image = Properties.Resources.pTypeW;
            pbPropName.Visible = true;
        }
        private void tbSname_MouseEnter(object sender, EventArgs e)
        {
            queryClass.enter(tbSname,pnlBname,lbBname);
            pbBname.Image = Properties.Resources.buyerC;
            
        }

        private void tbSname_Leave(object sender, EventArgs e)
        {
            queryClass.leave( pnlBname, lbBname);
            pbBname.Image = Properties.Resources.BuyerW;
        }

        private void tbCnicB_MouseEnter(object sender, EventArgs e)
        {
            queryClass.enter(tbCnicB,pnlcnicBuy,lbCnicB);
            pbCnicB.Image = Properties.Resources.cnicC;
        }

        private void tbCnicB_Leave(object sender, EventArgs e)
        {
            queryClass.leave(pnlcnicBuy, lbCnicB);
            pbCnicB.Image = Properties.Resources.cnicW;
        }

        private void tbCell_MouseEnter(object sender, EventArgs e)
        {
            queryClass.enter(tbCell,pnlCity,lbCity);
            pbCell.Image = Properties.Resources.cellC;
        }

        private void tbCell_Leave(object sender, EventArgs e)
        {
            queryClass.leave(pnlCity, lbCity);
            pbCell.Image = Properties.Resources.cellW;
        }

        private void tbAdr_MouseEnter(object sender, EventArgs e)
        {
            queryClass.enter(tbAdr,pnlAdr,lbAdr);
            pbAdr.Image = Properties.Resources.address1;
        }

        private void tbAdr_Leave(object sender, EventArgs e)
        {
            queryClass.leave(pnlAdr, lbAdr);
            pbAdr.Image = Properties.Resources.addressW;
        }

        private void tbPrID_Leave(object sender, EventArgs e)
        {
            queryClass.leave(pnlPrid, lbPid);
            pbPrid.Image = Properties.Resources.pidW;
            pbPropName.Visible = true;
        }

        private void dgvPropID_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbPrType.Text = dgvPropID.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbPrID.Text = dgvPropID.Rows[e.RowIndex].Cells[0].Value.ToString();
                dgvPropID.Visible = false;
                this.ActiveControl = tbSname;
                pnlBname.BackColor = Color.OrangeRed;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
              if (string.IsNullOrEmpty(tbPrID.Text) || string.IsNullOrEmpty(tbPrType.Text) || string.IsNullOrEmpty(tbSname.Text) 
                        || string.IsNullOrEmpty(tbCnicB.Text) || string.IsNullOrEmpty(tbCell.Text) || string.IsNullOrEmpty(tbAdr.Text))
                  {
                        queryClass.showMess("Please fill fields", Color.Red);
                  }
              else{
                        string qry = string.Format("insert into sellers(prId,pName,sName,sCNIC,sCell,sAddress)values('" + tbPrID.Text + "','" + tbPrType.Text
                    + "','" + tbSname.Text + "','" + tbCnicB.Text + "','" + tbCell.Text + "','" + tbAdr.Text + "' )");
                        queryClass.insert(qry);
                        show();
                        queryClass.clrearC(pnAddNew);
                        queryClass.showMess("One record added", Color.Green);
                  }
                                      
             }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (queryClass.id == 0) { MessageBox.Show("Click on record for delete"); }
                else
                {
                    DialogResult iExit = MessageBox.Show("Are you sure, You want to DELETE record", "Want Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (iExit == DialogResult.Yes)
                    {
                        string qry = string.Format("delete from sellers where sId=@i");
                        queryClass.Delete(qry);
                        show();
                    } btnDelete.Visible = false;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbPrID.Text) || string.IsNullOrEmpty(tbPrType.Text) || string.IsNullOrEmpty(tbSname.Text)
                        || string.IsNullOrEmpty(tbCnicB.Text) || string.IsNullOrEmpty(tbCell.Text) || string.IsNullOrEmpty(tbAdr.Text))
                {
                    queryClass.showMess("Please fill fields", Color.Red);
                }
                else
                {
                    DialogResult iExit = MessageBox.Show("Are you sure, You want to UPDATE record", "Want Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (iExit == DialogResult.Yes)
                    {
                        string qry = string.Format("update sellers set prId='" + tbPrID.Text + "', pName='" + tbPrType.Text + "',sName='" + tbSname.Text + "',sCNIC='" + tbCnicB.Text
                            + "',sCell='" + tbCell.Text + "',sAddress='" + tbAdr.Text + "' where sId=@i");
                        queryClass.update(qry);
                        show();
                        queryClass.clrearC(pnAddNew);
                        btnUpdate.Visible = false;
                        queryClass.showMess("Updated successful", Color.Green);
                    }
                }
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            queryClass.clrearC(pnAddNew);
        }

        private void dgvSellers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                queryClass.id = Convert.ToInt32(dgvSellers.Rows[e.RowIndex].Cells[0].Value.ToString());
                btnUpdate.Visible = false; btnDelete.Visible = true; queryClass.clrearC(pnAddNew);
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }

        private void dgvSellers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pbDown_Click(null, null);
                btnUpdate.Visible = true; btnDelete.Visible = false;
                tbPrID.Text = dgvSellers.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbPrType.Text = dgvSellers.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbSname.Text = dgvSellers.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbCnicB.Text = dgvSellers.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbCell.Text = dgvSellers.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbAdr.Text = dgvSellers.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception x) { MessageBox.Show(x.Message); }

        }
        private void seller_Load(object sender, EventArgs e)
        {
            queryClass.fr = this;

            queryClass.thm(pnAddNew, pnTop, pnlHeadings, dgvSellers, dgvPropID,tbSearch);
            show();
        }

        private void dgvSellers_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            queryClass.dgvra(dgvSellers);
        }

        private void tbPrType_TextChanged(object sender, EventArgs e)
        {
            try
            {
                queryClass.selectds("Select prId,pName,length,width,price,rooms,address from properties where pName LIKE'%" + tbPrType.Text + "%'");
                dgvPropID.DataSource = queryClass.ds.Tables[0];
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }

        private void tbCnicB_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valNum(e);
        }

        private void tbPrType_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLatr(e);
        }

        private void tbCnicB_TextChanged(object sender, EventArgs e)
        {
            queryClass.valaCNICh(tbCnicB) ;
        }

        private void tbPrID_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valNum(e);
        }

        private void tbSname_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLatr(e);
        }

        private void tbCell_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valNum(e);
        }

        private void tbCell_TextChanged(object sender, EventArgs e)
        {
            queryClass.valaCellh(tbCell);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            queryClass.selectds("SELECT * FROM sellers where pName LIKE '%" + tbSearch.Text + "%'");
            dgvSellers.DataSource = queryClass.ds.Tables[0];
        }

        private void pnlHeadings_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSellers.Size == new System.Drawing.Size(1110, 355))
                pbUp_Click(null, null);
            else
                pbDown_Click(null, null);
        }

        private void tbSearch_MouseEnter(object sender, EventArgs e)
        {
            queryClass.enter(tbSearch, pnSearch, lbSearch);
        }

        private void tbSearch_MouseLeave(object sender, EventArgs e)
        {
            queryClass.leave(pnSearch, lbSearch);
        }
        
        private void dgvPropID_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            queryClass.dgvra(dgvPropID);
        }

    }
}
