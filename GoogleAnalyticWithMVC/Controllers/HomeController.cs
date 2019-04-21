using Google.Apis.Analytics.v3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace GoogleAnalyticWithMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Google Analytic.";

            

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //private void SaveWebSiteInfo(string mailAddress, string Password, string ProfileId, int userId)
        //{
        //    DateTime startDate = DateTime.Now;
        //    AnalyticsService asv = new AnalyticsService("GData-Version: 1.8");
        //    asv.setUserCredentials(mailAddress, Password);
        //    const string dataFeedUrl = "https://www.google.com/analytics/feeds/data";
        //    var service = new AnalyticsService("WebSiteAnalytics");
        //    service.setUserCredentials(mailAddress, Password);
        //    DataQuery query = new DataQuery(dataFeedUrl);
        //    query.Ids = "ga:" + ProfileId;
        //    query.Dimensions = "ga:landingPagePath,ga:hostname";
        //    query.Metrics = "ga:entrances";
        //    query.GAStartDate = startDate.ToString("yyyy-MM-dd");
        //    query.GAEndDate = DateTime.Now.ToString("yyyy-MM-dd");
        //    var feed = asv.Query(query);
        //    WebSiteInfo aWebSiteInfo = new WebSiteInfo();
        //    for (int i = 0; i < feed.Entries.Count; i++)
        //    {
        //        aWebSiteInfo = new WebSiteInfo();
        //        var totalEntryse = feed.Entries[i];
        //        aWebSiteInfo.Pages = ((DataEntry)(totalEntryse)).Dimensions[0].Value;
        //        var webSiteList = _WebMarketingReportEntities.WebSiteInfoes.Where(x => x.Pages.Contains(aWebSiteInfo.Pages)).ToList();
        //        aWebSiteInfo.WebAddress = ((DataEntry)(totalEntryse)).Dimensions[1].Value;

        //        if (webSiteList.Count == 0)
        //            aWebSiteInfo.IsNewPage = true;
        //        else
        //            aWebSiteInfo.IsNewPage = false;

        //        aWebSiteInfo.UserID = userId;
        //        _WebMarketingReportEntities.WebSiteInfoes.Add(aWebSiteInfo);
        //        _WebMarketingReportEntities.SaveChanges();
        //    }
        //}
    }
}
