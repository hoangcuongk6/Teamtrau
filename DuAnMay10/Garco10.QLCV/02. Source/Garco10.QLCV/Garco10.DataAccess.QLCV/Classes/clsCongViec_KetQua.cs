using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
	public partial class clsCongViec_KetQua : clsDBInteractionQLCV
	{
		#region Class Member Declarations
			private SqlDateTime		m_daNgay_BatDau, m_daNgay_Lap, m_daNgay_HoanThanh;
			private SqlDecimal		m_dcGiaTri;
			private SqlInt32		m_iID_CongViec_KetQua, m_iID_NguoiLap, m_iID_CongViec, m_iID_DonVi_KetQua;
			private SqlString		m_sNoiDung;
		#endregion


		public clsCongViec_KetQua()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_KetQua_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_CongViec", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@NoiDung", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNoiDung));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@GiaTri", SqlDbType.Decimal, 5, ParameterDirection.Input, false, 5, 2, "", DataRowVersion.Proposed, m_dcGiaTri));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_DonVi_KetQua", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_DonVi_KetQua));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_NguoiLap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NguoiLap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_Lap", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_Lap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_BatDau", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_BatDau));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_HoanThanh", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_HoanThanh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_CongViec_KetQua", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec_KetQua));

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
				m_iID_CongViec_KetQua = (SqlInt32)scmCmdToExecute.Parameters["@ID_CongViec_KetQua"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsCongViec_KetQua::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_KetQua_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_CongViec_KetQua", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec_KetQua));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_CongViec", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@NoiDung", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNoiDung));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@GiaTri", SqlDbType.Decimal, 5, ParameterDirection.Input, false, 5, 2, "", DataRowVersion.Proposed, m_dcGiaTri));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_DonVi_KetQua", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_DonVi_KetQua));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_NguoiLap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NguoiLap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_Lap", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_Lap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_BatDau", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_BatDau));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_HoanThanh", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_HoanThanh));

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
				throw new Exception("clsCongViec_KetQua::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_KetQua_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_CongViec_KetQua", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec_KetQua));

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
				throw new Exception("clsCongViec_KetQua::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_KetQua_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("CongViec_KetQua");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_CongViec_KetQua", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec_KetQua));

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
					m_iID_CongViec_KetQua = (Int32)dtToReturn.Rows[0]["ID_CongViec_KetQua"];
					m_iID_CongViec = dtToReturn.Rows[0]["ID_CongViec"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ID_CongViec"];
					m_sNoiDung = dtToReturn.Rows[0]["NoiDung"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["NoiDung"];
					m_dcGiaTri = dtToReturn.Rows[0]["GiaTri"] == System.DBNull.Value ? SqlDecimal.Null : (Decimal)dtToReturn.Rows[0]["GiaTri"];
					m_iID_DonVi_KetQua = dtToReturn.Rows[0]["ID_DonVi_KetQua"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ID_DonVi_KetQua"];
					m_iID_NguoiLap = (Int32)dtToReturn.Rows[0]["ID_NguoiLap"];
					m_daNgay_Lap = (DateTime)dtToReturn.Rows[0]["Ngay_Lap"];
					m_daNgay_BatDau = dtToReturn.Rows[0]["Ngay_BatDau"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Ngay_BatDau"];
					m_daNgay_HoanThanh = dtToReturn.Rows[0]["Ngay_HoanThanh"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Ngay_HoanThanh"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsCongViec_KetQua::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_KetQua_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("CongViec_KetQua");
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
				throw new Exception("clsCongViec_KetQua::SelectAll::Error occured.", ex);
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
		public SqlInt32 ID_CongViec_KetQua
		{
			get
			{
				return m_iID_CongViec_KetQua;
			}
			set
			{
				SqlInt32 iID_CongViec_KetQuaTmp = (SqlInt32)value;
				if(iID_CongViec_KetQuaTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_CongViec_KetQua", "iD_CongViec_KetQua can't be NULL");
				}
				m_iID_CongViec_KetQua = value;
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


		public SqlString NoiDung
		{
			get
			{
				return m_sNoiDung;
			}
			set
			{
				m_sNoiDung = value;
			}
		}


		public SqlDecimal GiaTri
		{
			get
			{
				return m_dcGiaTri;
			}
			set
			{
				m_dcGiaTri = value;
			}
		}


		public SqlInt32 ID_DonVi_KetQua
		{
			get
			{
				return m_iID_DonVi_KetQua;
			}
			set
			{
				m_iID_DonVi_KetQua = value;
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
		#endregion
	}
}
