using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Najžer_RST_MAG_RNSUV_Projektna.Models
{
    public class OrderModel
    {
        [Key]
        public int OrderId { get; set; }
        public string CocktailName { get; set; }
        public float CocktailPrice { get; set; }
    }
}
