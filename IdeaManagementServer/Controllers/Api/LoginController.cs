using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Net;

namespace IdeaManagementServer.Controllers.Api
{
    [System.Web.Http.RoutePrefix("Api/login")]
    public class LoginController : ApiController
    {
        private Context context;

        public LoginController()
        {
            context = new Context();
        }

        [System.Web.Http.HttpPost]
        public void LoginTest(UserAccounts userAccounts)
        {
            Console.WriteLine(userAccounts.fld_username + "----" + userAccounts.fld_password);
            var result = context.tbl_userAccounts.FirstOrDefault(u => u.fld_username == userAccounts.fld_username && u.fld_password == userAccounts.fld_password);
           
            if (result != null)
            {
                Console.WriteLine("Success " + result.ToString());
            }
           
        }
        // GET: Login
    
    }
}