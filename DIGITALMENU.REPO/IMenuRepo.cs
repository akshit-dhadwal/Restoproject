using DIGITALMENU.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIGITALMENU.REPO
{
    public interface IMenuRepo
    {
        bool AddDish(Menu menu);

        List<Menu> AllDishes();

        Menu GetDishById(int DishID);

        //bool Update(Menu nenu, int DishID);


    }
}
