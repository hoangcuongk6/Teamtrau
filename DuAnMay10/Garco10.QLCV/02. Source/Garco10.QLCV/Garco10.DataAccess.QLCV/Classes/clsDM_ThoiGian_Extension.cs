using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Garco10.ConnectionProviders;

namespace M10_QLCV
{
	public partial class clsDM_ThoiGian : clsDBInteractionQLCV
	{
		


		

		
		public  DataTable SelectOne_TenThoiGian(string tenthoigian)
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_DM_ThoiGian_SelectOne_TenThoiGian]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("DM_ThoiGian");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iTen_ThoiGian", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, tenthoigian));

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
					m_iID_ThoiGian = (Int32)dtToReturn.Rows[0]["ID_ThoiGian"];
					m_sTen_ThoiGian = (string)dtToReturn.Rows[0]["Ten_ThoiGian"];
					m_bTonTai = (bool)dtToReturn.Rows[0]["TonTai"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDM_ThoiGian::SelectOne::Error occured.", ex);
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


		


		
	}
}
