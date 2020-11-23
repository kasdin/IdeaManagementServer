using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI;

namespace IdeaManagementServer.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private Context Context;

        public CustomersController()
        {
            Context = new Context();
        }

        //get /api/customers
        public IEnumerable<Customers> GetCustomers()
        {
            return Context.tbl_customers.ToList();

        }

        // GET /api/customers?id=1
        public Customers GetCustomers(int id)
        {
            Customers customer = Context.tbl_customers.SingleOrDefault(c => c.fld_id == id);

            if (customer == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return customer;
        }
        [HttpPost]
        public Customers CreateCustomers(Customers customer)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {
                Context.tbl_customers.Add(customer);
                Context.SaveChanges();
            }

            return customer;
        }

        //put /api/customers/1
        [HttpPut]
        public void updateCustomers(int id, Customers customer)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var customersInDB = Context.tbl_customers.SingleOrDefault(c => c.fld_id == id);

            if (customersInDB == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                customersInDB.fld_name = customer.fld_name;
                customersInDB.fld_url = customer.fld_url;
                Context.SaveChanges();
            }
        }

        //DELETE /Api/customers/1
        [HttpDelete]
        public void DeleteCustomers(int id)
        {
            var customerInDb = Context.tbl_customers.SingleOrDefault(c => c.fld_id == id);

            if (customerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                Context.tbl_customers.Remove(customerInDb);
                Context.SaveChanges();
            }
        }
    }
}
