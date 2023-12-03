// Р Е К У Р С И Я(продолжение)
// Факториал: 5! = 5 х 4 х 3 х 2 х 1
      //      5 х 4!
      //          4 х 3!
      //              3 х 2!     и т д

// double Factorial(int n)
//   {
//    if(n == 1) return 1;
//    else return n * Factorial(n - 1);
//   }
// Console.WriteLine(Factorial(40));  
// Числа Фибоначи {1 1 2 3 5 8 13 21 ....}
// f(1) = 1
// f(2) = 1
// f(3) = 2
// f(n) = f(n-1) + f(n-2)

int Fibonacci(int n)
  {
    if (n ==1 || n == 2) return 1;
    else return  Fibonacci(n-1) + Fibonacci(n-2);
  }
for (int i = 1; i < 10; i++)
{
  Console.WriteLine(Fibonacci(i));
}  



