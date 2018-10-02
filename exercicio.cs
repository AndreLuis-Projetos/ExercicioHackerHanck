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

class Solution {

    // Complete the staircase function below.
    static void staircase(int n) {
        int tamanho = n;
        string acumulador ="";
        
        for(int i=1; i<=tamanho;i++)
        {
            for(int j=0;j<tamanho;j++)
            {
                if (i+j>=tamanho)
                {
                  acumulador+="#";  
                }
                else
                {
                     acumulador += " ";
                }
                
            }
             acumulador+= "\n";
            
        }
        
        Console.WriteLine(acumulador);

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}