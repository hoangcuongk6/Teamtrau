using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
	public partial class clsPhanCapNhanVien : clsDBInteractionQLCV
	{
		#region Class Member Declarations
			private SqlInt32		m_iID_DonVi, m_iID_NhanVien, m_iID_NguoiQuanLy;
		#endregion


		public clsPhanCapNhanVien()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_PhanCapNhanVien_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_NguoiQuanLy", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NguoiQuanLy));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_NhanVien", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NhanVien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_DonVi", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_DonVi));

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
				throw new Exception("clsPhanCapNhanVien::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_PhanCapNhanVien_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_NguoiQuanLy", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NguoiQuanLy));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_NhanVien", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NhanVien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_DonVi", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_DonVi));

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
				throw new Exception("clsPhanCapNhanVien::Delete::Error occured.", ex);
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


		public bool DeleteWID_NguoiQuanLyLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_PhanCapNhanVien_DeleteWID_NguoiQuanLyLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_NguoiQuanLy", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NguoiQuanLy));

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
				throw new Exception("clsPhanCapNhanVien::DeleteWID_NguoiQuanLyLogic::Error occured.", ex);
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


		public bool DeleteWID_NhanVienLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_PhanCapNhanVien_DeleteWID_NhanVienLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_NhanVien", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NhanVien));

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
				throw new Exception("clsPhanCapNhanVien::DeleteWID_NhanVienLogic::Error occured.", ex);
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


		public bool DeleteWID_DonViLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_PhanCapNhanVien_DeleteWID_DonViLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_DonVi", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_DonVi));

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
				throw new Exception("clsPhanCapNhanVien::DeleteWID_DonViLogic::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_PhanCapNhanVien_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("PhanCapNhanVien");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_NguoiQuanLy", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NguoiQuanLy));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_NhanVien", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NhanVien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_DonVi", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_DonVi));

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
					m_iID_NguoiQuanLy = (Int32)dtToReturn.Rows[0]["ID_NguoiQuanLy"];
					m_iID_NhanVien = (Int32)dtToReturn.Rows[0]["ID_NhanVien"];
					m_iID_DonVi = (Int32)dtToReturn.Rows[0]["ID_DonVi"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsPhanCapNhanVien::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_PhanCapNhanVien_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("PhanCapNhanVien");
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
				throw new Exception("clsPhanCapNhanVien::SelectAll::Error occured.", ex);
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
		public SqlInt32 ID_NguoiQuanLy
		{
			get
			{
				return m_iID_NguoiQuanLy;
			}
			set
			{
				SqlInt32 iID_NguoiQuanLyTmp = (SqlInt32)value;
				if(iID_NguoiQuanLyTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_NguoiQuanLy", "iD_NguoiQuanLy can't be NULL");
				}
				m_iID_NguoiQuanLy = value;
			}
		}


		public SqlInt32 ID_NhanVien
		{
			get
			{
				return m_iID_NhanVien;
			}
			set
			{
				SqlInt32 iID_NhanVienTmp = (SqlInt32)value;
				if(iID_NhanVienTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_NhanVien", "iD_NhanVien can't be NULL");
				}
				m_iID_NhanVien = value;
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
				SqlInt32 iID_DonViTmp = (SqlInt32)value;
				if(iID_DonViTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_DonVi", "iD_DonVi can't be NULL");
				}
				m_iID_DonVi = value;
			}
		}
		#endregion
	}
}
