using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
	public partial class clsCongViec : clsDBInteractionQLCV
	{
		#region Class Member Declarations
			private SqlBoolean		m_bTonTai, m_bLapLai, m_bHienThiTrenLich;
			private SqlDateTime		m_daNgay_YeuCau, m_daNgay_DenHan, m_daNgay_HoanThanh, m_daNgay_SuaCuoi, m_daNgay_BatDau, m_daNgay_Lap;
			private SqlDecimal		m_dcSoLuong_KeHoach, m_dcPhanTramHoanThanh, m_dcThoiGian_DuKien;
			private SqlInt32		m_iID_NguoiYeuCau, m_iID_CongViec_Goc, m_iID_NguoiLap, m_iID_NguoiSuaCuoi, m_iID_MucDoUuTien, m_iID_CongViec, m_iID_TrangThai, m_iID_LoaiCV;
			private SqlString		m_sMa_CongViec, m_sLoaiThongBao, m_sDS_ID_NhanVien, m_sDiaDiem, m_sMoTa, m_sTieuDe;
			private SqlInt16		m_siID_ThoiGian;
		#endregion


		public clsCongViec()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ma_CongViec", SqlDbType.NVarChar, 13, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMa_CongViec));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@DS_ID_NhanVien", SqlDbType.VarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDS_ID_NhanVien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_MucDoUuTien", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_MucDoUuTien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@TieuDe", SqlDbType.NVarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTieuDe));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@MoTa", SqlDbType.NVarChar, 1000, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMoTa));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@DiaDiem", SqlDbType.NVarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDiaDiem));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_YeuCau", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_YeuCau));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_DenHan", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_DenHan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ThoiGian_DuKien", SqlDbType.Decimal, 5, ParameterDirection.Input, false, 5, 2, "", DataRowVersion.Proposed, m_dcThoiGian_DuKien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_ThoiGian", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 5, 0, "", DataRowVersion.Proposed, m_siID_ThoiGian));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_BatDau", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_BatDau));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_HoanThanh", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_HoanThanh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@PhanTramHoanThanh", SqlDbType.Decimal, 5, ParameterDirection.Input, false, 5, 2, "", DataRowVersion.Proposed, m_dcPhanTramHoanThanh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@SoLuong_KeHoach", SqlDbType.Decimal, 5, ParameterDirection.Input, false, 7, 2, "", DataRowVersion.Proposed, m_dcSoLuong_KeHoach));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_TrangThai", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_TrangThai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_LoaiCV", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_LoaiCV));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_CongViec_Goc", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec_Goc));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_Lap", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_Lap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_NguoiLap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NguoiLap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_SuaCuoi", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_SuaCuoi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_NguoiSuaCuoi", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NguoiSuaCuoi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@TonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_NguoiYeuCau", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NguoiYeuCau));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@LapLai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bLapLai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@LoaiThongBao", SqlDbType.NVarChar, 5, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sLoaiThongBao));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@HienThiTrenLich", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bHienThiTrenLich));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_CongViec", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec));

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
				m_iID_CongViec = (SqlInt32)scmCmdToExecute.Parameters["@ID_CongViec"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object

                Garco10.DataAccess.QLCV.Global.GlobalVariables.ErrorLogging(ex);
				throw new Exception("clsCongViec::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_CongViec", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ma_CongViec", SqlDbType.NVarChar, 13, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMa_CongViec));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@DS_ID_NhanVien", SqlDbType.VarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDS_ID_NhanVien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_MucDoUuTien", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_MucDoUuTien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@TieuDe", SqlDbType.NVarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTieuDe));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@MoTa", SqlDbType.NVarChar, 1000, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMoTa));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@DiaDiem", SqlDbType.NVarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDiaDiem));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_YeuCau", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_YeuCau));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_DenHan", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_DenHan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ThoiGian_DuKien", SqlDbType.Decimal, 5, ParameterDirection.Input, false, 5, 2, "", DataRowVersion.Proposed, m_dcThoiGian_DuKien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_ThoiGian", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 5, 0, "", DataRowVersion.Proposed, m_siID_ThoiGian));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_BatDau", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_BatDau));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_HoanThanh", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_HoanThanh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@PhanTramHoanThanh", SqlDbType.Decimal, 5, ParameterDirection.Input, false, 5, 2, "", DataRowVersion.Proposed, m_dcPhanTramHoanThanh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@SoLuong_KeHoach", SqlDbType.Decimal, 5, ParameterDirection.Input, false, 7, 2, "", DataRowVersion.Proposed, m_dcSoLuong_KeHoach));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_TrangThai", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_TrangThai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_LoaiCV", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_LoaiCV));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_CongViec_Goc", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec_Goc));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_Lap", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_Lap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_NguoiLap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NguoiLap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_SuaCuoi", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_SuaCuoi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_NguoiSuaCuoi", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NguoiSuaCuoi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@TonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_NguoiYeuCau", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NguoiYeuCau));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@LapLai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bLapLai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@LoaiThongBao", SqlDbType.NVarChar, 5, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sLoaiThongBao));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@HienThiTrenLich", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bHienThiTrenLich));

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
				throw new Exception("clsCongViec::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_CongViec", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec));

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
				throw new Exception("clsCongViec::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("CongViec");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_CongViec", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec));

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
					m_iID_CongViec = (Int32)dtToReturn.Rows[0]["ID_CongViec"];
					m_sMa_CongViec = dtToReturn.Rows[0]["Ma_CongViec"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Ma_CongViec"];
					m_sDS_ID_NhanVien = dtToReturn.Rows[0]["DS_ID_NhanVien"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["DS_ID_NhanVien"];
					m_iID_MucDoUuTien = dtToReturn.Rows[0]["ID_MucDoUuTien"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ID_MucDoUuTien"];
					m_sTieuDe = dtToReturn.Rows[0]["TieuDe"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["TieuDe"];
					m_sMoTa = dtToReturn.Rows[0]["MoTa"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["MoTa"];
					m_sDiaDiem = dtToReturn.Rows[0]["DiaDiem"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["DiaDiem"];
					m_daNgay_YeuCau = dtToReturn.Rows[0]["Ngay_YeuCau"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Ngay_YeuCau"];
					m_daNgay_DenHan = dtToReturn.Rows[0]["Ngay_DenHan"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Ngay_DenHan"];
					m_dcThoiGian_DuKien = dtToReturn.Rows[0]["ThoiGian_DuKien"] == System.DBNull.Value ? SqlDecimal.Null : (Decimal)dtToReturn.Rows[0]["ThoiGian_DuKien"];
					m_siID_ThoiGian = dtToReturn.Rows[0]["ID_ThoiGian"] == System.DBNull.Value ? SqlInt16.Null : (Int16)dtToReturn.Rows[0]["ID_ThoiGian"];
					m_daNgay_BatDau = dtToReturn.Rows[0]["Ngay_BatDau"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Ngay_BatDau"];
					m_daNgay_HoanThanh = dtToReturn.Rows[0]["Ngay_HoanThanh"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Ngay_HoanThanh"];
					m_dcPhanTramHoanThanh = dtToReturn.Rows[0]["PhanTramHoanThanh"] == System.DBNull.Value ? SqlDecimal.Null : (Decimal)dtToReturn.Rows[0]["PhanTramHoanThanh"];
					m_dcSoLuong_KeHoach = dtToReturn.Rows[0]["SoLuong_KeHoach"] == System.DBNull.Value ? SqlDecimal.Null : (Decimal)dtToReturn.Rows[0]["SoLuong_KeHoach"];
					m_iID_TrangThai = dtToReturn.Rows[0]["ID_TrangThai"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ID_TrangThai"];
					m_iID_LoaiCV = dtToReturn.Rows[0]["ID_LoaiCV"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ID_LoaiCV"];
					m_iID_CongViec_Goc = dtToReturn.Rows[0]["ID_CongViec_Goc"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ID_CongViec_Goc"];
					m_daNgay_Lap = dtToReturn.Rows[0]["Ngay_Lap"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Ngay_Lap"];
					m_iID_NguoiLap = dtToReturn.Rows[0]["ID_NguoiLap"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ID_NguoiLap"];
					m_daNgay_SuaCuoi = dtToReturn.Rows[0]["Ngay_SuaCuoi"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Ngay_SuaCuoi"];
					m_iID_NguoiSuaCuoi = dtToReturn.Rows[0]["ID_NguoiSuaCuoi"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ID_NguoiSuaCuoi"];
					m_bTonTai = (bool)dtToReturn.Rows[0]["TonTai"];
					m_iID_NguoiYeuCau = dtToReturn.Rows[0]["ID_NguoiYeuCau"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ID_NguoiYeuCau"];
					m_bLapLai = dtToReturn.Rows[0]["LapLai"] == System.DBNull.Value ? SqlBoolean.Null : (bool)dtToReturn.Rows[0]["LapLai"];
					m_sLoaiThongBao = dtToReturn.Rows[0]["LoaiThongBao"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["LoaiThongBao"];
					m_bHienThiTrenLich = dtToReturn.Rows[0]["HienThiTrenLich"] == System.DBNull.Value ? SqlBoolean.Null : (bool)dtToReturn.Rows[0]["HienThiTrenLich"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
                Garco10.DataAccess.QLCV.Global.GlobalVariables.ErrorLogging(ex);
				throw new Exception("clsCongViec::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("CongViec");
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
				throw new Exception("clsCongViec::SelectAll::Error occured.", ex);
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
		public SqlInt32 ID_CongViec
		{
			get
			{
				return m_iID_CongViec;
			}
			set
			{
				SqlInt32 iID_CongViecTmp = (SqlInt32)value;
				if(iID_CongViecTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_CongViec", "iD_CongViec can't be NULL");
				}
				m_iID_CongViec = value;
			}
		}


		public SqlString Ma_CongViec
		{
			get
			{
				return m_sMa_CongViec;
			}
			set
			{
				m_sMa_CongViec = value;
			}
		}


		public SqlString DS_ID_NhanVien
		{
			get
			{
				return m_sDS_ID_NhanVien;
			}
			set
			{
				m_sDS_ID_NhanVien = value;
			}
		}


		public SqlInt32 ID_MucDoUuTien
		{
			get
			{
				return m_iID_MucDoUuTien;
			}
			set
			{
				m_iID_MucDoUuTien = value;
			}
		}


		public SqlString TieuDe
		{
			get
			{
				return m_sTieuDe;
			}
			set
			{
				m_sTieuDe = value;
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
				m_sMoTa = value;
			}
		}


		public SqlString DiaDiem
		{
			get
			{
				return m_sDiaDiem;
			}
			set
			{
				m_sDiaDiem = value;
			}
		}


		public SqlDateTime Ngay_YeuCau
		{
			get
			{
				return m_daNgay_YeuCau;
			}
			set
			{
				m_daNgay_YeuCau = value;
			}
		}


		public SqlDateTime Ngay_DenHan
		{
			get
			{
				return m_daNgay_DenHan;
			}
			set
			{
				m_daNgay_DenHan = value;
			}
		}


		public SqlDecimal ThoiGian_DuKien
		{
			get
			{
				return m_dcThoiGian_DuKien;
			}
			set
			{
				m_dcThoiGian_DuKien = value;
			}
		}


		public SqlInt16 ID_ThoiGian
		{
			get
			{
				return m_siID_ThoiGian;
			}
			set
			{
				m_siID_ThoiGian = value;
			}
		}


		public SqlDateTime Ngay_BatDau
		{
			get
			{
				return m_daNgay_BatDau;
			}
			set
			{
				m_daNgay_BatDau = value;
			}
		}


		public SqlDateTime Ngay_HoanThanh
		{
			get
			{
				return m_daNgay_HoanThanh;
			}
			set
			{
				m_daNgay_HoanThanh = value;
			}
		}


		public SqlDecimal PhanTramHoanThanh
		{
			get
			{
				return m_dcPhanTramHoanThanh;
			}
			set
			{
				m_dcPhanTramHoanThanh = value;
			}
		}


		public SqlDecimal SoLuong_KeHoach
		{
			get
			{
				return m_dcSoLuong_KeHoach;
			}
			set
			{
				m_dcSoLuong_KeHoach = value;
			}
		}


		public SqlInt32 ID_TrangThai
		{
			get
			{
				return m_iID_TrangThai;
			}
			set
			{
				m_iID_TrangThai = value;
			}
		}


		public SqlInt32 ID_LoaiCV
		{
			get
			{
				return m_iID_LoaiCV;
			}
			set
			{
				m_iID_LoaiCV = value;
			}
		}


		public SqlInt32 ID_CongViec_Goc
		{
			get
			{
				return m_iID_CongViec_Goc;
			}
			set
			{
				m_iID_CongViec_Goc = value;
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
				m_iID_NguoiLap = value;
			}
		}


		public SqlDateTime Ngay_SuaCuoi
		{
			get
			{
				return m_daNgay_SuaCuoi;
			}
			set
			{
				m_daNgay_SuaCuoi = value;
			}
		}


		public SqlInt32 ID_NguoiSuaCuoi
		{
			get
			{
				return m_iID_NguoiSuaCuoi;
			}
			set
			{
				m_iID_NguoiSuaCuoi = value;
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


		public SqlInt32 ID_NguoiYeuCau
		{
			get
			{
				return m_iID_NguoiYeuCau;
			}
			set
			{
				m_iID_NguoiYeuCau = value;
			}
		}


		public SqlBoolean LapLai
		{
			get
			{
				return m_bLapLai;
			}
			set
			{
				m_bLapLai = value;
			}
		}


		public SqlString LoaiThongBao
		{
			get
			{
				return m_sLoaiThongBao;
			}
			set
			{
				m_sLoaiThongBao = value;
			}
		}


		public SqlBoolean HienThiTrenLich
		{
			get
			{
				return m_bHienThiTrenLich;
			}
			set
			{
				m_bHienThiTrenLich = value;
			}
		}
		#endregion
	}
}
