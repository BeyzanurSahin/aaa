using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan n değerini al
        Console.Write("Please enter the value of n: ");
        int n = int.Parse(Console.ReadLine());

        // Dizi oluştur ve değerlerle doldur
        int[] array = new int[n];
        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            int r = rand.Next(1, 4); // 1 ile 3 arasında rastgele sayı
            array[i] = (i * i + 1) * r;
        }

        // Diziyi ekranda göster
        Console.WriteLine("The created array is:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        // Dizinin toplamını ve ortalamasını hesapla ve ekranda göster
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += array[i];
        }

        double average = (double)sum / n;

        Console.WriteLine("Sum of the array: " + sum);
        Console.WriteLine("Average of the array: " + average);

        // Kullanıcıdan aranacak sayıyı al
        Console.Write("What do you want to search?: ");
        int searchValue = int.Parse(Console.ReadLine());

        // Binary search yap
        Array.Sort(array); // Binary search için dizinin sıralanması gerekir
        int index = Array.BinarySearch(array, searchValue);

        // Binary search sonucunu ekranda göster
        if (index >= 0)
        {
            Console.WriteLine($"{searchValue} is found at the index of {index}");
        }
        else
        {
            Console.WriteLine($"The number you have searched for is not found.");
        }
    }
}
