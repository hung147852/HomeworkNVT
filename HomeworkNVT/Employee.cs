using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkNVT
{
    public class Employee
    {
        private String no;
        private String name;
        private String email;

        public Employee()
        {
        }

        public void SetNo(String no)
        {
            this.no = no;
        }
        //public void SetName(String name)
        //{
        //    this.name = name;
        //}
        //public void SetEmail(String email)
        //{
        //    this.email = email;
        //}
        public String GetNo()
        {
            return this.no;
        }

        public String GetName()
        {
            return this.name;
        }
        public String GetEmail()
        {
            return this.email;
        }
        public Employee(string no, string name, string email)
        {
            this.no = no;
            this.name = name;
            this.email = email;
        }

        public override string? ToString()
        {
            return no + ", " + name + ", " + email;
        }
    }
}
