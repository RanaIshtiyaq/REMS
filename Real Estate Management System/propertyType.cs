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
    public partial class propertyType : Form
    {
        public propertyType()
        {
            InitializeComponent();
        }
        public void show() {
            try
            {
                queryClass.selectds("Select * from propType");
                dgvPropType.DataSource = queryClass.ds.Tables[0];
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Confirm if you want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                this.Close();                
            }
        }

        private void propertyType_Load(object sender, EventArgs e)
        {
            queryClass.fr = this;
            queryClass.thm(pnadnew, pnTop, pnlHeadings, dgvPropType, dgpid,tbSearch);
            show();
        }

        private void tbPropName_MouseEnter(object sender, EventArgs e)
        {
            queryClass.enter(tbPropName,pnlName,lbPropertyName);
            pbUser.Image = Properties.Resources.pType1;
        }

        private void tbPropName_Leave(object sender, EventArgs e)
        {
            queryClass.leave( pnlName, lbPropertyName);           
            pbUser.Image = Properties.Resources.pTypeW;
        }

        private void propertyType_MouseClick(object sender, MouseEventArgs e)
        {
            this.ActiveControl =dgvPropType;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit = MessageBox.Show("Are you sure, You want to delete record", "Want Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iExit == DialogResult.Yes)
                {
                    string qry = string.Format("delete from propType where pId=@i");
                    queryClass.Delete(qry);
                    show();
                } btnDelete.Visible = false;
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
                if (string.IsNullOrEmpty(tbPropName.Text))
                {
                    queryClass.showMess("Please fill fields", Color.Red);
                }
                else
                {
                    DialogResult iExit = MessageBox.Show("Are you sure, You want to UPDATE record", "Want Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (iExit == DialogResult.Yes)
                    {
                        string qry = string.Format("update propType set pName='" + tbPropName.Text + "' where pId=@i");
                        queryClass.update(qry);
                        show();
                        tbPropName.Clear();
                        btnUpdate.Visible = false;
                        queryClass.showMess("Updated successful", Color.Green);
                    }
                }
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }

        private void dgvPropType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                queryClass.id = Convert.ToInt32(dgvPropType.Rows[e.RowIndex].Cells[0].Value.ToString());
                btnUpdate.Visible = false; btnDelete.Visible = true; tbPropName.Clear();
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }

        private void dgvPropType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnUpdate.Visible = true; btnDelete.Visible = false;
                tbPropName.Text = dgvPropType.Rows[e.RowIndex].Cells[1].Value.ToString();
                pbPtype.Image = Properties.Resources.age1;
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbPropName.Text))
                {
                    queryClass.showMess("Please fill fields", Color.Red);
                }
                else
                {
                    string qry = string.Format("insert into propType(pName)values('" + tbPropName.Text + "')");
                    queryClass.insert(qry);
                    show();
                    tbPropName.Clear();
                    queryClass.showMess("One record added", Color.Green);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);

            }
        }

        private void dgvPropType_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            queryClass.dgvra(dgvPropType);
        }

        private void tbPropName_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLaterNum(e);
        }
    }
}
