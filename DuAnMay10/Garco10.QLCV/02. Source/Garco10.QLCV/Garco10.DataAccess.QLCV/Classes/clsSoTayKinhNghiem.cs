using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
	public partial class clsSoTayKinhNghiem : clsDBInteractionQLCV
	{
		#region Class Member Declarations
			private SqlDateTime		m_daNgay_Thang, m_daNgay_Lap;
			private SqlInt32		m_iID_NguoiLap, m_iID_SoTay, m_iID_BoPhan;
			private SqlString		m_sGhiChu, m_sMucDo_AnhHuong, m_sMoTa, m_sNguyenNhan, m_sBienPhap;
		#endregion


		public clsSoTayKinhNghiem()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_SoTayKinhNghiem_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daNgay_Thang", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_Thang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_BoPhan", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_BoPhan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sMoTa", SqlDbType.NVarChar, 1000, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMoTa));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sMucDo_AnhHuong", SqlDbType.NVarChar, 1000, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMucDo_AnhHuong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sNguyenNhan", SqlDbType.NVarChar, 1000, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNguyenNhan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sBienPhap", SqlDbType.NVarChar, 1000, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sBienPhap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sGhiChu", SqlDbType.NVarChar, 1000, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sGhiChu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daNgay_Lap", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_Lap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_NguoiLap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NguoiLap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_SoTay", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_SoTay));

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
				m_iID_SoTay = (SqlInt32)scmCmdToExecute.Parameters["@iID_SoTay"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsSoTayKinhNghiem::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_SoTayKinhNghiem_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_SoTay", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_SoTay));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daNgay_Thang", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_Thang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_BoPhan", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_BoPhan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sMoTa", SqlDbType.NVarChar, 1000, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMoTa));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sMucDo_AnhHuong", SqlDbType.NVarChar, 1000, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMucDo_AnhHuong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sNguyenNhan", SqlDbType.NVarChar, 1000, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNguyenNhan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sBienPhap", SqlDbType.NVarChar, 1000, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sBienPhap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sGhiChu", SqlDbType.NVarChar, 1000, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sGhiChu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daNgay_Lap", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_Lap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_NguoiLap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NguoiLap));

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
				throw new Exception("clsSoTayKinhNghiem::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_SoTayKinhNghiem_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_SoTay", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_SoTay));

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
				throw new Exception("clsSoTayKinhNghiem::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_SoTayKinhNghiem_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("SoTayKinhNghiem");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_SoTay", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_SoTay));

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
					m_iID_SoTay = (Int32)dtToReturn.Rows[0]["ID_SoTay"];
					m_daNgay_Thang = (DateTime)dtToReturn.Rows[0]["Ngay_Thang"];
					m_iID_BoPhan = (Int32)dtToReturn.Rows[0]["ID_BoPhan"];
					m_sMoTa = (string)dtToReturn.Rows[0]["MoTa"];
					m_sMucDo_AnhHuong = (string)dtToReturn.Rows[0]["MucDo_AnhHuong"];
					m_sNguyenNhan = (string)dtToReturn.Rows[0]["NguyenNhan"];
					m_sBienPhap = (string)dtToReturn.Rows[0]["BienPhap"];
					m_sGhiChu = (string)dtToReturn.Rows[0]["GhiChu"];
					m_daNgay_Lap = (DateTime)dtToReturn.Rows[0]["Ngay_Lap"];
					m_iID_NguoiLap = (Int32)dtToReturn.Rows[0]["ID_NguoiLap"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsSoTayKinhNghiem::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_SoTayKinhNghiem_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("SoTayKinhNghiem");
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
				throw new Exception("clsSoTayKinhNghiem::SelectAll::Error occured.", ex);
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
		public SqlInt32 ID_SoTay
		{
			get
			{
				return m_iID_SoTay;
			}
			set
			{
				SqlInt32 iID_SoTayTmp = (SqlInt32)value;
				if(iID_SoTayTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_SoTay", "iD_SoTay can't be NULL");
				}
				m_iID_SoTay = value;
			}
		}


		public SqlDateTime Ngay_Thang
		{
			get
			{
				return m_daNgay_Thang;
			}
			set
			{
				SqlDateTime daNgay_ThangTmp = (SqlDateTime)value;
				if(daNgay_ThangTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ngay_Thang", "ngay_Thang can't be NULL");
				}
				m_daNgay_Thang = value;
			}
		}


		public SqlInt32 ID_BoPhan
		{
			get
			{
				return m_iID_BoPhan;
			}
			set
			{
				SqlInt32 iID_BoPhanTmp = (SqlInt32)value;
				if(iID_BoPhanTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_BoPhan", "iD_BoPhan can't be NULL");
				}
				m_iID_BoPhan = value;
			}
		}


		public SqlString MoTa
		{
			get
			{
				return m_sMoTa;
			}
			set
			{
				SqlString sMoTaTmp = (SqlString)value;
				if(sMoTaTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("moTa", "moTa can't be NULL");
				}
				m_sMoTa = value;
			}
		}


		public SqlString MucDo_AnhHuong
		{
			get
			{
				return m_sMucDo_AnhHuong;
			}
			set
			{
				SqlString sMucDo_AnhHuongTmp = (SqlString)value;
				if(sMucDo_AnhHuongTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("mucDo_AnhHuong", "mucDo_AnhHuong can't be NULL");
				}
				m_sMucDo_AnhHuong = value;
			}
		}


		public SqlString NguyenNhan
		{
			get
			{
				return m_sNguyenNhan;
			}
			set
			{
				SqlString sNguyenNhanTmp = (SqlString)value;
				if(sNguyenNhanTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("nguyenNhan", "nguyenNhan can't be NULL");
				}
				m_sNguyenNhan = value;
			}
		}


		public SqlString BienPhap
		{
			get
			{
				return m_sBienPhap;
			}
			set
			{
				SqlString sBienPhapTmp = (SqlString)value;
				if(sBienPhapTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bienPhap", "bienPhap can't be NULL");
				}
				m_sBienPhap = value;
			}
		}


		public SqlString GhiChu
		{
			get
			{
				return m_sGhiChu;
			}
			set
			{
				SqlString sGhiChuTmp = (SqlString)value;
				if(sGhiChuTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ghiChu", "ghiChu can't be NULL");
				}
				m_sGhiChu = value;
			}
		}


		public SqlDateTime Ngay_Lap
		{
			get
			{
				return m_daNgay_Lap;
			}
			set
			{
				SqlDateTime daNgay_LapTmp = (SqlDateTime)value;
				if(daNgay_LapTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ngay_Lap", "ngay_Lap can't be NULL");
				}
				m_daNgay_Lap = value;
			}
		}


		public SqlInt32 ID_NguoiLap
		{
			get
			{
				return m_iID_NguoiLap;
			}
			set
			{
				SqlInt32 iID_NguoiLapTmp = (SqlInt32)value;
				if(iID_NguoiLapTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_NguoiLap", "iD_NguoiLap can't be NULL");
				}
				m_iID_NguoiLap = value;
			}
		}
		#endregion
	}
}
