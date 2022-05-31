using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cliente_ConversionUnidades.ec.edu.monster.service;

namespace Cliente_ConversionUnidades.ec.edu.monster.controller
{
    class ConversionUnidadesControl
    {

        private ConversionUnidadesService ConversionUnidadesService = new ConversionUnidadesService();

        public double centimetrosApulgadas(double centimetros)
        {
            return this.ConversionUnidadesService.CentimetrosApulgadas(centimetros);
        }

        public double pulgadasAcentimetros(double pulgadas)
        {
            return this.ConversionUnidadesService.pulgadasAcentimetros(pulgadas);
        }
    }
}
