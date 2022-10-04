using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_CSharp
{

    public class bonus
    {
        protected int amt;
        protected void EmpDetails()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Congrats!!!You got your bonus");
            Console.WriteLine("---------------------------------");
        }
    }
  
    public class staff : bonus
    {
        protected int tot_sal1;
        protected int did;
        protected string dname;
        protected int eid;
        protected string ename;


        public void DeptDetails()
        {
            eid = 100;
            ename = "Bhavana";
            dname = "IT";
            EmpDetails();
            tot_sal1 = 3 * amt;

            Console.WriteLine($"Employee_ID:{eid} Employee_Name:{ename} Department_Name:{dname}");
            Console.WriteLine("");
            Console.WriteLine("You got the bonus of " + tot_sal1);
            Console.WriteLine("--------------------------------------------------------------");



        }
    }
  
    public class non_staff : staff
    {
       
        protected int tot_sal2;
        protected int sid;
        protected string sname;
        protected string nsname;

        public void GetDetails()
        {
            amt = 1000;
            sid = 200;
            sname = "Achala";
            nsname = "Non-IT";
            EmpDetails();
            tot_sal2 = 2 * amt;
            Console.WriteLine($"Employee_ID:{sid} Employee_Name:{sname} Department:{nsname}");
            Console.WriteLine("");
            Console.WriteLine("You got the bonus of " + tot_sal2);


        }

    }
    
 
    internal class Inheritance
    {
        public static void Main()
        {
            

            non_staff ns = new non_staff();
            ns.GetDetails();
            ns.DeptDetails();
          

        }
    }
}