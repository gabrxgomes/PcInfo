using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Management;
using System.Diagnostics;

namespace PcInfo
{



    class Program
    {
        static void Main(string[] args)
        {
            string hostName = Dns.GetHostName(); 
            
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            
            string ComputerName = Environment.MachineName.ToString();

            string os = Environment.OSVersion.ToString();

            string os1 = Environment.CurrentManagedThreadId.ToString();

            int os2 = Process.GetCurrentProcess().Id;

            string iniciotxt = @"
  ____   ____   ___ _   _ _____ ___              ___        _ 
 |  _ \ / ___| |_ _| \ | |  ___/ _ \   __   __  / _ \      / |
 | |_) | |      | ||  \| | |_ | | | |  \ \ / / | | | |     | |
 |  __/| |___   | || |\  |  _|| |_| |   \ V /  | |_| |  _  | |
 |_|    \____| |___|_| \_|_|   \___/     \_/    \___/  (_) |_|
                                                              
                                                                ";

            string Computernameascii = @"
  _   _                   _   
 |_) /    |\ |  /\  |\/| |_ o 
 |   \_   | \| /--\ |  | |_ o " + " " + ComputerName + ".";




            Console.WriteLine(iniciotxt);


            Console.WriteLine(Computernameascii);


            Console.WriteLine(@"
                   ___  _    
 |   _   _  _. |    |  |_) o 
 |_ (_) (_ (_| |   _|_ |   o " + " " + myIP);





            Console.WriteLine(@"
                  _        __                               
 \_/ _      ._   / \  _   (_  o  _ _|_  _  ._ _    o  _   o 
  | (_) |_| |    \_/ _>   __) | _>  |_ (/_ | | |   | _>   o " + " " + os + ".");


            Console.WriteLine(@"
                 ___                    ___                    _                                
 \_/ _      ._    | |_  ._ _   _.  _|    |   _|  _  ._ _|_ o _|_ o  _  _. _|_  _  ._   o  _   o 
  | (_) |_| |     | | | | (/_ (_| (_|   _|_ (_| (/_ | | |_ |  |  | (_ (_|  |_ (_) |    | _>   o " + " " + os1 + ".");



            Console.WriteLine(@"
                  _                        _                       ___  _             
 \_/ _      ._   /      ._ ._ _  ._ _|_   |_) ._ _   _  _   _  _    |  | \   o  _   o 
  | (_) |_| |    \_ |_| |  | (/_ | | |_   |   | (_) (_ (/_ _> _>   _|_ |_/   | _>   o " + " " + os2 + ".");

            Console.ReadKey();
        }
    }
}