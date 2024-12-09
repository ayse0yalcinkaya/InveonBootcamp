using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_AsyncProgramming
{
    public class TaskStaticMethods
    {
        public void RunTaskExample()
        {
            Task.Run(() =>
            {
                Console.WriteLine("Task.Run: işlem arka planda çalışmaya devam ediyor");
            }).Wait();
        }

        public async Task DelayExample()
        {
            Console.WriteLine("Task.Delay: işlem beklemeye alındı");
            await Task.Delay(2000); 
        }

        public async Task WhenAllExample()
        {
            Task task1 = Task.Delay(2000);
            Task task2 = Task.Delay(3000);

            await Task.WhenAll(task1, task2);
            Console.WriteLine("Task.WhenAll: tüm işlemler tamamlandı");
        }

        public async Task WhenAnyExample()
        {
            Task task1 = Task.Delay(2000);
            Task task2 = Task.Delay(3000);

            await Task.WhenAny(task1, task2);
            Console.WriteLine("Task.WhenAny: ilk işlem tamamlandı");
        }

        public Task CompletedTaskExample()
        {
            Console.WriteLine("Task.CompletedTask: işlem tamamlandı!");
            return Task.CompletedTask;
        }
    }
}
