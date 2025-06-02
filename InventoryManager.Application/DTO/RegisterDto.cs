using InventoryManager.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Application.DTO
{
    public class RegisterDto
    {
        public string FullName { get; set; } = "";

        public string Email { get; set; } = "";

        public string Password { get; set; } = "";

        public UserRole Role { get; set; } = UserRole.User;
    }
}
