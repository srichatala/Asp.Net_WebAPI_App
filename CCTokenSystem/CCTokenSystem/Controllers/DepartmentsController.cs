using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CCTokenSystem.Models;
using System.Net.Http.Headers;

namespace CCTokenSystem.Controllers
{
    public class DepartmentsController : ApiController
    {
        private CCTokenSystemContext db = new CCTokenSystemContext();

        [HttpGet]
        public IEnumerable<Department> GetAllDepartments()
        {
            return db.Departments.AsEnumerable<Department>();
        }

        [HttpGet]

        public Department GetDepartmentByID(int Id)
        {
            Department department = db.Departments.Find(Id);
            if (department == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return department;
        }

        [HttpPut]
        public HttpResponseMessage UpdateDepartment(Department department)
        {
            if (department != null)
            {
                db.Entry(department).State = EntityState.Modified;
            }

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }


            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, department);

            response.StatusCode = HttpStatusCode.Created;

            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return response;
        }

        [HttpPost]
        public HttpResponseMessage CreateDepartment(Department department)
        {
            db.Departments.Add(department);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, department);

            response.StatusCode = HttpStatusCode.Created;

            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return response;
        }

        [HttpDelete]
        public HttpResponseMessage DeleteDepartment(int Id)
        {
            Department department = db.Departments.Find(Id);

            if (department == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            db.Departments.Remove(department);

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(new HttpResponseMessage(HttpStatusCode.OK));
        }
    }
}