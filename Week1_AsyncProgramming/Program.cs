using System;
using System.Threading.Tasks;
using Week1_AsyncProgramming;

class Program
{
    static async Task Main(string[] args)
    {

        //eşzamanlı
        var syncExample = new SynchronousExample();
        syncExample.LongRunningTask();

        //asenkron
        var asyncExample = new AsynchronousExample();
        await asyncExample.LongRunningTaskAsync();

        //statik metod
        var taskExamples = new TaskStaticMethods();
        taskExamples.RunTaskExample();
        await taskExamples.DelayExample();
        await taskExamples.WhenAllExample();
        await taskExamples.WhenAnyExample();
        await taskExamples.CompletedTaskExample();

        //async/await hata yönetimi
        var errorHandling = new AsyncErrorHandling();
        await errorHandling.ProcessDataAsync();

        Console.WriteLine("Asenkron programlama görevi başarıyla tamamlandı!");
    }
}
