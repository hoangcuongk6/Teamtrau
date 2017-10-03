using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
	public partial class clsCongViec_ThongSo : clsDBInteractionQLCV
	{

	    public DataTable Select_ID_CongViec(int ID_CongViec)
	    {
	        SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_CongViec_ThongSo_ID_CongViec]";
	        scmCmdToExecute.CommandType = CommandType.StoredProcedure;
	        DataTable dtToReturn = new DataTable("CongViec_ThongSo");
	        SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

	        // Use base class' connection object
	        scmCmdToExecute.Connection = m_scoMainConnection;

	        try
	        {
	            scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_CongViec", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ID_CongViec));
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
                throw new Exception("clsCongViec_ThongSo::Select_ID_CongViec::Error occured.", ex);
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

        public bool DeleteByID_CongViec(int iID_CongViec)
	    {
	        SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_CongViec_ThongSo_DeleteByID_CongViec]";
	        scmCmdToExecute.CommandType = CommandType.StoredProcedure;

	        // Use base class' connection object
	        scmCmdToExecute.Connection = m_scoMainConnection;

	        try
	        {
	            scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_CongViec", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, iID_CongViec));

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
                Garco10.DataAccess.QLCV.Global.GlobalVariables.ErrorLogging(ex);
                throw new Exception("clsCongViec_ThongSo::DeleteByID_CongViec::Error occured.", ex);
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
