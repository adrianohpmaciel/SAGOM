using SAGOM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Interfaces
{
    public interface IBillRepository
    {
        //Task<IEnumerable<Bill>?> GetBillsByReceiverCompanyAsync(Company company);
        //Task<IEnumerable<Bill>?> GetBillsByPayerAsync(Person payer);
        //Task<IEnumerable<Bill>?> GetBillsByPayerCompanyAsync(Company company);
        Task<IEnumerable<Bill>?> GetBillsByDate(DateTime data);
        Task<Bill?> GetBillByIdAsync(int id);
        Task<Bill> CreateAsync(Bill bill);
        Task<Bill?> UpdateAsync(Bill bill);
        Task<Bill?> RemoveAsync(Bill bill);
    }
}
