using EmpBL;
using EmpDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmpAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        BL blObj;

        public EmployeeController()
        {
            blObj = new BL();
        }
        [HttpGet]
        public HttpResponseMessage GetEmployeeFullDetails()
        {
            try
            {
                var result = blObj.GetEmployeeDetails();
                if (result.Count > 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, result);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "No Employee Details Found");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        [HttpPost]
        public HttpResponseMessage Display(DTO newemployee)
        {
            try
            {
                int res = blObj.DisplayAllEmployee(newemployee);
                if (res == 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Reviews enter sucessfully");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        [HttpPost]
        public HttpResponseMessage UpdateEmployeeDetails(DTO employee)
        {
            try
            {
                int res = blObj.UpdateAllEmployee(employee);
                if (res == 1)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Reviews enter sucessfully");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
        [HttpPost]
        public HttpResponseMessage DeleteEmployeeDetails(DTO emp)
        {
            try
            {
                int res = blObj.DeleteAllEmployee(emp);
                if (res == 1)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Reviews enter sucessfully");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        [HttpGet]
        public HttpResponseMessage GetDepartmentDetails()
        {
            try
            {
                var result = blObj.GetDepartmentDetails();
                if (result.Count > 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, result);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "No Employee Details Found");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public HttpResponseMessage CreateDepartment(DepDTO newdepartment)
        {
            try
            {
                int res = blObj.CreateAllDepartment(newdepartment);
                if (res == 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Reviews enter sucessfully");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
                }
            }
            catch (Exception ex)
            {

                throw ;
            }

        }
        [HttpPost]
        public HttpResponseMessage UpdateDepartmentDetails(DepDTO department)
        {
            try
            {
                int res = blObj.UpdateAllDepartment(department);
                if (res == 1)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Reviews enter sucessfully");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        [HttpPost]
        public HttpResponseMessage DeleteDepartmentDetails(DepDTO dep)
        {
            try
            {
                int res = blObj.DeleteAllDepartment(dep);
                if (res == 1)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Reviews enter sucessfully");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }
}
}