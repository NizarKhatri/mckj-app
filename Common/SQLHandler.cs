using System;
using System.Data;
using System.Data.SqlClient;

namespace MCKJ.Common
{
	/// <summary>
	/// Summary description for SQLHandler.
	/// </summary>
	class SQLHandler
	{
		private string Prefix = "SQLHandler";

		private String connectionString = "";

		private SqlCommand Cm;
		private SqlConnection Conn;
		private SqlDataReader data;
		private DataSet dataset;
		private SqlDataAdapter dataAdapter;

		private int rowCount = 0;

		//private DataSet dataset;
		//private SqlDataAdapter dataAdapter;

		public SQLHandler()
		{
			// instantiate and bind here, open later
			Conn = new SqlConnection();
			Cm = new SqlCommand();
			Cm.Connection = Conn;
		}

        ~SQLHandler()
        {
            Conn = null;
            Cm = null;
        }

		public int RowCount 
		{
			get{return rowCount;}
			set{rowCount = value;}
		}

		public void OpenConnection()
		{
			Conn.ConnectionString = connectionString;

			try
			{
                Cm.Connection.Open();
			}
			catch (Exception e)
			{
				this.Messages.Items.Add(new Message(MessageTypeCache.Error, ErrorCache.UnableToConnectToDatabase,
					ErrorCache.GetDescription(ErrorCache.UnableToConnectToDatabase)	+ "; Reason: " + e.Message,
					e.StackTrace,1));
			}
		}

		public void CloseConnection()
		{
            try
            {
                if ((Cm.Connection != null) && (Cm.Connection.State == ConnectionState.Open))
                {
                    SqlConnection.ClearPool(Cm.Connection);
                    Cm.Connection.Close();
                    Cm.Connection.Dispose();
                }
            }
            catch
            {
            }
		}

		/// <summary>
		/// Run an SQL statement that does provide a return resultset
		/// </summary>
		/// <param name="sql"></param>
		public SqlDataReader RunSQLRetrieve(String sql)
		{
			Cm.CommandText = sql;
			
			
			this.Messages.Items.Add(new Message(MessageTypeCache.Message, ErrorCache.NoErrorsOccured,
					"Sql : " + sql, null));


			if (data != null)
			{
				try
				{
					data.Close();			
					data = null;
				}
				catch
				{}
			}

			try 
			{
				data = Cm.ExecuteReader();
			}
			catch (Exception e)
			{
				this.Messages.Items.Add(new Message(MessageTypeCache.Error, ErrorCache.UnableToExecuteSQL,
					Prefix + ".RunSQLRetrieve: " + ErrorCache.GetDescription(ErrorCache.UnableToExecuteSQL)
					+ "; Reason: " + e.Message,	e.StackTrace, 1));
			}
			Cm.CommandText = "";
			return data;
		}

		/// <summary>
		/// Run an SQL statement that does provide a return resultset
		/// </summary>
		/// <param name="sql"></param>
		public object RunSQLScalar(String sql)
		{
			Cm.CommandText = sql;
			
			this.Messages.Items.Add(new Message(MessageTypeCache.Message, ErrorCache.NoErrorsOccured,
			"Sql : " + sql, null));

			object obj = null;

			try 
			{
				obj = Cm.ExecuteScalar();
			}
			catch (Exception e)
			{
				this.Messages.Items.Add(new Message(MessageTypeCache.Error, ErrorCache.UnableToExecuteSQL,
					Prefix + ".RunSQLScalar: " + ErrorCache.GetDescription(ErrorCache.UnableToExecuteSQL)
					+ "; Reason: " + e.Message, e.StackTrace, 1));
			}
			Cm.CommandText = "";
			return obj;
		}

		/// <summary>
		/// Run an SQL statement that does not provide a return resultset
		/// </summary>
		/// <param name="sql"></param>
		public void RunSQLExecute(String sql)
		{
			if (data != null)
			{
				try
				{
					data.Close();                  
					data = null;
				}
				catch
				{}
			}

			Cm.CommandText = sql;

			this.Messages.Items.Add(new Message(MessageTypeCache.Message, ErrorCache.NoErrorsOccured,
				"Sql : " + sql, null));

			try
			{
				rowCount = Cm.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				this.Messages.Items.Add(new Message(MessageTypeCache.Error, ErrorCache.UnableToExecuteSQL,
					Prefix + ".RunSQLExecute: " + ErrorCache.GetDescription(ErrorCache.UnableToExecuteSQL)
					+ "; Reason: " + e.Message, e.StackTrace, 1));
			}
			Cm.CommandText = "";
		}

		public int RetrieveMSSQLIdValue()
		{
			int i = -1;

			Cm.CommandText = "select @@identity as id";
			
			if (data != null)
			{
				try
				{
					data.Close();			
					data = null;
				}
				catch
				{}
			}

			try 
			{
				data = Cm.ExecuteReader();
				
				if(data.HasRows)
				{
					data.Read();
					i = System.Convert.ToInt32(data[0].ToString());
				}
			}
			catch (Exception e)
			{
				this.Messages.Items.Add(new Message(MessageTypeCache.Error, ErrorCache.UnableToExecuteSQL,
					Prefix + ".RunSQLRetrieve: " + ErrorCache.GetDescription(ErrorCache.UnableToExecuteSQL)
					+ "; Reason: " + e.Message,	e.StackTrace, 1));
			}
			finally
			{
				data.Close();			
				data = null;
			}
			Cm.CommandText = "";
			return i;
		}

		public DataSet RetrieveSqlDataSet(String sql)
		{
			if(this.data != null)
			{
				try
				{	
					this.data.Close();
					//this.dataset.Clear();
				}
				catch
				{}
			}

			try
			{
				
				this.Messages.Items.Add(new Message(MessageTypeCache.Message, ErrorCache.NoErrorsOccured,
					"Sql : " + sql, null));

				this.dataset = new DataSet();
				dataAdapter = new SqlDataAdapter(sql,Conn);
				dataAdapter.Fill(this.dataset);
				dataAdapter.Dispose();
			}
			catch (Exception e)
			{
				this.Messages.Items.Add(new Message(MessageTypeCache.Error, ErrorCache.UnableToExecuteSQL,
					Prefix + ".RunSQLExecute: " + ErrorCache.GetDescription(ErrorCache.UnableToExecuteSQL)
					+ "; Reason: " + e.Message, e.StackTrace, 1));

				
			}
			return this.dataset;
		}

		public void SaveLabelToDatabase(string trackingnbr, byte[] bytes, string labelstring)
		{
			if(this.data != null)
			{
				try
				{ 
					this.data.Close();
					//this.dataset.Clear();
				}
				catch
				{}
			}

			// one approach
			//SqlConnection connection = new SqlConnection("Data Source=FLANDERS;database=iabol_db_asi;uid=sa;pwd=abolsoft;Timeout=10000");
			// SqlCommand command = new SqlCommand( "INSERT INTO TEMP_LABELIMAGE (labelimage,trackingnbr,labelstring) VALUES (@img_name,@trackingnbr,@labelstring)", this.Conn );
			SqlCommand command = new SqlCommand( "INSERT INTO TEMP_LABELIMAGE (labelimage,trackingnbr) VALUES (@img_name,@trackingnbr)", this.Conn );

			SqlParameter param0 = new SqlParameter( "@img_name", SqlDbType.Image );
			param0.Value = bytes;
			command.Parameters.Add( param0 );

			SqlParameter param1 = new SqlParameter( "@trackingnbr", SqlDbType.VarChar,50 );
			param1.Value = trackingnbr;
			command.Parameters.Add( param1 );

			//SqlParameter param2 = new SqlParameter( "@labelstring", SqlDbType.VarChar,labelstring.Length );
			//p/aram1.Value = labelstring;
			//command.Parameters.Add( param2 );

			int numRowsAffected = command.ExecuteNonQuery();

			/* second approach 
			// "insert into temp_labelimage (trackingnbr, labelimage, labelstring) values (@trackingnbr, @labelimage, @labelstring)
			Cm.CommandText = SQLCache.InsertLabelImage;

			Cm.Parameters.Clear();
			Cm.Parameters.Add("@trackingnbr", SqlDbType.VarChar, trackingnbr.Length);
			Cm.Parameters.Add("@labelimage", SqlDbType.Image, labelimage.Length);
			Cm.Parameters.Add("@labelstring", SqlDbType.VarChar, labelstring.Length);

			byte[] a = System.Text.Encoding.Default.GetBytes(labelimage);
			
			Cm.Parameters[0].Value = trackingnbr;
			Cm.Parameters[1].Value = a;
			Cm.Parameters[2].Value = labelstring;

			try
			{
				Cm.Prepare();
				Cm.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				this.Messages.Items.Add(new Message(MessageTypeCache.Error, ErrorCache.UnableToExecuteSQL,
					Prefix + ".SaveLabelToDatabase: " + ErrorCache.GetDescription(ErrorCache.UnableToExecuteSQL)
					+ "; Reason: " + e.Message, e.StackTrace));
			}

			Cm.Parameters.Clear();
			Cm.CommandText = "";

			a = null;
		*/
		}

	}
}
