using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios;
namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ReglasEmp obj = new ReglasEmp();
        protected void Page_Load(object sender, EventArgs e)
        {
            gvEmpleados.DataSource = obj.listaEmpleados();
            gvEmpleados.DataBind();
        }

        protected void gvEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}