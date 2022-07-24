using AutoMapper;
using SAGOM.Application.DTOs;
using SAGOM.Application.Interfaces.UserInterfaces;
using SAGOM.Domain.Entities;
using SAGOM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.Services.UserServices
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EmployeeDTO>?> GetEmployeesByName(string name)
        {
            var employeesEntity = await _employeeRepository.GetEmployeesByNameAsync(name);
            return _mapper.Map<IEnumerable<EmployeeDTO>>(employeesEntity);
        }

        public async Task<EmployeeDTO?> GetEmployeeByCpf(string cpf)
        {
            var employeeEntity = await _employeeRepository.GetEmployeeByCpfAsync(cpf);
            return _mapper.Map<EmployeeDTO>(employeeEntity);
        }

        public async Task Add(EmployeeDTO employee)
        {
            var employeeEntity = _mapper.Map<Employee>(employee);
            await _employeeRepository.CreateAsync(employeeEntity);
        }

        public async Task Update(EmployeeDTO employee)
        {
            var employeeEntity = _mapper.Map<Employee>(employee);
            await _employeeRepository.UpdateAsync(employeeEntity);
        }

        public async Task Remove(EmployeeDTO employee)
        {
            var employeeEntity = _mapper.Map<Employee>(employee);
            await _employeeRepository.RemoveAsync(employeeEntity);
        }
    }
}
