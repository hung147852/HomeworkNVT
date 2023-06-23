using System.Xml.Linq;

namespace HomeworkNVT;

class Program
{
    static void Main(string[] args)
    {
        int selected;
        EmployeeManager manager = new EmployeeManager();
        do
        {
            Console.WriteLine("***EMPLOYEE MANAGER***");
            Console.WriteLine("1. Search Employee by Name or EmpNo");
            Console.WriteLine("2. Add New Employee");
            Console.WriteLine("3. Update Employee");
            Console.WriteLine("4. Delete Employee");
            Console.WriteLine("5. Exit");
            Console.Write("   Select (1-5): ");
            selected = Convert.ToInt16(Console.ReadLine());

            switch (selected)
            {
                case 1:
                    manager.Find();
                    break;
                case 2:
                    manager.AddNew();
                    break;
                case 3:
                    manager.Update();
                    break;
                case 4:
                    manager.Delete();
                    break;
                case 5:
                    Console.WriteLine("-------- END ---------");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        } while (selected != 5);

        Console.ReadLine();
    }
}