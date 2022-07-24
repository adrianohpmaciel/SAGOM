using SAGOM.Domain.AccountInterfaces;
using Microsoft.AspNetCore.Identity;
using SAGOM.Infra.Data.Identity;
using System.Threading.Tasks;
using SAGOM.Domain.Entities;

namespace SAGOM.Infra.Data.Repositories
{
    public class AuthenticateRepository : IAuthenticateRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly PersonRepository _personRepository;
        private readonly CostumerRepository _costumerRepository;
        private readonly EmployeeRepository _employeeRepository;

        public AuthenticateRepository(SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, PersonRepository personRepository, CostumerRepository costumerRepository, EmployeeRepository employeeRepository)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
            _personRepository = personRepository;
            _costumerRepository = costumerRepository;
            _employeeRepository = employeeRepository;
        }

        public async Task<bool> UserExists(Costumer costumer)
        {
            var exists = await _userManager.FindByEmailAsync(costumer.CpfNavigation.Email);
            return exists != null;
        }
        public async Task<bool> UserExists(Employee employee)
        {
            var exists = await _userManager.FindByEmailAsync(employee.CpfNavigation.Email);
            return exists != null;
        }

        #region Authenticate Operations (to users)
        public async Task<bool> Authenticate(Authenticate authenticate)
        {
            var result = await _signInManager.PasswordSignInAsync(authenticate.Email,
                authenticate.Password, false, lockoutOnFailure: false);

            return result.Succeeded;
        }

        public async Task<bool> RegisterUser(Employee employee, Authenticate authenticate)
        {
            if (await UserExists(employee))
                return false;

            var applicationUser = new ApplicationUser
            {
                UserName = authenticate.Email,
                Email = authenticate.Email
            };

            if (!CheckExistenceRoleByName(authenticate.RoleName).Result)
                return false;

            var result = await _userManager.CreateAsync(applicationUser, authenticate.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(applicationUser, authenticate.RoleName.Trim().ToLower());
                var person = await _personRepository.CreateAsync(employee.CpfNavigation);
                employee.CpfNavigation = person;
                await _employeeRepository.CreateAsync(employee);

                await _signInManager.SignInAsync(applicationUser, isPersistent: false);
            }
            return result.Succeeded;
        }

        public async Task<bool> RegisterUser(Costumer costumer, Authenticate authenticate)
        {
            if (await UserExists(costumer))
                return false;

            var applicationUser = new ApplicationUser
            {
                UserName = authenticate.Email,
                Email = authenticate.Email
            };

            var result = await _userManager.CreateAsync(applicationUser, authenticate.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(applicationUser, "costumer");
                var person = await _personRepository.CreateAsync(costumer.CpfNavigation);
                costumer.CpfNavigation = person;
                await _costumerRepository.CreateAsync(costumer);

                await _signInManager.SignInAsync(applicationUser, isPersistent: false);
            }
            return result.Succeeded;
        }

        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }
        #endregion

        public async Task<bool> CheckExistenceRoleByName(string name)
        {
            var exists = await _roleManager.RoleExistsAsync(name.Trim().ToLower());
            return exists;
        }

        #region Role operations
        public async Task<bool> RegisterRole(string name)
        {
            bool roleExists = await CheckExistenceRoleByName(name);

            if (!roleExists)
            {
                IdentityRole role = new IdentityRole();
                role.Name = name.Trim().ToLower();
                role.NormalizedName = name.Trim().ToUpper();
                var roleResult = await _roleManager.CreateAsync(role);

                return roleResult.Succeeded;
            }

            return false;

        }
        #endregion
    }
}
