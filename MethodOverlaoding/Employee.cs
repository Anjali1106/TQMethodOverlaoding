using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverlaoding
{

    // 2. WAP to overload constructor in Employee class
    internal class Employee
    {
        private int eid;
        private string ename;
        private int esal;

        public Employee(int id, string name, int sal) { 
            this.eid = id;
            this.ename = name;
            this.esal = sal;
        }

        public Employee() { 
            eid= 0;
            ename = "";
            esal= 0;
        }

        public string Display(){
            return $"id: {eid}, name:{ename}, esal:{esal}";
        }

    }
}
