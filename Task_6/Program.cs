﻿// Напишите программу, 
// которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

string s_a = Console.ReadLine();
int a = int.Parse(s_a);
int i = 1;
while (i < a){ 
    if (0 == i % 2){
    Console.WriteLine($"{i}");
}
    i += 1; 
}
