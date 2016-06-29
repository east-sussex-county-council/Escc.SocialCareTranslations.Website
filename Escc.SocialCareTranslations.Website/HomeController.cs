using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Escc.EastSussexGovUK.Mvc;

namespace Escc.SocialCareTranslations.Website
{
    public class HomeController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            var model = new HomeViewModel();
            model.Metadata.Title = "Translation service";
            model.Metadata.Description = "Information on how to get Adult Social Care publications and web pages translated into other languages.";
            model.Metadata.DateCreated = "2004-08-06";
            model.Metadata.DateIssued = "2004-08-06";
            model.Metadata.Keywords = "Translation, interpreting, languages, language, publications, leaflet";
            model.Metadata.IpsvPreferredTerms = "Health, well-being and care; Languages";
            model.Metadata.LgslNumbers = "169";
            model.ShowEastSussex1SpaceWidget = true;

            return View(model);
        }
    }
}