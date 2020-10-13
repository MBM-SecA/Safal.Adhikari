using System.Linq;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        var employees = Person.GetEmployees();
       
        return View(employees);
    }

    public ActionResult Detail( string firstName)
    {
        var employees = Person.GetEmployees();
        var employee = employees.FirstOrDefault(x => x.FirstName == firstName);

        return View(employee);
    }
}


