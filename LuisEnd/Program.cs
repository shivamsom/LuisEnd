using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace LuisEnd
{
    class Program 
    {
        Program()
        {
            

        }

        static void Main(string[] args)
        {
            String usrInp;
            
                Console.WriteLine("Luis");
            WebClient client = new WebClient();
            while(true)
            {
                usrInp = Console.ReadLine();
               usrInp=  usrInp.ToLower();
                if (usrInp.Equals("exit"))
                {
                    Environment.Exit(1);
                }
                else {
                    string op = client.DownloadString("https://westus.api.cognitive.microsoft.com/luis/v2.0/apps/5114176a-0f51-4805-be95-533511908407?subscription-key=26a97c46300748c096f15fd899469265&verbose=true&timezoneOffset=0&q="+usrInp);

                    Console.WriteLine(op);
                }       
            }

                    

        }
    }
}
