using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models.Vulnerabilidad;

namespace WinFormsApp1.Controller
{
    public class VulnerabilidadCtrl
    {
        public List<Vulnerabilidad> getVulnerabilidades()
        {
            List<Vulnerabilidad> vulnerabilidades = new List<Vulnerabilidad>(); 
            using(var context = new Context())
            {
                vulnerabilidades = context.vuln.ToList();
            }
            return vulnerabilidades;
        }
        public Vulnerabilidad GetVulnerabilidadById(int id)
        {
            Vulnerabilidad vuln = new Vulnerabilidad();
            using (var context = new Context())
            {
                vuln = context.vuln.FirstOrDefault(b => b.id == id);
            }
            return vuln;
        }
        public bool insertVulnerabilidad(Vulnerabilidad vuln)
        {
            try
            {
                using (var context = new Context())
                {
                    context.vuln.Add(vuln);
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
