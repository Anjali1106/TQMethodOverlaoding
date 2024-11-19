using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverlaoding
{

//    3. Create a class Payment having a static method payBill
//If you pay the bill by cash you are not eligible for any discount, method payBill(double amt)
//If you pay by a mode you get 15% discount on the bill, method  payBill(double amt, String mode)

    internal class Payment
    {

        private int pid;
        private string mode;
      

        public  Payment(int id , string mode) { 
            this.pid=id;
            this.mode=mode;
        
        }
        public Payment() { 
            pid=0;
            mode = "";
        }

        public void payBill(double  amt) {
            Console.WriteLine("pay the bill by cash you are not eligible for any discount");
        }

        public void payBill(double amt, string mode) {
            double discnt = 0.15;
            double disamt = amt - (amt * 0.15);
            Console.WriteLine("pay by a mode you get 15% discount on the bill "+disamt);
        }
    }
}
