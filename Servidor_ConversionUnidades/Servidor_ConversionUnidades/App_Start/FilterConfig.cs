using System.Web;
using System.Web.Mvc;

namespace Servidor_ConversionUnidades
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
