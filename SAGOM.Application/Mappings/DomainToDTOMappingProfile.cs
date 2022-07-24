using AutoMapper;
using SAGOM.Application.DTOs;
using SAGOM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Authenticate, AuthenticateDTO>().ReverseMap();
            CreateMap<Bill, BillDTO>().ReverseMap();
            CreateMap<Company, CompanyDTO>().ReverseMap();
            CreateMap<Costumer, CostumerDTO>().ReverseMap();
            CreateMap<CostumerService, CostumerDTO>().ReverseMap();
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<Person, PersonDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Role, RoleDTO>().ReverseMap();
            CreateMap<Service, ServiceDTO>().ReverseMap();
            CreateMap<ServiceOrder, ServiceOrderDTO>().ReverseMap();
            CreateMap<Tool, ToolDTO>().ReverseMap();
            CreateMap<Vehicle, VehicleDTO>().ReverseMap();

        }

    }
}
