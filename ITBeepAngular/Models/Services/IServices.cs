using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITBeepAngular.Models.Services
{
   public interface IServices
    {
        // Get All Employees
        Task<IEnumerable<ITBeepAngular.Data.Services.Services>> GetServices();
    }
}
