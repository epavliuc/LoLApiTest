using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLApiTest.HTTP_Management
{
    class program
    {
        static void Main(string[] args)
        {
            LoLApiCall loLApiCall = new LoLApiCall();

            Console.WriteLine(loLApiCall.LoLApiRequest());
            Console.Read();

        }


    }
}
