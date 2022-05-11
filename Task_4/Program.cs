// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

string s_a = Console.ReadLine ();
string s_b = Console.ReadLine ();
string s_c = Console.ReadLine ();
int a = int.Parse(s_a);
int b = int.Parse(s_b);
int c = int.Parse(s_c);
int max = 0;
if (a > b) {
    max = a;
}
else {
    max = b;
}

if (max < c) {
    max = c;
}
Console.WriteLine ( $"{max} наибольшее значение");