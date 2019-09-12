using RestauranteDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteBL
{
    public class EmpleadoBL
    {
        public int InsertarEmpleado(Empleado emp)
        {
            var empleados = new List<Empleado>();
            empleados.Add(emp);
            //UpdateDatabase()
            return emp.Id;
        }
        public bool Edit(Empleado emp)
        {
            try
            {
                var empleados = new List<Empleado>();
                var r = ConsultarEmpleado(emp.Id, empleados);
                r.Nombre = emp.Nombre;
                r.Id = emp.Id;
                r.RestauranteId = emp.RestauranteId;
                return true;
            }
            catch (Exception err)
            {
                return false;
            }


        }
        public bool Eliminar(int Id)
        {
            try
            {
                var empleados = new List<Empleado>();
                var r = ConsultarEmpleado(Id, empleados);
                empleados.Remove(r);
                return true;
            }
            catch (Exception err)
            {
                return false;
            }
        }

        public IEnumerable<Empleado> ConsultarEmpleados(string nombre)
        {
            var empleados = new List<Empleado>();
            var tmpList = new List<Empleado>();
            foreach (var r in empleados)
            {
                if (r.Nombre.Contains(nombre.ToLower()))
                {
                    tmpList.Add(r);
                }
            }
            return tmpList;
        }
        public Empleado ConsultarEmpleado(int id, List<Empleado> context = null)
        {                                     //if      //else
            var empleados = context != null ? context : new List<Empleado>();
            var emp = new Empleado();
            foreach (var r in empleados)
            {
                if (r.Id == id)
                {
                    emp = r;
                    break;
                }

            }
            return emp;

        }
    }
}
