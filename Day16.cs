using System;
class Solution {

    static void Main(String[] args) {
        string S = Console.ReadLine();

        try{
            int num = int.Parse(S);
            Console.WriteLine(num);
        } catch (Exception)
        {
            Console.WriteLine("Bad String");
        }
    }
}