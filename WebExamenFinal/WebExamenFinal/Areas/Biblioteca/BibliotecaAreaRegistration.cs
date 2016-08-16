using System.Web.Mvc;

namespace WebExamenFinal.Areas.Biblioteca
{
    public class BibliotecaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Biblioteca";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Libro_default",
                "Libro/{action}/{id}",
                new { controller = "Libro", action = "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Biblioteca_default",
                "Biblioteca/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}