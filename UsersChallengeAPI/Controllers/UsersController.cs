using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UsersChallenge.Models;
using UsersChallengeAPI.Services;

namespace UsersChallengeAPI.Controllers
{
    public class UsersController : ApiController
    {
        private UsersService _usersService;

        public UsersController()
        {
            _usersService = new UsersService();
        }

        public HttpResponseMessage Get()
        {
            try
            {
                var responseContent = _usersService.GetAllUsers(); ;
                return Request.CreateResponse(HttpStatusCode.OK, responseContent);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        public HttpResponseMessage Get(int id)
        {
            try
            {
                var responseContent = _usersService.GetUser(id);
                if (responseContent is null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "User not found for the provided ID");
                }
                return Request.CreateResponse(HttpStatusCode.OK, responseContent);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        public HttpResponseMessage Post([FromBody] User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _usersService.CreateUser(user);
                    return Request.CreateResponse(HttpStatusCode.NoContent);
                }

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        public HttpResponseMessage Put([FromBody] User user)
        {
            try
            {
                if (ModelState.IsValid && user.UserId != null)
                {
                    _usersService.UpdateUser(user);
                    return Request.CreateResponse(HttpStatusCode.NoContent);
                }
                ModelState.AddModelError("UpdateError", "UserId required for update operations");
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            catch(DbUpdateException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }            
        }
    }
}