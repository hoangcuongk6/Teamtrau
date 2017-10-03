using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
	public partial class clsNhom : clsDBInteractionQLCV
	{
	    public DataTable SelectAll_ParentNodes(int id_Nhom)
	    {
	        SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_Nhom_SelectAll_ParentNodes]";
	        scmCmdToExecute.CommandType = CommandType.StoredProcedure;
	        DataTable dtToReturn = new DataTable("DM_LoaiCV");
	        SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

	        // Use base class' connection object
	        scmCmdToExecute.Connection = m_scoMainConnection;

	        try
	        {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_Nhom", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, id_Nhom));

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
	            throw new Exception("clsDM_LoaiCV::SelectAll::Error occured.", ex);
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
