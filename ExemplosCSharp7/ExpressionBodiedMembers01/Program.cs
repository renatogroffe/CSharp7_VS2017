using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionBodiedMembers01
{
    class Program
    {
        static void Main(string[] args)
        {
            CargaDados c = new CargaDados(@"C:\Temp\Processamento\");
            c.Processar();
            Console.ReadKey();
        }
    }
}
