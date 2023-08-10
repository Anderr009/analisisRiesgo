using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models.Profundidad;

namespace WinFormsApp1.Controller
{
    public class ProfundidadCtrl
    {
        public List<Profundidad> getProfundidad()
        {
            List<Profundidad> profundidad = new List<Profundidad>();     
            using(var context = new Context())
            {
                profundidad = context.profundidad.ToList();
            }
            return profundidad;
        }
        public Profundidad getProfundidadById(int id)
        {
            Profundidad profundidad = new Profundidad();
            using(var context = new Context())
            {
                profundidad = context.profundidad.SingleOrDefault(b=>b.id == id); 
            }
            return profundidad;
        }
        public bool insertProfundidad(Profundidad profundidad)
        {
            try 
            {
                using (var context = new Context())
                {
                    context.profundidad.Add(profundidad);
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
