using IdeaManagementServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace IdeaManagementServer.Controllers.Api
{

    public class IdeaController : ApiController
    {
        private Context context;
        public IdeaController()
        {
            context = new Context();
        }

        public IEnumerable<Ideas> GetIdeas()
        {
            return context.tbl_ideas.ToList();

        }
        [HttpPost]
        public Ideas CreateIdea(Ideas idea)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {
                context.tbl_ideas.Add(idea);
                context.SaveChanges();
            }

            return idea;
        }
    }
}