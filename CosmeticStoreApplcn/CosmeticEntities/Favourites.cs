using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CosmeticEntities
{
    public class Favourites
    {
        [ForeignKey("Id")]
        public string Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Cosmetic title is Required")]
        public CosmeticDetails cosmeticDetails{ get; set; }
   } 
}
