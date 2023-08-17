using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Controller;
using WinFormsApp1.Models.Agresion;
using WinFormsApp1.Models.Extension;
using WinFormsApp1.Models.Funcion;
using WinFormsApp1.Models.Profundidad;
using WinFormsApp1.Models.Sustitucion;
using WinFormsApp1.Models.Vulnerabilidad;

namespace WinFormsApp1.Libs
{
    public class Utilities
    {
        List<Funcion> listFunc = new FuncionCtrl().getFunciones();
        List<Sustitucion> listSust = new SustitucionCtrl().getSustituciones();
        List<Profundidad>  listProf = new ProfundidadCtrl().getProfundidad();
        List<Extension> listExt = new ExtensionCtrl().getExtensiones();
        List<Agresion> listAgr = new AgresionCtrl().getAgresiones();
        List<Vulnerabilidad> listVuln = new VulnerabilidadCtrl().getVulnerabilidades();
        public int[] CaractRiesg()
        {
            int[] carRisk = new int[listFunc.Count];
            for(int i = 0 ; i < listFunc.Count; i++)
            {
                int x = listFunc[i].valoration * listSust[i].valoration;
                int c = listProf[i].valoration * listExt[i].valoration;
                carRisk[i] = x+c;
            }
            return carRisk;

        }
        public int[] ProbRisk()
        {
            int[] probRisk = new int[listAgr.Count];
            for (int i = 0; i < listAgr.Count; i++)
            {
                probRisk[i] = listAgr[i].valoration * listVuln[i].valoration;
            }
            return probRisk;
        }
        public int[] CuantRisk()
        {
            int[] CaractRisk = CaractRiesg();
            int[] ProbR = ProbRisk();
            int[] cuantR = new int[CaractRisk.Length];
            for(int i = 0;i < CaractRisk.Length; i++)
            {
                cuantR[i] = CaractRisk[i] * ProbR[i];
            }
            return cuantR;
        }
        public string[] clasfRisk()
        {
            int[] CR = CuantRisk();
            string[] clasf = new string[CR.Length]; 
            for(int i = 0; i < CR.Length; i++) 
            {
                if (CR[i] >= 1 && CR[i] <= 250)
                {
                    clasf[i] = "Muy pequeño";
                }
                if (CR[i] >= 251 && CR[i] <= 500)
                {
                    clasf[i] = "Pequeño";
                }
                if (CR[i] >= 501 && CR[i] <= 750)
                {
                    clasf[i] = "Normal";
                }
                if (CR[i] >= 751 && CR[i] <= 1000)
                {
                    clasf[i] = "Grande";
                }
                if (CR[i] >= 1001 && CR[i] <= 1250)
                {
                    clasf[i] = "Elevado";
                }
            }
            return clasf;
        }
    }
}
