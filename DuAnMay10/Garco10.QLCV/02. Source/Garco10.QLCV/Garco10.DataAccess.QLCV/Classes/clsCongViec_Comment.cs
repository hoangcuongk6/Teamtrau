using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
	public partial class clsCongViec_Comment : clsDBInteractionQLCV
	{
		#region Class Member Declarations
			private SqlBoolean		m_bTonTai, m_bDaDoc;
			private SqlDateTime		m_daNgay_Lap;
			private SqlInt32		m_iID_TaiKhoan, m_iID_CongViec, m_iID_Comment_Parent, m_iID_Comment;
			private SqlString		m_sNoiDung;
		#endregion


		public clsCongViec_Comment()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_Comment_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_CongViec", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_Comment_Parent", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_Comment_Parent));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@NoiDung", SqlDbType.NVarChar, 1000, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNoiDung));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_TaiKhoan", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_TaiKhoan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_Lap", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_Lap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@TonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@DaDoc", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bDaDoc));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_Comment", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_Comment));

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
				m_iID_Comment = (SqlInt32)scmCmdToExecute.Parameters["@ID_Comment"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
                Garco10.DataAccess.QLCV.Global.GlobalVariables.ErrorLogging(ex);
				throw new Exception("clsCongViec_Comment::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_Comment_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_Comment", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_Comment));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_CongViec", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongViec));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_Comment_Parent", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_Comment_Parent));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@NoiDung", SqlDbType.NVarChar, 1000, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNoiDung));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_TaiKhoan", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_TaiKhoan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_Lap", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_Lap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@TonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@DaDoc", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bDaDoc));

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
				throw new Exception("clsCongViec_Comment::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_Comment_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_Comment", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_Comment));

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
				throw new Exception("clsCongViec_Comment::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_Comment_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("CongViec_Comment");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_Comment", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_Comment));

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
					m_iID_Comment = (Int32)dtToReturn.Rows[0]["ID_Comment"];
					m_iID_CongViec = dtToReturn.Rows[0]["ID_CongViec"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ID_CongViec"];
					m_iID_Comment_Parent = dtToReturn.Rows[0]["ID_Comment_Parent"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ID_Comment_Parent"];
					m_sNoiDung = (string)dtToReturn.Rows[0]["NoiDung"];
					m_iID_TaiKhoan = dtToReturn.Rows[0]["ID_TaiKhoan"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ID_TaiKhoan"];
					m_daNgay_Lap = (DateTime)dtToReturn.Rows[0]["Ngay_Lap"];
					m_bTonTai = (bool)dtToReturn.Rows[0]["TonTai"];
					m_bDaDoc = dtToReturn.Rows[0]["DaDoc"] == System.DBNull.Value ? SqlBoolean.Null : (bool)dtToReturn.Rows[0]["DaDoc"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
                Garco10.DataAccess.QLCV.Global.GlobalVariables.ErrorLogging(ex);
				throw new Exception("clsCongViec_Comment::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_CongViec_Comment_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("CongViec_Comment");
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
				throw new Exception("clsCongViec_Comment::SelectAll::Error occured.", ex);
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
		public SqlInt32 ID_Comment
		{
			get
			{
				return m_iID_Comment;
			}
			set
			{
				SqlInt32 iID_CommentTmp = (SqlInt32)value;
				if(iID_CommentTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_Comment", "iD_Comment can't be NULL");
				}
				m_iID_Comment = value;
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


		public SqlInt32 ID_Comment_Parent
		{
			get
			{
				return m_iID_Comment_Parent;
			}
			set
			{
				m_iID_Comment_Parent = value;
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


		public SqlInt32 ID_TaiKhoan
		{
			get
			{
				return m_iID_TaiKhoan;
			}
			set
			{
				m_iID_TaiKhoan = value;
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


		public SqlBoolean DaDoc
		{
			get
			{
				return m_bDaDoc;
			}
			set
			{
				m_bDaDoc = value;
			}
		}
		#endregion
	}
}
