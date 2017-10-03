using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
	public class clsDM_LoaiThongBao : clsDBInteractionQLCV
	{
		#region Class Member Declarations
			private SqlInt32		m_iID_LoaiThongBao;
			private SqlString		m_sTen_LoaiThongBao;
		#endregion


		public clsDM_LoaiThongBao()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_DM_LoaiThongBao_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTen_LoaiThongBao", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTen_LoaiThongBao));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_LoaiThongBao", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_LoaiThongBao));

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
				m_iID_LoaiThongBao = (SqlInt32)scmCmdToExecute.Parameters["@iID_LoaiThongBao"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDM_LoaiThongBao::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_DM_LoaiThongBao_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_LoaiThongBao", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_LoaiThongBao));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTen_LoaiThongBao", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTen_LoaiThongBao));

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
				throw new Exception("clsDM_LoaiThongBao::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_DM_LoaiThongBao_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_LoaiThongBao", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_LoaiThongBao));

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
				throw new Exception("clsDM_LoaiThongBao::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_DM_LoaiThongBao_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("DM_LoaiThongBao");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_LoaiThongBao", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_LoaiThongBao));

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
					m_iID_LoaiThongBao = (Int32)dtToReturn.Rows[0]["ID_LoaiThongBao"];
					m_sTen_LoaiThongBao = dtToReturn.Rows[0]["Ten_LoaiThongBao"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Ten_LoaiThongBao"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDM_LoaiThongBao::SelectOne::Error occured.", ex);
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

        public DataTable SelectOne_TenThongBao(string tenthongbao)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_DM_LoaiThongBao_SelectOne_TenThongBao]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("ThongBao");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iTen_LoaiThongBao", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, tenthongbao));

                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Open connection.
                    m_scoMainConnection.Open();
                }
                else
                {
                    if (m_cpMainConnectionProvider.IsTransactionPending)
                    {
                        scmCmdToExecute.Transaction = m_cpMainConnectionProvider.CurrentTransaction;
                    }
                }

                // Execute query.
                sdaAdapter.Fill(dtToReturn);
                if (dtToReturn.Rows.Count > 0)
                {
                    m_iID_LoaiThongBao = (Int32)dtToReturn.Rows[0]["ID_LoaiThongBao"];
                    m_sTen_LoaiThongBao = dtToReturn.Rows[0]["Ten_LoaiThongBao"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Ten_LoaiThongBao"];

                }
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("clsThongBao::SelectOne::Error occured.", ex);
            }
            finally
            {
                if (m_bMainConnectionIsCreatedLocal)
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
			scmCmdToExecute.CommandText = "dbo.[pr_DM_LoaiThongBao_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("DM_LoaiThongBao");
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
				throw new Exception("clsDM_LoaiThongBao::SelectAll::Error occured.", ex);
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
		public SqlInt32 ID_LoaiThongBao
		{
			get
			{
				return m_iID_LoaiThongBao;
			}
			set
			{
				SqlInt32 iID_LoaiThongBaoTmp = (SqlInt32)value;
				if(iID_LoaiThongBaoTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_LoaiThongBao", "iD_LoaiThongBao can't be NULL");
				}
				m_iID_LoaiThongBao = value;
			}
		}


		public SqlString Ten_LoaiThongBao
		{
			get
			{
				return m_sTen_LoaiThongBao;
			}
			set
			{
				m_sTen_LoaiThongBao = value;
			}
		}
		#endregion
	}
}
