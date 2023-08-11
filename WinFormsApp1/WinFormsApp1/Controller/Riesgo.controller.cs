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
        public String prueba()
        {
            try
            {
                using (var context = new Context())
                {
                    int count = context.riesgo.Count();
                    return "Funciono";
                }
            }catch(Exception ex)
            {
                return ex.Message;
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
