// №2 На вход принимаем 2 числа. Пишем какое большее, какое меньшее

Console.WriteLine("Enter number 1: ");
string enterNum1 = Console.ReadLine();
int number1 = Convert.ToInt32(enterNum1);
Console.WriteLine("Enter number 2: ");
string enterNum2 = Console.ReadLine();
int number2 = Convert.ToInt32(enterNum2);

if (number1 > number2) 
{ Console.WriteLine("Number 1 bigger than number 2"); }
else if (number1 < number2) 
{ Console.WriteLine("Number 2 bigger than number 1"); }
else 
{ Console.WriteLine("Number 1 equal to number 2"); }