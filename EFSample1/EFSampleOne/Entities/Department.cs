using System;
using System.Collections.Generic;

namespace EFSampleOne.Entities;

public partial class Department
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? Head { get; set; }

    public virtual Manager? HeadNavigation { get; set; }

    public virtual ICollection<Manager> Managers { get; set; } = new List<Manager>();
}
