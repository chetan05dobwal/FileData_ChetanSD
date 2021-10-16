using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;
using System.IO;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string param = "";
            string sParam1 = "";
            string sParam2 = "";
            int size =0;
            string result;
            try
            {

                // param = Console.ReadLine().Trim();
               
                //args = param.Split(' ');


                if (args.Count() >= 2)
                {
                    sParam1 = args[0];

                    sParam2 = args[1];


                    //Task 1
                    if (sParam1 == "-v" || sParam1 == "--v" || sParam1 == "/v" || sParam1 == "--version")
                    {
                        FileDetails f = new FileDetails();
                        result = f.Version(sParam2);
                        Console.WriteLine(result);
                    }

                    //Task 2 
                    if (sParam1 == "-s" || sParam1 == "--s" || sParam1 == "/s" || sParam1 == "--size")
                    {
                        FileDetails f = new FileDetails();
                        size = f.Size(sParam2);

                        Console.WriteLine(size);
                    }

                    Console.ReadLine();
                }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
