using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C#에서 Hello world 출력하기
            Console.WriteLine("Hello World");

            //오버플로우 연습
            int a = 2000000000; //20억
            int b = 1000000000; //10억

            Console.WriteLine(a + b);
        }
    }
}
