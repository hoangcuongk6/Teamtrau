using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
	public partial class clsCongViec_Comment : clsDBInteractionQLCV
	{
	    public DataTable Select_W_ID_CongViec(int ID_CongViec)
	    {
	        SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_CongViec_Comment_Select_W_ID_CongViec]";
	        scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("CongViec_Comment");
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
                throw new Exception("clsCongViec_Comment::Select_W_ID_CongViec::Error occured.", ex);
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

        public  DataTable SelectAll_ChuaDoc()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_CongViec_Comment_SelectAll_ChuaDoc]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("CongViec_CommentChua doc");
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
                throw new Exception("clsCongViec_Comment_ChuaDoc::SelectAll::Error occured.", ex);
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
