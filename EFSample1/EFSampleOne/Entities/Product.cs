using System;
using System.Collections.Generic;

namespace EFSampleOne.Entities;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal? Price { get; set; }

    public string? Code { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = [];
}
