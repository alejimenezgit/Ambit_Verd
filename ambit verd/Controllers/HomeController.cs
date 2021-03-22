using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace Ambit_Verd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }

        public ActionResult WhoWeAre()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public void sendEmail(string email)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("alejimreg@gmail.com", "alejandro199855");
            MailMessage msg = new MailMessage();

            msg.To.Add("alejimreg@gmail.com");
            msg.From = new MailAddress("alejimreg@gmail.com");
            msg.Subject = "alejandro";
            msg.Body = "alejandro";

            try
            {
                //envío el mensaje
                client.Send(msg);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                    ex.ToString());
            }
            
        }
        public ActionResult Change(String Lang)
        {
            if(Lang != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(Lang);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(Lang);
            }

            HttpCookie cookie = new HttpCookie("Language");
            cookie.Value = Lang;
            Response.Cookies.Add(cookie);

            return View("Index");
        }
    }
}