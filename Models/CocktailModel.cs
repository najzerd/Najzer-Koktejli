using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Najžer_RST_MAG_RNSUV_Projektna.Models
{
    public class CocktailModel
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Image Title")]
        [Required]
        public string ImageTitle { get; set; }
        [DisplayName("Cocktail Name")]
        [Required]
        public string CocktailName { get; set; }
        [DisplayName("Cocktail Price")]
        [Required]
        [Range(5,20,ErrorMessage = "Must be between 5 and 20")]
        public float CocktailPrice { get; set; }
    }
}
