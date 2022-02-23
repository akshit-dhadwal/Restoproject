using DIGITALMENU.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIGITALMENU.BUSINESS
{
    public interface IMenuBusiness
    {
        bool AddDish(Menu menu);

        List<Menu> AllDishes();

        Menu GetDishById(int DishID);
    }
}
