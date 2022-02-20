using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Univalle.Fie.Sistemas.BaseDeDatos2.NorthWindApp.CustomersDal;
using Univalle.Fie.Sistemas.BaseDeDatos2.NorthWindApp.Common;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.NorthWindApp.CustomersBrl
{
    /// <summary>
    /// Class to handle the customer bussiness logic
    /// </summary>
    public class CustomerBrl
    {
        /// <summary>
        ///Business logic method to insert a user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool Insert(Customer customer)
        {
            Operations.WriteLogsDebug("CustomerBrl", "Insert", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el método lógica de negocio para crear un cliente"));
            bool result = false;
           // try
            //{
                result = CustomerDal.Insert(customer);
            //}
            /*catch (SqlException ex)
            {
                Operations.WriteLogsRelease("UsuarioBrl", "Insertar", string.Format("{0} Error: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operations.WriteLogsRelease("UsuarioBrl", "Insertar", string.Format("{0} Error: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }*/

            Operations.WriteLogsDebug("UsuarioBrl", "Insertar", string.Format("{0} Info: {1}",
           DateTime.Now.ToString(), DateTime.Now.ToString(),
           "Termino de ejecutar el método lógica de negocio para insertar usuario"));
            return result;
        }
    }
}
