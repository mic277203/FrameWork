using FrameWork.Model;
using FrameWork.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrameWork.Web.Areas.Manage.Controllers.Information
{
    public class InformationCategoryController : Controller
    {
        private IInformationCategoryService _InformationCategoryService;
        public InformationCategoryController(IInformationCategoryService informationCategoryService)
        {
            _InformationCategoryService = informationCategoryService;
        }

        // GET: Manage/InformationCategory
        public ActionResult Index()
        {
            var listInformation = _InformationCategoryService.GetPage();
            return View(listInformation);
        }

        public ActionResult Edit(string id)
        {
            var model = _InformationCategoryService.Get(id);
            return View(model);
        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(tbl_sys_infomationcategory infomationcategory)
        {
            _InformationCategoryService.Add(infomationcategory);
            _InformationCategoryService.SaveChanges();
            return View();
        }
    }
}