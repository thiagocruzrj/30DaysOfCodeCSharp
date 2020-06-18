using System;

class Day9 {

    static void Main(string[] args) {
        var n = int.Parse(Console.ReadLine());

        Console.WriteLine(factorial(n));
    }
    
    static int factorial(int n) {
        if(n == 1) return 1;

        return factorial(n - 1) * n;
    }
}
