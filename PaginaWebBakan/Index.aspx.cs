using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using BLL; 

namespace PaginaWebBakan
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmpleadoBLL em = new EmpleadoBLL();
            grilla.DataSource = em.Listar();
            grilla.DataBind(); 
        }
    }
}