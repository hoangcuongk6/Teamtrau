using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
	public partial class clsNhom : clsDBInteractionQLCV
	{
		#region Class Member Declarations
			private SqlBoolean		m_bTonTai;
			private SqlInt32		m_iID_Nhom, m_iID_Nhom_Cha;
			private SqlString		m_sTen_Nhom;
		#endregion


		public clsNhom()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_Nhom_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_Nhom_Cha", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_Nhom_Cha));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ten_Nhom", SqlDbType.NVarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTen_Nhom));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@TonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_Nhom", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_Nhom));

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
				m_iID_Nhom = (SqlInt32)scmCmdToExecute.Parameters["@ID_Nhom"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsNhom::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_Nhom_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_Nhom", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_Nhom));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_Nhom_Cha", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_Nhom_Cha));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ten_Nhom", SqlDbType.NVarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTen_Nhom));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@TonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));

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
				throw new Exception("clsNhom::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_Nhom_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_Nhom", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_Nhom));

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
				throw new Exception("clsNhom::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_Nhom_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("Nhom");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_Nhom", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_Nhom));

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
					m_iID_Nhom = (Int32)dtToReturn.Rows[0]["ID_Nhom"];
					m_iID_Nhom_Cha = dtToReturn.Rows[0]["ID_Nhom_Cha"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ID_Nhom_Cha"];
					m_sTen_Nhom = dtToReturn.Rows[0]["Ten_Nhom"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Ten_Nhom"];
					m_bTonTai = dtToReturn.Rows[0]["TonTai"] == System.DBNull.Value ? SqlBoolean.Null : (bool)dtToReturn.Rows[0]["TonTai"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsNhom::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_Nhom_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("Nhom");
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
				throw new Exception("clsNhom::SelectAll::Error occured.", ex);
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
		public SqlInt32 ID_Nhom
		{
			get
			{
				return m_iID_Nhom;
			}
			set
			{
				SqlInt32 iID_NhomTmp = (SqlInt32)value;
				if(iID_NhomTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_Nhom", "iD_Nhom can't be NULL");
				}
				m_iID_Nhom = value;
			}
		}


		public SqlInt32 ID_Nhom_Cha
		{
			get
			{
				return m_iID_Nhom_Cha;
			}
			set
			{
				m_iID_Nhom_Cha = value;
			}
		}


		public SqlString Ten_Nhom
		{
			get
			{
				return m_sTen_Nhom;
			}
			set
			{
				m_sTen_Nhom = value;
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
				m_bTonTai = value;
			}
		}
		#endregion
	}
}
