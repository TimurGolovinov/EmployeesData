using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesData
{
    public class Employees : IComparable<Employees>
    {
        //Create setters and getters
        public string Name
        {
            get;
            set;
        }
        public String Age
        {
            get;
            set;
        }
        public String Salary
        {
            get;
            set;
        }
        public String Experience
        {
            get;
            set;
        }
        public string Position
        {
            get;
            set;
        }
        public string Department
        {
            get;
            set;
        }

        //Compare method to sort employees by their Name
        public int CompareTo(Employees other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
