using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTpl.Dataflow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Net Framework4.7.1 Tpl.Dataflow Hello World!");
            Console.WriteLine("NET平台-请输入管道并发数:");
            if (int.TryParse(Console.ReadLine(), out int max))
            {
                var pipeline = new Pipeline(max);
                var task = pipeline.Builder();
                pipeline.Process(new[] { "计", "算", "机", "科", "学", "与", "技", "术" });
                task.Wait();
                Console.ReadKey();
            }
        }
    }
}
