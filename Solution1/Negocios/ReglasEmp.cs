using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Clases;


namespace Negocios
{
    public class ReglasEmp
    {
        ClsEmpleados obj = new ClsEmpleados();
        public DataTable listaEmpleados()
        {
            return obj.ListarEmpleados();
        }
    }
}
