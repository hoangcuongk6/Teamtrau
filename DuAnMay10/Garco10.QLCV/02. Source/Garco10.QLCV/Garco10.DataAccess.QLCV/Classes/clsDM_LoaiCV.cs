using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
	public partial class clsDM_LoaiCV : clsDBInteractionQLCV
	{
		#region Class Member Declarations
			private SqlBoolean		m_bSuDung, m_bTonTai;
			private SqlInt32		m_iID_DonVi, m_iID_LoaiCV, m_iID_LoaiCV_Cha;
			private SqlString		m_sSTT_LoaiCV, m_sTen_LoaiCV;
		#endregion


		public clsDM_LoaiCV()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_DM_LoaiCV_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ten_LoaiCV", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTen_LoaiCV));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_LoaiCV_Cha", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_LoaiCV_Cha));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@TonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@SuDung", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bSuDung));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_DonVi", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_DonVi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@STT_LoaiCV", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSTT_LoaiCV));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_LoaiCV", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_LoaiCV));

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
				m_iID_LoaiCV = (SqlInt32)scmCmdToExecute.Parameters["@ID_LoaiCV"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDM_LoaiCV::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_DM_LoaiCV_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_LoaiCV", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_LoaiCV));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ten_LoaiCV", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTen_LoaiCV));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_LoaiCV_Cha", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_LoaiCV_Cha));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@TonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@SuDung", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bSuDung));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_DonVi", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_DonVi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@STT_LoaiCV", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSTT_LoaiCV));

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
				throw new Exception("clsDM_LoaiCV::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_DM_LoaiCV_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_LoaiCV", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_LoaiCV));

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
				throw new Exception("clsDM_LoaiCV::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_DM_LoaiCV_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("DM_LoaiCV");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_LoaiCV", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_LoaiCV));

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
					m_iID_LoaiCV = (Int32)dtToReturn.Rows[0]["ID_LoaiCV"];
					m_sTen_LoaiCV = (string)dtToReturn.Rows[0]["Ten_LoaiCV"];
					m_iID_LoaiCV_Cha = dtToReturn.Rows[0]["ID_LoaiCV_Cha"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ID_LoaiCV_Cha"];
					m_bTonTai = (bool)dtToReturn.Rows[0]["TonTai"];
					m_bSuDung = (bool)dtToReturn.Rows[0]["SuDung"];
					m_iID_DonVi = dtToReturn.Rows[0]["ID_DonVi"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ID_DonVi"];
					m_sSTT_LoaiCV = dtToReturn.Rows[0]["STT_LoaiCV"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["STT_LoaiCV"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDM_LoaiCV::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_DM_LoaiCV_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("DM_LoaiCV");
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
				throw new Exception("clsDM_LoaiCV::SelectAll::Error occured.", ex);
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
		public SqlInt32 ID_LoaiCV
		{
			get
			{
				return m_iID_LoaiCV;
			}
			set
			{
				SqlInt32 iID_LoaiCVTmp = (SqlInt32)value;
				if(iID_LoaiCVTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_LoaiCV", "iD_LoaiCV can't be NULL");
				}
				m_iID_LoaiCV = value;
			}
		}


		public SqlString Ten_LoaiCV
		{
			get
			{
				return m_sTen_LoaiCV;
			}
			set
			{
				SqlString sTen_LoaiCVTmp = (SqlString)value;
				if(sTen_LoaiCVTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ten_LoaiCV", "ten_LoaiCV can't be NULL");
				}
				m_sTen_LoaiCV = value;
			}
		}


		public SqlInt32 ID_LoaiCV_Cha
		{
			get
			{
				return m_iID_LoaiCV_Cha;
			}
			set
			{
				m_iID_LoaiCV_Cha = value;
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


		public SqlBoolean SuDung
		{
			get
			{
				return m_bSuDung;
			}
			set
			{
				SqlBoolean bSuDungTmp = (SqlBoolean)value;
				if(bSuDungTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("suDung", "suDung can't be NULL");
				}
				m_bSuDung = value;
			}
		}


		public SqlInt32 ID_DonVi
		{
			get
			{
				return m_iID_DonVi;
			}
			set
			{
				m_iID_DonVi = value;
			}
		}


		public SqlString STT_LoaiCV
		{
			get
			{
				return m_sSTT_LoaiCV;
			}
			set
			{
				m_sSTT_LoaiCV = value;
			}
		}
		#endregion
	}
}
