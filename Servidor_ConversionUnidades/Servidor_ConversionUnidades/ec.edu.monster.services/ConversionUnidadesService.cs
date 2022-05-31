using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servidor_ConversionUnidades.ec.edu.monster.services
{
    public class ConversionUnidadesService
    {
        public double pulgadasAcentimetros(double pulgadas)
        {
            return pulgadas * 2.54;
        }

        public double centimetrosApulgadas(double centimetros)
        {
            return centimetros / 2.54;
        }
    }
}