using System.ComponentModel.DataAnnotations;

namespace API.Models.Dtos
{
    public class VillaNumberUpdateDTO
    {
        [Required]
        public int VillaNo { get; set; }

        [Required]
        public int VillaID { get; set; }
        public string SpecialDetail { get; set; }

    }
}
