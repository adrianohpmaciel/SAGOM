using AutoMapper;
using SAGOM.Application.DTOs;
using SAGOM.Application.Interfaces.UserInterfaces;
using SAGOM.Domain.AccountInterfaces;
using SAGOM.Domain.Entities;

namespace SAGOM.Application.Services.UserServices
{
    public class AuthenticateService : IAuthenticateService
    {
        private readonly IAuthenticateRepository _authenticateRepository;
        private readonly IMapper _mapper;

        public AuthenticateService(IAuthenticateRepository authenticateRepository, IMapper mapper)
        {
            _authenticateRepository = authenticateRepository;
            _mapper = mapper;
        }

        public async Task<bool> Login(AuthenticateDTO authenticate)
        {
            var realAuthenticate = _mapper.Map<Authenticate>(authenticate);
            return await _authenticateRepository.Authenticate(realAuthenticate);
        }
        public async Task<bool> SignUp(EmployeeDTO employee, AuthenticateDTO authenticate)           
        {
            var realEmployee = _mapper.Map<Employee>(employee);
            var realAuthenticate = _mapper.Map<Authenticate>(authenticate);
            return await _authenticateRepository.RegisterUser(realEmployee, realAuthenticate);
        }
        public async Task<bool> SignUp(CostumerDTO costumer, AuthenticateDTO authenticate)
        {
            var realCostumer = _mapper.Map<Costumer>(costumer);
            var realAuthenticate = _mapper.Map<Authenticate>(authenticate);
            return await _authenticateRepository.RegisterUser(realCostumer, realAuthenticate);
        }
        public async Task Logout()
        {
            await _authenticateRepository.Logout();
        }
        public async Task<bool> AddRole(string name)
        {
            return await _authenticateRepository.RegisterRole(name);
        }
    }
}
