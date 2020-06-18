using System;

class Day7 {
    static void Main(string[] args) {
        Console.ReadLine();
        
        var str = Console.ReadLine();
        var arr = str.Split(' ');

        Array.Reverse(arr);

        foreach(var num in arr){
            Console.Write($"{num} ");
        }
    }
}
