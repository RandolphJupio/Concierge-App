﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConciergeApp.Models;
using ConciergeApp.Services;
using ConciergeApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNet.Identity;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ConciergeApp.API
{
    [Route("api/[controller]")]
    public class FeedbackController : Controller
    {
        private FeedbacksService _service;

        public FeedbackController(FeedbacksService service)
        {
            _service = service;
        }
        
        // GET: api/values
        [HttpGet]
        public ICollection<FeedbackDTO> GetProfileFeedback()
        {
            string userId = User.Identity.GetUserId();
            var profileFeedbacks = _service.GetProfileFeedback(userId);
            return profileFeedbacks;
        }

        //GET: api/values
        //[HttpGet]
        //public IEnumerable<FeedbackDTO> GetBusinessFeedback()
        //{
        //    int id = Business.Id;
        //    return _service.GetBusinessFeedback(id);
        //}

        // GET api/values/5
        //[HttpGet("{id}")]
        //public IEnumerable<FeedbackDTO> Get(int id)
        //{
        //    return _service.GetFeedbackById(id);
        //}

        // POST api/values
        [HttpPost("{id}")]
        public void Post(int businessid, [FromBody]FeedbackDTO value)
        {
            _service.Add(value, User.Identity.Name, businessid);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}


