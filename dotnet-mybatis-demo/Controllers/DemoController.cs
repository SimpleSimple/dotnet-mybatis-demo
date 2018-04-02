using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using service;
using dotnet_mybatis_demo.Models;

namespace dotnet_mybatis_demo.Controllers
{
    public class DemoController : BaseController
    {
        TextService textService = new TextService();
        // GET: Demo
        public JsonResult getList(PageParam param)
        {
            int page = param.page <= 0 ? 1 : param.page;
            int page_size = param.page_size <= 0 ? 10 : param.page_size;
            int start = (page - 1) * page_size;
            var list = textService.getTextList(start, page_size);
            return Json(list);
        }
    }
}