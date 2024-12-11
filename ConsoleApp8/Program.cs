using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int> list = new List<int>();
        // Ro'yxatga elementlar qo'shish
        list.Add(10);
        list.Add(20);
        list.Add(30);
        // Ro'yxatdagi elementlarni chop etish
        Console.WriteLine("Ro'yxat elementlari:");
        foreach (int item in list)
        {
            Console.WriteLine(item);
        }
        // Ro'yxatdan elementni o'chirish
        list.Remove(20);
        Console.WriteLine("Element o'chirilganidan keyin:");
        foreach (int item in list)
        {
            Console.WriteLine(item);
        }
    }
}
