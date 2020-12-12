using System;
using System.Collections.Generic;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }

    public List<Employee> Employees { get; set; }
}
