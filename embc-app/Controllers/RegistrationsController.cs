﻿using Gov.Jag.Embc.Interfaces;
using Gov.Jag.Embc.Public.Authentication;
using Gov.Jag.Embc.Public.DataInterfaces;
using Gov.Jag.Embc.Public.Models;
using Gov.Jag.Embc.Public.Sqlite.Models;
using Gov.Jag.Embc.Public.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gov.Jag.Embc.Public.Controllers
{
    [Route("api/[controller]")]
    public class RegistrationsController : Controller
    {
        private readonly IConfiguration Configuration;
        private readonly IDataInterface _dataInterface;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger _logger;
        private readonly IHostingEnvironment _env;

        public RegistrationsController(IConfiguration configuration, IHttpContextAccessor httpContextAccessor, ILoggerFactory loggerFactory, IHostingEnvironment env, IDataInterface dataInterface)
        {
            Configuration = configuration;
            _dataInterface = dataInterface;
            _httpContextAccessor = httpContextAccessor;
            _logger = loggerFactory.CreateLogger(typeof(PeopleController));
            this._env = env;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet()]
        [AllowAnonymous]
        public IActionResult Get(string id)
        {
            List < ViewModels.Registration > result = _dataInterface.GetRegistrations();
  
            return Json(result);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {

            return Json(null);
        }


        /// <summary>
        /// Update
        /// </summary>
        /// <param name="item"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] ViewModels.Registration item, string id)
        {
            if (id != null && item.Id != null && id != item.Id)
            {
                return BadRequest();
            }

            

            return Json(null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost()]
        [AllowAnonymous]
        public async Task<IActionResult> Create([FromBody] ViewModels.Registration item)
        {
            var result = _dataInterface.CreateRegistration(item);
            return Json(result);
        }


    }
}