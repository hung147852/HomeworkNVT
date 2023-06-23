using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkNVT
{
    public class BaseManager
    {
        public static String VERSION = "1.0";


        private String name;



        public BaseManager()
        {
            Console.WriteLine("Init BaseManager");
            this.name = "Unknown";
        }

        public BaseManager(String name)
        {
            Console.WriteLine("Init BaseManager With name");
            this.name = name;
        }

        // Getter
        public String GetName()
        {
            return this.name;
        }

        // Setter
        public void SetName(String name)
        {
            this.name = name;
        }

        public virtual void AddNew()
        {
            Console.WriteLine("AddNew");
        }

        public virtual void Update()
        {
            Console.WriteLine("Update");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Delete");
        }

        public virtual void Find()
        {
            Console.WriteLine("Find");
        }
    }
}
