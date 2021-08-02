using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.Entity; 

namespace BLL
{
    public class EmpleadoBLL
    {
        private int _rut;
        private string _dv;
        private string _nombres;
        private string _apellidos;
        private int _empresa;

        public int Rut
        {
            get
            {
                return _rut;
            }
            set
            {
                if (value > 0)
                {
                    _rut = value;
                }
                else
                {
                    throw new Exception("Rut no puede estar vacio");
                }
            }
        }

        public string Dv
        {
            get
            {
                return _dv;
            }
            set
            {
                if (value != string.Empty)
                {
                    _dv = value;
                }
                else
                {
                    throw new Exception("El DV no puede estar vacio");
                }
            }
        }

        public string Nombres
        {
            get
            {
                return _nombres;
            }
            set
            {
                if (value != string.Empty)
                {
                    _nombres = value;
                }
                else
                {
                    throw new Exception("Los nombres no pueden estar vacio");
                }

            }
        }

        public string Apellidos
        {
            get
            {
                return _apellidos;
            }
            set
            {
                if (value != string.Empty)
                {
                    _apellidos = value;
                }
                else
                {
                    throw new Exception("Apellido no puede estar vacio");
                }
            }
        }

        public int Empresa { get => _empresa; set => _empresa = value; }

        public bool Agregar()
        {
            EmpresasEntities modelo = new EmpresasEntities();

            Empleado e = (from emple in modelo.Empleado
                          where emple.Rut == this.Rut
                          select emple).FirstOrDefault(); 

            if(e==null)
            {
                Empleado nuevo = new Empleado();

                nuevo.Rut = _rut;
                nuevo.Dv = _dv;
                nuevo.Nombres = _nombres; 
                nuevo.Apellidos = _apellidos;
                nuevo.Empresa = _empresa;

                modelo.Empleado.Add(nuevo);
                modelo.SaveChanges(); 
                
            }

            return true; 
        }

        public List<EmpleadoBLL> Listar()
        {
            EmpresasEntities modelo = new EmpresasEntities();

            List<EmpleadoBLL> lista = new List<EmpleadoBLL>(); 

            foreach(Empleado item in modelo.Empleado)
            {
                EmpleadoBLL em = new EmpleadoBLL();
                em._rut = item.Rut;
                em._dv = item.Dv;
                em._nombres = item.Nombres;
                em._apellidos = item.Apellidos;
                em._empresa = item.Empresa;

                lista.Add(em);
            }

            return lista; 
        }

        public bool Eliminar()
        {

            EmpresasEntities modelo = new EmpresasEntities();

            Empleado e = (from emple in modelo.Empleado
                          where emple.Rut == this.Rut
                          select emple).FirstOrDefault();

            if(e.Rut == this.Rut)
            {
                modelo.Empleado.Remove(e);
                modelo.SaveChanges();
                return true; 
            }
            return false; 

        }

        public bool Modificar()
        {
            EmpresasEntities modelo = new EmpresasEntities();

            Empleado e = (from emple in modelo.Empleado
                          where emple.Rut == this.Rut
                          select emple).FirstOrDefault();

            if(e!=null)
            {
                e.Rut = this._rut;
                e.Dv = this._dv;
                e.Nombres = this._nombres;
                e.Apellidos = this._apellidos;
                e.Empresa = this._empresa;

                modelo.SaveChanges();
                return true; 
            }

            return false; 
        }

        public List<EmpleadoBLL>ListaCaracteresNombre()
        {
            EmpresasEntities modelo = new EmpresasEntities();

            List<EmpleadoBLL> listadoCaracter = new List<EmpleadoBLL>(); 

            foreach(Empleado item in modelo.Empleado)
            {
                if(item.Nombres.Length > 5)
                {
                    EmpleadoBLL em = new EmpleadoBLL();

                    em._rut = item.Rut;
                    em._dv = item.Dv;
                    em._nombres = item.Nombres;
                    em._apellidos = item.Apellidos;
                    em._empresa = item.Empresa;

                    listadoCaracter.Add(em); 
                }
            }

            return listadoCaracter; 
        }
    }
}
