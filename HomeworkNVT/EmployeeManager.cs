using System;
using System.Reflection;
using System.Reflection.Metadata;
using System.Xml.Serialization;

namespace HomeworkNVT
{
    public class EmployeeManager : BaseManager
    {
        public static int MAX = 10;
        private Employee[] employees;

        public EmployeeManager() : base()
        {
            //this.employees = new Employee[MAX];
            this.employees = new Employee[]{
                new Employee("E001", "hoangnm", "hoangnm@gmail.com"),
                new Employee("E002", "namph", "namph@gmail.com"),
                new Employee("E003", "minhnv", "minhnv@gmail.com"),
            };
        }

        public EmployeeManager(String name, Employee[] employees) : base(name)
        {
            //SetName(name);
            this.employees = employees;
        }

        //      public void ViewAll()
        //{
        //	Console.WriteLine("ViewAll");
        //	Console.WriteLine(BaseManager.VERSION);

        //	base.AddNew();
        //}

        public override void AddNew()
        {
            int UserChoice = 0;
            // Nhập thông tin nhân viên từ người dùng
            do
            {
                Console.Write("Enter employee No:");

                string UserNo = Console.ReadLine();

                Console.WriteLine("Enter employee name:");
                string UserName = Console.ReadLine();

                Console.WriteLine("Enter employee email:");
                string UserEmail = Console.ReadLine();

                Employee newUser = new(UserNo, UserName, UserEmail);

                AddEmployee(newUser);

                Console.WriteLine("***Danh sách nhân viên sau thêm***");
                PrintList(employees);

                Console.WriteLine("Bạn muốn tiếp tục không ? (Ấn 1 nếu tiếp, ấn 0 để trở lại menu");
                UserChoice = Convert.ToInt16(Console.ReadLine());
                
                
            } while (UserChoice != 0);
  
        }
        private void AddEmployee(Employee employee)
        {
            // Thêm nhân viên vào danh sách
            List<Employee> employeeAdd = new List<Employee>(employees);
            employeeAdd.Add(employee);
            employees = employeeAdd.ToArray();
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Delete()
        
        {
            int UserChoice1 = 0;
            do
            {
                //EmployeeManager manager = new EmployeeManager();
                Console.WriteLine("***Danh sách nhân viên hiện hữu***");
                PrintList(employees);

                Console.Write("Nhập mã số hoặc tên nhân viên muốn xóa:");
                string idxdel = Console.ReadLine();
                
                Employee[] updatedEmployees = new Employee[employees.Length - 1];
                int count = 0;

                for (int i = 0; i < employees.Length; i++)
                {
                    if (employees[i].GetNo() != idxdel || employees[i].GetName() != idxdel)
                    {
                        updatedEmployees[count] = employees[i];
                        count++;
                    }
                }

                employees = updatedEmployees;
                Console.WriteLine("***Danh sách nhân viên sau xóa***");
                PrintList(employees);
            
                Console.WriteLine("Bạn muốn tiếp tục không ? (Ấn 1 nếu tiếp, ấn 0 để trở lại menu");
                UserChoice1 = Convert.ToInt16(Console.ReadLine());
                    
                //else
                //    Console.WriteLine("Khong tim thay");
                    //return;

            } while (UserChoice1 != 0);

        }


        public override void Find()
        {
            Console.Write("Enter EmpNo or Name: ");
            String searchKey = Console.ReadLine();

            // search
            Employee[] result = new Employee[MAX];
            int count = 0;
            foreach (Employee emp in employees)
            {
                if (emp.GetNo().Equals(searchKey) || emp.GetName().Equals(searchKey))
                {
                    result[count++] = emp;
                    //count++;
                }
            }

            // print
            if (count > 0)
            {
                PrintList(result);
            }
            else
            {
                Console.WriteLine("Not Found!");
            }

        }

        private void PrintList(Employee[] arr)
        {
            foreach (Employee item in arr)
            {
                if (item != null)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}