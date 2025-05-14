using System;
using System.Collections.Generic;

namespace EFSampleOne.Entities;

public partial class Order
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public Guid? CustomerId { get; set; }

    public int? ManagerId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Manager? Manager { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
