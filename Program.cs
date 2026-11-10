//task1
// bool result = IsDivisible(15, 3);
// Console.WriteLine(result);

// bool IsDivisible(int number, int divisor)
// {
//     return number % divisor == 0;
// }

//task2
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(GetNumberType(number));

// string GetNumberType(int number)
// {
//     if (number % 2 == 0)
//     {
//         return "Even";
//     }
//     else
//     {
//         return "Odd";
//     }
// }


//task3
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(CountNumbers(a, b));

// int CountNumbers(int a, int b)
// {
//     int rakam = a - b;
//     if (rakam < 0)
//     {
//         rakam = -rakam;
//     }
//     if (rakam == 0)
//     {
//         return 0;
//     }
//     return rakam - 1;
// }

//task 4
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SumFromOneToN(n));

// int SumFromOneToN(int n)
// {
//     int sum = 0;
//     for (int i = 1; i <= n; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
// }


//task5
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Factorial(n));

// long Factorial(int n)
// {
//     long result = 1;
//     for (int i = 1; i <= n; i++)
//     {
//         result = result * i;
//     }
//     return result;
// }


//task6
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(ReverseNumber(number));

// int ReverseNumber(int number)
// {
//     int result = 0;
//     while (number > 0)
//     {
//         int digit = number % 10;
//         result = result * 10 + digit;
//         number = number / 10;
//     }
//     return result;
// }


//task7
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(CountDigits(number));

// int CountDigits(int number)
// {
//     if (number == 0)
//     {
//         return 1;
//     }
//     if (number < 0)
//     {
//         number = -number;
//     }
//     int count = 0;
//     while (number > 0)
//     {
//         number = number / 10;
//         count++;
//     }
//     return count;
// }


//task8
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SumEvenDigits(number));

// int SumEvenDigits(int number)
// {
//     if (number < 0)
//     {
//         number = -number;
//     }
//     int sum = 0;
//     while (number > 0)
//     {
//         int digit = number % 10;
//         if (digit % 2 == 0)
//         {
//             sum = sum + digit;
//         }
//         number = number / 10;
//     }
//     return sum;
// }


//task9
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(MaxDigit(number));

// int MaxDigit(int number)
// {
//     if (number < 0)
//     {
//         number = -number;
//     }
//     int max = 0;
//     while (number > 0)
//     {
//         int digit = number % 10;
//         if (digit > max)
//         {
//             max = digit;
//         }
//         number = number / 10;
//     }
//     return max;
// }


//task10
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(IsBool(number));

// bool IsBool(int number)
// {
//     if (number < 2)
//     {
//         return false;
//     }
//     for (int i = 2; i * i <= number; i++)
//     {
//         if (number % i == 0)
//         {
//             return false;
//         }
//     }
//     return true;
// }


//task11
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(CountDivisors(number));

// int CountDivisors(int number)
// {
//     int count = 0;
//     for (int i = 1; i <= number; i++)
//     {
//         if (number % i == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

//task12
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(IsPalindrome(number));

// bool IsPalindrome(int number)
// {
//     if (number < 0)
//     {
//         return false;
//     }
//     int original = number;
//     int reversed = 0;
//     while (number > 0)
//     {
//         int digit = number % 10;
//         reversed = reversed * 10 + digit;
//         number = number / 10;
//     }
//     return original == reversed;
// }


//task13
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(GCD(a, b));

// int GCD(int a, int b)
// {
//     while (b != 0)
//     {
//         int temp = b;
//         b = a % b;
//         a = temp;
//     }
//     return a;
// }


//task14
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(IsArmstrong(number));

// bool IsArmstrong(int number)
// {
//     if (number <= 0)
//     {
//         return false;
//     }

//     int original = number;

//     int count = 0;
//     int temp = number;
//     while (temp > 0)
//     {
//         temp = temp / 10;
//         count++;
//     }

//     int sum = 0;
//     while (number > 0)
//     {
//         int digit = number % 10;

//         int power = 1;
//         for (int i = 0; i < count; i++)
//         {
//             power = power * digit;
//         }

//         sum = sum + power;
//         number = number / 10;
//     }

//     return sum == original;
// }


int secretNumber = Convert.ToInt32(Console.ReadLine());
int guess = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CheckGuess(secretNumber, guess));

string CheckGuess(int secretNumber, int guess)
{
    if (guess < secretNumber)
    {
        return "Too low";
    }
    else if (guess > secretNumber)
    {
        return "Too high";
    }
    else
    {
        return "Correct";
    }
}