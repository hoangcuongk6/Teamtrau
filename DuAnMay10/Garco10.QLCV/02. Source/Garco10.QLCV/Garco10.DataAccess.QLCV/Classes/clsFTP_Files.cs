using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
	public partial class clsFTP_Files : clsDBInteractionQLCV
	{
		#region Class Member Declarations
			private SqlBoolean		m_bTonTai;
			private SqlDateTime		m_daNgay_Lap, m_daNgay_SuaCuoi;
			private SqlInt32		m_iID_Files;
			private SqlString		m_sFileIdentity, m_sGhiChu, m_sFilePath, m_sFileName;
			private SqlInt16		m_siTaiKhoan_Lap, m_siTaiKhoan_SuaCuoi, m_siID_FileType;
		#endregion


		public clsFTP_Files()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_FTP_Files_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@siID_FileType", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 5, 0, "", DataRowVersion.Proposed, m_siID_FileType));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFileIdentity", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFileIdentity));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFileName", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFileName));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFilePath", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFilePath));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@siTaiKhoan_Lap", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 5, 0, "", DataRowVersion.Proposed, m_siTaiKhoan_Lap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daNgay_Lap", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_Lap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@siTaiKhoan_SuaCuoi", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 5, 0, "", DataRowVersion.Proposed, m_siTaiKhoan_SuaCuoi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daNgay_SuaCuoi", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_SuaCuoi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sGhiChu", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sGhiChu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_Files", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_Files));

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
				m_iID_Files = (SqlInt32)scmCmdToExecute.Parameters["@iID_Files"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsFTP_Files::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_FTP_Files_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_Files", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_Files));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@siID_FileType", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 5, 0, "", DataRowVersion.Proposed, m_siID_FileType));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFileIdentity", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFileIdentity));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFileName", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFileName));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFilePath", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFilePath));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@siTaiKhoan_Lap", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 5, 0, "", DataRowVersion.Proposed, m_siTaiKhoan_Lap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daNgay_Lap", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_Lap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@siTaiKhoan_SuaCuoi", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 5, 0, "", DataRowVersion.Proposed, m_siTaiKhoan_SuaCuoi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daNgay_SuaCuoi", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_SuaCuoi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sGhiChu", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sGhiChu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));

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
				throw new Exception("clsFTP_Files::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_FTP_Files_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_Files", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_Files));

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
				throw new Exception("clsFTP_Files::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_FTP_Files_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("FTP_Files");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_Files", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_Files));

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
					m_iID_Files = (Int32)dtToReturn.Rows[0]["ID_Files"];
					m_siID_FileType = (Int16)dtToReturn.Rows[0]["ID_FileType"];
					m_sFileIdentity = (string)dtToReturn.Rows[0]["FileIdentity"];
					m_sFileName = (string)dtToReturn.Rows[0]["FileName"];
					m_sFilePath = (string)dtToReturn.Rows[0]["FilePath"];
					m_siTaiKhoan_Lap = (Int16)dtToReturn.Rows[0]["TaiKhoan_Lap"];
					m_daNgay_Lap = (DateTime)dtToReturn.Rows[0]["Ngay_Lap"];
					m_siTaiKhoan_SuaCuoi = (Int16)dtToReturn.Rows[0]["TaiKhoan_SuaCuoi"];
					m_daNgay_SuaCuoi = (DateTime)dtToReturn.Rows[0]["Ngay_SuaCuoi"];
					m_sGhiChu = dtToReturn.Rows[0]["GhiChu"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["GhiChu"];
					m_bTonTai = (bool)dtToReturn.Rows[0]["TonTai"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsFTP_Files::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_FTP_Files_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("FTP_Files");
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
				throw new Exception("clsFTP_Files::SelectAll::Error occured.", ex);
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
		public SqlInt32 ID_Files
		{
			get
			{
				return m_iID_Files;
			}
			set
			{
				SqlInt32 iID_FilesTmp = (SqlInt32)value;
				if(iID_FilesTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_Files", "iD_Files can't be NULL");
				}
				m_iID_Files = value;
			}
		}


		public SqlInt16 ID_FileType
		{
			get
			{
				return m_siID_FileType;
			}
			set
			{
				SqlInt16 siID_FileTypeTmp = (SqlInt16)value;
				if(siID_FileTypeTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_FileType", "iD_FileType can't be NULL");
				}
				m_siID_FileType = value;
			}
		}


		public SqlString FileIdentity
		{
			get
			{
				return m_sFileIdentity;
			}
			set
			{
				SqlString sFileIdentityTmp = (SqlString)value;
				if(sFileIdentityTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fileIdentity", "fileIdentity can't be NULL");
				}
				m_sFileIdentity = value;
			}
		}


		public SqlString FileName
		{
			get
			{
				return m_sFileName;
			}
			set
			{
				SqlString sFileNameTmp = (SqlString)value;
				if(sFileNameTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fileName", "fileName can't be NULL");
				}
				m_sFileName = value;
			}
		}


		public SqlString FilePath
		{
			get
			{
				return m_sFilePath;
			}
			set
			{
				SqlString sFilePathTmp = (SqlString)value;
				if(sFilePathTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("filePath", "filePath can't be NULL");
				}
				m_sFilePath = value;
			}
		}


		public SqlInt16 TaiKhoan_Lap
		{
			get
			{
				return m_siTaiKhoan_Lap;
			}
			set
			{
				SqlInt16 siTaiKhoan_LapTmp = (SqlInt16)value;
				if(siTaiKhoan_LapTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("taiKhoan_Lap", "taiKhoan_Lap can't be NULL");
				}
				m_siTaiKhoan_Lap = value;
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


		public SqlInt16 TaiKhoan_SuaCuoi
		{
			get
			{
				return m_siTaiKhoan_SuaCuoi;
			}
			set
			{
				SqlInt16 siTaiKhoan_SuaCuoiTmp = (SqlInt16)value;
				if(siTaiKhoan_SuaCuoiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("taiKhoan_SuaCuoi", "taiKhoan_SuaCuoi can't be NULL");
				}
				m_siTaiKhoan_SuaCuoi = value;
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
				SqlDateTime daNgay_SuaCuoiTmp = (SqlDateTime)value;
				if(daNgay_SuaCuoiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ngay_SuaCuoi", "ngay_SuaCuoi can't be NULL");
				}
				m_daNgay_SuaCuoi = value;
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
				m_sGhiChu = value;
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
		#endregion
	}
}
