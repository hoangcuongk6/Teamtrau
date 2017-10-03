using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
	public partial class clsCongViec_ThongSo : clsDBInteractionQLCV
	{
		#region Class Member Declarations
			private SqlInt32		m_iID_ThoiGian, m_iID_CongViec, m_iID_CongViec_ThongSo;
			private SqlString		m_sDS_Ngay, m_sDS_Thu, m_sDS_Thang;
			private SqlDateTime		m_daGio_BatDau, m_daGio_KetThuc;
		#endregion


		public clsCongViec_ThongSo()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_ThongSo_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_CongViec", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sDS_Thu", SqlDbType.NVarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDS_Thu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daGio_BatDau", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daGio_BatDau));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daGio_KetThuc", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daGio_KetThuc));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ThoiGian", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ThoiGian));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sDS_Ngay", SqlDbType.NVarChar, 60, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDS_Ngay));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sDS_Thang", SqlDbType.NVarChar, 40, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDS_Thang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_CongViec_ThongSo", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec_ThongSo));

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
				m_iID_CongViec_ThongSo = (SqlInt32)scmCmdToExecute.Parameters["@iID_CongViec_ThongSo"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
                Garco10.DataAccess.QLCV.Global.GlobalVariables.ErrorLogging(ex);
				throw new Exception("clsCongViec_ThongSo::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_ThongSo_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_CongViec_ThongSo", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec_ThongSo));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_CongViec", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sDS_Thu", SqlDbType.NVarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDS_Thu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daGio_BatDau", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daGio_BatDau));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daGio_KetThuc", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daGio_KetThuc));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ThoiGian", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ThoiGian));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sDS_Ngay", SqlDbType.NVarChar, 60, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDS_Ngay));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sDS_Thang", SqlDbType.NVarChar, 40, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDS_Thang));

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
				throw new Exception("clsCongViec_ThongSo::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_ThongSo_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_CongViec_ThongSo", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec_ThongSo));

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
				throw new Exception("clsCongViec_ThongSo::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_ThongSo_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("CongViec_ThongSo");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_CongViec_ThongSo", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec_ThongSo));

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
					m_iID_CongViec_ThongSo = (Int32)dtToReturn.Rows[0]["ID_CongViec_ThongSo"];
					m_iID_CongViec = (Int32)dtToReturn.Rows[0]["ID_CongViec"];
					m_sDS_Thu = dtToReturn.Rows[0]["DS_Thu"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["DS_Thu"];
					m_daGio_BatDau = dtToReturn.Rows[0]["Gio_BatDau"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Gio_BatDau"];
					m_daGio_KetThuc = dtToReturn.Rows[0]["Gio_KetThuc"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Gio_KetThuc"];
					m_iID_ThoiGian = dtToReturn.Rows[0]["ID_ThoiGian"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ID_ThoiGian"];
					m_sDS_Ngay = dtToReturn.Rows[0]["DS_Ngay"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["DS_Ngay"];
					m_sDS_Thang = dtToReturn.Rows[0]["DS_Thang"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["DS_Thang"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
                Garco10.DataAccess.QLCV.Global.GlobalVariables.ErrorLogging(ex);
				throw new Exception("clsCongViec_ThongSo::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_ThongSo_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("CongViec_ThongSo");
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
				throw new Exception("clsCongViec_ThongSo::SelectAll::Error occured.", ex);
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
		public SqlInt32 ID_CongViec_ThongSo
		{
			get
			{
				return m_iID_CongViec_ThongSo;
			}
			set
			{
				SqlInt32 iID_CongViec_ThongSoTmp = (SqlInt32)value;
				if(iID_CongViec_ThongSoTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_CongViec_ThongSo", "iD_CongViec_ThongSo can't be NULL");
				}
				m_iID_CongViec_ThongSo = value;
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
				SqlInt32 iID_CongViecTmp = (SqlInt32)value;
				if(iID_CongViecTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_CongViec", "iD_CongViec can't be NULL");
				}
				m_iID_CongViec = value;
			}
		}


		public SqlString DS_Thu
		{
			get
			{
				return m_sDS_Thu;
			}
			set
			{
				m_sDS_Thu = value;
			}
		}


		public SqlDateTime Gio_BatDau
		{
			get
			{
				return m_daGio_BatDau;
			}
			set
			{
				m_daGio_BatDau = value;
			}
		}


		public SqlDateTime Gio_KetThuc
		{
			get
			{
				return m_daGio_KetThuc;
			}
			set
			{
				m_daGio_KetThuc = value;
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


		public SqlString DS_Ngay
		{
			get
			{
				return m_sDS_Ngay;
			}
			set
			{
				m_sDS_Ngay = value;
			}
		}


		public SqlString DS_Thang
		{
			get
			{
				return m_sDS_Thang;
			}
			set
			{
				m_sDS_Thang = value;
			}
		}
		#endregion
	}
}
