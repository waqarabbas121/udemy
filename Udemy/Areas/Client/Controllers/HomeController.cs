using AutoMapper;
using BLL.Client.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Udemy.Areas.Client.Interfaces;
using Udemy.Controllers;

namespace Udemy.Areas.Client.Controllers
{
    [Route("client")]
    public class HomeController : BaseController
    {
        private ISample sample;
        private ILoggerFactory logger;
        public HomeController(ISample _sample, ILoggerFactory _logger)
        {
            sample = _sample;
            logger = _logger;
        }
        [HttpGet, Route("")]
        public ActionResult Index()
        {
            try
            {
                // Use AutoMapper
                //Mapper.Map<SampleDTO>(Sample);
                var getData = sample.SampleMethod(100);
                return View();
            }
            catch (Exception ex)
            {
                logger.CreateLogger(ex.Message);
                return View();
            }
        }

        [Route("getall")]
        public ActionResult GetAllUsers()
        {
            return View();
        }
    }
}