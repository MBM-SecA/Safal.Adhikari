using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Person
{
    public int Id {get; set; }

    [Required]
    [Display(Name = "First Name")]
    public string FirstName {get; set; }

    [Required(ErrorMessage="We need Last Name")]
    [Display(Name = "Last Name")]
    public string Surname { get; set; }
    public string Address { get; set; }
    public char? Gender { get; set; } = 'M';
    public double? Salary { get; set; }

    public static List<Person> GetEmployees()
    {
        // Object initializer syntax
        Person emp1 = new Person() { Id = 1, FirstName = "Safal", Surname = "Adhikari", Address = "Bhaktapur", Salary = 20090.0 };
        Person emp2 = new Person() { Id = 2, FirstName = "James", Surname = "Bond", Address = "KTM", Salary = 12000.0 };
        Person emp3 = new Person() { Id = 3, FirstName = "John", Surname = "Wick", Address = "Bhaktapur", Salary = 223000.0 };
        Person emp4 = new Person() { Id = 4, FirstName = "Ram", Surname = "Shree", Address = "BKT", Salary = 203700.0 };
        Person emp5 = new Person() { Id = 5, FirstName = "Kurt", Surname = "Angle", Address = "Lalitpur", Salary = 19000.0 };
        Person emp6 = new Person() { Id = 6, FirstName = "William", Surname = "Shakespeare", Address = "Pokhara", Salary = 45000.0 };
        Person emp7 = new Person() { Id = 7, FirstName = "Jason", Surname = "Statham", Address = "Kavre", Salary = 62000.0 };

        List<Person> employees = new List<Person> {emp1, emp2, emp3, emp4, emp5, emp6, emp7};
        return employees;
    }
}