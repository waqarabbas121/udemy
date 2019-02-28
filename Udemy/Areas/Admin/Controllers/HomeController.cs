using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Udemy.Controllers;

namespace Udemy.Areas.Admin.Controllers
{
    [Route("admin")]
    public class HomeController : BaseController
    {
        [HttpGet, Route("")]
        public ActionResult Index()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}