using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
	public partial class clsCongViec_ThongBao : clsDBInteractionQLCV
	{
		#region Class Member Declarations
			private SqlDecimal		m_dcThoiGian_BaoTruoc;
			private SqlInt32		m_iID_ThoiGian, m_iID_CongViec_ThongBao, m_iID_CongViec, m_iID_LoaiThongBao;
		#endregion


		public clsCongViec_ThongBao()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_ThongBao_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_CongViec", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_LoaiThongBao", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_LoaiThongBao));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ThoiGian", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ThoiGian));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcThoiGian_BaoTruoc", SqlDbType.Decimal, 5, ParameterDirection.Input, false, 5, 2, "", DataRowVersion.Proposed, m_dcThoiGian_BaoTruoc));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_CongViec_ThongBao", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec_ThongBao));

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
				m_iID_CongViec_ThongBao = (SqlInt32)scmCmdToExecute.Parameters["@iID_CongViec_ThongBao"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsCongViec_ThongBao::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_ThongBao_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_CongViec_ThongBao", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec_ThongBao));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_CongViec", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_LoaiThongBao", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_LoaiThongBao));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ThoiGian", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ThoiGian));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcThoiGian_BaoTruoc", SqlDbType.Decimal, 5, ParameterDirection.Input, false, 5, 2, "", DataRowVersion.Proposed, m_dcThoiGian_BaoTruoc));

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
				throw new Exception("clsCongViec_ThongBao::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_ThongBao_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_CongViec_ThongBao", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec_ThongBao));

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
				throw new Exception("clsCongViec_ThongBao::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_ThongBao_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("CongViec_ThongBao");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_CongViec_ThongBao", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec_ThongBao));

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
					m_iID_CongViec_ThongBao = (Int32)dtToReturn.Rows[0]["ID_CongViec_ThongBao"];
					m_iID_CongViec = dtToReturn.Rows[0]["ID_CongViec"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ID_CongViec"];
					m_iID_LoaiThongBao = dtToReturn.Rows[0]["ID_LoaiThongBao"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ID_LoaiThongBao"];
					m_iID_ThoiGian = dtToReturn.Rows[0]["ID_ThoiGian"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ID_ThoiGian"];
					m_dcThoiGian_BaoTruoc = dtToReturn.Rows[0]["ThoiGian_BaoTruoc"] == System.DBNull.Value ? SqlDecimal.Null : (Decimal)dtToReturn.Rows[0]["ThoiGian_BaoTruoc"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsCongViec_ThongBao::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_ThongBao_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("CongViec_ThongBao");
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
				throw new Exception("clsCongViec_ThongBao::SelectAll::Error occured.", ex);
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
		public SqlInt32 ID_CongViec_ThongBao
		{
			get
			{
				return m_iID_CongViec_ThongBao;
			}
			set
			{
				SqlInt32 iID_CongViec_ThongBaoTmp = (SqlInt32)value;
				if(iID_CongViec_ThongBaoTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_CongViec_ThongBao", "iD_CongViec_ThongBao can't be NULL");
				}
				m_iID_CongViec_ThongBao = value;
			}
		}


		public SqlInt32 ID_CongViec
		{
			get
			{
				return m_iID_CongViec;
			}
			set
			{
				m_iID_CongViec = value;
			}
		}


		public SqlInt32 ID_LoaiThongBao
		{
			get
			{
				return m_iID_LoaiThongBao;
			}
			set
			{
				m_iID_LoaiThongBao = value;
			}
		}


		public SqlInt32 ID_ThoiGian
		{
			get
			{
				return m_iID_ThoiGian;
			}
			set
			{
				m_iID_ThoiGian = value;
			}
		}


		public SqlDecimal ThoiGian_BaoTruoc
		{
			get
			{
				return m_dcThoiGian_BaoTruoc;
			}
			set
			{
				m_dcThoiGian_BaoTruoc = value;
			}
		}
		#endregion
	}
}
