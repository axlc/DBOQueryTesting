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

            newRowNumber = insertNewUser.InsertIntoUsers("thisShouldBehigher", 3);
            Console.WriteLine("Data was inserted to row: {0}", newRowNumber);
            Console.ReadKey();

            newRowNumber = insertNewUser.InsertIntoContactDetails(1, "Bob", "Barker",
                                                   "", "", "",
                                                   "", "", "",
                                                   "", "axl.mccracken@gmail.com");

            Console.WriteLine("Data was inserted to row: {0}", newRowNumber);
            Console.ReadKey();

            string courseDescription = "Testing Course Description.";
            newRowNumber = insertNewUser.InsertIntoCourses("Test Course 74",
                                                           "TEST-0001", "007", courseDescription,
                                                           "1:13", "2:00", 3.51);

            newRowNumber = insertNewUser.InsertIntoUserCourses(1, 1);

            Console.WriteLine("Data was inserted to row: {0}", newRowNumber);
            Console.ReadKey();
        }
    }
}
