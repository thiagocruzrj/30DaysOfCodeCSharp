using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    //Write your code here
    Stack<char> stack = new Stack<char>();
    Queue<char> myQ = new Queue<char>();

    void pushCharacter(char ch)
    {
        stack.Push(ch);
    }

    char popCharacter()
    {
        return stack.Pop();
    }

    void enqueueCharacter(char ch)
    {
        myQ.Enqueue(ch);
    }

    char dequeueCharacter()
    {
        return (char) myQ.Dequeue();
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        
        Solution obj = new Solution();
        
        foreach (char c in s) {
            obj.pushCharacter(c);
            obj.enqueueCharacter(c);
        }
        
        bool isPalindrome = true;
        
        for (int i = 0; i < s.Length / 2; i++) {
            if (obj.popCharacter() != obj.dequeueCharacter()) {
                isPalindrome = false;
                
                break;
            }
        }
        
        if (isPalindrome) {
            Console.Write("The word, {0}, is a palindrome.", s);
        } else {
            Console.Write("The word, {0}, is not a palindrome.", s);
        }
    }
}