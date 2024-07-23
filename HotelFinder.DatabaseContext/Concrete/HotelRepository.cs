using HotelFinder.DatabaseContext.Abstract;
using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelFinder.DatabaseContext.Concrete
{
    public class HotelRepository : IHotelRepository
    {
        public HotelDbContext hotelDbContext = new(); //context yaratmış olduk ve alttakı butun fonksuyonlaar görebilir.


        public async Task<List<Hotel>> GetAllHotels()
        {
            return await hotelDbContext.Hotels.ToListAsync();
        }

        public async Task<Hotel> GetHotelById(int Id)
        {
            return await hotelDbContext.Hotels.FirstOrDefaultAsync(h=>h.Id == Id);
        }

        public async Task<Hotel> CreateHotel(Hotel hotel)
        {
            hotelDbContext.Hotels.Add(hotel);
            await hotelDbContext.SaveChangesAsync();
            return hotel;
        }


        public async Task<Hotel> UpdateHotel(Hotel hotel)
        {

                hotelDbContext.Hotels.Update(hotel);
                await hotelDbContext.SaveChangesAsync();
                return hotel;


        }


        public async Task DeleteHotel(int Id)
        {
            var deletedHotel = await GetHotelById(Id);
            hotelDbContext.Hotels.Remove(deletedHotel);
            await hotelDbContext.SaveChangesAsync();
        }

    
  


    }
}

