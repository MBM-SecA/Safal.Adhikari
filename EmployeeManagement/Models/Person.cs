using System.Collections.Generic;
public class Person
{
    public string FirstName {get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; } = 'M';
    public double Salary { get; set; }

    public static List<Person> GetEmployees()
    {
         // Object initializer syntax
        Person emp1 = new Person() { FirstName = "Safal", Surname = "Adhikari", Address = "Bhaktapur", Salary = 20090.0 };
        Person emp2 = new Person() { FirstName = "James", Surname = "Bond", Address = "KTM", Salary = 12000.0 };
        Person emp3 = new Person() { FirstName = "John", Surname = "Wick", Address = "Bhaktapur", Salary = 223000.0 };
        Person emp4 = new Person() { FirstName = "Ram", Surname = "Shree", Address = "BKT", Salary = 203700.0 };
        Person emp5 = new Person() { FirstName = "Kurt", Surname = "Angle", Address = "Lalitpur", Salary = 19000.0 };
        Person emp6 = new Person() { FirstName = "William", Surname = "Shakespeare", Address = "Pokhara", Salary = 45000.0 };
        Person emp7 = new Person() { FirstName = "Jason", Surname = "Statham", Address = "Kavre", Salary = 62000.0 };

        List<Person> employees = new List<Person> {emp1, emp2, emp3, emp4, emp5, emp6, emp7};
        return employees;
    }
}