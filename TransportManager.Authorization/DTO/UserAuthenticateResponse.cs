﻿using System;
using TransportManager.Common.Enums;

namespace TransportManager.Authorization.DTO
{
    public class UserAuthenticateResponse
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? SoftDeletedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Login { get; set; }
        public Role Role { get; set; }
        public string Token { get; set; }
    }
}
