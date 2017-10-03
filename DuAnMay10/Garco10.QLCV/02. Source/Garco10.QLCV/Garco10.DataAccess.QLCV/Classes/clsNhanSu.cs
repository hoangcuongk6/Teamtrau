using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
    public partial class clsNhanSu : clsDBInteractionQLCV
    {
        public clsNhanSu()
        {
            
        }

        public int GetID_NhanSu(int id_TaiKhoanDangNhap)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "[dbo].[GetID_NhanSu]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("ID_NhanSu");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_TaiKhoanDangNhap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, id_TaiKhoanDangNhap));

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
                int id_NhanSu = 0;
                int.TryParse(dtToReturn.Rows[0][0].ToString(), out id_NhanSu);
                return id_NhanSu;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("clsNhanSu::GetID_NhanSu::Error occured.", ex);
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

        public DataTable GetNhanSu(int ID_DonVi, int ID_BoPhan)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_GetNhanSu]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("GetNhanSu");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_DonVi", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 5, 0, "", DataRowVersion.Proposed, ID_DonVi));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_BoPhan", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 5, 0, "", DataRowVersion.Proposed, ID_BoPhan));
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
                throw new Exception("clsGetNhanSu::GetNhanSu::Error occured.", ex);
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

        public DataTable SelectAllNVCapDuoi(int ID_NhanSu)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_DM_NhanVien_SelectAllNVCapDuoi]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("DM_NhanVien");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_NhanSu", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ID_NhanSu));
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
                throw new Exception("clsDM_NhanVien::SelectAllNVCapDuoi::Error occured.", ex);
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

        public DataTable SelectW_ID_NguoiQuanLy(int ID_NguoiQuanLy, int ID_DonVi)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_SelectNV_With_ID_NguoiQuanLy]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("DM_NhanVien");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_NguoiQuanLy", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ID_NguoiQuanLy));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_DonVi", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ID_DonVi));
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
                throw new Exception("clsDM_NhanVien::SelectW_ID_NguoiQuanLy::Error occured.", ex);
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
