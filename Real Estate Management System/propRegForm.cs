using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System
{ 
    public partial class propRegForm : Form
    {
        public propRegForm()
        {
            InitializeComponent();
        }
        int al;
        public void show()
        {
            try
            {
                queryClass.selectds("Select * from properties ");
                dgvProperties.DataSource = queryClass.ds.Tables[0];
                 al= queryClass.ds.Tables[0].Rows.Count;
                 Properties.Settings.Default.TotalProp = al.ToString();
                 Properties.Settings.Default.Save();
            } 
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbPropName.Text) || string.IsNullOrEmpty(tbLength.Text) || string.IsNullOrEmpty(tbWidth.Text) 
                        || string.IsNullOrEmpty(tbPrice.Text) || string.IsNullOrEmpty(tbAgeBuild.Text) || string.IsNullOrEmpty(tbRooms.Text)
                        || string.IsNullOrEmpty(tbDrooms.Text)|| string.IsNullOrEmpty(tbCity.Text)|| string.IsNullOrEmpty(tbAdr.Text))
                    {
                        queryClass.showMess("Please fill the fields", Color.Red);
                    }
                        else
                        {
                            string qry = string.Format("insert into properties(pName,length,width,price,buildAge,rooms,dRooms,city,address)values('" + tbPropName.Text + "','" + tbLength.Text
                    + "','" + tbWidth.Text + "','" + tbPrice.Text + "','" + tbAgeBuild.Text + "','" + tbRooms.Text + "','" + tbDrooms.Text + "','" + tbCity.Text + "','" + tbAdr.Text + "'  )");
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
        private void btnReset_Click(object sender, EventArgs e)
        {
            queryClass.clrearC(pnAddNew);           
        }
        private void tbLength_Enter(object sender, EventArgs e)
        {
            queryClass.enter(tbLength,pnlLeng,lbLength);
            dgvPropType.Visible = false;
            pbLenWid.Image = Properties.Resources.length1;
        }

        private void tbLength_Leave(object sender, EventArgs e)
        {
            queryClass.leave(pnlLeng, lbLength);
            pbLenWid.Image = Properties.Resources.lenWidW;
        }

        private void tbWidth_Enter(object sender, EventArgs e)
        {
            queryClass.enter(tbWidth,pnlWidth,lbWidth);
            pbLenWid.Image = Properties.Resources.width1;
        }

        private void tbWidth_Leave(object sender, EventArgs e)
        {
            queryClass.leave( pnlWidth, lbWidth);
            pbLenWid.Image = Properties.Resources.lenWidW;
        }

        private void tbPrice_Enter(object sender, EventArgs e)
        {
            queryClass.enter(tbPrice,pnlPrice,lbPrice);
            pbPrice.Image = Properties.Resources.pPriceC;          
        }

        private void tbPrice_Leave(object sender, EventArgs e)
        {
            queryClass.leave( pnlPrice, lbPrice);
            pbPrice.Image = Properties.Resources.pPriceW;
        }

        private void tbAgeBuild_Enter(object sender, EventArgs e)
        {
            queryClass.enter(tbAgeBuild,pnlAge,lbAgeBuild);
            pbAge.Image = Properties.Resources.age1;            
        }

        private void tbAgeBuild_Leave(object sender, EventArgs e)
        {
            queryClass.leave(pnlAge,lbAgeBuild);
            pbAge.Image = Properties.Resources.ageW;
        }

        private void tbRooms_Enter(object sender, EventArgs e)
        {
            queryClass.enter(tbRooms,pnlRoom,lbRooms);
            pbRooms.Image = Properties.Resources.room1;
        }

        private void tbRooms_Leave(object sender, EventArgs e)
        {
            queryClass.leave(pnlRoom, lbRooms);
            pbRooms.Image = Properties.Resources.roomW;
        }

        private void tbDrooms_Enter(object sender, EventArgs e)
        {
            queryClass.enter(tbDrooms,pnlDroom,lbDrooms);
            pbDroom.Image = Properties.Resources.droom1;
        }

        private void tbDrooms_Leave(object sender, EventArgs e)
        {
            queryClass.leave(pnlDroom, lbDrooms);
            pbDroom.Image = Properties.Resources.dRoomW;
        }

        private void tbCity_Enter(object sender, EventArgs e)
        {
            queryClass.enter(tbCity,pnlCity,lbCity);
            pbCity.Image = Properties.Resources.CityC;
        }

        private void tbCity_Leave(object sender, EventArgs e)
        {
            queryClass.leave(pnlCity, lbCity);
            pbCity.Image = Properties.Resources.CityW;
        }

        private void tbAdr_Enter(object sender, EventArgs e)
        {
            queryClass.enter(tbAdr,pnlAdr,lbAdr);
            pbAdr.Image = Properties.Resources.address1;
        }
        private void tbAdr_Leave(object sender, EventArgs e)
        {
            queryClass.leave(pnlAdr,lbAdr);
            pbAdr.Image = Properties.Resources.addressW;
        }
        
        private void propRegForm_Load(object sender, EventArgs e)
        {            
            queryClass.fr = this;
            queryClass.thm(pnAddNew, pnTop, pnlHeadings, dgvProperties, dgvPropType,tbSearch);
            show();
           
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
                        string qry = string.Format("delete from properties where prId=@i");
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
                if (string.IsNullOrEmpty(tbPropName.Text) || string.IsNullOrEmpty(tbLength.Text) || string.IsNullOrEmpty(tbWidth.Text)
                        || string.IsNullOrEmpty(tbPrice.Text) || string.IsNullOrEmpty(tbAgeBuild.Text) || string.IsNullOrEmpty(tbRooms.Text)
                        || string.IsNullOrEmpty(tbDrooms.Text) || string.IsNullOrEmpty(tbCity.Text) || string.IsNullOrEmpty(tbAdr.Text))
                {
                    queryClass.showMess("Please fill fields", Color.Red);
                }
                else
                {
                    DialogResult iExit = MessageBox.Show("Are you sure, You want to UPDATE record", "Want Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (iExit == DialogResult.Yes)
                    {
                        string qry = string.Format("update properties set pName='" + tbPropName.Text + "',length='" + tbLength.Text + "',width='" + tbWidth.Text + "',price='" + tbPrice.Text
                            + "',buildAge='" + tbAgeBuild.Text + "',rooms='" + tbRooms.Text + "',dRooms='" + tbDrooms.Text + "',city='" + tbCity.Text + "',address='" + tbAdr.Text + "' where prId=@i");
                        queryClass.update(qry);
                        show();
                        btnUpdate.Visible = false;
                        btnDelete.Visible = false;
                        queryClass.clrearC(pnAddNew);
                        queryClass.showMess("Updated successful", Color.Green);
                    }
                }
            }
            catch (Exception x) { MessageBox.Show(x.Message); }        
        }
       
        private void tbPropName_Enter(object sender, EventArgs e)
        {
            queryClass.enter(tbPropName,pnlName,lbPropertyName);
            pbUser.Image = Properties.Resources.pType1;
            dgvPropType.Visible = true;
            pbPropName.Visible = false;
        }

        private void tbPropName_Leave(object sender, EventArgs e)
        {
            queryClass.leave( pnlName, lbPropertyName);
            pbPropName.Visible = true;
            pbUser.Image = Properties.Resources.pTypeW;
        }
        private void pnlName_MouseEnter(object sender, EventArgs e)
        {
            dgvPropType.Visible = true;
        }
        private void pnAddNew_MouseEnter(object sender, EventArgs e)
        {
            dgvPropType.Visible = false;
            try
            {
                queryClass.selectds("Select pName from propType");
                dgvPropType.DataSource = queryClass.ds.Tables[0];
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void pnAddNew_Click(object sender, EventArgs e)
        {
            this.ActiveControl = pnAddNew;
        }

        private void pbUp_Click(object sender, EventArgs e)
        {
            queryClass.controlMaxi(dgvProperties, pnlHeadings, pbUp, pbDown);
        }

        private void pbDown_Click(object sender, EventArgs e)
        {
            queryClass.controlMini(dgvProperties,pnlHeadings,pbUp,pbDown);  
        }
        private void pnlHeadings_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProperties.Size == new System.Drawing.Size(1110, 355))
                pbUp_Click(null, null);
            else
                pbDown_Click(null,null);
        }

        private void dgvProperties_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                queryClass.id = Convert.ToInt32(dgvProperties.Rows[e.RowIndex].Cells[0].Value.ToString());
                btnUpdate.Visible = false; btnDelete.Visible = true; queryClass.clrearC(pnAddNew);
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }

        private void dgvProperties_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pbDown_Click(null,null);
                btnUpdate.Visible = true; btnDelete.Visible = false;
                tbPropName.Text = dgvProperties.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbLength.Text = dgvProperties.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbWidth.Text = dgvProperties.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbPrice.Text = dgvProperties.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbAgeBuild.Text = dgvProperties.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbRooms.Text = dgvProperties.Rows[e.RowIndex].Cells[6].Value.ToString();
                tbDrooms.Text = dgvProperties.Rows[e.RowIndex].Cells[7].Value.ToString();
                tbCity.Text = dgvProperties.Rows[e.RowIndex].Cells[8].Value.ToString();
                tbAdr.Text = dgvProperties.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
            catch (Exception x) { MessageBox.Show(x.Message); }

        }

        private void dgvProperties_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            queryClass.dgvra(dgvProperties);
        }

        private void dgvPropType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                if (dgvPropType.Rows[e.RowIndex].Cells[0].Value.ToString() == "Add New")
                {
                    propertyType pt = new propertyType();
                    pt.TopLevel = false;
                    queryClass.pnn.Controls.Add(pt);
                    pt.Show();
                    pt.BringToFront();
                    pt.Location = new System.Drawing.Point(5, 272);
                    dgvPropType.Visible = false;
                }
                else
                {
                    dgvPropType.Visible = false;
                    tbPropName.Text = dgvPropType.Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.ActiveControl = tbLength;
                }
            }
            catch (Exception) { MessageBox.Show("Dont Select Header"); }
        }

        private void tbPropName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                queryClass.selectds("Select pName from propType where pName LIKE '%"+tbPropName.Text+"%'");
                dgvPropType.DataSource = queryClass.ds.Tables[0];
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void tbLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valNum(e);
        }

        private void tbWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valNum(e);
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valNum(e);
        }

        private void tbAgeBuild_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valNum(e);
        }

        private void tbRooms_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valNum(e);
        }

        private void tbDrooms_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valNum(e);
        }

        private void tbCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLatr(e);
        }

        private void tbAdr_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valadr(e);
        }

        private void tbSearch_MouseEnter(object sender, EventArgs e)
        {
            queryClass.enter(tbSearch, pnSearch, lbSearch);
        }

        private void tbSearch_MouseLeave(object sender, EventArgs e)
        {
            queryClass.leave( pnSearch, lbSearch);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

            queryClass.selectds("SELECT * FROM properties where pName LIKE '%" + tbSearch.Text + "%'");
                dgvProperties.DataSource = queryClass.ds.Tables[0];
        }

        private void dgvPropType_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            queryClass.dgvra(dgvPropType);
        }

    }
}
