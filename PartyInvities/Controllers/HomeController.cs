using PartyInvities.Models;
using PartyInvities.Infrastructure;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using SendGrid;
using System.Net;

namespace PartyInvities.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        // [Authorize(Users = "admin")]
        //[PartyUnhandledException]
        [HandleError(ExceptionType = typeof(ArgumentNullException), View = "PrettyError")]
        public ActionResult Index()
        {
            //LearnCSharp learn = new LearnCSharp(15);
            //learn.DaysToLearn = 19;
            //int[][][] my3DArray = learn.CreateJaggedArray<int[][][]>(1, 2, 3);

            string forward = "ReverseMe";
            var backward = forward.ToCharArray().Reverse().ToArray();

            var dict = new Dictionary<object,string>{{1, "Oklahoma"}, {2, "UNC"}, {3, "Kansas"} };
            IEnumerator<KeyValuePair<object, string>> myRator = dict.GetEnumerator();
            while (myRator.MoveNext())
            {
                Debug.WriteLine(String.Concat(myRator.Current.Value, " is overrated at #", myRator.Current.Key.ToString()));
            }

            foreach (int i in dict.Keys)
            {
                Debug.WriteLine(String.Concat(dict[i], " is ranked ", i.ToString()));
            }

            foreach (var kvp in dict)
            {
                Debug.WriteLine(String.Concat(kvp.Value, " is ranked #", kvp.Key.ToString()));
            }

            ViewBag.FavoriteTeam = "UNC Tar Heels";
            ViewBag.UserName = "Brent";
            return View();
        }

        [HttpGet]
        // [DployAuth]
        public ActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid) {
                if (guestResponse.WillAttend.HasValue)      // && guestResponse.WillAttend == true
                {
                    var sendGridMsg = new SendGridMessage();
                    sendGridMsg.From = new MailAddress("noreply@uncpartyinvite.com");
                    sendGridMsg.AddTo("bhetland@outlook.com");
                    sendGridMsg.Subject = "Party Invite RSVP";

                    string htmlBody = string.Concat("The following user has sent an RSVP:", "<br />", "<br />");
                    htmlBody = string.Concat(htmlBody, "Name: ", guestResponse.Name);
                    htmlBody = string.Concat(htmlBody, "<br />", "Will Attend: ", guestResponse.WillAttend.ToString());
                    sendGridMsg.Html = htmlBody;

                    var username = System.Environment.GetEnvironmentVariable("SENDGRID_USERNAME");
                    var pswd = System.Environment.GetEnvironmentVariable("SENDGRID_PASSWORD");
                    var credentials = new NetworkCredential(username, pswd);
                    var transportWeb = new Web(credentials);
                    transportWeb.DeliverAsync(sendGridMsg);
                }

                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }

        [CustomAction]
        public string FilterTest()
        {
            return "this is my filter test";
        }

		public ViewResult ListInfo()
		{
			return View("Result", new Result { ControllerName = "Home", ActionName = "ListInfo"} );
		}
    }
}