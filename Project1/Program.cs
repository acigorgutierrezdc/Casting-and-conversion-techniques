﻿// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result);

// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");


// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);

// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);

// string name = "Bob";
// Console.WriteLine(int.Parse(name));


// string value = "a";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//    Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//    Console.WriteLine("Unable to report the measurement.");
// }

// string value = "bad";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//    Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//    Console.WriteLine("Unable to report the measurement.");
// }
// if (result > 0)
//    Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// Console.WriteLine($"Measurement (w/ offset): {50 + result}");



using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");


// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// decimal retorno = 0;
// decimal sumTotal = 0;
// string sumString = "";

// foreach (var item in values)
// {

//     if (decimal.TryParse(item, out retorno))
//     {
//         sumTotal = sumTotal + retorno;
//     }
//     else
//     {
//         sumString = sumString + item;
//     }

// }

// Console.WriteLine("Message: " + sumString);
// Console.WriteLine("Total: " + sumTotal);

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// decimal total = 0m;
// string message = "";

// foreach (var value in values)
// {
//     decimal number; // stores the TryParse "out" value
//     if (decimal.TryParse(value, out number))
//     {
//         total += number;
//     }
//     else
//     {
//         message += value;
//     }
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
int result1 = 0;
result1 = Convert.ToInt32(value1) / Convert.ToInt32(value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = 0;
result2 = Convert.ToDecimal(value2) / Convert.ToDecimal(value3);
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = 0;
//result3 = float.Parse(value3.ToString()) / float.Parse(value1.ToString());
result3 = (float)value3 / (float)value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");



















