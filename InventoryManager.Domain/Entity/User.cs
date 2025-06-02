﻿using InventoryManager.Domain.Enums;

namespace InventoryManager.Domain.Entity
{
    public class User
    {
        public int Id { get; set; }

        public string FullName { get; set; }
        public string Email { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public UserRole Role { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;
    }
}
