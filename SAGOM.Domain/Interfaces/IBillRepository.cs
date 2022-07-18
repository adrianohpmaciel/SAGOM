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
        Task<IEnumerable<Bill>> GetBillsAsync();
        Task<IEnumerable<Bill>> GetBillsByReceiverCompanyAsync(Company company);
        Task<IEnumerable<Bill>> GetBillsByPayerAsync(Person payer);
        Task<IEnumerable<Bill>> GetBillsByPayerCompanyAsync(Company company);
        Task<IEnumerable<Bill>> GetBillsByData(DateTime data);
        Task<IEnumerable<Bill>> GetBillByIdAsync(int id);
        Task<IEnumerable<Bill>> CreateAsync(Bill bill);
        Task<IEnumerable<Bill>> UpdateAsync(Bill bill);
        Task<IEnumerable<Bill>> RemoveAsync(Bill bill);
    }
}
