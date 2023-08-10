using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models.Agresion;

namespace WinFormsApp1.Controller
{
    public class AgresionCtrl
    {
        public List<Agresion> getAgresiones()
        {
            List<Agresion> agresiones = new List<Agresion>();
            using (var context = new Context()) 
            {
                agresiones = context.agresion.ToList();
            }
            return agresiones;
        }
        public Agresion getAgresionById(int id) 
        {
            Agresion agresion = new Agresion();
            using(var context = new Context()) 
            {
                agresion = context.agresion.SingleOrDefault(b => b.id == id);
            }
            return agresion;
        }
        public bool insertAgresion(Agresion agresion) 
        {
            try {
                using (var context = new Context())
                {
                    context.agresion.Add(agresion);
                    context.SaveChanges();
                }
                return true;
            }
            catch(Exception) 
            {
                return false;
            }
           
        }
    }
}
