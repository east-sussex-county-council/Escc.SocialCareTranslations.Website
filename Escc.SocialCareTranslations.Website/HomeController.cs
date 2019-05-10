using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Escc.EastSussexGovUK.Mvc;
using Exceptionless;

namespace Escc.SocialCareTranslations.Website
{
    public class HomeController : Controller
    {
        // GET: Default
        public async Task<ActionResult> Index()
        {
            var model = new HomeViewModel();
            model.Metadata.Title = "Translation service";
            model.Metadata.Description = "Information on how to get Adult Social Care publications and web pages translated into other languages.";
            model.Metadata.DateCreated = new DateTimeOffset(new DateTime(2004, 8, 6));
            model.Metadata.DateIssued = new DateTimeOffset(new DateTime(2004, 8, 6));
            model.Metadata.LocalGovernmentServices.Add(new Uri("http://id.esd.org.uk/service/169", UriKind.RelativeOrAbsolute));
            model.ShowEastSussex1SpaceWidget = true;

            var templateRequest = new EastSussexGovUKTemplateRequest(Request);
            try
            {
                model.WebChat = await templateRequest.RequestWebChatSettingsAsync();
            }
            catch (Exception ex)
            {
                // Catch and report exceptions - don't throw them and cause the page to fail
                ex.ToExceptionless().Submit();
            }
            try
            {
                model.TemplateHtml = await templateRequest.RequestTemplateHtmlAsync();
            }
            catch (Exception ex)
            {
                // Catch and report exceptions - don't throw them and cause the page to fail
                ex.ToExceptionless().Submit();
            }

            return View(model);
        }
    }
}