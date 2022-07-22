﻿// MACORATTI, JOSÉ CARLOS. Curso Clean Architecture Essencial. Disponível em: https://www.udemy.com/course/clean-architecture-essencial-asp-net-core-com-c/. Acesso em: 20 jul. 2022.

namespace SAGOM.Domain.Account
{
    public interface ISeedUserRoleInitial
    {
        void SeedUsers();
        void SeedRoles();
    }
}