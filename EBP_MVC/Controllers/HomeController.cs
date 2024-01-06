using EBP_MVC.Models;
using LibTraitement.Business;
using LibTraitement.Domain;
using System.Web.Mvc;

namespace EBP_MVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var model = new ModelTransformation();
            return View(model);
        }

        [HttpPost]
        public ActionResult Transform(ModelTransformation model)
        {
            BaseTransformation baseTransf = BusinessTransformation.getClass(model.DropDownTraitementField);
            if (baseTransf != null)
            {
                baseTransf.OriginalText = model.OriginalText;

                baseTransf.Transform();

                model.FinalText = baseTransf.ResultFormatedText;
            }

            return View(model);

        }

    }
}
