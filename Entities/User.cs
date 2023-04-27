﻿namespace ComplaintRequestSystem.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string HashSalt { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string RoleId { get; set; }
    }
}