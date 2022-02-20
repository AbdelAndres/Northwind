using System;
using System.Data.SqlClient;
using Univalle.Fie.Sistemas.BaseDeDatos2.NorthWindApp.Common;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.NorthWindApp.CustomersDal
{
    /// <summary>
    /// Clase para crear usuarios
    /// </summary>
    public class CustomerDal
    {
       
        #region Methods
        /// <summary>
        /// Insert an user into database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool Insert(Customer customer)
        {
            Operations.WriteLogsDebug("CustomerDal", "Insert", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear un usuario"));

            SqlCommand command = null;
            int result = 0;
            //Consulta para insertar usuarios
            string queryString = @"INSERT INTO Customers(CustomerID, CompanyName)
                                    VALUES(@CustomerID, @CompanyName)";
           // try
            //{
                command = OperationsSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
                command.Parameters.AddWithValue("@CompanyName", customer.CompanyName);                               
                result = OperationsSql.ExecuteBasicCommand(command);
/*
            }
            catch (SqlException ex)
            {
                Operations.WriteLogsRelease("CustomerDal", "Insert", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operations.WriteLogsRelease("CustomerDal", "Insert", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }*/

            Operations.WriteLogsDebug("CustomerDal", "Insert", string.Format("{0} {1} Info: {1}",
           DateTime.Now.ToString(), DateTime.Now.ToString(),
           "Termino de ejecutar el metodo acceso a datos para insertar un cliente"));
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
