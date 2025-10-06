using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorTemplate.Domain.Entities
{
    public interface IUser
    {
        string Username { get; set; }
        string Password { get; set; }

    }
}
