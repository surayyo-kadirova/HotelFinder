using System;
using System.Diagnostics;
using HotelFinder.Business.Abstract;
using HotelFinder.DatabaseContext;
using HotelFinder.DatabaseContext.Abstract;
using HotelFinder.DatabaseContext.Concrete;
using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelFinder.Business.Concrete
{

    public class HotelManager : IHotelService
    {
        private IHotelRepository _hotelRepository;

        public HotelManager(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }


        public async Task<Hotel> CreateHotel(Hotel hotel)
        {
            return await _hotelRepository.CreateHotel(hotel);
        }

        public async Task DeleteHotel(int Id)
        {
           if (Id >= 0)
           {
               await  _hotelRepository.DeleteHotel(Id);

           }
           else
           {
                throw new Exception("Id can not be less than 1");
           }
           
        }

        public async Task<List<Hotel>> GetAllHotels()
        {
            return await _hotelRepository.GetAllHotels();

        }


        public async Task<Hotel> GetHotelById(int Id)
        {

            if (Id >= 0)
            {
                return await  _hotelRepository.GetHotelById(Id);

            }

            else
            {
                throw new Exception("Id can not be less than 1");
            }

        }


        public async Task<Hotel> UpdateHotel(Hotel hotel)
        {
            return await _hotelRepository.UpdateHotel(hotel);
        }

    }
}
