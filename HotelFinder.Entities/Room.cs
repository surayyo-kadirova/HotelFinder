using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelFinder.Entities
{

    public class Room
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string RoomType { get; set; }

        public bool IsAvailable { get; set; }

        //public ICollection<HotelRoom> Hotels { get; set; }




    }
}

