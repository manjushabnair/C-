using System;

namespace CSharpDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var method = new MethodExample();
            var sampleData = new SampleData
            {
                ID = 1,
                Name = "Data1",
                Value = 100
            };
            var sampleObject = new object();
            Console.WriteLine(method.ProcessData(sampleData));
            Console.WriteLine("++++++++++++++++++++++++++");
            Console.WriteLine(method.ProcessData(sampleObject));
            Console.WriteLine("++++++++++++++++++++++++++");
            Console.WriteLine(method.ProcessData(sampleData, 23));
            Console.WriteLine("++++++++++++++++++++++++++");
        }x

    }
}
