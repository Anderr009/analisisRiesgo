using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models.Agresion;
using WinFormsApp1.Models.Sustitucion;

namespace WinFormsApp1.Controller
{
    public class SustitucionCtrl
    {
        public List<Sustitucion> getSustituciones()
        {
            List<Sustitucion> Sustituciones = new List<Sustitucion>();
            using (var context = new Context())
            {
                Sustituciones = context.Sust.ToList();
            }
            return Sustituciones;
        }
        public bool RemoveSustitucionesById(int id)
        {
            //Riesgo? risk = new Riesgo();
            using (var context = new Context())
            {
                var Sustituciones = context.Sust.SingleOrDefault(b => b.id == id);
                if (Sustituciones != null)
                {
                    context.Sust.Remove(Sustituciones);
                    context.SaveChanges();
                    return true; // Indica que se eliminó exitosamente
                }
                return false; // Indica que no se encontró el riesgo con el ID dado
            }
        }
        public bool inserSustitucion(Sustitucion Sustituciones)
        {
            try
            {
                using (var context = new Context())
                {
                    context.Sust.Add(Sustituciones);
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
