﻿using CarRentalsBlazorEcho.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRentalsBlazorEcho.Data
{
    public class CarPictureRepository : ICarPicture
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CarPictureRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task AddAsync(CarPicture picture)
        {
            _applicationDbContext.CarPictures.Add(picture);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(CarPicture picture)
        {
            _applicationDbContext?.CarPictures.Remove(picture);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task <IEnumerable<CarPicture>> GetAllByCarIdAsync(int id)
        {
            return await _applicationDbContext.CarPictures.Where(p => p.CarId == id).ToListAsync();
        }

        public async Task<IEnumerable<CarPicture>> GetAllAsync()
        {
            return await _applicationDbContext.CarPictures.OrderBy(c => c.Id).ToListAsync();
        }
    }
}
