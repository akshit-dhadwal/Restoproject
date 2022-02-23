using DIGITALMENU.BUSINESS;
using DIGITALMENU.MODEL;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace NS.RESTROMENU.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuBusiness _imenubusiness = null;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public MenuController(IMenuBusiness imenubusiness, IWebHostEnvironment webHostEnvironment)
        {
          _imenubusiness = imenubusiness;
          _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult AddNewDish()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewDish(Menu menu)
        {
            if (ModelState.IsValid)
            {
                if (menu.DishPhoto != null)
                {
                    string folder = "dish/dishpicture";
                    folder += Guid.NewGuid().ToString() + "-" + menu.DishPhoto.FileName;       //for uplodaing multiple images

                    menu.DishImageUrl = "/" + folder;
                    string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);    // used to recognise path during deployment 

                    menu.DishPhoto.CopyTo(new FileStream(serverFolder, FileMode.Create));
                }
                _imenubusiness.AddDish(menu);

                return RedirectToAction("AddNewDish", "Menu");

            }
            return View();
        }

        public IActionResult GetAllDishes()
        {
            var model = _imenubusiness.AllDishes();
            return View(model);
        }

        public ViewResult GetDishById(int DishID)
        {
            var data = _imenubusiness.GetDishById(DishID);
            return View(data);
        }
    }
}
