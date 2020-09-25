using AARP.DTO;
using AARP.UOW.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AARP.WEBStore.Controllers
{
    public class CategoryController : Controller
    {
        readonly IUnitOfWork db;
        public CategoryController(IUnitOfWork db){ this.db = db; }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(AddCategoryVM model)
        {
            if (db.Service.CreateCategory(model))
            {
                return View("Index");
            }
            return View(model);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}