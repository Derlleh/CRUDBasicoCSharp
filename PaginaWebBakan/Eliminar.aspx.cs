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
    public partial class Eliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoBLL eli = new EmpleadoBLL();

                eli.Rut = int.Parse(txtRut.Text);

                if (eli.Eliminar())
                {
                    Response.Write("<script>alert('Empleado Eliminado Con exito!!!!')</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script> alert('Error: " + ex.Message + ")</script>");

            }
        }
    }
}