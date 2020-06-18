using System;

class Day2 {

    static void solve(double meal_cost, int tip_percent, int tax_percent) {
        double total = meal_cost + (meal_cost * tip_percent/100) + (meal_cost * tax_percent/100);

        Console.Write(Math.Round(total));

    }

    static void Main(string[] args) {
        double meal_cost = Convert.ToDouble(Console.ReadLine());

        int tip_percent = Convert.ToInt32(Console.ReadLine());

        int tax_percent = Convert.ToInt32(Console.ReadLine());

        solve(meal_cost, tip_percent, tax_percent);
    }
}
