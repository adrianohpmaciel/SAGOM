using SAGOM.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.Interfaces
{
    public interface ICompanyService
    {
        Task<IEnumerable<CompanyDTO>?> GetCompaniesByName(string fantasyName);
        Task<CompanyDTO?> GetCompanyByCnpj(string cnpj);
        Task Add(CompanyDTO CompanyDTO);
        Task Update(CompanyDTO CompanyDTO);
        Task Remove(CompanyDTO CompanyDTO);
    }
}
