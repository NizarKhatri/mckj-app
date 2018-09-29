using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;
using System.Data.SqlClient;
using Community;
using MCKJ.Common;
using System.Collections;

namespace MCKJ.Members
{
    public partial class frmNIC : Form
    {
        public frmNIC()
        {
            InitializeComponent();
        }

        int ID = 0;
        string Header = "Community ID Card";
        int mode = 0;
        string fcard_filter = "";

        private void Disable(bool disable)
        {
            btnAdd.Enabled = disable;
            btnDelete.Enabled = disable;
            btnEdit.Enabled = disable;
            btnPrint.Enabled = disable;
            dgvNIC.Visible = disable;
            btnView.Enabled = disable;
            txtNicSearch.Visible = disable;
            btnSearch.Visible = disable;
            btnReset.Visible = disable;
            lblSearchLabel.Visible = disable;
        }
        private void write_name()
        {
            pbGsSign.Text = "General Secratary Sign";
            pbMember.Text = "Member Snap";
            pbMemberSign.Text = "Member Sign";
        }

        private bool CheckField()
        {
            //bool check = false;
            if (txtAddress.TextLength > 94)
            {
                MessageBox.Show("Address length must not be exceeded to 94 characters", "Warning");
                return false;
            }
            if (mode == 0 && (txtMPath.Text == ""))
            {
                MessageBox.Show("Please fill the required field!!\nRequired fields are yellow in color", "Required Field cannot left blank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (txtFCardNo.Text == "" || cmbMemberName.Text == "" || txtCMIC.Text == "")
            {
                MessageBox.Show("Please fill the required field!!\nRequired fields are yellow in color", "Required Field cannot left blank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }
        static Image FixedSize(Image imgPhoto, int Width, int Height)
        {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)Width / (float)sourceWidth);
            nPercentH = ((float)Height / (float)sourceHeight);

            //if we have to pad the height pad both the top and the bottom
            //with the difference between the scaled height and the desired height
            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = (int)((Width - (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = (int)((Height - (sourceHeight * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(96, 96, PixelFormat.Format64bppPArgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.Transparent);
            grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }

        byte[] ReadFile(string sPath)
        {
            FileStream fs = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            byte[] photo = br.ReadBytes((int)fs.Length);


            br.Close();
            fs.Close();

            return photo;
            ////Initialize byte array with a null value initially.
            //byte[] data = null;

            ////Use FileInfo object to get file size.
            //FileInfo fInfo = new FileInfo(sPath);
            //long numBytes = fInfo.Length;       
            ////Open FileStream to read file
            //FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            //ImageConverter img = new ImageConverter();


            ////Use BinaryReader to read file stream into byte array.
            //BinaryReader br = new BinaryReader(fStream);

            ////When you use BinaryReader, you need to supply number of bytes to read from file.
            ////In this case we want to read entire file. So supplying total number of bytes.
            //data = br.ReadBytes((int)numBytes);                        
            //return data;
        }


        private void resize()
        {
        }
        private void EmptyFields()
        {
            txtAddress.Text = "";
            txtCMIC.Text = "";
            txtCNIC.Text = "";
            txtDOB.Text = "";
            txtFCardNo.Text = "";
            txtFName.Text = "";
            txtGFName.Text = "";
            txtMPath.Text = "";
            txtMSPath.Text = "";
            txtNukh.Text = "";
            txtOrakh.Text = "";
            txtPhoneNo.Text = "";
            txtGPath.Text = "";
            cmbBGroup.Text = null;
            cmbMemberName.Text = null;
            pbMember.Image = null;
            picMemberBox.Image = null;
            pbGsSign.Image = null;
            picBoxGeneralSec.Image = null;
            pbMemberSign.Image = null;
            picBoxMemberSign.Image = null;
            chkDuplicate.Checked = false;
            dtpDOB.Text = DateTime.Now.ToShortDateString();
            dtpIssueDate.Text = DateTime.Now.ToShortDateString();
            dtpValidUpto.Text = DateTime.Now.ToShortDateString();
        }

        private string grand_FatherName(string FCard, string MName)
        {
            string GrandFatherName = "";
            try
            {

                SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                con.Open();
                string query = "SELECT FatherName FROM tblFamilyMember WHERE FCardNo = '%F%' AND MemberName = '%M%'";
                query = query.Replace("%F%", FCard);
                query = query.Replace("%M%", MName);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    GrandFatherName = reader.GetValue(0).ToString();

                }
                else
                {
                    GrandFatherName = "";
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return GrandFatherName;
        }

        private byte[] Membersnap(int memberid)
        {
            byte[] Membersnap = null;
            try
            {

                SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                con.Open();
                string query = "SELECT Image FROM tblNIC WHERE ID = %F%";
                query = query.Replace("%F%", memberid.ToString());
                SqlCommand cmd = new SqlCommand(query, con);
                //SqlDataReader reader = cmd.ExecuteReader();

                //string type = reader.GetValue(0).GetType().ToString();
                //Membersnap = Convert.toireader.GetValue(0);
                Membersnap = (byte[])cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Membersnap;
        }

        private byte[] Membersign(int memberid)
        {
            byte[] MemberSign = null;
            try
            {

                SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                con.Open();
                string query = "SELECT MemberSign FROM tblNIC WHERE ID = %F%";
                query = query.Replace("%F%", memberid.ToString());
                SqlCommand cmd = new SqlCommand(query, con);
                //SqlDataReader reader = cmd.ExecuteReader();

                //string type = reader.GetValue(0).GetType().ToString();
                //Membersnap = Convert.toireader.GetValue(0);
                MemberSign = (byte[])cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return MemberSign;
        }


        private byte[] generalsecratary(int memberid)
        {
            byte[] Membersnap = null;
            try
            {

                SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                con.Open();
                string query = "SELECT SecretarySign FROM tblNIC WHERE ID = %F%";
                query = query.Replace("%F%", memberid.ToString());
                SqlCommand cmd = new SqlCommand(query, con);
                //SqlDataReader reader = cmd.ExecuteReader();

                //string type = reader.GetValue(0).GetType().ToString();
                //Membersnap = Convert.toireader.GetValue(0);
                Membersnap = (byte[])cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Membersnap;
        }

        private void View_ReadOnly(bool read)
        {
            txtCMIC.ReadOnly = read;
            txtCNIC.ReadOnly = read;
            txtFCardNo.ReadOnly = read;
            txtMPath.ReadOnly = read;
            txtMSPath.ReadOnly = read;
            txtNukh.ReadOnly = read;
            txtOrakh.ReadOnly = read;
            txtPhoneNo.ReadOnly = read;
            txtGPath.ReadOnly = read;
            cmbBGroup.Enabled = !read;
            cmbMemberName.Enabled = !read;
            btnGSBrowser.Enabled = !read;
            btnMBrowse.Enabled = !read;
            btnSBrowser.Enabled = !read;
            dtpDOB.Enabled = !read;
            dtpIssueDate.Enabled = !read;
            dtpValidUpto.Enabled = !read;
            btnSave.Enabled = !read;
            btnCancel.Enabled = !read;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            if (mode == 3)
            {
                lbl.Text = Header;
                Disable(true);
                View_ReadOnly(false);
                mode = 0;
            }
            else
            {
                this.Close();
            }


        }

        private void frmNIC_Load(object sender, EventArgs e)
        {
            pbMemberSign.Image = null;
            pbMember.Image = null;
            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_FAMILY' table. You can move, or remove it, as needed.
            //this.usp_SEL_FAMILYTableAdapter.Fill(this.comDataSet.usp_SEL_FAMILY);
            // TODO: This line of code loads data into the 'dataset.tblNIC' table. You can move, or remove it, as needed.
            this.tblNICTableAdapter.Fill(this.dataset.tblNIC);
            this.usp_SEL_tblBloodGroupTableAdapter.Fill(comDataSet.usp_SEL_tblBloodGroup);
            usp_SEL_tblWorkTypeTableAdapter.Fill(comDataSet.usp_SEL_tblWorkType);
          
            dgvNIC.BringToFront();


            picMemberBox.Image = pbMember.Image;

            picBoxMemberSign.Image = pbMemberSign.Image;
            picBoxGeneralSec.Image = pbGsSign.Image;


        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ID = 0;
            picMemberBox.Image = null;
            picBoxMemberSign.Image = null;
            picBoxGeneralSec.Image = null;
            lbl.Text = Header + ">>Create";
            Disable(false);
            EmptyFields();
            mode = 0;
            write_name();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvNIC.Rows.Count != 0)
            {
                ID = Convert.ToInt32(dgvNIC.CurrentRow.Cells[0].Value.ToString());
                lbl.Text = Header + ">>Modifing";
                Disable(false);
                mode = 1;
                txtFCardNo_Leave(sender, e);
                usp_SEL_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_SEL_tblFamilyMember, txtFCardNo.Text);
                cmbMemberName.Text = dgvNIC.CurrentRow.Cells[2].Value.ToString();
                cmbMemberName_Leave(sender, e);
                //if (txtDOB.Text.Length != 4)
                //{
                //    txtDOB.Text = "";
                //}
                //else
                //    dtpDOB.Enabled = false;
                pbMember.Text = "";
                pbMemberSign.Text = "";
                if (txtDuplicate.Text == "Duplicate")
                    chkDuplicate.Checked = true;
                else
                    chkDuplicate.Checked = false;
            }
            else
                MessageBox.Show("No record to modify", "No record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            lbl.Text = Header + " >> Preview";
            Disable(false);
            View_ReadOnly(true);
            mode = 3;
            usp_SEL_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_SEL_tblFamilyMember, txtFCardNo.Text);
            cmbMemberName.Text = dgvNIC.CurrentRow.Cells[2].Value.ToString();
            if (txtDOB.Text.Length != 4)
            {
                txtDOB.Text = "";
            }

            pbMember.Text = "";
            pbMemberSign.Text = "";
        }

        private void btnMBrowse_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dlg = new OpenFileDialog();

            DialogResult dlgRes = dlg.ShowDialog();
            if (dlgRes != DialogResult.Cancel)
            {
                //Set image in picture box
                //pbMember.ImageLocation = dlg.FileName;

                //Provide file path in txtImagePath text box.
                txtMPath.Text = dlg.FileName;

                Image image = Image.FromFile(txtMPath.Text);
                Image image2 = FixedSize(image, 96, 96);
                pbMember.Image = image2;

                pbMember.Text = "";
                picMemberBox.Image = pbMember.Image;


            }
        }

        private void btnSBrowser_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dlg = new OpenFileDialog();
            DialogResult dlgRes = dlg.ShowDialog();
            if (dlgRes != DialogResult.Cancel)
            {

                //Provide file path in txtImagePath text box.
                txtMSPath.Text = dlg.FileName;
                Image image = Image.FromFile(txtMSPath.Text);
                Image image2 = FixedSize(image, 96, 48);
                pbMemberSign.Image = image2;
                picBoxMemberSign.Image = pbMemberSign.Image;
                pbMemberSign.Text = "";
            }
        }

        private void btnGSBrowser_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dlg = new OpenFileDialog();
            DialogResult dlgRes = dlg.ShowDialog();
            if (dlgRes != DialogResult.Cancel)
            {

                //Provide file path in txtImagePath text box.
                txtGPath.Text = dlg.FileName;
                Image image = Image.FromFile(txtGPath.Text);
                Image image2 = FixedSize(image, 96, 48);
                pbGsSign.Image = image2;
                picBoxGeneralSec.Image = pbGsSign.Image;

                pbGsSign.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //Check if NIC for the respective Family Card No. and NIC already generated or NOT
            if (mode == 0)
            {
                DataTable dt = tblNICTableAdapter.CheckIFCMICAlreadyGenerated(txtCMIC.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("CMIC already exist for the current member.");
                    return;
                }

            }
            else if (mode == 1)
            {
                DataTable dt = tblNICTableAdapter.CheckIfCMICAlreadyGeneratedWithID(txtCMIC.Text, Convert.ToInt64(ID));
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("CMIC already exist for the current member.");
                    return;
                }
            }

            if (CheckField())
            {

                int MemberID = Convert.ToInt32(cmbMemberName.SelectedValue.ToString());
                string CNIC = txtCNIC.Text;
                string NIC = txtCMIC.Text;

                string occupation = cmbTypeWork.Text;
                string Phone = txtPhoneNo.Text;
                string BloodGroup = cmbBGroup.Text;
                string Duplicate = cmbDuplicate.Text;
                DateTime IssueDate = Convert.ToDateTime(dtpIssueDate.Text);
                DateTime ValidDate = Convert.ToDateTime(dtpValidUpto.Text);
                string FCardNo = txtFCardNo.Text;
                string GrandFatherName = txtGFName.Text;
                string Orakh = txtOrakh.Text;
                string Nukh = txtNukh.Text;
                string Address = txtAddress.Text;
                if (mode == 0)
                {
                    byte[] MemberSnap = ReadFile(txtMPath.Text);
                    byte[] SecratarySign = ReadFile(txtGPath.Text);
                    byte[] MemberSign = ReadFile(txtMSPath.Text);
                    tblNICTableAdapter.CreateNIC(MemberID, MemberSnap, NIC, MemberSign, SecratarySign, IssueDate, ValidDate, FCardNo, GrandFatherName, Orakh, Nukh, Address, Duplicate, occupation,Convert.ToByte(chkIsNicPrinted.Checked));

                    usp_SEL_tblFamilyMemberTableAdapter.Upd_NIC(CNIC, NIC, occupation, Phone, BloodGroup, MemberID);
                    tblNICTableAdapter.Fill(dataset.tblNIC);
                  
                    MessageBox.Show("Saved Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Disable(true);
                    mode = 0;
                    fcard_filter = "";
                }
                else if (mode == 1)
                {
                    byte[] MemberSnap = null;
                    if (txtMPath.Text != "")
                    {
                        MemberSnap = ReadFile(txtMPath.Text);
                    }
                    else
                    {
                        MemberSnap = Membersnap(ID);
                    }

                    byte[] SecratarySign = null;
                    if (txtGPath.Text != "")
                    {
                        SecratarySign = ReadFile(txtGPath.Text);
                    }
                    else
                    {
                        SecratarySign = generalsecratary(ID);
                    }

                    byte[] MemberSign = null;
                    if (txtMSPath.Text != "")
                    {
                        MemberSign = ReadFile(txtMSPath.Text);
                    }
                    else
                    {
                        MemberSign = Membersign(ID);
                    }

                    tblNICTableAdapter.UpdateNIC(MemberID, MemberSnap, NIC, MemberSign, SecratarySign, IssueDate, ValidDate, FCardNo, GrandFatherName, Nukh, Orakh, Address, Duplicate, occupation,Convert.ToByte((chkIsNicPrinted.Checked)?1:0), ID);
                    usp_SEL_tblFamilyMemberTableAdapter.Upd_NIC(CNIC, NIC, occupation, Phone, BloodGroup, MemberID);
                    tblNICTableAdapter.Fill(dataset.tblNIC);
                  
                    MessageBox.Show("Saved Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Disable(true);
                    mode = 0;
                    fcard_filter = "";
                }

            }

        }

        private void txtFCardNo_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtFCardNo.Text != "" && fcard_filter != txtFCardNo.Text)
                {
                    string FCard = txtFCardNo.Text = Convert.ToInt32(txtFCardNo.Text).ToString("00000");
                    SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                    con.Open();
                    string query = "SELECT Nukh,[Sign],ResidentAddress FROM tblFamily WHERE FCardNo = '%F%'";
                    query = query.Replace("%F%", FCard);
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    fcard_filter = txtFCardNo.Text;
                    if (reader.HasRows)
                    {
                        reader.Read();
                        txtNukh.Text = reader.GetValue(0).ToString();
                        txtOrakh.Text = reader.GetValue(1).ToString();
                        txtAddress.Text = reader.GetValue(2).ToString();
                    
                        usp_SEL_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_SEL_tblFamilyMember, FCard);
                        uspSELtblFamilyMemberBindingSource.Filter = "Gender = 'Male'";
                        con = new SqlConnection(Community.DBLayer.con_String);
                        con.Open();
                        query = "SELECT Address,IsNicPrinted FROM tblNIC WHERE ID = '%F%'";
                        query = query.Replace("%F%", ID.ToString());
                        cmd = new SqlCommand(query, con);
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            txtAddress.Text = reader.GetValue(0).ToString();
                            chkIsNicPrinted.Checked = reader.GetValue(1).ToString() == "0" ? false : true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Card No not found!!\n\nPlease enter valid Card No.", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    reader.Close();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmNIC_2 frm = new frmNIC_2();
            frm.Show();
            // Print_NIC();          
        }
        private void Print_NIC()
        {
            try
            {
                string NIC = dgvNIC.CurrentRow.Cells[3].Value.ToString();
                Community.DBLayer dblayer = new Community.DBLayer();
                SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                string query = richTextBox1.Text;
                string query1 = "NIC = '" + NIC + "'";
                query = query.Replace("NIC = @NIC", query1);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;

                DataTable dt = new DataTable();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);

                ada.Fill(dt);
                MCKJ.Reports.Members.frmViewer frm = new MCKJ.Reports.Members.frmViewer();
                MCKJ.Reports.Members.rptNIC rpt = new MCKJ.Reports.Members.rptNIC();
                rpt.SetDataSource(dt);
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbMemberName_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cmbMemberName.SelectedValue != null)
                {
                    int mId = Convert.ToInt32(cmbMemberName.SelectedValue.ToString());
                    SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                    string query = "SELECT FatherName,DOB,BloodGroup,Mobile,CNIC,WorkType,NIC FROM tblFamilyMember WHERE FamilyMemberID = %ID%";
                    query = query.Replace("%ID%", mId.ToString());
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string FName = txtFName.Text = reader.GetValue(0).ToString();
                        cmbBGroup.Text = reader.GetValue(2).ToString();
                        txtDOB.Text = reader.GetValue(1).ToString();
                        txtCMIC.Text = reader.GetValue(6).ToString();
                        //if (dob.Length == 4)
                        //{
                        //    txtDOB.Text = dob;
                        //}
                        //else
                        //{
                        //    dtpDOB.Text = dob;
                        //    txtDOB.Text = "";                           
                        //}
                        txtPhoneNo.Text = reader.GetValue(3).ToString();
                        txtCNIC.Text = reader.GetValue(4).ToString();
                        txtGFName.Text = grand_FatherName(txtFCardNo.Text, FName);
                        cmbTypeWork.Text = reader.GetValue(5).ToString();


                    }
                    reader.Close();
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvNIC.Rows.Count != 0)
            {
                Text = Header + ">> Deleting NIC";
                ID = Convert.ToInt32(dgvNIC.CurrentRow.Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confiramtion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    tblNICTableAdapter.DeleteNIC(ID);
                    MessageBox.Show("Deleted Succesfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    tblNICTableAdapter.Fill(dataset.tblNIC);
                  
                    Text = Header;

                }
                else
                    Text = Header;
            }
            else
            {
                MessageBox.Show("No record to delete", "No record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wnat to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                tblNICTableAdapter.Fill(dataset.tblNIC);
             
                Disable(true);
                mode = 0;
                Text = Header;
                fcard_filter = "";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            cmbTypeWork.Text = null;
        }

        private void tblNICBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            picBoxMemberSign.Image = pbMemberSign.Image;
            picMemberBox.Image = pbMember.Image;
            picBoxGeneralSec.Image = pbGsSign.Image;
        }

        private void uspSELtblFamilyMemberBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtNicSearch.Text.Length > 0)
            {
                //DbHelper dbHelper = new DbHelper();
                //SQLCache sql = null;
                //ArrayList Params = new ArrayList();
                //Params.Add(txtNicSearch.Text);
                //sql = new SQLCache(Params);
                //DataTable dt = dbHelper.ExecuteDataTable(sql.GetSQL("GetNICTableDataById"));
                //dgvNIC.Rows.Clear();
                //dgvNIC.DataSource = null;
                //dgvNIC.DataSource = dt;
                this.tblNICTableAdapter.GetNICById(this.dataset.tblNIC, txtNicSearch.Text);
                //((BindingSource)dgvNIC.DataSource).Filter = "NIC like '%-" + txtNicSearch.Text + "'";

            }
            else
            {
                ((BindingSource)dgvNIC.DataSource).Filter = "";
            }
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                ((BindingSource)dgvNIC.DataSource).Filter = "";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDuplicate_TextChanged(object sender, EventArgs e)
        {

        }



    }

}