using System;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail(){
            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                return Redirect("/");
            }

            return Content("Hello");

        }

		public string HotWings()
		{
			return "Spicy";
		}
    }
}
