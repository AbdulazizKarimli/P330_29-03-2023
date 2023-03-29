//Console.WriteLine(Sum(new int[] { -2, -1, 5, 7, 3 }, IsPositive));
//Console.WriteLine(Sum(new int[] { -2, -1, 5, 7, 3 }, IsNegative));
//Console.WriteLine(Sum(new int[] { -2, -1, 5, 7, 3 }, IsOdd));
//Console.WriteLine(Sum(new int[] { -2, -1, 5, 7, 3 }, value => value % 2 != 0));
//Console.WriteLine(Sum(new int[] { -2, -1, 5, 7, 3 }, value =>
//{
//    bool result = value % 2 != 0;
//    return result;
//}));

//int Sum(int[] arr, Predicate<int> predicate)
//{
//    int sum = 0;
//    foreach (var item in arr)
//    {
//        if (predicate(item))
//            sum += item;
//    }

//    return sum;
//}

//int Sum(int[] arr, CheckNumber func)
//{
//    int sum = 0;
//    foreach (var item in arr)
//    {
//        if (func(item))
//            sum += item;
//    }

//    return sum;
//}


//int SumPositive(int[] arr)
//{
//    int sum = 0;
//    foreach (var item in arr)
//    {
//        if (IsPositive(item))
//            sum += item;
//    }

//    return sum;
//}

//int SumNegative(int[] arr)
//{
//    int sum = 0;
//    foreach (var item in arr)
//    {
//        if (IsNegative(item))
//            sum += item;
//    }

//    return sum;
//}

//bool IsPositive(int value) => value > 0;
//bool IsNegative(int value) => value < 0;
//bool IsOdd(int value) => value % 2 != 0;

//Console.WriteLine(IsPositive(2));

//CheckNumber check = IsPositive;
//CheckNumber checkNegative = new CheckNumber(IsNegative);
//Console.WriteLine(checkNegative(-5));
//Console.WriteLine(check(2));

//void ShowStr(string str) => Console.WriteLine(str);
//void ShowUpperStr(string str) => Console.WriteLine(str.ToUpper());
//void ShowLowerStr(string str) => Console.WriteLine(str.ToLower());

//Action<string> printStr = ShowStr;
//printStr += ShowUpperStr;
//printStr += ShowLowerStr;
//printStr += str => Console.WriteLine(str.Replace('a', 'h'));
//printStr -= str => Console.WriteLine(str.Replace('a', 'h'));
//printStr -= ShowUpperStr;
//printStr("ASajksdaa");

//Action<int> printInt = number => Console.WriteLine(number);
//printInt(4);

//Action<string, string> printFullName = (name, surname) => Console.WriteLine($"{name} {surname}");
//printFullName("Nicat", "Heyderov");

//delegate void Print<T>(T value);
//delegate void Print<T, K>(T value1, K value2);
//delegate void PrintInt(int number);
//delegate void PrintStr(string str);
//delegate bool CheckNumber(int number);
//int SumInt(int number1, int number2) => number1 + number2;
//decimal SumDouble(decimal number1, decimal number2) => number1 + number2;

//Func<int, int, int> calcInt = SumInt;
//Func<decimal, decimal, decimal> calcDouble = SumDouble;
//Console.WriteLine(calcInt(1, 2));
//Console.WriteLine(calcDouble(1.4m, 2.3m));

//delegate TResult Calc<in T, in K, out TResult>(T num1, K num2);
//delegate int Calc(int num1, int num2);

//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
//Console.WriteLine(numbers.FirstOrDefault(x => x < 4));
//Console.WriteLine(numbers.Find(value => value % 2 == 0));
//foreach (var item in numbers.FindAll(value => value % 2 != 0))
//{
//    Console.WriteLine(item);
//}
//numbers.RemoveAll(x => x > 2);
//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}