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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ILoginSVC
    {
        [OperationContract]
        bool ValidarUsuario(string usr, string pas);

        [OperationContract]

        String NombreUsuario(string usr, string pas); 

    }
}
