using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltoBajo
{
    internal class ClaseAltoBajo
    {

        public double costoAlto { get; set; }
        public double costoBajo { get; set; }
        public double unidadesAlta { get; set; }
        public double unidadesBaja { get; set; }

        public double horasUnidadesProducidas {get;set;}
        public double costoTabla { get; set; }

        
        
        

        public double CostoVariableUnitario()
        {
            double cvu;

            cvu = (costoAlto - costoBajo) / (unidadesAlta - unidadesBaja);
            return cvu;
        }

        public double Total()
        {
            
            return costosFijoss() + (CostoVariableUnitario() * unidadesAlta);
        }

        public double costosFijoss()
        {
            double cf;
            cf = costoAlto - (CostoVariableUnitario() * unidadesAlta);
            return cf;
        }

    }
}
