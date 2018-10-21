using System;
using System.Threading.Tasks;

namespace MethodSignature
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Program.Result();
            Console.WriteLine("Hello World!");
        }

        public async static void Result()
        {
            var (averageSalary, numberOfEmployee) =  await Program.SomeCalculation(0L, 10L, 0L == 10L);
        }

        public async static Task<(string averageSalary, string numberOfEmployee)> SomeCalculation(long l1, long l2, bool f)
        {

            var averageSalary = "1000";
            var numberOfEmployee = "2";
            return (averageSalary, numberOfEmployee);
        }
    }

}
