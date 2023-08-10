using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models.Funcion;

namespace WinFormsApp1.Controller
{
    public class FuncionCtrl
    {
        public List<Funcion> getFunciones() 
        {
            List<Funcion> funciones = new List<Funcion>();
            using (var context = new Context()) 
            {
                funciones = context.funcion.ToList();
            }
            return funciones;
        }
        public Funcion getFuncionById(int id)
        {
            Funcion funcion = new Funcion();
            using (var context = new Context()) 
            {
                funcion = context.funcion.SingleOrDefault(b => b.id == id);
            }
            return funcion;
        }
        public bool insertFuncion(Funcion funcion)
        {
            try 
            { 
                using(var context = new Context())
                {
                    context.funcion.Add(funcion);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
