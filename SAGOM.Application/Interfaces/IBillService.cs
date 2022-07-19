using SAGOM.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.Interfaces
{
    public interface IBillService
    {
        Task<IEnumerable<BillDTO>?> GetBillsByDate(DateTime data);
        Task<BillDTO?> GetBillById(int id);
        Task Add(BillDTO bill);
        Task Update(BillDTO bill);
        Task Remove(BillDTO bill);
    }
}
