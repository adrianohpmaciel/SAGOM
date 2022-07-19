using SAGOM.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Interfaces
{
    public interface IServiceService
    {
        Task<IEnumerable<ServiceDTO>?> GetServicesByName(string name);
        Task<ServiceDTO> GetServiceById(int idService);
        Task Add(ServiceDTO service);
        Task Update(ServiceDTO service);
        Task Remove(ServiceDTO service);
    }
}