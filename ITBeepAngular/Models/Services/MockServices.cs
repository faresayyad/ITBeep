using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITBeepAngular.Data;
using ITBeepAngular.Data.Services;
using Microsoft.EntityFrameworkCore;

namespace ITBeepAngular.Models.Services
{
    public class MockServices : IServices
    {
        private readonly ApplicationDbContext _dbContext;

        public MockServices(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Data.Services.Services>> GetServices()
        {
            return await _dbContext.services.ToListAsync();
        }
    }
}
