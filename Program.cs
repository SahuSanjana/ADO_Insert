using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using ADO_Insert.Ado;
namespace ADO_Insert
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInformation information = new StudentInformation();
            Console.WriteLine("Please enter your Roll number: ");
            int rNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your name: ");
            string sName = Console.ReadLine();
            Console.WriteLine("Please enter your phone number: ");
            long cNumber = Convert.ToInt64(Console.ReadLine());
            information.InsertDataIntoStudent_Info(rNumber, sName, cNumber);
        }
       
    }
}
