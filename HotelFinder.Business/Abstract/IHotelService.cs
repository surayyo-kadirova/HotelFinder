using System;
using HotelFinder.Entities;


namespace HotelFinder.Business.Abstract
{
	public interface IHotelService
	{
		List<Hotel> GetAllHotels();
        Hotel GetHotelById(int Id);
		Hotel CreateHotel(Hotel hotel);
		Hotel UpdateHotel(Hotel hotel);
		void DeleteHotel(int Id);

	}
}

