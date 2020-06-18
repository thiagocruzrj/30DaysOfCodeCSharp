using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Day5 {
    static void Main(string[] args) {
        var N = int.Parse(Console.ReadLine());

        for (int i = 1; i < 11; i ++)
        {
            Console.WriteLine($"{N} x {i} = {N * i}");
        }
    }
}
