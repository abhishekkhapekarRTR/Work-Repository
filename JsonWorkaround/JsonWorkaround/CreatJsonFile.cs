using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonWorkaround.DTO;

namespace JsonWorkaround
{
    public static class CreatJsonFile
    {
        public static void WriteJsonAsync()
        {
            Employee employee = new Employee();
            Console.Write("Enter your first name : ");
            employee.FirstName = Console.ReadLine();

        }
    }
}
