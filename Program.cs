using System;

class Program
{
    static void Main()
    {
        Console.Write("Sıcaklık değerini girin (°C): ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double temperature))
        {
            if (temperature >= 10 && temperature < 20)
            {
                Console.WriteLine("Durum: Normal");
            }
            else if (temperature >= 20 && temperature < 30)
            {
                Console.WriteLine("Durum: Sıcak");
            }
            else if (temperature >= 30 && temperature < 40)
            {
                Console.WriteLine("Durum: Çok Sıcak");
            }
            else
            {
                Console.WriteLine("Sıcaklık 10-40 °C aralığında değil.");
            }
        }
        else
        {
            Console.WriteLine("Lütfen geçerli bir sıcaklık değeri girin.");
        }
    }
}
