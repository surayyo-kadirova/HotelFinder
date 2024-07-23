using System;
using HotelFinder.Entities;


namespace HotelFinder.Business.Abstract
{
	public interface IHotelService
	{
		Task<List<Hotel>> GetAllHotels();

        Task<Hotel> GetHotelById(int Id);

        Task<Hotel> CreateHotel(Hotel hotel);

        Task<Hotel> UpdateHotel(Hotel hotel);

		Task DeleteHotel(int Id);

	}
}





