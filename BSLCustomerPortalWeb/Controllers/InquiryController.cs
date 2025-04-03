using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BSLCustomerPortalWeb.Controllers
{
    public class InquiryController : Controller
    {
        // GET: Inquiry
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Quotation()
        {
            return View();
        }

        public ActionResult DisplayQuotation()
        {
            return View();
        }

    }
}