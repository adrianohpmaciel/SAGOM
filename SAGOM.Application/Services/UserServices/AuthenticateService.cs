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
        public async Task<bool> SignUp(Employee employee, AuthenticateDTO authenticate)
        {
            var realAuthenticate = _mapper.Map<Authenticate>(authenticate);
            return await _authenticateRepository.RegisterUser(employee, realAuthenticate);
        }
        public async Task<bool> SignUp(Costumer costumer, AuthenticateDTO authenticate)
        {
            var realAuthenticate = _mapper.Map<Authenticate>(authenticate);
            return await _authenticateRepository.RegisterUser(costumer, realAuthenticate);
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
