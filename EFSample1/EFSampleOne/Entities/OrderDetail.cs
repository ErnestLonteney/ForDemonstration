using System;
using System.Collections.Generic;

namespace EFSampleOne.Entities;

public partial class OrderDetail
{
    public int OrderId { get; set; }

    public short LineId { get; set; }

    public int? ProductId { get; set; }

    public short Qty { get; set; }

    public virtual Order Order { get; set; } = new();

    public virtual Product? Product { get; set; }
}
