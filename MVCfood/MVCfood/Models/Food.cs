using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCfood.Models
{
    public class Food
    {
        [Key]
        public int foodID { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Description ="Food description")]
        [StringLength(30,ErrorMessage ="Te pasaste choco solo 30 caracteres", MinimumLength =5)]
        public string Description { get; set; }


    }
}