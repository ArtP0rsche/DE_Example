using System;
using System.Collections.Generic;

namespace Store21WebApplication.Models;

public partial class Provider
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
