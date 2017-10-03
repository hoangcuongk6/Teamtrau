using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
	public partial class clsChucVu_PhanCap : clsDBInteractionQLCV
	{
        public DataTable SelectAll_NhanVienCapDuoi(int ID_NhanSu)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_DM_NhanVien_SelectAll_NhanVienCapDuoi]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("PhanCap_ChucVu");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_ChucVu", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ID_NhanSu));
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
                Garco10.DataAccess.QLCV.Global.GlobalVariables.ErrorLogging(ex);
                throw new Exception("clsChucVu_PhanCap::SelectAll_ChucVuCapDuoi::Error occured.", ex);
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

        public DataTable SelectAll_With_Ten()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_ChucVu_PhanCap_SelectAll_With_Ten]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("PhanCap_ChucVu");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {

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
                Garco10.DataAccess.QLCV.Global.GlobalVariables.ErrorLogging(ex);
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

	}
}
