using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
	public partial class clsChucVu_PhanCap : clsDBInteractionQLCV
	{
		#region Class Member Declarations
			private SqlInt32		m_iID_ChucVu_CapDuoi, m_iID_ChucVu_CapTren;
		#endregion


		public clsChucVu_PhanCap()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_ChucVu_PhanCap_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_ChucVu_CapTren", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChucVu_CapTren));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_ChucVu_CapDuoi", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChucVu_CapDuoi));

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
                Garco10.DataAccess.QLCV.Global.GlobalVariables.ErrorLogging(ex);
				throw new Exception("clsChucVu_PhanCap::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_ChucVu_PhanCap_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_ChucVu_CapTren", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChucVu_CapTren));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_ChucVu_CapDuoi", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChucVu_CapDuoi));

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
                Garco10.DataAccess.QLCV.Global.GlobalVariables.ErrorLogging(ex);
				throw new Exception("clsChucVu_PhanCap::Delete::Error occured.", ex);
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


		public bool DeleteWID_ChucVu_CapTrenLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_ChucVu_PhanCap_DeleteWID_ChucVu_CapTrenLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_ChucVu_CapTren", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChucVu_CapTren));

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
                Garco10.DataAccess.QLCV.Global.GlobalVariables.ErrorLogging(ex);
				throw new Exception("clsChucVu_PhanCap::DeleteWID_ChucVu_CapTrenLogic::Error occured.", ex);
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


		public bool DeleteWID_ChucVu_CapDuoiLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_ChucVu_PhanCap_DeleteWID_ChucVu_CapDuoiLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_ChucVu_CapDuoi", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChucVu_CapDuoi));

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
                Garco10.DataAccess.QLCV.Global.GlobalVariables.ErrorLogging(ex);
				throw new Exception("clsChucVu_PhanCap::DeleteWID_ChucVu_CapDuoiLogic::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_ChucVu_PhanCap_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("ChucVu_PhanCap");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_ChucVu_CapTren", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChucVu_CapTren));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_ChucVu_CapDuoi", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChucVu_CapDuoi));

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
					m_iID_ChucVu_CapTren = (Int32)dtToReturn.Rows[0]["ID_ChucVu_CapTren"];
					m_iID_ChucVu_CapDuoi = (Int32)dtToReturn.Rows[0]["ID_ChucVu_CapDuoi"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
                Garco10.DataAccess.QLCV.Global.GlobalVariables.ErrorLogging(ex);
				throw new Exception("clsChucVu_PhanCap::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_ChucVu_PhanCap_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("ChucVu_PhanCap");
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
                Garco10.DataAccess.QLCV.Global.GlobalVariables.ErrorLogging(ex);
				throw new Exception("clsChucVu_PhanCap::SelectAll::Error occured.", ex);
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
		public SqlInt32 ID_ChucVu_CapTren
		{
			get
			{
				return m_iID_ChucVu_CapTren;
			}
			set
			{
				SqlInt32 iID_ChucVu_CapTrenTmp = (SqlInt32)value;
				if(iID_ChucVu_CapTrenTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_ChucVu_CapTren", "iD_ChucVu_CapTren can't be NULL");
				}
				m_iID_ChucVu_CapTren = value;
			}
		}


		public SqlInt32 ID_ChucVu_CapDuoi
		{
			get
			{
				return m_iID_ChucVu_CapDuoi;
			}
			set
			{
				SqlInt32 iID_ChucVu_CapDuoiTmp = (SqlInt32)value;
				if(iID_ChucVu_CapDuoiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_ChucVu_CapDuoi", "iD_ChucVu_CapDuoi can't be NULL");
				}
				m_iID_ChucVu_CapDuoi = value;
			}
		}
		#endregion
	}
}
