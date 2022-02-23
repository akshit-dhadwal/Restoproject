using DIGITALMENU.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIGITALMENU.REPO
{
    public class MenuRepo:IMenuRepo
    {
        private readonly MigrationContext _context = null;

        public MenuRepo(MigrationContext context)
        {
            _context = context;
        }
        public bool AddDish(Menu menu)
        {
            var newdish = new Menu()
            {
                DishCategory = menu.DishCategory,
                DishName = menu.DishName,
                DishDescription = menu.DishDescription,
                DishType = menu.DishType,
                DishPrice = menu.DishPrice,
                DishQuantity = menu.DishQuantity,
                DishImageUrl = menu.DishImageUrl,
                CreatedOn = DateTime.UtcNow
            };
            _context.Add(newdish);
            _context.SaveChanges();
            return true;
        }

        public Menu GetDishById(int DishID)
        {
            return  _context.Menus.Find(DishID);
            //if (menuid != null)
            //{
            //    var dish = new Menu()
            //    {
            //       DishID = menuid.DishID,
            //        DishName = menuid.DishName,
            //        DishCategory = menuid.DishCategory,
            //        DishDescription = menuid.DishDescription,
            //        DishImageUrl = menuid.DishImageUrl,
            //        DishPrice = menuid.DishPrice,
            //        DishQuantity = menuid.DishQuantity,
            //        DishType = menuid.DishType,

            //    };
            //    return dish;

            //}
            //return null;
        }

        public List<Menu> AllDishes()
        {
            return _context.Menus.Select(menu => new Menu()
            {
                DishName= menu.DishName,
                DishCategory= menu.DishCategory,
                DishType= menu.DishType,    
                DishDescription= menu.DishDescription,
                DishPrice= menu.DishPrice,  
                DishQuantity= menu.DishQuantity,
                DishImageUrl= menu.DishImageUrl,
                DishID = menu.DishID

            }).ToList();
            
        }

        //public bool Update(Menu menu, int DishID)
        //{
            


        //    return true;
        //}
    }
}
