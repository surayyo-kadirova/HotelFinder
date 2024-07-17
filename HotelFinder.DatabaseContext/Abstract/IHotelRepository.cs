using System;
using HotelFinder.Entities;


namespace HotelFinder.DatabaseContext.Abstract
{
	public interface IHotelRepository
	{
		List<Hotel> GetAllHotels();

		Hotel GetHotelById(int Id);

		Hotel CreateHotel(Hotel hotel);

		Hotel UpdateHotel(Hotel hotel);

        void DeleteHotel(int Id);
	}
}

