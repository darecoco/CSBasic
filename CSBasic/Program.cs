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

            Console.WriteLine((long)a + b);
            Console.WriteLine(a + (long)b);
            Console.WriteLine((long)a + (long)b);

            Console.WriteLine("===================================");

            //자료형 최소, 최대 값 출력하기
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine("===================================");

            //sizeof 연산자 연습
            Console.WriteLine("int : " + sizeof(int));
            Console.WriteLine("long : " + sizeof(long));
            Console.WriteLine("float : " + sizeof(float));
            Console.WriteLine("double : " + sizeof(double));
            Console.WriteLine("char : " + sizeof(char));
            Console.WriteLine("bool : " + sizeof(bool));
        }
    }
}
