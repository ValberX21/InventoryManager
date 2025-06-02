using InventoryManager.Application.DTO;
using InventoryManager.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Application.Interface
{
    public interface IAuthService
    {
        /// <summary>
        /// Authenticates a user and returns a JWT token if valid.
        /// </summary>
        Task<string> LoginAsync(LoginDto loginDto);

        /// <summary>
        /// Registers a new user and returns a success flag.
        /// </summary>
        Task<User> RegisterAsync(RegisterDto registerDto);
    }
}
