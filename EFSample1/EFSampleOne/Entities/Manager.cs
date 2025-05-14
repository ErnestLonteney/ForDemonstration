using System;
using System.Collections.Generic;

namespace EFSampleOne.Entities;

public partial class Manager
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Position { get; set; } = null!;

    public int? Department { get; set; }

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Department> DepartmentsNavigation { get; set; } = new List<Department>();
}
