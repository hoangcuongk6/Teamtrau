using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
	public partial class clsThongBao : clsDBInteractionQLCV
	{
		#region Class Member Declarations
			private SqlDateTime		m_daNgay_Gui;
			private SqlInt32		m_iID_CongViec, m_iID_ThongBao;
			private SqlString		m_sTen_ChucNang_ThongBao, m_sNoiDung, m_sTaiKhoan_Nhan;
			private SqlInt16		m_siTaiKhoan_Gui;
			private SqlByte			m_byTrangThai;
		#endregion


		public clsThongBao()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_ThongBao_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@siTaiKhoan_Gui", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 5, 0, "", DataRowVersion.Proposed, m_siTaiKhoan_Gui));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTaiKhoan_Nhan", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTaiKhoan_Nhan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sNoiDung", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNoiDung));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daNgay_Gui", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_Gui));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTen_ChucNang_ThongBao", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTen_ChucNang_ThongBao));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@byTrangThai", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, 3, 0, "", DataRowVersion.Proposed, m_byTrangThai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_CongViec", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ThongBao", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ThongBao));

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
				m_iID_ThongBao = (SqlInt32)scmCmdToExecute.Parameters["@iID_ThongBao"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsThongBao::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_ThongBao_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ThongBao", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ThongBao));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@siTaiKhoan_Gui", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 5, 0, "", DataRowVersion.Proposed, m_siTaiKhoan_Gui));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTaiKhoan_Nhan", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTaiKhoan_Nhan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sNoiDung", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNoiDung));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daNgay_Gui", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_Gui));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTen_ChucNang_ThongBao", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTen_ChucNang_ThongBao));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@byTrangThai", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, 3, 0, "", DataRowVersion.Proposed, m_byTrangThai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_CongViec", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec));

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
				throw new Exception("clsThongBao::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_ThongBao_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ThongBao", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ThongBao));

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
				throw new Exception("clsThongBao::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_ThongBao_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("ThongBao");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ThongBao", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ThongBao));

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
					m_iID_ThongBao = (Int32)dtToReturn.Rows[0]["ID_ThongBao"];
					m_siTaiKhoan_Gui = (Int16)dtToReturn.Rows[0]["TaiKhoan_Gui"];
					m_sTaiKhoan_Nhan = (string)dtToReturn.Rows[0]["TaiKhoan_Nhan"];
					m_sNoiDung = (string)dtToReturn.Rows[0]["NoiDung"];
					m_daNgay_Gui = (DateTime)dtToReturn.Rows[0]["Ngay_Gui"];
					m_sTen_ChucNang_ThongBao = (string)dtToReturn.Rows[0]["Ten_ChucNang_ThongBao"];
					m_byTrangThai = (byte)dtToReturn.Rows[0]["TrangThai"];
					m_iID_CongViec = dtToReturn.Rows[0]["ID_CongViec"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ID_CongViec"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsThongBao::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_ThongBao_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("ThongBao");
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
				throw new Exception("clsThongBao::SelectAll::Error occured.", ex);
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
		public SqlInt32 ID_ThongBao
		{
			get
			{
				return m_iID_ThongBao;
			}
			set
			{
				SqlInt32 iID_ThongBaoTmp = (SqlInt32)value;
				if(iID_ThongBaoTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_ThongBao", "iD_ThongBao can't be NULL");
				}
				m_iID_ThongBao = value;
			}
		}


		public SqlInt16 TaiKhoan_Gui
		{
			get
			{
				return m_siTaiKhoan_Gui;
			}
			set
			{
				SqlInt16 siTaiKhoan_GuiTmp = (SqlInt16)value;
				if(siTaiKhoan_GuiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("taiKhoan_Gui", "taiKhoan_Gui can't be NULL");
				}
				m_siTaiKhoan_Gui = value;
			}
		}


		public SqlString TaiKhoan_Nhan
		{
			get
			{
				return m_sTaiKhoan_Nhan;
			}
			set
			{
				SqlString sTaiKhoan_NhanTmp = (SqlString)value;
				if(sTaiKhoan_NhanTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("taiKhoan_Nhan", "taiKhoan_Nhan can't be NULL");
				}
				m_sTaiKhoan_Nhan = value;
			}
		}


		public SqlString NoiDung
		{
			get
			{
				return m_sNoiDung;
			}
			set
			{
				SqlString sNoiDungTmp = (SqlString)value;
				if(sNoiDungTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("noiDung", "noiDung can't be NULL");
				}
				m_sNoiDung = value;
			}
		}


		public SqlDateTime Ngay_Gui
		{
			get
			{
				return m_daNgay_Gui;
			}
			set
			{
				SqlDateTime daNgay_GuiTmp = (SqlDateTime)value;
				if(daNgay_GuiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ngay_Gui", "ngay_Gui can't be NULL");
				}
				m_daNgay_Gui = value;
			}
		}


		public SqlString Ten_ChucNang_ThongBao
		{
			get
			{
				return m_sTen_ChucNang_ThongBao;
			}
			set
			{
				SqlString sTen_ChucNang_ThongBaoTmp = (SqlString)value;
				if(sTen_ChucNang_ThongBaoTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ten_ChucNang_ThongBao", "ten_ChucNang_ThongBao can't be NULL");
				}
				m_sTen_ChucNang_ThongBao = value;
			}
		}


		public SqlByte TrangThai
		{
			get
			{
				return m_byTrangThai;
			}
			set
			{
				SqlByte byTrangThaiTmp = (SqlByte)value;
				if(byTrangThaiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("trangThai", "trangThai can't be NULL");
				}
				m_byTrangThai = value;
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
		#endregion
	}
}
