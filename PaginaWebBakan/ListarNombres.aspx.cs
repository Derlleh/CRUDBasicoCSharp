using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data.Entity; 

namespace PaginaWebBakan
{
    public partial class ListarNombres : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmpleadoBLL ems = new EmpleadoBLL();
            grilla.DataSource = ems.ListaCaracteresNombre();
            grilla.DataBind();
        }
    }
}