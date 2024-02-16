using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore;
using Microsoft.AspNetCore.Mvc;
using TeaTimeDemo.Data;
using TeaTimeDemo.Models;

namespace TeaTimeDemo.Controllers
{
    public class CategoryController: Controller
    {
        private readonly ApplicationDBContext _db;
        public CategoryController(ApplicationDBContext db){
            _db = db;
        }
        public IActionResult Index(){
            //List<Category> objCategoryList = _db.Categories.ToList();
            return View();
        }
    }
}