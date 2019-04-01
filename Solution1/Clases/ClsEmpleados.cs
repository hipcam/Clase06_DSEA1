using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clases
{
    public class ClsEmpleados:Conexion
    {

        SqlConnection cn = new SqlConnection();

        public DataTable ListarEmpleados()
        {
            cn = cadena();
            using (SqlDataAdapter df = new SqlDataAdapter("Usp_ListEmpleados4", cn))
            {
                df.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable dt = new DataTable())
                {
                    df.Fill(dt);
                    return dt;
                }
            }

        }

    }
}
