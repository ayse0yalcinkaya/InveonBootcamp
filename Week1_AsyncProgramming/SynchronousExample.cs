using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_AsyncProgramming
{
    public class SynchronousExample
    {
        public void LongRunningTask()
        {
            Console.WriteLine("Uzun süreli senkron görev başlıyor!");
            System.Threading.Thread.Sleep(5000); 
            Console.WriteLine("Senkron Görev Tamamlandı!");
        }
    }
}
