using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0;i<12;i++)
            {
                Console.WriteLine($"hello world {i} + Post-Build Action test Java app");
            }
        }
    }
}
