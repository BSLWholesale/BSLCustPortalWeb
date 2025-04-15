using BSLCustomerPortalWeb.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace BSLCustomerPortalWeb.Controllers
{
    public class HRController : Controller
    {
        // GET: HR
        public ActionResult ITHelpdesk()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Fn_Create_Tickets(clsITHelpdesk obj)
        {

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCustPortalWebAPI"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(obj);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/HRAPI/Fn_Create_Tickets", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {

                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "No data found." }, JsonRequestBehavior.AllowGet);

                }
            }
        }


        [HttpPost]
        public JsonResult Fn_Get_Tickets(clsITHelpdesk obj)
        {

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCustPortalWebAPI"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(obj);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/HRAPI/Fn_Get_Tickets", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {

                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "No data found." }, JsonRequestBehavior.AllowGet);

                }
            }
        }
    }
}