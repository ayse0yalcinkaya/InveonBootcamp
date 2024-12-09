using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_AsyncProgramming
{
    public class AsynchronousExample
    {
        public async Task LongRunningTaskAsync()
        {
            Console.WriteLine("Uzun süreli asenkron görev başlıyor!");
            await Task.Delay(5000); 
            Console.WriteLine("ASenkron Görev Tamamlandı!");
        }
    }
}
