using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TestCaptainEnroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* relative path of "TestManager.exe" */
            string path = "..\\..\\..\\TestManager\\bin\\Debug\\TestManager.exe";

            Console.WriteLine("Hello TestCaptainEnroll.");

            /* get current path */
            Console.WriteLine(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));

            /* start up "TestManager.exe" */
            Process.Start(path);
            
            /* hold the console, if not, "TestCaptainEnroll.exe" will close itself */
            Console.ReadLine();
        }
    }
}
