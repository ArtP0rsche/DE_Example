using System;
using System.Collections.Generic;

namespace Store21WebApplication.Models;

public partial class OrderedProduct
{
    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public int Amount { get; set; }
}
