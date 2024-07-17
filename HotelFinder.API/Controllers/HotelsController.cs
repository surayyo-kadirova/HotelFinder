using HotelFinder.Business.Abstract;
using HotelFinder.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : Controller
    {
        private IHotelService _hotelService;

        public HotelsController(IHotelService hotelService)
        {
            _hotelService = hotelService; 
        }

        [HttpGet]
        public List<Hotel> Get()
        {
            return _hotelService.GetAllHotels();
        }

        [HttpGet("{Id}")]
        public Hotel Get(int Id)
        {
            return _hotelService.GetHotelById(Id);
        }

        [HttpPost]
        public Hotel Post([FromBody]Hotel hotel)
        {
            return _hotelService.CreateHotel(hotel);
        }

        [HttpPut]
        public Hotel Put([FromBody]Hotel hotel)
        {
            return _hotelService.UpdateHotel(hotel);
        }

        [HttpDelete("{Id}")]
        public void Delete(int Id)
        {
            _hotelService.DeleteHotel(Id);
        }

      
    }
}

