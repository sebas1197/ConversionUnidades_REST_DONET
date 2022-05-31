using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using System.Globalization;

namespace Cliente_ConversionUnidades.ec.edu.monster.service
{
    public class ConversionUnidadesService
    {
        public double CentimetrosApulgadas(double centimetros)
        {
            HttpClient cliente = new HttpClient();
            string url = "http://localhost:62708/api/CentimetrosPulgadas";
            cliente.BaseAddress = new Uri(url);
            var respuesta = cliente.GetAsync("?centimetros=" + centimetros).Result;
           
            return Double.Parse(respuesta.Content.ReadAsStringAsync().Result); 
        }

        public double pulgadasAcentimetros(double pulgadas)
        {
            HttpClient cliente = new HttpClient();
            string url = "http://localhost:62708/api/PulgadasCentimetros";
            cliente.BaseAddress = new Uri(url);
            var respuesta = cliente.GetAsync("?pulgadas=" + pulgadas).Result;

            return Double.Parse(respuesta.Content.ReadAsStringAsync().Result);
        }
    }
}
