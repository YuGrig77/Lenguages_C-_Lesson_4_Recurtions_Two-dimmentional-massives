// Recurtions!!!

// Factorial have view: 
// 5! = 5*4*3*2*1 
//      5*4!
//        4*3!
//          3*2! - то есть можно задать функцию через саму себя
//Давайте попробуем

//double Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }

// если взять цыкл то с какого то момента подсчет сильно замедляется и в итоге будет переполненин типа,
// заменим int на double, чтобы можно было посмотреть все числа
//for (int i = 0; i < 40; i++)
{
    //Console.WriteLine($"{i}! = {Factorial(i)}");
}

// Фибоначчи
// 1 1 2 3 5 8 13 21 …
// fn = fn-1 + fn-2
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)
// Напишем это кодом:

int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(Fibonacci(i));
}

