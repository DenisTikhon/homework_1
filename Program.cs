Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
{ if ( A > B) {
Console.WriteLine(" Min {1} Max {0}", A, B);} 
else {
Console.WriteLine(" Min {0} Max {1}", A, B);}
}