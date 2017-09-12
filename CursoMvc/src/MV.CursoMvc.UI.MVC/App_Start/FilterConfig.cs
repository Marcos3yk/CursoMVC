using System.Web;
using System.Web.Mvc;
using MV.CursoMvc.Infra.CrossCutting.Mvc.Filters;

namespace MV.CursoMvc.UI.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new GlobalErrorHandler());
        }
    }
}
