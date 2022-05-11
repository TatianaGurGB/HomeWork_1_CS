// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

string s_a = Console.ReadLine();
int a = int.Parse(s_a);
int res = 0;

if (res == a % 2) {
    Console.WriteLine ($"{a} является четным числом");
}
else {
    Console.WriteLine ($"{a} не является четным числом");
}