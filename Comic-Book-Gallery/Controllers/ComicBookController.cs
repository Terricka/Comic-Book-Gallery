using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Models;
using ComicBookGallery.Data;
using System.Diagnostics.Contracts;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBookController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Detail(int? id){
            Contract.Ensures(Contract.Result<ActionResult>() != null);

            if(id == null){
                return HttpNotFound();
            }

            var comicBook = _comicBookRepository.GetComicBook(id.Value);


            return View(comicBook);

        }

    }
}
