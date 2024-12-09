using System;
using System.Threading.Tasks;

namespace Week1_AsyncProgramming
{
    public class AsyncErrorHandling
    {
        public async Task ProcessDataAsync()
        {
            try
            {
                Console.WriteLine("Veri işlenmeye başlandı!");
                await Task.Delay(2000); 
                throw new InvalidOperationException("Beklenmeyen bir hata oluştu!");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Veri işleme tamamlandı!");
            }
        }
    }
}
