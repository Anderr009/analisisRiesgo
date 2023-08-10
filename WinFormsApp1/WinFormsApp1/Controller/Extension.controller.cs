using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models.Extension;

namespace WinFormsApp1.Controller
{
    public class ExtensionCtrl
    {
        public List<Extension> getExtensiones() 
        {
            List<Extension> extensiones = new List<Extension>();
            using (var context = new Context()) 
            {
                extensiones = context.extension.ToList();
            }
            return extensiones;
        }
        public Extension GetExtensionById(int id) 
        {
            Extension extension = new Extension();
            using(var context = new Context()) 
            {
                extension = context.extension.SingleOrDefault(b=> b.id == id);
            }
            return extension;
        }
        public bool insertExtension(Extension extension)
        {
            try
            {
                using (var context = new Context())
                {
                    context.extension.Add(extension);
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
