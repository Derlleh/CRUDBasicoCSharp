using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DAL;
using System.Data.Entity; 

namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "LoginSVC" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione LoginSVC.svc o LoginSVC.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class LoginSVC : ILoginSVC
    {
        public string NombreUsuario(string usr, string pas)
        {
            EmpresasEntities modelo = new EmpresasEntities();
            Usuarios valido = (from users in modelo.Usuarios
                               where users.UserName == usr &&
                               users.Password == pas
                               select users).FirstOrDefault();
            if(valido!=null)
            {
                return valido.UserName; 
            }
            return "no se puede recuperar el nombre"; 
        }

        public bool ValidarUsuario(string usr, string pas)
        {
            EmpresasEntities modelo = new EmpresasEntities();
            Usuarios valido = (from users in modelo.Usuarios
                               where users.UserName == usr &&
                               users.Password == pas
                               select users).FirstOrDefault();
            if(valido!=null)
            {
                return true; 
            }
            return false; 
        }
    }
}
