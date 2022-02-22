// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//using EmployeeManagement.Staff;
//using EmployeeManagement.Department;

using EmployeeManagement.Employee;
using EmployeeManagement.Department;
using System.Collections;

static String ObtainDateStamp(DateTime value)
{
    return value.ToString("yyyyMMdd");
}

Department db1 = new Department();

String timeStamp = ObtainDateStamp(DateTime.Now);

db1.Departments = new string[] { "research", "sales", "accounting", "finance", "engineering", "admin"};

db1.JobTitles = new string[] { "Engineer", "Sales Executive", "Program Manager",
    "Product Manager", "Accountant", "Auditor", "Manager", "Senior Manger", "GM", "MD", "CTO", "ED",
"executive", "Clerk", "Technician"};

//String timeStamp = GetTimestamp(DateTime.Now); 

//staf id, name and date of employment
Employee employee1 = new Employee(100, "Grace Alika", timeStamp);
Employee employee2 = new Employee(101, "Musa Badru",  timeStamp);
Employee employee3 = new Employee(102, "Ogbonna Nkamuke", timeStamp);
Employee employee4 = new Employee(103, "Obi Uma Akapbio", timeStamp);
Employee employee5 = new Employee(104, "Augustine Sola", timeStamp);
//department
employee1.Department = db1.Departments[4];
employee2.Department = db1.Departments[1];
employee3.Department = db1.Departments[4];
employee4.Department = db1.Departments[4];
employee5.Department = db1.Departments[5];

//job title
employee1.JobTitle = db1.JobTitles[0];
employee2.JobTitle = db1.JobTitles[1];
employee3.JobTitle = db1.JobTitles[2];
employee4.JobTitle = db1.JobTitles[3];
employee5.JobTitle = db1.JobTitles[4];
//Store all 5 employees in an array of employees

ArrayList employees = new ArrayList();

employees.Add(employee1);
employees.Add(employee2);
employees.Add(employee3);
employees.Add(employee4);
employees.Add(employee5);


foreach (object obj in employees)
{   
    Console.WriteLine(obj);
}




