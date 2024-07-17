using System;
using System.Diagnostics;
using HotelFinder.Business.Abstract;
using HotelFinder.DatabaseContext.Abstract;
using HotelFinder.DatabaseContext.Concrete;
using HotelFinder.Entities;

namespace HotelFinder.Business.Concrete
{

    public class HotelManager : IHotelService
    {
        private IHotelRepository _hotelRepository;

        public HotelManager(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }


        public Hotel CreateHotel(Hotel hotel)
        {
            return _hotelRepository.CreateHotel(hotel);
        }

        public void DeleteHotel(int Id)
        {
            _hotelRepository.DeleteHotel(Id);
        }

        public List<Hotel> GetAllHotels()
        {
            return _hotelRepository.GetAllHotels();
        }

        public Hotel GetHotelById(int Id)
        {
            
            if (Id > 0)
            {
                return _hotelRepository.GetHotelById(Id);
               
            }
            throw new Exception("Id can not be less than 1");


        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            return _hotelRepository.UpdateHotel(hotel);
        }
    }
}

