using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
	public partial class clsFTP_Files : clsDBInteractionQLCV
	{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID_FileType"></param>
        /// <param name="ID_FileType_Group"></param>
        /// <param name="FileIdentity"></param>
        /// <returns></returns>
        public DataTable SelectDanhSachFiles(short ID_FileType_Group, short ID_FileType, string FileIdentity)
	    {
	        SqlCommand scmCmdToExecute = new SqlCommand();
	        scmCmdToExecute.CommandText = "dbo.[pr_FTP_Files_SelectDanhSachFiles]";
	        scmCmdToExecute.CommandType = CommandType.StoredProcedure;
	        DataTable dtToReturn = new DataTable("FTP_Files");
	        SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

	        // Use base class' connection object
	        scmCmdToExecute.Connection = m_scoMainConnection;

	        try
	        {
	            scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_FileType", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ID_FileType));
	            scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_FileType_Group", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ID_FileType_Group));
	            scmCmdToExecute.Parameters.Add(new SqlParameter("@FileIdentity", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, FileIdentity));
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
	            throw new Exception("clsFTP_Files::SelectDanhSachFiles::Error occured.", ex);
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

	    public DataTable Select_Files_JustUpload()
	    {
	        SqlCommand scmCmdToExecute = new SqlCommand();
	        scmCmdToExecute.CommandText = "dbo.[pr_FTP_Files_JustUpload]";
	        scmCmdToExecute.CommandType = CommandType.StoredProcedure;
	        DataTable dtToReturn = new DataTable("FTP_Files");
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
	            throw new Exception("clsFTP_FIles::Select_Files_JustUpload::Error occured.", ex);
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

        public DataTable SelectDanhSachFiles_ID_CongViec(int ID_CongViec)
	    {
	        SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_FTP_Files_SelectDanhSachFiles_ID_CongViec]";
	        scmCmdToExecute.CommandType = CommandType.StoredProcedure;
	        DataTable dtToReturn = new DataTable("FTP_Files");
	        SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

	        // Use base class' connection object
	        scmCmdToExecute.Connection = m_scoMainConnection;

	        try
	        {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_CongViec", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ID_CongViec));
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
	            throw new Exception("clsFTP_Files::SelectDanhSachFiles::Error occured.", ex);
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

	    public DataTable SelectDanhSachFiles_QLCV(short ID_FileType_Group, short ID_FileType, string FileIdentity)
	    {
	        SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_FTP_Files_SelectDanhSachFiles_QLCV]";
	        scmCmdToExecute.CommandType = CommandType.StoredProcedure;
	        DataTable dtToReturn = new DataTable("FTP_Files");
	        SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

	        // Use base class' connection object
	        scmCmdToExecute.Connection = m_scoMainConnection;

	        try
	        {
	            scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_FileType", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ID_FileType));
	            scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_FileType_Group", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ID_FileType_Group));
	            scmCmdToExecute.Parameters.Add(new SqlParameter("@FileIdentity", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, FileIdentity));
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
                throw new Exception("clsFTP_Files::SelectDanhSachFiles_QLCV::Error occured.", ex);
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
