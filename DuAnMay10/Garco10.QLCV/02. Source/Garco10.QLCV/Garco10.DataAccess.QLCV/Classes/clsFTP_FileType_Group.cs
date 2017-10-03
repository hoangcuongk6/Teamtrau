using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
    public class clsFTP_FileType_Group : clsDBInteractionQLCV
	{
		#region Class Member Declarations
			private SqlBoolean		m_bTonTai;
			private SqlString		m_sFileType_Group_Name;
			private SqlInt16		m_siID_FileType_Group;
			private SqlByte			m_byID_PhanMem;
		#endregion


		public clsFTP_FileType_Group()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_FTP_FileType_Group_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@byID_PhanMem", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, 3, 0, "", DataRowVersion.Proposed, m_byID_PhanMem));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFileType_Group_Name", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFileType_Group_Name));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@siID_FileType_Group", SqlDbType.SmallInt, 2, ParameterDirection.Output, false, 5, 0, "", DataRowVersion.Proposed, m_siID_FileType_Group));

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
				m_siID_FileType_Group = (SqlInt16)scmCmdToExecute.Parameters["@siID_FileType_Group"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsFTP_FileType_Group::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_FTP_FileType_Group_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@siID_FileType_Group", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 5, 0, "", DataRowVersion.Proposed, m_siID_FileType_Group));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@byID_PhanMem", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, 3, 0, "", DataRowVersion.Proposed, m_byID_PhanMem));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFileType_Group_Name", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFileType_Group_Name));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));

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
				throw new Exception("clsFTP_FileType_Group::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_FTP_FileType_Group_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@siID_FileType_Group", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 5, 0, "", DataRowVersion.Proposed, m_siID_FileType_Group));

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
				throw new Exception("clsFTP_FileType_Group::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_FTP_FileType_Group_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("FTP_FileType_Group");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@siID_FileType_Group", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 5, 0, "", DataRowVersion.Proposed, m_siID_FileType_Group));

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
					m_siID_FileType_Group = (Int16)dtToReturn.Rows[0]["ID_FileType_Group"];
					m_byID_PhanMem = (byte)dtToReturn.Rows[0]["ID_PhanMem"];
					m_sFileType_Group_Name = (string)dtToReturn.Rows[0]["FileType_Group_Name"];
					m_bTonTai = (bool)dtToReturn.Rows[0]["TonTai"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsFTP_FileType_Group::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_FTP_FileType_Group_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("FTP_FileType_Group");
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
				throw new Exception("clsFTP_FileType_Group::SelectAll::Error occured.", ex);
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
		public SqlInt16 ID_FileType_Group
		{
			get
			{
				return m_siID_FileType_Group;
			}
			set
			{
				SqlInt16 siID_FileType_GroupTmp = (SqlInt16)value;
				if(siID_FileType_GroupTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_FileType_Group", "iD_FileType_Group can't be NULL");
				}
				m_siID_FileType_Group = value;
			}
		}


		public SqlByte ID_PhanMem
		{
			get
			{
				return m_byID_PhanMem;
			}
			set
			{
				SqlByte byID_PhanMemTmp = (SqlByte)value;
				if(byID_PhanMemTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_PhanMem", "iD_PhanMem can't be NULL");
				}
				m_byID_PhanMem = value;
			}
		}


		public SqlString FileType_Group_Name
		{
			get
			{
				return m_sFileType_Group_Name;
			}
			set
			{
				SqlString sFileType_Group_NameTmp = (SqlString)value;
				if(sFileType_Group_NameTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fileType_Group_Name", "fileType_Group_Name can't be NULL");
				}
				m_sFileType_Group_Name = value;
			}
		}


		public SqlBoolean TonTai
		{
			get
			{
				return m_bTonTai;
			}
			set
			{
				SqlBoolean bTonTaiTmp = (SqlBoolean)value;
				if(bTonTaiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("tonTai", "tonTai can't be NULL");
				}
				m_bTonTai = value;
			}
		}
		#endregion
	}
}
