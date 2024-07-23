using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace HotelFinder.Entities {

    public class Hotel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [StringLength(15)]
        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public float Rating { get; set; }

        [Required]
        public string Email { get; set; }

        //public Address Address { get; set; }

        //public ICollection<HotelRoom> Rooms { get; set; }
        
    }

}


