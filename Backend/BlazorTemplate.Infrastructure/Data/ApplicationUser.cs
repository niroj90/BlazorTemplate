using BlazorTemplate.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorTemplate.Infrastructure.Data
{
    public class ApplicationUser : IdentityUser, IUser
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
    }
}
