using EBP_MVC.Models;
using LibTraitement.Business;
using System;
using System.Web.Mvc;

namespace EBP_MVC.Controllers
{
    public class AjaxController : Controller
    {
        //
        // GET: /Ajax/

        public ActionResult Index()
        {
            var model = new ModelTransformation();
            return View(model);
        }

        [HttpPost]
        public PartialViewResult TransformationAjax(FormCollection collection, ModelTransformation model)
        {
            try
            {

#if DEBUG
                throw new Exception("Test Error in debug mode");
#endif

                var baseTransf = BusinessTransformation.getClass(model.DropDownTraitementField);
                if (baseTransf != null)
                {
                    baseTransf.OriginalText = model.OriginalText;

                    baseTransf.Transform();

                    model.FinalText = baseTransf.ResultFormatedText;
                }
                
                return PartialView("TransformationAjaxOK", model);
            }
            catch (Exception ex)
            {
                model.ErrorMessage = ex.Message;
                return PartialView("TransformationAjaxError", model.ErrorMessage);
            }
           
        }
    }
}
