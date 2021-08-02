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
    public partial class Editar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoBLL em = new EmpleadoBLL();

                em.Rut = int.Parse(txtRut.Text);
                em.Dv = txtDV.Text;
                em.Nombres = TtxtNombre.Text;
                em.Apellidos = txtApellido.Text;
                em.Empresa = int.Parse(DDLEmpresa.SelectedValue);

                if (em.Modificar())
                {
                    Response.Write("<script>alert('Empleado Modificado')</script>");
                }
            }
            catch (Exception ex)
            {

                Response.Write("<script>alert('Error: " + ex.Message + "')</script>");
            }
        }
    }
}