using InventoryManager.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Application.Interface
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}
