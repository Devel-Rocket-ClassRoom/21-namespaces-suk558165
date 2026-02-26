using System;


//## 과제 3: using static 지시문
using static System.Console;
using static System.Math;

WriteLine("Hello World!");

double result = Sqrt(16);
WriteLine($"제곱근: {result}");


double maxValue = Max(10, 20);
WriteLine($"최댓값: {maxValue}");