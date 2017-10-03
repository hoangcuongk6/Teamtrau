using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
    public class clsFTP_Server : clsDBInteractionQLCV
	{
		#region Class Member Declarations
			private SqlString		m_sFTP_UserName, m_sFTP_PassWord, m_sFTP_Port, m_sFTP_Server_Internet, m_sFTP_Server_Local;
			private SqlByte			m_byID_FTP_Server;
		#endregion


		public clsFTP_Server()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_FTP_Server_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@byID_FTP_Server", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, 3, 0, "", DataRowVersion.Proposed, m_byID_FTP_Server));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFTP_Server_Local", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFTP_Server_Local));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFTP_Server_Internet", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFTP_Server_Internet));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFTP_UserName", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFTP_UserName));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFTP_PassWord", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFTP_PassWord));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFTP_Port", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFTP_Port));

				if(m_bMainConnectionIsCreatedLocal)
				{
					// Open connection.
					m_scoMainConnection.Open();
				}
				else
				{
					if(m_cpMainConnectionProvider.IsTransactionPending)
					{
						scmCmdToExecute.Transaction = m_cpMainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsFTP_Server::Insert::Error occured.", ex);
			}
			finally
			{
				if(m_bMainConnectionIsCreatedLocal)
				{
					// Close connection.
					m_scoMainConnection.Close();
				}
				scmCmdToExecute.Dispose();
			}
		}


		public override bool Update()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_FTP_Server_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@byID_FTP_Server", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, 3, 0, "", DataRowVersion.Proposed, m_byID_FTP_Server));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFTP_Server_Local", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFTP_Server_Local));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFTP_Server_Internet", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFTP_Server_Internet));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFTP_UserName", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFTP_UserName));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFTP_PassWord", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFTP_PassWord));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFTP_Port", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFTP_Port));

				if(m_bMainConnectionIsCreatedLocal)
				{
					// Open connection.
					m_scoMainConnection.Open();
				}
				else
				{
					if(m_cpMainConnectionProvider.IsTransactionPending)
					{
						scmCmdToExecute.Transaction = m_cpMainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsFTP_Server::Update::Error occured.", ex);
			}
			finally
			{
				if(m_bMainConnectionIsCreatedLocal)
				{
					// Close connection.
					m_scoMainConnection.Close();
				}
				scmCmdToExecute.Dispose();
			}
		}


		public override bool Delete()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_FTP_Server_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@byID_FTP_Server", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, 3, 0, "", DataRowVersion.Proposed, m_byID_FTP_Server));

				if(m_bMainConnectionIsCreatedLocal)
				{
					// Open connection.
					m_scoMainConnection.Open();
				}
				else
				{
					if(m_cpMainConnectionProvider.IsTransactionPending)
					{
						scmCmdToExecute.Transaction = m_cpMainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsFTP_Server::Delete::Error occured.", ex);
			}
			finally
			{
				if(m_bMainConnectionIsCreatedLocal)
				{
					// Close connection.
					m_scoMainConnection.Close();
				}
				scmCmdToExecute.Dispose();
			}
		}


		public override DataTable SelectOne()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_FTP_Server_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("FTP_Server");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@byID_FTP_Server", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, 3, 0, "", DataRowVersion.Proposed, m_byID_FTP_Server));

				if(m_bMainConnectionIsCreatedLocal)
				{
					// Open connection.
					m_scoMainConnection.Open();
				}
				else
				{
					if(m_cpMainConnectionProvider.IsTransactionPending)
					{
						scmCmdToExecute.Transaction = m_cpMainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				if(dtToReturn.Rows.Count > 0)
				{
					m_byID_FTP_Server = (byte)dtToReturn.Rows[0]["ID_FTP_Server"];
					m_sFTP_Server_Local = (string)dtToReturn.Rows[0]["FTP_Server_Local"];
					m_sFTP_Server_Internet = dtToReturn.Rows[0]["FTP_Server_Internet"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["FTP_Server_Internet"];
					m_sFTP_UserName = (string)dtToReturn.Rows[0]["FTP_UserName"];
					m_sFTP_PassWord = (string)dtToReturn.Rows[0]["FTP_PassWord"];
					m_sFTP_Port = (string)dtToReturn.Rows[0]["FTP_Port"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsFTP_Server::SelectOne::Error occured.", ex);
			}
			finally
			{
				if(m_bMainConnectionIsCreatedLocal)
				{
					// Close connection.
					m_scoMainConnection.Close();
				}
				scmCmdToExecute.Dispose();
				sdaAdapter.Dispose();
			}
		}


		public override DataTable SelectAll()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_FTP_Server_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("FTP_Server");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{

				if(m_bMainConnectionIsCreatedLocal)
				{
					// Open connection.
					m_scoMainConnection.Open();
				}
				else
				{
					if(m_cpMainConnectionProvider.IsTransactionPending)
					{
						scmCmdToExecute.Transaction = m_cpMainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsFTP_Server::SelectAll::Error occured.", ex);
			}
			finally
			{
				if(m_bMainConnectionIsCreatedLocal)
				{
					// Close connection.
					m_scoMainConnection.Close();
				}
				scmCmdToExecute.Dispose();
				sdaAdapter.Dispose();
			}
		}


		#region Class Property Declarations
		public SqlByte ID_FTP_Server
		{
			get
			{
				return m_byID_FTP_Server;
			}
			set
			{
				SqlByte byID_FTP_ServerTmp = (SqlByte)value;
				if(byID_FTP_ServerTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_FTP_Server", "iD_FTP_Server can't be NULL");
				}
				m_byID_FTP_Server = value;
			}
		}


		public SqlString FTP_Server_Local
		{
			get
			{
				return m_sFTP_Server_Local;
			}
			set
			{
				SqlString sFTP_Server_LocalTmp = (SqlString)value;
				if(sFTP_Server_LocalTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fTP_Server_Local", "fTP_Server_Local can't be NULL");
				}
				m_sFTP_Server_Local = value;
			}
		}


		public SqlString FTP_Server_Internet
		{
			get
			{
				return m_sFTP_Server_Internet;
			}
			set
			{
				m_sFTP_Server_Internet = value;
			}
		}


		public SqlString FTP_UserName
		{
			get
			{
				return m_sFTP_UserName;
			}
			set
			{
				SqlString sFTP_UserNameTmp = (SqlString)value;
				if(sFTP_UserNameTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fTP_UserName", "fTP_UserName can't be NULL");
				}
				m_sFTP_UserName = value;
			}
		}


		public SqlString FTP_PassWord
		{
			get
			{
				return m_sFTP_PassWord;
			}
			set
			{
				SqlString sFTP_PassWordTmp = (SqlString)value;
				if(sFTP_PassWordTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fTP_PassWord", "fTP_PassWord can't be NULL");
				}
				m_sFTP_PassWord = value;
			}
		}


		public SqlString FTP_Port
		{
			get
			{
				return m_sFTP_Port;
			}
			set
			{
				SqlString sFTP_PortTmp = (SqlString)value;
				if(sFTP_PortTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fTP_Port", "fTP_Port can't be NULL");
				}
				m_sFTP_Port = value;
			}
		}
		#endregion
	}
}
