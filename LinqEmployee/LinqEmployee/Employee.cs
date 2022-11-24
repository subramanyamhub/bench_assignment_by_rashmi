using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEmployee
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }

        static void Main(string[] args)
        {


            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee() { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla",Title = "Manager", DOB = DateTime.Parse("16/11/1984"), DOJ=DateTime.Parse("8/6/2011"), City="Mumbai" });
            empList.Add(new Employee() { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = DateTime.Parse("20/08/1984"), DOJ = DateTime.Parse("7/7/2012"), City = "Mumbai" });
            empList.Add(new Employee() { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = DateTime.Parse("14/11/1987"), DOJ = DateTime.Parse("12/4/2015"), City = "Pune" });
            empList.Add(new Employee() { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = DateTime.Parse("3/6/1990"), DOJ = DateTime.Parse("2/2/2016"), City = "Pune" });
            empList.Add(new Employee() { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = DateTime.Parse("8/3/1991"), DOJ = DateTime.Parse("2/2/2016"), City = "Mumbai" });
            empList.Add(new Employee() { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = DateTime.Parse("7/11/1989"), DOJ = DateTime.Parse("8/8/2014"), City = "Chennai" });
            empList.Add(new Employee() { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = DateTime.Parse("2/12/1989"), DOJ = DateTime.Parse("1/6/2015"), City = "Mumbai" });
            empList.Add(new Employee() { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = DateTime.Parse("11/11/1993"), DOJ = DateTime.Parse("6/11/2014"), City = "Chennai" });
            empList.Add(new Employee() { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = DateTime.Parse("12/8/1992"), DOJ = DateTime.Parse("3/12/2014"), City = "Chennai" });
            empList.Add(new Employee() { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = DateTime.Parse("12/4/1991"), DOJ = DateTime.Parse("2/1/2016"), City = "Pune" });
            
            //  (a) - Display details of all employees - using LINQ Query Syntax

            var AllEmployees = from employee in empList
                               select employee;

            // iterating through the given list
            Console.WriteLine("Details of all employees are:");
            foreach (var s in AllEmployees)
            {
               
                Console.WriteLine(s.EmployeeID +"  "+ s.FirstName+ "  " + s.LastName+ "  " + s.Title+ "  " + s.DOB+ "  " + s.DOJ+ "  " + s.City);
            }

            Console.WriteLine("\n");

            
            // (b) - Display details of employee whose location is not Mumbai - using LINQ method syntax

            var NotMumbaiEmployees = empList.Where(emp => emp.City != "Mumbai").ToList();
            Console.WriteLine("Details of all employees whose location is not mumbai are:");
            foreach (var a in NotMumbaiEmployees)
            {
                
                Console.WriteLine(a.EmployeeID + " - " + a.FirstName + " - " + a.City);
            }

            Console.WriteLine("\n");

            
            // (c) - Display details of employee whose title is AsstManager

            var AsstManagerEmployee = from employee in empList
                                     where (employee.Title == "AsstManager")
                                     select employee;

            // iterate through the AsstManagerEmployee
            Console.WriteLine("Details of all employees whose title is AsstManager:");
            foreach (var r in AsstManagerEmployee)
            {
              
                Console.WriteLine(r.FirstName + " - " + r.Title + " - " + r.City);
            }

            Console.WriteLine("\n");

           
            // (d) - Display details of all the employees whose last name starts with s
            var LastNameSEmployees = from s in empList
                                     where s.LastName.ToLower().StartsWith("s")
                                     select s;
            // iteration
            Console.WriteLine("Details of all employees whose last name starts with s are:");
            foreach (var a in LastNameSEmployees)
            {
               
                Console.WriteLine(a.EmployeeID + "  " + a.FirstName + "  " + a.LastName + "  " + a.Title + "  " + a.DOB + "  " + a.DOJ + "  " + a.City);
            }


            Console.WriteLine("\n");

           
            // (e) - Display all the employees who have joined before 1/1/2015

            var emps = empList.Where(emp => emp.DOJ < new DateTime(2015, 1, 1)).ToList();

            //iteration through list
            Console.WriteLine("Details of all employees who have joined before 1/1/2015 are:");
            foreach (var t in emps)
            {
                
                Console.WriteLine(t.FirstName + " - " + t.DOJ);
            }

            Console.WriteLine("\n");

           
            // (f) - Display a list of all employee whose date of birth is after 1/1/1990

            var Emps = empList.Where(emp => emp.DOB > new DateTime(1990, 1, 1)).ToList();

            //iteration through list
            Console.WriteLine("Details of all employees whose date of birth is after 1/1/1990 are:");
            foreach ( var h in emps)
            {
                

                Console.WriteLine(h.FirstName + " " + h.DOB);
            }

            Console.WriteLine("\n");

            
            // (g) - Display a list of all employees whose designation is consultant and associate

            var employees = empList.Where(emp => (emp.Title.ToLower() == "consultant" && emp.Title.ToLower() == "associate")).ToList();

            // iterating through the list
            Console.WriteLine("Details of all employees whose designation is consultant and associate are:");
            foreach (var employee in employees)
            {

                Console.WriteLine(employee.FirstName + " - " + employee.Title);
            }

            Console.WriteLine("\n");

           
            // (h) - Display total count of all the employees

            var TotalEmployeeCount = empList.Count();

            //count of the employee
            Console.WriteLine("total count of all the employees are:");
            Console.WriteLine(TotalEmployeeCount);

            Console.WriteLine("\n");

            
            // (i) - Display a count of all employee belonging to Chennai

            var TotalChennaiEmployees = empList.Where(x => x.City.ToLower() == "chennai").Count();
            Console.WriteLine("total count of all employee belonging to Chennai  are:");
            Console.WriteLine(TotalChennaiEmployees);

            Console.WriteLine("\n");

            
            // (j) - Display highest employee id 

            var highestId = empList.Max(x => x.EmployeeID);
            Console.WriteLine(" highest employee id is:");
            Console.WriteLine(highestId);

            Console.WriteLine("\n");

            
            // (k) - Display total count of employees who joined after 1/1/2015

            var DjCount = empList.Where(x => x.DOJ > new DateTime(2015, 1, 1)).Count();

            Console.WriteLine("total count of employees who joined after 1 / 1 / 2015");
            Console.WriteLine(DjCount);

            Console.WriteLine("\n");

           
            // (l) - Display total number of employees who designation is not associate

            var NotAssociateCount = empList.Where(emp => emp.Title.ToLower() != "associate").Count();

            Console.WriteLine("total number of employees who designation is not associate");
            Console.WriteLine(NotAssociateCount);

            Console.WriteLine("\n");

            
            // (m) - Display total number of employees based on city

            var TotalBasedOnCity = empList.GroupBy(x => x.City).ToList();

            // iterating and showing city with toatal employee count
            Console.WriteLine("total number of employees based on city are:");
            foreach (var h in TotalBasedOnCity)
            {
             
                Console.WriteLine(h.Key + " - " + h.Count());
            }

            Console.WriteLine("\n");

           
            // (n) - Display a total number of employees based title

            var Employees = empList.GroupBy(x => x.Title).ToList();
            Console.WriteLine("total number of employees based on title");

            foreach (var x in Employees)
            {
                
                Console.WriteLine(x.Key + " - " + x.Count());
            }

            Console.WriteLine("\n");

            
            // (o) - Display the employee who is youngest

            var answer = empList.Min(x => x.DOB);

            Console.WriteLine("the employee who is youngest:");
            Console.WriteLine(answer);

            Console.ReadLine();
        }
        
    }
}
    

