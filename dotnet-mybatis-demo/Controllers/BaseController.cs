﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dotnet_mybatis_demo.Controllers
{
    public class BaseController : Controller
    {
        protected new JsonResult Json(object data)
        {
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}