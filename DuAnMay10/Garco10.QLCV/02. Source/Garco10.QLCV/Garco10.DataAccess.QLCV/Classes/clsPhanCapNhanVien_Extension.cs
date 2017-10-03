using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
    public partial class clsPhanCapNhanVien : clsDBInteractionQLCV
    {
        public DataTable SelectAll_With_Ten(int iID_DonVi)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_PhanCapNhanVien_SelectAll_With_Ten]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("PhanCapNhanVien");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_DonVi", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, iID_DonVi));
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
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("clsPhanCapNhanVien::SelectAll_With_Ten::Error occured.", ex);
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

        public bool InsertOrUpdate()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_PhanCapNhanVien_InsertOrUpdate]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_NguoiQuanLy", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NguoiQuanLy));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_NhanVien", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NhanVien));

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
                scmCmdToExecute.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("clsPhanCapNhanVien::InsertOrUpdate::Error occured.", ex);
            }
            finally
            {
                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    m_scoMainConnection.Close();
                }
                scmCmdToExecute.Dispose();
            }
        }

    }
}
