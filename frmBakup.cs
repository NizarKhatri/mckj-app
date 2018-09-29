using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace MCKJ
{
    public partial class frmBakup : Form
    {
        public frmBakup()
        {
            InitializeComponent();
        }
        Community.DBLayer dbLayer = new Community.DBLayer();


        public void GetServices()
        {
            
            ServiceController[] services = ServiceController.GetServices("Fasnatics-1");            
            foreach (ServiceController x in services)
            {
                if (x.ServiceName == "MSSQLSERVER")
                {
                    this.cmbServices.Items.Add("" + x.DisplayName);
                    this.txtStatus.Text = x.Status.ToString();
                }

            }

        }


        public void GetStatus()
        {
            try
            {
                ServiceController[] services = ServiceController.GetServices("(local)");
                foreach (ServiceController x in services)
                {
                    if (x.DisplayName == this.cmbServices.SelectedItem.ToString())
                        this.txtStatus.Text = x.Status.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }


        private void btnStart_Click(object sender, System.EventArgs e)
        {
            try
            {
                ServiceController x = new ServiceController("MSSQLSERVER", "Fasnatics-1");

                if (x.Status == ServiceControllerStatus.Running)
                {
                    MessageBox.Show("Service already Started!!");

                }
                else
                {
                    x.Start();
                    txtStatus.Text = x.Status.ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        
        private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            GetStatus();
           
        }


        private void btnStop_Click(object sender, System.EventArgs e)
        {
            try
            {
                ServiceController x = new ServiceController("MSSQLSERVER", "Fasnatics-1");
               
                if (x.Status == ServiceControllerStatus.Stopped)
                {
                    MessageBox.Show("Service already stopped!!");

                }
                else
                {
                    x.Stop();

                    this.txtStatus.Text = x.Status.ToString();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }


        private void btnPause_Click(object sender, System.EventArgs e)
        {
            try
            {
                ServiceController x = new ServiceController("MSSQLSERVER", "Fasnatics-1");

                if (x.Status == ServiceControllerStatus.Paused)
                {
                    MessageBox.Show("Service already Paused!!");

                }
                else
                {
                    x.Pause();
                    this.txtStatus.Text = x.Status.ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }


        public void LoadData()
        {
         
            try
            {
                SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                con.Close();
                con.Open();
                DataSet ds = new DataSet();
                String sql = "select * from tblSecurity";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {

                    this.cmbSyName.Items.Add(sdr.GetString(2));
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Load data" + ex.Message + ex.StackTrace);
            }


        }
        public void ClientLoadData()
        {
           
            try
            {
                SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                con.Close();
                con.Open();
               DataSet  ds = new DataSet();
                String sql = "select * from System_Details";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    this.cmbSyName.Items.Add(sdr.GetString(2));
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Load data" + ex.Message + ex.StackTrace);
            }


        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void frmBakup_Load(object sender, EventArgs e)
        {
           // LoadData();
            //ClientLoadData();
            //			this.comboBox1.Items.Add("local");
            //			this.comboBox1.Items.Add("lab03-01");
            //			this.comboBox1.Items.Add("lab03-02");
            //			this.comboBox1.Items.Add("lab03-03");
            //			this.comboBox1.Items.Add("lab03-04");
            //			this.comboBox1.Items.Add("lab03-05");
            //this.cmbSyName.SelectedIndex = 0;
            GetServices();
            this.cmbServices.SelectedIndex = 0;
        }

        //private void cmbServices_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    GetServices();
        //}

        //private void cmbSyName_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    GetStatus();
        //}

    }
}

