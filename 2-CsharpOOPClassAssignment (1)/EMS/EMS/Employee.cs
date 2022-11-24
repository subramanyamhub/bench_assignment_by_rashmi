using System;

namespace EMS
{
    public class Employee
    {
        private int EmpNo;
        private string EmpName;
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;

        public void EmployeeDetails()
        {
            Console.WriteLine("Enter your Employee Number: ");
            EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Employee Name: ");
            EmpName = Console.ReadLine();
            Console.WriteLine("Enter your EmployeeSalary: ");
            Salary = Convert.ToDouble(Console.ReadLine());

            try
            {
                if (Salary <= 0)
                {
                    throw new Exception();
                }
                if (Salary < 5000)
                {
                    HRA = Salary * 10 / 100; TA = Salary * 5 / 100; DA = Salary * 15 / 100;
                }
                else if (Salary > 5000 && Salary < 10000)
                {
                    HRA = Salary * 15 / 100; TA = Salary * 10 / 100; DA = Salary * 20 / 100;


                }
                else if (Salary > 10000 && Salary < 15000)
                {
                    HRA = Salary * 20 / 100; TA = Salary * 15 / 100; DA = Salary * 25 / 100;


                }
                else if (Salary > 15000 && Salary < 20000)
                {
                    HRA = Salary * 25 / 100; TA = Salary * 20 / 100; DA = Salary * 30 / 100;


                }
                else
                {
                    HRA = Salary * 30 / 100; TA = Salary * 25 / 100; DA = Salary * 35 / 100;


                }
                GrossSalary = Salary + HRA + TA + DA;
                CalculateSalary(GrossSalary);

            }

            catch (Exception ex)
            {
                Console.WriteLine("Give a proper salary ");


            }
        }
        public void CalculateSalary(double GrossSalary)
        {
            PF = GrossSalary * 10 / 100;
            TDS = GrossSalary * 18 / 100;
            NetSalary = GrossSalary - (PF + TDS);
            DisplaySalary(GrossSalary, PF, TDS, NetSalary);


        }
        public void DisplaySalary(double GrossSalary, double PF, double TDS, double NetSalary)
        {
            Console.WriteLine(" salary is " + GrossSalary);
            Console.WriteLine("PF is " + PF);
            Console.WriteLine("TDS is " + TDS);
            Console.WriteLine("NET Salary is " + NetSalary);
        }
    }




}

