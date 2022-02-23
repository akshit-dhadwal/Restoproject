using DIGITALMENU.MODEL;
using DIGITALMENU.REPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIGITALMENU.BUSINESS
{
    public class MenuBusiness:IMenuBusiness
    {
        private readonly IMenuRepo _imenurepo = null;

        public MenuBusiness(IMenuRepo imenurepo)
        {
            _imenurepo  = imenurepo;    
        }
        public bool AddDish(Menu menu)
        {

            return _imenurepo.AddDish(menu);
        }

        public List<Menu> AllDishes()
        {
            return _imenurepo.AllDishes();
        }
        public Menu GetDishById(int DishID)
        {
            return _imenurepo.GetDishById(DishID);
        }
    }
}
