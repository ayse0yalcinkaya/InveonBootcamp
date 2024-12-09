using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_SOLID
{
    /*
    public class SRP
    {
        public string Name { get; set; }
        public string Department { get; set; }

        // Employee'nin bilgilerini kaydetmek
        public void SaveEmployee()
        {
            // veritabanı işlemleri
            Console.WriteLine("Çalışan veritabanına kayıt edildi.");
        }

        // employee bilgilerini yazdırma
        public void PrintEmployeeDetails()
        {
            Console.WriteLine($"İsim: {Name}, Departman: {Department}");
        }
    }

    */

    public class SRP
    {
        public string Name { get; set; }
        public string Department { get; set; }
    }

    // employee verilerini veritabanına kaydetme 
    public class EmployeeRepository
    {
        public void SaveEmployee(SRP employee)
        {
            // veritabanı işlemleri
            Console.WriteLine("Çalışan veritabanına kayıt edildi.");
        }
    }

    // employee bilgilerini yazdırma 
    public class EmployeePrinter
    {
        public void PrintEmployeeDetails(SRP employee)
        {
            Console.WriteLine($"İsim: {employee.Name}, Departman: {employee.Department}");
        }
    }


}

