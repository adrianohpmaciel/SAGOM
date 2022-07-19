using AutoMapper;
using SAGOM.Application.DTOs;
using SAGOM.Application.Interfaces;
using SAGOM.Domain.Entities;
using SAGOM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.Services
{
    public class CompanyService : ICompanyService
    {
        private ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public CompanyService(ICompanyRepository companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CompanyDTO>?> GetCompaniesByName(string name)
        {
            var companysEntity = await _companyRepository.GetCompaniesByNameAsync(name);
            return _mapper.Map<IEnumerable<CompanyDTO>>(companysEntity);
        }

        public async Task<CompanyDTO?> GetCompanyByCnpj(string cnpj)
        {
            var companyEntity = await _companyRepository.GetCompanyByCnpjAsync(cnpj);
            return _mapper.Map<CompanyDTO>(companyEntity);
        }

        public async Task Add(CompanyDTO company)
        {
            var companyEntity = _mapper.Map<Company>(company);
            await _companyRepository.CreateAsync(companyEntity);
        }

        public async Task Update(CompanyDTO company)
        {
            var companyEntity = _mapper.Map<Company>(company);
            await _companyRepository.UpdateAsync(companyEntity);
        }

        public async Task Remove(CompanyDTO company)
        {
            var companyEntity = _mapper.Map<Company>(company);
            await _companyRepository.RemoveAsync(companyEntity);
        }
    }
}
