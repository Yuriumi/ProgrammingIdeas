using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 迪米特原则_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HeadOfficeEmployeeManager headOfficeEmployeeManager = new HeadOfficeEmployeeManager();
            BranchOfficeEmployeeManager branchOfficeEmployeeManager = new BranchOfficeEmployeeManager();
            headOfficeEmployeeManager.PrintOfficeEmployee();

            Console.ReadKey();
        }
    }

    public class HeadOfficeEmployee
    {
        public int ID { get; set; }

    }

    public class BranchOfficeEmployee
    {
        public int ID { get; set; }
    }

    public class HeadOfficeEmployeeManager
    {
        public List<HeadOfficeEmployee> GetHeadOfficeEmployees()
        {
            List<HeadOfficeEmployee> headOfficeEmployees = new List<HeadOfficeEmployee>();

            for (int i = 0; i < 10; i++)
            {
                HeadOfficeEmployee employee = new HeadOfficeEmployee();
                employee.ID = i;
                headOfficeEmployees.Add(employee);
            }

            return headOfficeEmployees;
        }

        public void PrintOfficeEmployee()
        {
            Console.WriteLine("总公司的员工ID为");
            foreach (var item in GetHeadOfficeEmployees())
            {
                Console.WriteLine(item.ID);
            }
        }
    }
    
    public class BranchOfficeEmployeeManager
    {
        public List<BranchOfficeEmployee> GetBranchOfficeEmployees()
        {
            List<BranchOfficeEmployee> branchOfficeEmployees = new List<BranchOfficeEmployee>();

            for (int i = 0; i < 5; i++)
            {
                BranchOfficeEmployee employee = new BranchOfficeEmployee();
                employee.ID = i;
                branchOfficeEmployees.Add(employee);
            }

            return branchOfficeEmployees;
        }

        public void PrintOfficeEmployee()
        {
            Console.WriteLine("分公司的员工ID为");
            foreach (var item in GetBranchOfficeEmployees())
            {
                Console.WriteLine(item.ID);
            }
        }
    }
}
