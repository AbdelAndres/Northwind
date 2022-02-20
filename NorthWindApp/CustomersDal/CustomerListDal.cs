using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Univalle.Fie.Sistemas.BaseDeDatos2.NorthWindApp.Common;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.NorthWindApp.CustomersDal
{
    public class CustomerListDal
    {
        #region Methods
        public static CustomerList GetByUsername(string username)
        {
            CustomerList userList = new CustomerList();
            SqlCommand commando = null;
            SqlDataReader reader = null;
            string QueryString = @"Select CustomerID,CompanyName
                                   FROM Customers
                                   WHERE CompanyName like @nombre";
            try
            {
                commando = OperationsSql.CreateBasicCommand(QueryString);
                commando.Parameters.AddWithValue("@nombre", string.Format("%{0}%", username));
                reader = OperationsSql.ExecuteDataReaderCommand(commando);
                while (reader.Read())
                {

                    userList.Add(new Customer()
                    {
                        CustomerID = reader.GetString(0),
                        CompanyName = reader.GetString(1)
                    });
                }
            }
            catch (SqlException ex)
            {
                Operations.WriteLogsRelease("UserListDal", "Get", string.Format("{0},{1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operations.WriteLogsRelease("UserListDal", "Get", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            return userList;
        }
        #endregion
    }
}
