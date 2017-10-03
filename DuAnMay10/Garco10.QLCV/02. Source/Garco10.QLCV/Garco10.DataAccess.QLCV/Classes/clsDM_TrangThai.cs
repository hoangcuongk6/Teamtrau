using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
	public partial class clsDM_TrangThai : clsDBInteractionQLCV
	{
		#region Class Member Declarations
			private SqlBoolean		m_bHienThi, m_bTonTai, m_bSuDung;
			private SqlInt32		m_iSTT_TrangThai;
			private SqlString		m_sTen_TrangThai;
			private SqlByte			m_byID_TrangThai;
		#endregion


		public clsDM_TrangThai()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_DM_TrangThai_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTen_TrangThai", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTen_TrangThai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iSTT_TrangThai", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iSTT_TrangThai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bHienThi", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bHienThi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bSuDung", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bSuDung));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@byID_TrangThai", SqlDbType.TinyInt, 1, ParameterDirection.Output, false, 3, 0, "", DataRowVersion.Proposed, m_byID_TrangThai));

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
				m_byID_TrangThai = (SqlByte)scmCmdToExecute.Parameters["@byID_TrangThai"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDM_TrangThai::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_DM_TrangThai_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@byID_TrangThai", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, 3, 0, "", DataRowVersion.Proposed, m_byID_TrangThai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTen_TrangThai", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTen_TrangThai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iSTT_TrangThai", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iSTT_TrangThai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bHienThi", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bHienThi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bSuDung", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bSuDung));

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
				throw new Exception("clsDM_TrangThai::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_DM_TrangThai_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@byID_TrangThai", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, 3, 0, "", DataRowVersion.Proposed, m_byID_TrangThai));

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
				throw new Exception("clsDM_TrangThai::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_DM_TrangThai_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("DM_TrangThai");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@byID_TrangThai", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, 3, 0, "", DataRowVersion.Proposed, m_byID_TrangThai));

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
					m_byID_TrangThai = (byte)dtToReturn.Rows[0]["ID_TrangThai"];
					m_sTen_TrangThai = (string)dtToReturn.Rows[0]["Ten_TrangThai"];
					m_iSTT_TrangThai = dtToReturn.Rows[0]["STT_TrangThai"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["STT_TrangThai"];
					m_bHienThi = dtToReturn.Rows[0]["HienThi"] == System.DBNull.Value ? SqlBoolean.Null : (bool)dtToReturn.Rows[0]["HienThi"];
					m_bTonTai = dtToReturn.Rows[0]["TonTai"] == System.DBNull.Value ? SqlBoolean.Null : (bool)dtToReturn.Rows[0]["TonTai"];
					m_bSuDung = dtToReturn.Rows[0]["SuDung"] == System.DBNull.Value ? SqlBoolean.Null : (bool)dtToReturn.Rows[0]["SuDung"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDM_TrangThai::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_DM_TrangThai_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("DM_TrangThai");
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
				throw new Exception("clsDM_TrangThai::SelectAll::Error occured.", ex);
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
		public SqlByte ID_TrangThai
		{
			get
			{
				return m_byID_TrangThai;
			}
			set
			{
				SqlByte byID_TrangThaiTmp = (SqlByte)value;
				if(byID_TrangThaiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_TrangThai", "iD_TrangThai can't be NULL");
				}
				m_byID_TrangThai = value;
			}
		}


		public SqlString Ten_TrangThai
		{
			get
			{
				return m_sTen_TrangThai;
			}
			set
			{
				SqlString sTen_TrangThaiTmp = (SqlString)value;
				if(sTen_TrangThaiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ten_TrangThai", "ten_TrangThai can't be NULL");
				}
				m_sTen_TrangThai = value;
			}
		}


		public SqlInt32 STT_TrangThai
		{
			get
			{
				return m_iSTT_TrangThai;
			}
			set
			{
				m_iSTT_TrangThai = value;
			}
		}


		public SqlBoolean HienThi
		{
			get
			{
				return m_bHienThi;
			}
			set
			{
				m_bHienThi = value;
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


		public SqlBoolean SuDung
		{
			get
			{
				return m_bSuDung;
			}
			set
			{
				m_bSuDung = value;
			}
		}
		#endregion
	}
}
