using System;
using System.Web;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CosmeticEntities
{
    public class CosmeticDetails
    {
        [Key]
        public string Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Cosmetic title is Required")]
        public string CosmeticTitle { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Company is Required")]
        public string Company { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Category is Required")]
        public string Category { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Quantity is Required")]
        public int Quantity { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Price is Required")]
        public int price { get; set; }
    }
}
