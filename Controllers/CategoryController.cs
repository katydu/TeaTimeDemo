using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeaTimeDemo.Data;
using TeaTimeDemo.Models;

namespace TeaTimeDemo.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db){
            _db = db;
        }
        public IActionResult Index(){
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
        [HttpGet]
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj){
            if(ModelState.IsValid){
                _db.Categories.Add(obj);
                _db.SaveChanges();
            }
            
            return RedirectToAction("Index");
        }
    }
}