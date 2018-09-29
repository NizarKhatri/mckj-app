using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace MCKJ.Common
{
    public class DbHelper
    {
        private string connString;
        SqlConnection conn;
        public DbHelper()
        {
            connString = Community.DBLayer.con_String;
            conn = new SqlConnection(connString);
        }

        public int ExecuteNonQuery(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;

                OpenConnection(conn);
                int status = cmd.ExecuteNonQuery();
                CloseConnection(conn);
                return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return 0;
            }
        }

        public DataTable ExecuteDataTable(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);

                conn.Close();
                return dtRecord;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public SqlDataReader ExecuteReader(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                OpenConnection(conn);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr != null && rdr.HasRows)
                {
                    return rdr;
                }
                else
                {
                    conn.Close();
                    return null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return null;
            }
        }

        public int ExecuteNonQueryForImage(string query, ArrayList parameters)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("Name", SqlDbType.VarChar).Value = parameters[0];
                cmd.Parameters.AddWithValue("FatherName", SqlDbType.VarChar).Value = parameters[1];
                cmd.Parameters.AddWithValue("DOB", SqlDbType.Date).Value = parameters[2];
                cmd.Parameters.AddWithValue("ContactNo", SqlDbType.VarChar).Value = parameters[3];
                cmd.Parameters.AddWithValue("Designation", SqlDbType.VarChar).Value = parameters[4];
                cmd.Parameters.AddWithValue("CNIC", SqlDbType.VarChar).Value = parameters[5];
                cmd.Parameters.AddWithValue("Address", SqlDbType.VarChar).Value = parameters[6];
                cmd.Parameters.AddWithValue("Image", SqlDbType.Image).Value = parameters[7];
                cmd.Parameters.AddWithValue("IsActive", SqlDbType.Bit).Value = parameters[8];

                if (parameters.Count > 9)
                {
                    cmd.Parameters.AddWithValue("Id", SqlDbType.Int).Value = parameters[9];
                }

                OpenConnection(conn);

                int status = cmd.ExecuteNonQuery();
                CloseConnection(conn);
                return status;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return 0;
            }
        }

        public string ExecuteScalar(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                OpenConnection(conn);
                object value = cmd.ExecuteScalar();

                if (value != null)
                {
                    conn.Close();
                    return value.ToString();
                }
                else
                {
                    conn.Close();
                    return null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return null;
            }
        }

        private void OpenConnection(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Open();
            }
            else
            {
                conn.Open();
            }

        }

        private void CloseConnection(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
