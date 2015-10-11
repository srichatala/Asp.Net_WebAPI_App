using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CCTokenSystem.Models;
using System.Data.Entity;
using System.Net.Http.Headers;

namespace CCTokenSystem.Controllers
{
    public class DepartmentsController : ApiController
    {
        private CCTokenSystemContext db_context = new CCTokenSystemContext();

        [HttpGet]
        public IEnumerable<Department> GetAllDepts()
        {
            return db_context.Departments.AsEnumerable<Department>();
        }

        [HttpGet]
        public Department GetDeptById(int Id)
        {
            Department dept = db_context.Departments.Find(Id);

            if(dept == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return dept;
        }

        [HttpPut]
        public HttpResponseMessage UpdateDept(Department dept)
        {
            if(dept != null)
            {
                db_context.Entry(dept).State = EntityState.Modified;
            }
            try
            {
                db_context.SaveChanges();
            }
            catch(Exception error)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, error);
            }
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, dept);

            response.StatusCode = HttpStatusCode.Created;

            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return response;
        }

        [HttpPost]
        public HttpResponseMessage CreateDept(Department dept)
        {
            db_context.Departments.Add(dept);
            try
            {
                db_context.SaveChanges();
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, dept);

            response.StatusCode = HttpStatusCode.Created;

            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return response;
        }

        [HttpDelete]
        public HttpResponseMessage DeleteDept(int Id)
        {
            Department dept = db_context.Departments.Find(Id);

            if (dept == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            db_context.Departments.Remove(dept);

            try
            {
                db_context.SaveChanges();
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(new HttpResponseMessage(HttpStatusCode.OK));
        }
    }
}
