
using Microsoft.VisualBasic;
using System.Xml.Linq;
using static n2;

public partial class n2
{
    public class Department
    {
        public string departmentName;
        public int departmentNumber;
        public string headOfDepartment;
    }
    public class Employee
    {
        public string lastName;
        public string firstName;
        public string patronymic;
        public int age;
        public string department;
    }

    private static List<Employee> BuildList()
    {
        return new List<Employee>
        {
        { new Employee() { lastName = "Franc", firstName = "Tiplin", patronymic = "Gafer", age = 28, department = "financial"}},
        { new Employee() { lastName = "Urim", firstName = "Tram", patronymic = "Getter", age = 27, department = "financial"}},
        { new Employee() { lastName = "Glam", firstName = "Turin", patronymic = "Icon", age = 30, department = "work"}},
        { new Employee() { lastName = "Tack", firstName = "Liert", patronymic = "Stoger", age = 46, department = "work"}},
        { new Employee() { lastName = "Uyyim", firstName = "Tram", patronymic = "Gter", age = 27 , department = "financial"}},
        { new Employee() { lastName = "Taggk", firstName = "Liert", patronymic = "Sger", age = 36, department = "financial"}},
        { new Employee() { lastName = "Earm", firstName = "Kotlin", patronymic = "Stoger", age = 20 , department = "work"}}
        };
    }
   
    public static void Main()
    {
        var financial = new Department() { departmentName = "financial", departmentNumber = 1, headOfDepartment = "Franc" };
        var work = new Department() { departmentName = "work", departmentNumber = 2, headOfDepartment = "Glam" };

        List<Employee> employee = BuildList();

        var employeeFinancial = (from p in employee
                                where p.department == financial.departmentName
                                select p).ToList();

        var employeeWork = (from p in employee
                           where p.department == work.departmentName
                           select p).ToList();



        var n = new Dictionary<string, List<Employee>>();

        n.Add(financial.departmentName, employeeFinancial);
        n.Add(work.departmentName, employeeWork);

        foreach (var p in n)
        {
            foreach(var l in p.Value)
            Console.WriteLine(p.Key + " " + l.department);
        }
       
    }

    
}




