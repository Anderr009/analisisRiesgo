using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models.Riesgo;

namespace WinFormsApp1.Controller
{
    public class RiesgoCtrl
    {
        public List<Riesgo> getRiesgos()
        {
            List<Riesgo> risk = new List<Riesgo>();
            using(var context = new Context())
            {
                risk = context.riesgo.ToList();
            }
            return risk;
        }
        public Riesgo getRiesgoById(int id) 
        {
            Riesgo? risk = new Riesgo();
            using(var context = new Context())
            {
                risk = context.riesgo.SingleOrDefault(b => b.Id == id);
            }
            return risk;

        }
        
        public bool RemoveRiesgoById(int id) 
        {
            //Riesgo? risk = new Riesgo();
            using (var context = new Context())
            {
                var riesgo = context.riesgo.SingleOrDefault(b => b.Id == id);
                if (riesgo != null)
                {
                    context.riesgo.Remove(riesgo);
                    context.SaveChanges();
                    return true; // Indica que se eliminó exitosamente
                }
                return false; // Indica que no se encontró el riesgo con el ID dado
            }
        }
        public bool insertRiesgo(Riesgo risk)
        {
            try
            {
                using (var context = new Context())
                {
                    context.riesgo.Add(risk);
                    context.SaveChanges();
                }
                return true;
            }catch(Exception)
            {
                return false;
            }
          
        }
    }
}
