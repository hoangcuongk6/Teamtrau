using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
	public partial class clsThongBao : clsDBInteractionQLCV
	{

        public DataTable Select_ID_NhanSu(string ID_NhanSu)
	    {
	        SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_ThongBao_Select_ID_NhanSu]";
	        scmCmdToExecute.CommandType = CommandType.StoredProcedure;
	        DataTable dtToReturn = new DataTable("ThongBao");
	        SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

	        // Use base class' connection object
	        scmCmdToExecute.Connection = m_scoMainConnection;

	        try
	        {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_NhanSu", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ID_NhanSu));
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
	            throw new Exception("clsThongBao::Select_ID_NhanSu::Error occured.", ex);
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

	    public bool UpdateTrangThai(int ID_ThongBao, byte TrangThai)
	    {
	        SqlCommand scmCmdToExecute = new SqlCommand();
	        scmCmdToExecute.CommandText = "dbo.[pr_ThongBao_ChuyenTrangThai]";
	        scmCmdToExecute.CommandType = CommandType.StoredProcedure;

	        // Use base class' connection object
	        scmCmdToExecute.Connection = m_scoMainConnection;

	        try
	        {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_ThongBao", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ID_ThongBao));
	            scmCmdToExecute.Parameters.Add(new SqlParameter("@TrangThai", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, TrangThai));
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
	            throw new Exception("clsThongBao::UpdateTrangThai::Error occured.", ex);
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

	    public DataTable SelectAll_By_ID_NhanSu(string ID_NhanSu)
	    {
	        SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_ThongBao_ChuaDoc_Select_ID_NhanSu]";
	        scmCmdToExecute.CommandType = CommandType.StoredProcedure;
	        DataTable dtToReturn = new DataTable("ThongBao");
	        SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

	        // Use base class' connection object
	        scmCmdToExecute.Connection = m_scoMainConnection;

	        try
	        {
	            scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_NhanSu", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ID_NhanSu));
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
	            throw new Exception("clsThongBao::Select_ID_NhanSu::Error occured.", ex);
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
