using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace Community
{

     
    class DBLayer
    {
        //public static string con_String = "Data Source=FASNATICS-1;Failover Partner=FASNATICS-1;Initial Catalog=Community;Persist Security Info=True;User ID=FNY;Password=arbani4u;Connect Timeout=60;Packet Size=32768";
        //public string CON_string = "Data Source=FASNATICS-1;Failover Partner=FASNATICS-1;Initial Catalog=Community;Persist Security Info=True;User ID=FNY;Password=arbani4u;Connect Timeout=60;Packet Size=32768";   

        //Community database connection string
        //public static string con_String = @"Data Source=MCKJ-SERVER;Initial Catalog=Community;Persist Security Info=True;User ID=sa;Password=sql_pwd_SA";
        //public string CON_string = @"Data Source=MCKJ-SERVER;Initial Catalog=Community;Persist Security Info=True;User ID=sa;Password=sql_pwd_SA";

        public static string con_String = @"Data Source=MCKJ-SERVER;Initial Catalog=Community;Persist Security Info=True;User ID=sa;Password=sql_pwd_SA";
        public string CON_string = @"Data Source=MCKJ-SERVER;Initial Catalog=Community;Persist Security Info=True;User ID=sa;Password=sql_pwd_SA";   

#region SELECT METHODS


        public static int ID = ID;
        public static int UserID;
        public void SetUserID(int UID)
        {
            UserID = UID;
        }
        public int GetUserID()
        {
            return UserID;
        }
        public bool CHKUSER(int UserID, string Password)
        {
            
            bool result = false;
            SqlConnection con = new SqlConnection(con_String);
            try
            {
                SqlCommand cmd = new SqlCommand("Select UserID,Password from tblSecurity WHERE UserID=" + UserID + " AND Password= '" + Password + "'", con);
                cmd.CommandType = CommandType.Text;

                SqlParameter paraUserID = cmd.Parameters.Add("@UserID", SqlDbType.Int);
                paraUserID.Value = UserID;


                SqlParameter paraPassword = cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50);
                paraPassword.Value = Password;
                con.Open();

                SqlDataReader DR = cmd.ExecuteReader();
                if (DR.HasRows)
                {
                    result = true;
                }
                else 
                {
                    result = false;
                }
            }
           catch (Exception ex)
            {
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }
        
        public bool Rights (int UserID, int SecurityLevel)
        {
           
            bool result = false;           

            SqlConnection con = new SqlConnection(con_String);
            try
            {
                SqlCommand cmd = new SqlCommand("Select PermissionID ,SecurityLevelID,Inactive_FL from tblPermission WHERE UserID =" + UserID + " And SecurityLevelID = " + SecurityLevel + " And Inactive_FL = 1", con);
                cmd.CommandType = CommandType.Text;

                SqlParameter paraUserID = cmd.Parameters.Add("@UserID", SqlDbType.Int);
                paraUserID.Value = UserID;


                SqlParameter paraSecurityLevel = cmd.Parameters.Add("@SecurityLevelID", SqlDbType.VarChar, 50);
                paraSecurityLevel.Value = SecurityLevel;
                con.Open();

                SqlDataReader DR = cmd.ExecuteReader();
                if (DR.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                string chk = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }

        public bool User_Right(int UserID,int SecurityLevel,string Right)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(con_String);

            try
            {
                SqlCommand cmd = new SqlCommand("Select "+Right + " from tblPermission  Where UserID =" + UserID + " And SecurityLevelID= " + SecurityLevel + " And Inactive_FL = 1 AND " + Right + "=1", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                    result = true;
                else
                    result = false;
            }
            catch (Exception ex)
            {
                string jusChk = ex.Message;     
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }
       

#region CHECK IF FAMILY CARD ALREADY EXIST


        //public bool Search_Hall(DateTime Date)
        //{
        //   
        //    bool result = false;

        //    SqlConnection con = new SqlConnection(con_String);
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("Select *
        //    }
        //    catch (Exception ex)
        //    {
        //        //RECORD THIS BUG IN YOUR XML FILE
        //        //FOR FUTURE MONITORING
        //        string justChecking = ex.Message;
        //    }
        //    finally
        //    {
        //        if (con.State == ConnectionState.Open)
        //        {
        //            con.Close();
        //        }
        //    }
        //    return result;
        //}

        public bool CHK_RegNo(string RegNo)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(con_String);
            try
            {
                SqlCommand cmd = new SqlCommand("Select RegNo from tblBirth Where RegNo = @RegNo",con);
                cmd.CommandType = CommandType.Text;
                SqlParameter para = cmd.Parameters.Add("@RegNo", SqlDbType.VarChar, 50);
                para.Value = RegNo;

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    result = true;
                }
                else
                    result = false;

            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;

        }
        public bool CHK_RegNo_Death(string RegNo)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(con_String);
            try
            {
                SqlCommand cmd = new SqlCommand("Select RegNo from tblDeath Where RegNo = @RegNo", con);
                cmd.CommandType = CommandType.Text;
                SqlParameter para = cmd.Parameters.Add("@RegNo", SqlDbType.VarChar, 50);
                para.Value = RegNo;

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    result = true;
                }
                else
                    result = false;

            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;

        }
        public bool CHK_ReceiptNo(string ReceiptNo)
        {
          
            bool result = false;

            SqlConnection con = new SqlConnection();

            try
            {
                SqlCommand cmd = new SqlCommand("Select ReceiptNo from tblDonations where ReceiptNo = '"+ReceiptNo + "'", con);
               
                con.Open();

                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                //RECORD THIS BUG IN YOUR XML FILE
                //FOR FUTURE MONITORING
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }


        public bool CHK_Serial(string SerialNo)
        {
            

            bool result = false;

            SqlConnection con = new SqlConnection(con_String);

            try
            {
                SqlCommand cmd = new SqlCommand("usp_CHK_Serial", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para = cmd.Parameters.Add("@SerialNo", SqlDbType.VarChar, 50);
                para.Value = SerialNo;

                con.Open();

                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                //RECORD THIS BUG IN YOUR XML FILE
                //FOR FUTURE MONITORING
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }
        public bool CHK_Nukh(string Nukh)
        {
            

            bool result = false;

            SqlConnection con = new SqlConnection(con_String);

            try
            {
                SqlCommand cmd = new SqlCommand("usp_CHK_Nukh", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para = cmd.Parameters.Add("@Nukh", SqlDbType.VarChar, 100);
                para.Value = Nukh;

                con.Open();

                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                //RECORD THIS BUG IN YOUR XML FILE
                //FOR FUTURE MONITORING
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }

        public bool CHK_Type(string WorkType)
        {
            

            bool result = false;

            SqlConnection con = new SqlConnection(con_String);

            try
            {
                SqlCommand cmd = new SqlCommand("usp_CHK_Type", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para = cmd.Parameters.Add("@WorkType", SqlDbType.VarChar, 100);
                para.Value = WorkType;

                con.Open();

                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                //RECORD THIS BUG IN YOUR XML FILE
                //FOR FUTURE MONITORING
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }


        public bool CHK_Orakh(string Orakh)
        {
            

            bool result = false;

            SqlConnection con = new SqlConnection(con_String);

            try
            {
                SqlCommand cmd = new SqlCommand("usp_CHK_Orakh", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para = cmd.Parameters.Add("@Orakh", SqlDbType.VarChar, 100);
                para.Value = Orakh;

                con.Open();

                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                //RECORD THIS BUG IN YOUR XML FILE
                //FOR FUTURE MONITORING
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }

        public bool CHK_City(string City)
        {
            

            bool result = false;

            SqlConnection con = new SqlConnection(con_String);

            try
            {
                SqlCommand cmd = new SqlCommand("usp_CHK_City", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para = cmd.Parameters.Add("@City", SqlDbType.VarChar, 100);
                para.Value = City;

                con.Open();

                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                //RECORD THIS BUG IN YOUR XML FILE
                //FOR FUTURE MONITORING
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }
      
         public bool CHK_Area(string Area)
        {
            

            bool result = false;

            SqlConnection con = new SqlConnection(con_String);

            try
            {
                SqlCommand cmd = new SqlCommand("usp_CHK_Area", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para = cmd.Parameters.Add("@Area", SqlDbType.VarChar, 100);
                para.Value = Area;

                con.Open();

                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                //RECORD THIS BUG IN YOUR XML FILE
                //FOR FUTURE MONITORING
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }
        
         public bool CHK_Origin(string Village)
        {
            

            bool result = false;

            SqlConnection con = new SqlConnection(con_String);

            try
            {
                SqlCommand cmd = new SqlCommand("usp_CHK_Village", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para = cmd.Parameters.Add("@Village", SqlDbType.VarChar, 100);
                para.Value = Village;

                con.Open();

                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                //RECORD THIS BUG IN YOUR XML FILE
                //FOR FUTURE MONITORING
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }

        public bool CHK_Serial_Marriage(string SerialNo)
        {
            

            bool result = false;

            SqlConnection con = new SqlConnection(con_String);

            try
            {
                SqlCommand cmd = new SqlCommand("usp_CHK_Serial_Marriage", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para = cmd.Parameters.Add("@SerialNo", SqlDbType.VarChar, 50);
                para.Value = SerialNo;

                con.Open();

                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                //RECORD THIS BUG IN YOUR XML FILE
                //FOR FUTURE MONITORING
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }

        public bool CHK_B4_DEL_ORAKH(string Sign)
        {
            

            bool result = false;

            SqlConnection con = new SqlConnection(con_String);

            try
            {
                SqlCommand cmd = new SqlCommand("usp_CHK_OTHER_ORAKH", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para = cmd.Parameters.Add("@Sign", SqlDbType.VarChar, 100);
                para.Value = Sign;

                con.Open();

                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                //RECORD THIS BUG IN YOUR XML FILE
                //FOR FUTURE MONITORING
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }

        public bool CHK_B4_DEL_Type1(string WorkType)
        {

            bool result = false;

            SqlConnection con = new SqlConnection(con_String);

            try
            {
                SqlCommand cmd = new SqlCommand("usp_CHK_INOTHER_Type1", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para = cmd.Parameters.Add("@WorkType", SqlDbType.VarChar, 100);
                para.Value = WorkType;

                con.Open();

                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                //RECORD THIS BUG IN YOUR XML FILE
                //FOR FUTURE MONITORING
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }
        
        public bool CHK_B4_DEL_Type(string WorkType)
        {
           

            bool result = false;

            SqlConnection con = new SqlConnection(con_String);

            try
            {
                SqlCommand cmd = new SqlCommand("usp_CHK_INOTHER_Type", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para = cmd.Parameters.Add("@WorkType", SqlDbType.VarChar, 100);
                para.Value = WorkType;

                con.Open();

                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                //RECORD THIS BUG IN YOUR XML FILE
                //FOR FUTURE MONITORING
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }

        public bool CHK_B4_DEL_NUKH(string Nukh)
        {
           

            bool result = false;

            SqlConnection con = new SqlConnection(con_String);

            try
            {
                SqlCommand cmd = new SqlCommand("usp_CHK_OTHER_NUKH", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para = cmd.Parameters.Add("@Nukh", SqlDbType.VarChar, 100);
                para.Value = Nukh;

                con.Open();

                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                //RECORD THIS BUG IN YOUR XML FILE
                //FOR FUTURE MONITORING
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }

        public bool CHK_B4_DEL_AREA(string Area)
        {
           

            bool result = false;

            SqlConnection con = new SqlConnection(con_String);

            try
            {
                SqlCommand cmd = new SqlCommand("usp_CHK_OTHER_AREA", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para = cmd.Parameters.Add("@Area", SqlDbType.VarChar, 100);
                para.Value = Area;

                con.Open();

                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                //RECORD THIS BUG IN YOUR XML FILE
                //FOR FUTURE MONITORING
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }

        public bool CHK_B4_DEL_ORIGIN(string Village)
        {
           

            bool result = false;

            SqlConnection con = new SqlConnection(con_String);

            try
            {
                SqlCommand cmd = new SqlCommand("usp_CHK_OTHER_ORIGIN", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para = cmd.Parameters.Add("@Village", SqlDbType.VarChar, 100);
                para.Value = Village;

                con.Open();

                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                //RECORD THIS BUG IN YOUR XML FILE
                //FOR FUTURE MONITORING
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }

        public bool CHK_B4_DEL_CITY(string City)
        {
           

            bool result = false;

            SqlConnection con = new SqlConnection(con_String);

            try
            {
                SqlCommand cmd = new SqlCommand("usp_CHK_OTHER_City", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para = cmd.Parameters.Add("@City", SqlDbType.VarChar, 100);
                para.Value = City;

                con.Open();

                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                //RECORD THIS BUG IN YOUR XML FILE
                //FOR FUTURE MONITORING
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }

        public bool TRANSFER(string FCardNo, string MemberName)
        {
           
            bool result = false;
            SqlConnection con = new SqlConnection(con_String);
            try
            {
                SqlCommand cmd = new SqlCommand("usp_SEL_TSF_tblFamilyMember", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paraFCardNo = cmd.Parameters.Add("@FCardNo", SqlDbType.VarChar, 50);
                paraFCardNo.Value = FCardNo;


                SqlParameter paraMemberName = cmd.Parameters.Add("MemberName", SqlDbType.VarChar, 100);
                paraMemberName.Value = MemberName;
                con.Open();

                SqlDataReader DR = cmd.ExecuteReader();
                if (DR.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }
      
        public bool CHK_RWL(string FCardNo, string RenewalYear,string To)
        {
                      
            SqlConnection con = new SqlConnection(con_String);
            try
            {

                SqlCommand cmd = new SqlCommand("Select RenewalYear,RenewalTo From tblRenewal WHERE FCardNo ='" + FCardNo + "' order by date desc", con);
                cmd.CommandType = CommandType.Text;

                //SqlParameter paraFCardNo = cmd.Parameters.Add("@FCardNo", SqlDbType.VarChar,50);
                //paraFCardNo.Value = FCardNo;


                //SqlParameter paraRenewalYear = cmd.Parameters.Add("RenewalYear", SqlDbType.VarChar, 50);
                //paraRenewalYear.Value = RenewalYear;
                con.Open();

                

                SqlDataReader DR = cmd.ExecuteReader();

                while (DR.Read())
                {
                    string ofrom = DR.GetValue(0).ToString();
                    string oTo = DR.GetValue(1).ToString();

                    if (To == "")
                    {

                        SqlCommand com = new SqlCommand("Select * from tblRenewal WHERE RenewalYear = '" + RenewalYear + "' AND FCardNo ='" + FCardNo + "' order by date desc", con);
                        com.CommandType = CommandType.Text;

                        SqlDataReader reader = com.ExecuteReader();
                        if (reader.HasRows)
                            return true;
                    }
                    else
                    {
                        //Renew year
                        //for (int x = Convert.ToInt32(RenewalYear); x <= Convert.ToInt32(To); x++)
                        //{
                        //    if (oTo != "")
                        //    {
                        //        //currently validity year
                        //        for (int y = Convert.ToInt32(ofrom); y <= Convert.ToInt32(oTo); y++)
                        //            if (x == y)
                        //                return true;
                        //    }
                        //    else
                        //    {
                        //        if (x == Convert.ToInt32(ofrom))
                        //            return true;
                        //    }
                        //}
                        if (oTo == To)
                            return true;
                    }
                }
                //if (DR.HasRows)
                //{
                //    result = true;
                //}
                //else
                //{
                //    result = false;
                //}
            }
            catch (Exception ex)
            {
                string justChecking = ex.Message;
                return true;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return false;
        }
       
        public bool CHK_DVC(string FamilyCardNo, string LeaderRelation, string HusbandName)
        {
           

            bool result = false;

            SqlConnection con = new SqlConnection(con_String);

            try
            {
                SqlCommand cmd = new SqlCommand("usp_CHK_DVC_Member", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para = cmd.Parameters.Add("@FCardNo", SqlDbType.VarChar,50);
                para.Value = FamilyCardNo;

                SqlParameter LRelation = cmd.Parameters.Add("@LeaderRelation",SqlDbType.VarChar,100);
                LRelation.Value = LeaderRelation;

                SqlParameter HName = cmd.Parameters.Add("@HusbandName", SqlDbType.VarChar, 100);
                HName.Value = HusbandName;

                con.Open();

                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                //RECORD THIS BUG IN YOUR XML FILE
                //FOR FUTURE MONITORING
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }
     
        public bool CHK_B4_DELETE(string FamilyCardNo)
        {
           

            bool result = false;

            SqlConnection con = new SqlConnection(con_String);

            try
            {
                SqlCommand cmd = new SqlCommand("usp_CHK_OTHER_FCardNo", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para = cmd.Parameters.Add("@FCardNo", SqlDbType.VarChar,50);
                para.Value = FamilyCardNo;

                con.Open();

                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                //RECORD THIS BUG IN YOUR XML FILE
                //FOR FUTURE MONITORING
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }
        
        public bool CheckFamily(string FamilyCardNo)
        {         

            bool result = false;

            SqlConnection con = new SqlConnection(con_String);

            try
            {
                SqlCommand cmd = new SqlCommand("usp_SEL_CHK_FCardNo", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para = cmd.Parameters.Add("@FCardNo", SqlDbType.VarChar,50);
                para.Value = FamilyCardNo;

                con.Open();

                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                //RECORD THIS BUG IN YOUR XML FILE
                //FOR FUTURE MONITORING
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }
        #endregion

        #endregion

        #region INSERT METHODS

        #region ADD NEW USER

        public bool AddUser(string UserName, string Password)
        {   
            bool result = false;
            SqlConnection con = new SqlConnection(con_String);
            try
            {
                SqlCommand cmd = new SqlCommand("usp_ADD_USER", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paraUserName = cmd.Parameters.Add("@UserName", SqlDbType.VarChar, 50);
                paraUserName.Value = UserName;

                SqlParameter paraPassword = cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50);
                paraPassword.Value = Password;
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                //RECORD THIS BUG IN YOUR XML FILE
                //FOR FUTURE MONITORING
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;

        }

        #endregion

        #region ADD FAMILY

        public bool AddFamily(int FamilyCardNo, string FamilyName, string FamilyLeader, string Sign, string Nukh, string Village, string Address, string Phone, string Mobile, string Country, string City, string Area, string BusinessName, string WorkType, string Designation, string BusinessAddress, string BusinessPhone, string Fax, string Email, string Website)
        {
           
            bool result = false;
            SqlConnection con = new SqlConnection(con_String);
            try
            {
                SqlCommand cmd = new SqlCommand("usp_ADD_FAMILY", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paraFCardNo = cmd.Parameters.Add("@FCardNo", SqlDbType.Int);
                paraFCardNo.Value = FamilyCardNo;

                SqlParameter paraFamilyName = cmd.Parameters.Add("@FamilyName", SqlDbType.VarChar, 100);
                paraFamilyName.Value = FamilyName;

                SqlParameter paraFamilyLeader = cmd.Parameters.Add("@FamilyLeader", SqlDbType.VarChar, 100);
                paraFamilyLeader.Value = FamilyLeader;

                SqlParameter paraSign = cmd.Parameters.Add("@Sign", SqlDbType.VarChar, 100);
                paraSign.Value = Sign;

                SqlParameter paraNukh = cmd.Parameters.Add("@Nukh", SqlDbType.VarChar, 100);
                paraNukh.Value = Nukh;

                SqlParameter paraVillage = cmd.Parameters.Add("@Village", SqlDbType.VarChar, 100);
                paraVillage.Value = Village;

                SqlParameter paraCountry = cmd.Parameters.Add("@Country", SqlDbType.VarChar, 100);
                paraCountry.Value = Country;

                SqlParameter paraCity = cmd.Parameters.Add("@City", SqlDbType.VarChar, 100);
                paraCity.Value = City;

                SqlParameter paraArea = cmd.Parameters.Add("@Area", SqlDbType.VarChar, 100);
                paraArea.Value = Area;

                SqlParameter paraResidentAddress = cmd.Parameters.Add("@ResidentAddress", SqlDbType.VarChar, 200);
                paraResidentAddress.Value = Address;

                SqlParameter paraResidentPhone = cmd.Parameters.Add("@ResidentPhone", SqlDbType.VarChar, 100);
                paraResidentPhone.Value = Phone;

                SqlParameter paraMobile = cmd.Parameters.Add("@Mobile", SqlDbType.VarChar, 100);
                paraMobile.Value = Mobile;

                SqlParameter paraBusinessName = cmd.Parameters.Add("@BusinessName", SqlDbType.VarChar, 100);
                paraBusinessName.Value = BusinessName;

                SqlParameter paraWorkType = cmd.Parameters.Add("@WorkType", SqlDbType.VarChar, 100);
                paraWorkType.Value = WorkType;

                SqlParameter paraDesignation = cmd.Parameters.Add("@Designation", SqlDbType.VarChar, 100);
                paraDesignation.Value = Designation;

                SqlParameter paraBusinessAddress = cmd.Parameters.Add("@BusinessAddress", SqlDbType.VarChar, 200);
                paraBusinessAddress.Value = BusinessAddress;

                SqlParameter paraBusinessPhone = cmd.Parameters.Add("@BusinessPhone", SqlDbType.VarChar, 100);
                paraBusinessPhone.Value = BusinessPhone;

                SqlParameter paraBusinessFax = cmd.Parameters.Add("@BusinessFax", SqlDbType.VarChar, 100);
                paraBusinessFax.Value = Fax;

                SqlParameter paraEmail = cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100);
                paraEmail.Value = Email;

                SqlParameter paraWebsite = cmd.Parameters.Add("@Website", SqlDbType.VarChar, 100);
                paraWebsite.Value = Website;

                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                //RECORD THIS BUG IN YOUR XML FILE
                //FOR FUTURE MONITORING
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;

        }
        #endregion

        #region ADD HALL BOOKING
        public bool AddHallBooking(int SerialNo, DateTime Date, string Mr, int Event, int Hall1, int Hall2, int Hall3, int Hall4,int Hall5, DateTime Dated, DateTime Day, DateTime FromTime, DateTime ToTime, string Remarks, string FName, string Orakh, decimal Amount, string ReasonCancel, int Account,string ContactNo,string FCardNo,bool Temp,int UserID)
        {
            bool result = false;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(con_String);
                SqlCommand command = new SqlCommand("usp_ADD_HallBooking", conn);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter paraSerialNo = command.Parameters.Add("@SerialNo", SqlDbType.Int);
                paraSerialNo.Value = SerialNo;

                SqlParameter paraDate = command.Parameters.Add("@Date", SqlDbType.DateTime);
                paraDate.Value = Date;

                SqlParameter paraMr = command.Parameters.Add("@Mr", SqlDbType.VarChar, 100);
                paraMr.Value = Mr;

                SqlParameter paraEvent = command.Parameters.Add("@Event", SqlDbType.Int);
                paraEvent.Value = Event;

                SqlParameter paraHall1 = command.Parameters.Add("@Hall1", SqlDbType.Bit);
                paraHall1.Value = Hall1;

                SqlParameter paraHall2 = command.Parameters.Add("@Hall2", SqlDbType.Bit);
                paraHall2.Value = Hall2;

                SqlParameter paraHall3 = command.Parameters.Add("@Hall3", SqlDbType.Bit);
                paraHall3.Value = Hall3;

                SqlParameter paraHall4 = command.Parameters.Add("@Hall4", SqlDbType.Bit);
                paraHall4.Value = Hall4;

                SqlParameter paraHall5 = command.Parameters.Add("@Hall5", SqlDbType.Bit);
                paraHall5.Value = Hall5;

                SqlParameter paraDated = command.Parameters.Add("@Dated", SqlDbType.DateTime);
                paraDated.Value = Dated;

                SqlParameter paraDay = command.Parameters.Add("@Day", SqlDbType.DateTime);
                paraDay.Value = Day;

                SqlParameter paraFromTime = command.Parameters.Add("@FromTime", SqlDbType.DateTime);
                paraFromTime.Value = FromTime;

                SqlParameter paraToTime = command.Parameters.Add("@ToTime", SqlDbType.DateTime);
                paraToTime.Value = ToTime;

                SqlParameter paraRemarks = command.Parameters.Add("@Remarks", SqlDbType.VarChar, 100);
                paraRemarks.Value = Remarks;

                SqlParameter paraFName = command.Parameters.Add("@FName", SqlDbType.VarChar, 50);
                paraFName.Value = FName;

                SqlParameter paraOrakh = command.Parameters.Add("@Orakh", SqlDbType.VarChar, 50);
                paraOrakh.Value = Orakh;

                SqlParameter paraReasonCancel = command.Parameters.Add("@ReasonCancel", SqlDbType.VarChar, 100);
                paraReasonCancel.Value = ReasonCancel;

                SqlParameter paraAmount = command.Parameters.Add("@Amount", SqlDbType.Money);
                paraAmount.Value = Amount;

                SqlParameter paraAccount = command.Parameters.Add("@Account", SqlDbType.Int);
                paraAccount.Value = Account;

                SqlParameter paraContactNo = command.Parameters.Add("@ContactNo", SqlDbType.VarChar,50);
                paraContactNo.Value = ContactNo;

                SqlParameter paraFCardNo = command.Parameters.Add("@FCardNo", SqlDbType.VarChar, 50);
                paraFCardNo.Value = FCardNo;

                SqlParameter paraTemp = command.Parameters. Add("@Temp", SqlDbType.Bit);
                paraTemp.Value = Temp;

                SqlParameter paraUserID = command.Parameters.Add("@UserID", SqlDbType.Int);
                paraUserID.Value = UserID;


                conn.Open();
                int i = command.ExecuteNonQuery();
                if (i != 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return result;
        }

        public DataTable GetFamilyCardRenewalFee()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(con_String))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_SEL_FamilyCardRenewalFee", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string justChecking = ex.Message;
            }
            finally
            {
                //if (con.State == ConnectionState.Open)
                //{
                //    con.Close();
                //}
            }
            return dt;
        }
        public bool AddFamilyCardRenewalFee(Decimal CardRenewalFee,Decimal MemberFee,Decimal LateFee)
        {
            int ret = 0;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(con_String))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_ADD_FCardRenewalFee", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@cardRenewalFee", CardRenewalFee);
                        cmd.Parameters.AddWithValue("@memberFee ", MemberFee);
                        cmd.Parameters.AddWithValue("@lateFee ", LateFee);
                        con.Open();
                        ret = cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                string justChecking = ex.Message;
            }
            finally
            {
                //if (con.State == ConnectionState.Open)
                //{
                //    con.Close();
                //}
            }
            if (ret > 0)
                return true;
            else
                return false;

        }

        public DataTable GetFamilyCardRenewalLateFee()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(con_String))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_SEL_FamilyCardRenewalLateFee", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {

                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string justChecking = ex.Message;
            }
            finally
            {
                //if (con.State == ConnectionState.Open)
                //{
                //    con.Close();
                //}
            }
            return dt;
        }
        //Add Family Card Renewal Late Fee
        public bool AddFamilyCardRenewalLateFee(String BegYear, String EndYear, DateTime FromDate,DateTime ToDate)
        {
            int ret = 0;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(con_String))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_ADD_FCardRenewalLateFee", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@begYear", BegYear);
                        cmd.Parameters.AddWithValue("@endYear ", EndYear);
                        cmd.Parameters.AddWithValue("@fromDate ", FromDate);
                        cmd.Parameters.AddWithValue("@toDate ", ToDate);
                        con.Open();
                        ret = cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                string justChecking = ex.Message;
            }
            finally
            {
                //if (con.State == ConnectionState.Open)
                //{
                //    con.Close();
                //}
            }
            if (ret > 0)
                return true;
            else
                return false;

        }
        //Get CardRenewalFee Data
        public DataTable GetFamilyCardRenewalFeeEnhanceDate()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(con_String))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_SEL_CardRenewalFee", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {

                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string justChecking = ex.Message;
            }
            finally
            {
                //if (con.State == ConnectionState.Open)
                //{
                //    con.Close();
                //}
            }
            return dt;
        }
        //Get current record of family card renewal late fee
        public DataTable GetFamilyCardRenewalFeeLateCurrent()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(con_String))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_SEL_FamilyCardRenewalLateFeeCurrent", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {

                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string justChecking = ex.Message;
            }
            finally
            {
                //if (con.State == ConnectionState.Open)
                //{
                //    con.Close();
                //}
            }
            return dt;
        }
                //Get current record of family card renewal late fee
        public DataTable GetRenewalByFCardNo(String FCardNo)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(con_String))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_SEL_Renewal", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FCardNO", FCardNo);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {

                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string justChecking = ex.Message;
            }
            finally
            {
                //if (con.State == ConnectionState.Open)
                //{
                //    con.Close();
                //}
            }
            return dt;
        }
        public DataTable GetFamilyCardRenewalLateFeeDueDate()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(con_String))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_SEL_FamilyCardRenewalLateFeeDueDate", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {

                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string justChecking = ex.Message;
            }
            finally
            {
                //if (con.State == ConnectionState.Open)
                //{
                //    con.Close();
                //}
            }
            return dt;
        }


        public DataTable GetFamilyByFamilyCardNo(String FCardNo)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(con_String))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_SEL_FAMILY_BYFAMILYCARDNO", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FCardNo", FCardNo);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string justChecking = ex.Message;
            }
            finally
            {
                //if (con.State == ConnectionState.Open)
                //{
                //    con.Close();
                //}
            }
            return dt;
        }

        public DataTable GetPendingFCardRenewal(int year)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(con_String))
                {
                    //using (SqlCommand cmd = new SqlCommand("usp_SEL_PendingFCardRenewal", con))
                    using (SqlCommand cmd = new SqlCommand("usp_PendingFCardRenewal", con))
                    
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@YEAR", year));
                        //cmd.Parameters.AddWithValue("@FCardNo", FCardNo);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string justChecking = ex.Message;
            }
            finally
            {
                //if (con.State == ConnectionState.Open)
                //{
                //    con.Close();
                //}
            }
            return dt;
        }
        //Daily Summary Report
        public DataTable GetDailySummaryReport(DateTime Date)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(con_String))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_SEL_DailySummaryReport", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Date", Date);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string justChecking = ex.Message;
            }
            finally
            {
                //if (con.State == ConnectionState.Open)
                //{
                //    con.Close();
                //}
            }
            return dt;
        }

        public DataTable GetExpiredNIC()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(con_String))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_SEL_ExpiredNIC", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@FCardNo", FCardNo);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string justChecking = ex.Message;
            }
            finally
            {
                //if (con.State == ConnectionState.Open)
                //{
                //    con.Close();
                //}
            }
            return dt;
        }

        public DataTable GetFamilyByFCardNo(String FCardNo)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(con_String))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_SEL_GetFamilyByFCardNo", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FCardNo", FCardNo);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string justChecking = ex.Message;
            }
            finally
            {
                //if (con.State == ConnectionState.Open)
                //{
                //    con.Close();
                //}
            }
            return dt;
        }


        #endregion


        #endregion

        #region UPDATE METHODS
        #region UPDATE HALL BOOKING
        public bool UpdateHallBooking(int SerialNo, DateTime Date, string Mr, int Event, int Hall1, int Hall2, int Hall3, int Hall4, int Hall5, DateTime Dated, DateTime Day, DateTime FromTime, DateTime ToTime, string Remarks, int ID, string FName, string Orakh, decimal Amount, string ReasonCancel, int Account, string ContactNo, string FCardNo, bool Temp,int ChangedBy)
        {
            bool result = false;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(con_String);
                SqlCommand command = new SqlCommand("usp_UPD_HallBooking", conn);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter paraID = command.Parameters.Add("@ID", SqlDbType.Int);
                paraID.Value = ID;

                SqlParameter paraSerialNo = command.Parameters.Add("@SerialNo", SqlDbType.Int);
                paraSerialNo.Value = SerialNo;

                SqlParameter paraDate = command.Parameters.Add("@Date", SqlDbType.DateTime);
                paraDate.Value = Date;

                SqlParameter paraMr = command.Parameters.Add("@Mr", SqlDbType.VarChar, 100);
                paraMr.Value = Mr;

                SqlParameter paraEvent = command.Parameters.Add("@Event", SqlDbType.Int);
                paraEvent.Value = Event;

                SqlParameter paraHall1 = command.Parameters.Add("@Hall1", SqlDbType.Bit);
                paraHall1.Value = Hall1;

                SqlParameter paraHall2 = command.Parameters.Add("@Hall2", SqlDbType.Bit);
                paraHall2.Value = Hall2;

                SqlParameter paraHall3 = command.Parameters.Add("@Hall3", SqlDbType.Bit);
                paraHall3.Value = Hall3;

                SqlParameter paraHall4 = command.Parameters.Add("@Hall4", SqlDbType.Bit);
                paraHall4.Value = Hall4;

                SqlParameter paraHall5 = command.Parameters.Add("@Hall5", SqlDbType.Bit);
                paraHall5.Value = Hall5;

                SqlParameter paraDated = command.Parameters.Add("@Dated", SqlDbType.DateTime);
                paraDated.Value = Dated;

                SqlParameter paraDay = command.Parameters.Add("@Day", SqlDbType.DateTime);
                paraDay.Value = Day;

                SqlParameter paraFromTime = command.Parameters.Add("@FromTime", SqlDbType.DateTime);
                paraFromTime.Value = FromTime;

                SqlParameter paraToTime = command.Parameters.Add("@ToTime", SqlDbType.DateTime);
                paraToTime.Value = ToTime;


                SqlParameter paraRemarks = command.Parameters.Add("@Remarks", SqlDbType.VarChar, 100);
                paraRemarks.Value = Remarks;

                SqlParameter paraFName = command.Parameters.Add("@FName", SqlDbType.VarChar, 50);
                paraFName.Value = FName;

                SqlParameter paraOrakh = command.Parameters.Add("@Orakh", SqlDbType.VarChar, 50);
                paraOrakh.Value = Orakh;

                SqlParameter paraReasonCancel = command.Parameters.Add("@ReasonCancel", SqlDbType.VarChar, 100);
                paraReasonCancel.Value = ReasonCancel;

                SqlParameter paraAmount = command.Parameters.Add("@Amount", SqlDbType.Money);
                paraAmount.Value = Amount;

                SqlParameter paraAccount = command.Parameters.Add("@Account", SqlDbType.Int);
                paraAccount.Value = Account;

                SqlParameter paraContactNo = command.Parameters.Add("@ContactNo", SqlDbType.VarChar, 50);
                paraContactNo.Value = ContactNo;

                SqlParameter paraFCardNo = command.Parameters.Add("@FCardNo", SqlDbType.VarChar, 50);
                paraFCardNo.Value = FCardNo;

                SqlParameter paraTemp = command.Parameters.Add("@Temp", SqlDbType.Bit);
                paraTemp.Value = Temp;

                SqlParameter paraChangedBy = command.Parameters.Add("@ChangedBy", SqlDbType.Int);
                paraChangedBy.Value = ChangedBy;

                conn.Open();
                int i = command.ExecuteNonQuery();
                if (i != 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return result;
        }
        #endregion
        #endregion

        #region Reports
        public DataTable getTrialBalance(DateTime UpTo)
        {

            SqlConnection Conn = null;

            try
            {
                Conn = new SqlConnection(con_String);

                Conn.Open();

                SqlCommand command = new SqlCommand("usp_RPT_TrialBalance", Conn);

                command.CommandType = CommandType.StoredProcedure;

                SqlParameter paraUptoDate = command.Parameters.Add("@UpToDate", SqlDbType.DateTime);

                paraUptoDate.Value = UpTo;              

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                return dataTable;

            }

            catch (Exception)
            {
                DataTable emptySet = new DataTable();
                return emptySet;
            }
            finally
            {
                if (Conn != null)
                {
                    if (Conn.State == ConnectionState.Open)
                    {
                        Conn.Close();
                    }
                }
            }
        }
        #endregion

        #region DELETE METHODS
        #region DELETE HALL BOOKING

        public bool DeleteHallBookingAll(int SerialNo)
        {
            bool result = false;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(con_String);
                SqlCommand command = new SqlCommand("usp_DEL_HallBookingAll", conn);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter paraSerialNo = command.Parameters.Add("@SerialNo", SqlDbType.Int);
                paraSerialNo.Value = SerialNo;

                conn.Open();
                int i = command.ExecuteNonQuery();
                if (i != 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return result;
        }

        public bool DeleteHallBooking(int ID)
        {
            bool result = false;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(con_String);
                SqlCommand command = new SqlCommand("usp_DEL_HallBooking", conn);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter paraSerialNo = command.Parameters.Add("@ID", SqlDbType.Int);
                paraSerialNo.Value = ID;

                conn.Open();
                int i = command.ExecuteNonQuery();
                if (i != 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return result;
        }

        #endregion
        #endregion

        #region Get Methods
        public DataTable GetDataByQuery(string query)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.CommandTimeout = 60;
                con.ConnectionString = con_String;
                con.Open();
                cmd.Connection = con;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion 

    }
}
