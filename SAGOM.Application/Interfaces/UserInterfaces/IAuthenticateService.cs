using Microsoft.AspNetCore.Identity;
using SAGOM.Application.DTOs;
using SAGOM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.Interfaces.UserInterfaces
{
    public interface IAuthenticateService
    {
        Task<bool> Login(AuthenticateDTO authenticate);
        Task<bool> SignUp(EmployeeDTO employee, AuthenticateDTO authenticate);
        Task<bool> SignUp(CostumerDTO costumer, AuthenticateDTO authenticate);
        Task Logout();
        Task<bool> AddRole(string name);
    }
}
