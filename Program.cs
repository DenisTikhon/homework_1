//Задача №2
Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
{ if ( A > B) {
Console.WriteLine(" Min {1} Max {0}", A, B);} 
else {
Console.WriteLine(" Min {0} Max {1}", A, B);}
}
// задача №4
Console.WriteLine("Введите первое число");
int F; // дополнитеоьная переменная
int C = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int D = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int E = Convert.ToInt32(Console.ReadLine());
{ if (C > D) { F = C ;} 
else {F = D;}
}{
if (F > E) {Console.WriteLine("Максимальное число "+ F );}
else {Console.WriteLine("Максимальное число "+ E );}
}
//Задача №8
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int i=1;// дополнительная переменная
    while (i<=num) {
    if ((i % 2) == 0) {Console.Write(i+","); i++;} else {i++;}
 }
 