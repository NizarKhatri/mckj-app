using System;
using System.Collections.Generic;
using System.Text;

namespace MCKJ
{
    class ccc
    {
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (chk == 0)
                {
                    CLEAR();
                    comboBox1.Focus();
                    chk = 1;
                    button1.Text = "SAVE";
                }
                else
                {
                    
                    con = new OleDbConnection(@"Provider=Microsoft.Jet.OleDb.4.0;Data Source=D:\house.mdb;User Id=Admin;Password=;");
                    //Read Image Bytes into a byte array
                    byte[] imageData = ReadFile(imgPath.ToString());
                    //Initialize SQL Server Connection
                    //SqlConnection CN = new SqlConnection(txtConnectionString.Text);

                    //Set insert query
                    string qry = "insert into household_composition & #40;Vill_No,house_no,sl_no,Family_member,Photo_ID,relation,age,sex,Maritial_status,age_1st_marriage,education,Proficiency,occu_main,occu_sub,Present_health,Govt_assi) values('" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + (object)imageData + "','" + comboBox3.Text + "','" + textBox3.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox6.Text + "','" + comboBox7.Text + "','" + comboBox8.Text + "','" + textBox7.Text + "')";

                    //Initialize SqlCommand object for insert.
                    cmd = new OleDbCommand(qry, con);

                    //We are passing Original Image Path and Image byte data as sql parameters.
                    //SqlCom.Parameters.Add(new SqlParameter("@OriginalPath", (object)txtImagePath.Text));
                    //SqlCom.Parameters.Add(new SqlParameter("@ImageData", (object)imageData));

                    //Open connection and execute insert query.
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    //Close form and return to list or images.
                    //this.Close();
                    MessageBox.Show("NEW MEMBER ADDED SUCCESSFULLY..", "INFORMATION..!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button1.Text = "ADD NEW";
                    chk = 0;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                con.Close();
            }
        }

        //Open file in to a filestream and read data in a byte array.
        byte[] ReadFile(string sPath)
        {
            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to supply number of bytes to read from file.
            //In this case we want to read entire file. So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);
            return data;
        }
    }
}
