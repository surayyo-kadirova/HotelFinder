using System;
using HotelFinder.Entities;


namespace HotelFinder.DatabaseContext.Abstract
{
	public interface IHotelRepository
	{
		Task<List<Hotel>> GetAllHotels();

		Task<Hotel> GetHotelById(int Id);

        Task<Hotel> CreateHotel(Hotel hotel);

        Task<Hotel> UpdateHotel(Hotel hotel);

        Task DeleteHotel(int Id);   //void olan method olduğu için herhangi bir tip belirtmiyoruz
	}
}

