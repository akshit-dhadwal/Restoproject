using System;
using System.Collections.Generic;

#nullable disable

namespace DIGITALMENU.MODEL.Entities
{
    public partial class DishMenu
    {
        public int DishId { get; set; }
        public string DishName { get; set; }
        public string DishDescription { get; set; }
        public int? DishPrice { get; set; }
        public string DishCategory { get; set; }
        public int? DishType { get; set; }
        public int? DishQuantity { get; set; }
        public string DishImageUrl { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
