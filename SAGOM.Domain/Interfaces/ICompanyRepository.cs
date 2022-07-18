using SAGOM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Interfaces
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> GetAllCompanyAsync();
        Task<IEnumerable<Company>> GetAllCompanyByNameAsync(string fantasyName);
        Task<IEnumerable<Company>> GetCompanyByCnpjAsync(string cnpj);
        Task<IEnumerable<Company>> CreateAsync(Company company);
        Task<IEnumerable<Company>> UpdateAsync(Company company);
        Task<IEnumerable<Company>> RemoveAsync(Company company);
    }
}
