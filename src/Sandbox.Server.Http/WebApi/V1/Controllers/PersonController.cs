﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sandbox.Server.DomainObjects.Interfaces.Handlers;
using Sandbox.Server.DomainObjects.Interfaces.Handlers.Abstract;
using Sandbox.Server.DomainObjects.Models;
using Sandbox.Server.Http.WebApi.V1.Controllers.Abstract;
using Sandbox.Server.Http.WebApi.V1.Views;
using Sandbox.Server.Http.WebApi.V1.Views.PersonViews;

namespace Sandbox.Server.Http.WebApi.V1.Controllers
{
   [Route("api")]
    public class PersonController : EntityController<Person, IEntityHandler<Person>>
    {
        public PersonController(IPersonHandler handler) : base(handler)
        {
        }

        /// <summary>
        /// No authentication required
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("users/login")]
        public JsonResult Login([FromBody] RootUserAuthView user)
        {
            // TODO
            
            return Json(new RootUserAuthView());
        } 


        /// <summary>
        /// Get Current User
        /// Authentication Required
        /// </summary>
        /// <returns>A UserAuthView Json object</returns>
        [HttpGet]
        [Route("user")]
        public JsonResult GetUser(){
            var user = new RootUserAuthView();

            // TODO
            
            return Json(user);
        }

        /// <summary>
        /// Update User
        /// Authentication required
        /// </summary>
        /// <param name="user"></param>
        /// <returns>A UserAuthView Json object</returns>
        [HttpPut]
        [Route("user")]
        public JsonResult UpdateUser([FromBody] RootUserAuthView user)
        {
            // TODO
            
            return Json(new {});
        }

        /// <summary>
        /// Authentication optional
        /// </summary>
        /// <param name="username"></param>
        /// <returns>A ProfileView Json</returns>
        [HttpGet]
        [Route("profiles/{username}")]
        public JsonResult GetProfile(string username)
        {
            // TODO
            
            return Json(new RootProfileView());
        } 

        /// <summary>
        /// Authentication required
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("profiles/{username}/follow")]
        public JsonResult FollowProfile(string username)
        {
            // TODO
            
            return Json(new RootProfileView());
        } 

        /// <summary>
        /// Authentication required
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("profiles/{username}/follow")]
        public JsonResult UnfollowProfile(string username)
        {
            // TODO
            
            return Json(new RootProfileView());
        } 

    }
}
