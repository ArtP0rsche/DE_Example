using System;
using System.Collections.Generic;

namespace Store21WebApplication.Models;

public partial class User
{
    public int Id { get; set; }

    public string Role { get; set; } = null!;

    public string Fullname { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
