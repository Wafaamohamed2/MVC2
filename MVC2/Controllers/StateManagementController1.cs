using Microsoft.AspNetCore.Mvc;

namespace MVC2.Controllers
{
	public class StateManagementController1 : Controller
	{

		public IActionResult SetCookie()
        {
			CookieOptions cookieOptions = new CookieOptions();
			cookieOptions.Expires = DateTimeOffset.Now.AddHours(1);

            Response.Cookies.Append("msg", "Hello from cookie"); // session cookie 20 miniute
			Response.Cookies.Append("Name", "Wafaa" , cookieOptions);  // persistent cookie
            return Content("Cookie saved");
        }

		public IActionResult GetCookie()
		{
			string str = Request.Cookies["msg"];
			string name = Request.Cookies["Name"];
			return Content($"From Cookies {str} {name}");
		}

		public IActionResult SetTempData()
		{
			TempData["msg"] = "Message set Hello ";
			return Content("Data saved");
		}

		public IActionResult GetTempData1()
		{

			//read from tempdata "client cookies" defult
			string message = "Empty Msg";
			if (TempData.ContainsKey("msg")) {

				//	message = TempData["msg"].ToString(); // normal read get only one time then deleted

				message = TempData.Peek("msg").ToString();   // peek read more times
            }

			return Content
			   ("get1" + message);


		}
		public IActionResult GetTempData2()
		{

            //read from tempdata "server sission"
            string message = "Empty Msg";
            if (TempData.ContainsKey("msg")) 
			{ 
				message = TempData["msg"].ToString(); // normal read
				TempData.Keep();                     //dont delete any key
				TempData.Keep("msg");                 // save this key only and dont delete it
    		}

            return Content
               ("get2" + message);


        }
	}
}
