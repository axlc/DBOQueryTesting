using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using A2_Reg_A_Lot_2017;

namespace DBOQueryTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            DBOQuery insertNewUser = new DBOQuery();
            int newRowNumber = 0;

            // insertNewUser.InsertIntoUsers("bob", 1);
            //insertNewUser.InsertIntoContactDetails(1, "Axl", "Mcc",
            //                                       "", "", "",
            //                                       "", "", "",
            //                                       "", "");
            string courseDescription = "Testing Course Description.";
            newRowNumber = insertNewUser.InsertIntoCourses("Test Course 1", 
                                                           "TEST-0001", "007", courseDescription,
                                                           "1:13", "2:00", 3.51);
            Console.WriteLine("Data was inserted to row: {0}", newRowNumber);
            Console.ReadKey();
            
        }
    }
}
