using System;
using System.Collections.Generic;

namespace EFSampleOne.Entities;

public partial class CustomerAddress
{
    public Guid CustomerId { get; set; }

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public string Number { get; set; } = null!;

    public short? SecondNumber { get; set; }

    public string? Description { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
