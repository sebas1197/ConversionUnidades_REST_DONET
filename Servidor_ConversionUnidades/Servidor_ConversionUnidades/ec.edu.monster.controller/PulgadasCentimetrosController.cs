using Servidor_ConversionUnidades.ec.edu.monster.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Servidor_ConversionUnidades.Controllers
{
    public class PulgadasCentimetrosController : ApiController
    {

        private ConversionUnidadesService conversionUnidadesService = new ConversionUnidadesService();

        // GET api/values/5
        public double Get(double pulgadas)
        {
            return this.conversionUnidadesService.pulgadasAcentimetros(pulgadas);
        }

    }
}
