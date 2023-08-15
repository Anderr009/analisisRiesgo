using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;
using WinFormsApp1.Models.Agresion;

namespace WinFormsApp1.Controller
{
    public class SustitucionCtrl
    {
        public List<Sustitucion> getSustituciones()
        {
            List<Sustitucion> agresiones = new List<Sustitucion>();
            using (var context = new Context())
            {
                agresiones = context.Sust.ToList();
            }
            return agresiones;
        }
        public bool inserSustitucion(Sustitucion agresion)
        {
            try
            {
                using (var context = new Context())
                {
                    context.Sust.Add(agresion);
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
