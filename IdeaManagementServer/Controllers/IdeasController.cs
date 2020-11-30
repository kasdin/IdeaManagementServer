using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IdeaManagementServer.Models;

namespace IdeaManagementServer
{
    public class IdeasController : Controller
    {
        // GET: Ideas
        public ActionResult Ideas()
        {
            var idea = new Ideas();
            idea.fld_id = 1;
            idea.fld_title = "Faster work idea";
            idea.fld_description =
                "I have come up with this amazing idea to work better, faster, and longer without any cost for the company";
            idea.fld_effortScale = 1;
            idea.fld_impactScale = 5;
            idea.fld_employeeNo = 521452;

            return View(idea);
        }

        public ActionResult NewIdea()
        {
            return View();
        }
    }
}