using BSLCustomerPortalWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Net.Http;
using System.Text;

namespace BSLCustomerPortalWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult DashBoard()
        {
            ViewBag.Message = "Your DashBoard page.";

            return View();
        }

        public ActionResult Feedback()
        {           
            return View();
        }


        [HttpPost]
        public JsonResult Fn_LogIn_Customer(clsCustomer objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCustPortalWebAPI"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/CustomerAPI/Fn_LogIn_Customer", content).Result;
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
        public JsonResult Fn_Add_Feedback(clsFeedback obj)
        {

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCustPortalWebAPI"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(obj);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/CustomerAPI/Fn_Add_Feedback", content).Result;
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
        public JsonResult Fn_Get_Feedback(clsFeedback obj)
        {

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCustPortalWebAPI"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(obj);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/CustomerAPI/Fn_Get_Feedback", content).Result;
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
        public JsonResult Fn_Delete_Feedback(clsFeedback obj)
        {

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCustPortalWebAPI"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(obj);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/CustomerAPI/Fn_Delete_Feedback", content).Result;
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