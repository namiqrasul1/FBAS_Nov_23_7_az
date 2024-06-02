using System;
using Lesson6ExceptionHandlingReadonlyOperatorOverloadingIndexer;
using Ecommerce;

//Product product = new();
//product.Description = "zererli ichki";
////product.Name = "Cola";
////product.Id = 1;
//product.Price = 4;

//string s = null;

//_ = s.ToCharArray();


//int foo(int x) => 1 / x;

//try
//{
//    var result = foo(0);
//    Console.WriteLine(result);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Source);
//    Console.WriteLine(ex.Message);
//}

string[] arr = ["hakuna", "matata", "300"];

//try
//{
//    byte b = byte.Parse(arr[2]);
//}
////catch (FormatException fe)
////{
////    Console.WriteLine(fe.Message);
////}
////catch (IndexOutOfRangeException ex)
////{
////    Console.WriteLine(ex.Message);
////}
////catch (OverflowException ex)
////{
////    Console.WriteLine(ex.Message);
////}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


//try
//{
//    throw new NotImplementedException();
//}
//catch
//{
//    Console.WriteLine("salam");
//}

//try
//{
//	throw new Exception("nese agir problem oldu");
//}
//catch (Exception ex) 
//{
//    Console.WriteLine(ex.Message);
//    throw;
//}


//try
//{
//    throw new NotImplementedException();
//}
//finally
//{
//    Console.WriteLine("finally");
//}

//var name = string.Empty;
//var surname = string.Empty;
//var age = 0;

//inputname:
//try
//{
//    Console.WriteLine("name:");
//    name = Console.ReadLine();
//    if (string.IsNullOrWhiteSpace(name))
//        throw new FormatException("invalid name");
//}
//catch (Exception)
//{
//    goto inputname;
//}

//inputsurname:
//try
//{
//    Console.WriteLine("surname:");
//    surname = Console.ReadLine();
//    if (string.IsNullOrWhiteSpace(surname))
//        throw new FormatException("invalid surname");
//}
//catch (Exception)
//{
//    goto inputsurname;
//}
//inputage:
//try
//{
//    Console.WriteLine("age:");
//    age = int.Parse(Console.ReadLine());
//}
//catch (Exception)
//{
//    goto inputage;
//}


//Console.WriteLine("{0} {1} {2}", name, surname, age);

///////////////////////////////////////////////////////////////////////////
/// exception filtering

//try
//{
//	throw new Exception("hakun       ");
//}
//catch (Exception ex) when (ex.Message.Length > 8)
//{
//    Console.WriteLine("when (ex.Message.Length > 8)");
//}

//int getValue(int[] arr, int index)
//{
//    try
//    {
//        return arr[index];
//    }
//    catch (IndexOutOfRangeException) when (index < 0)
//    {
//        throw new ArgumentOutOfRangeException(nameof(arr), "index cannot be negative");
//    }
//    catch (IndexOutOfRangeException) when (arr.Length <= index)
//    {
//        throw new ArgumentOutOfRangeException(nameof(arr), "index cannot be equal or greater than length of array");
//    }
//}

//int[] ints = [1, 2, 3, 4, 5, 6];

//try
//{
//    var result = getValue(ints, 12);
//    Console.WriteLine(result);
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}

/////////////////////////////////////////
///readonly

//const int a = 2;
//readonly int b = 4; // 




///////////////////////////////////////////////////
/// operator overloading
/// 

//Int obj = new() { Value = 112 };
//Int obj1 = new() { Value = 12 };

//if(obj == obj1)
//{
//    Console.WriteLine("Equal");
//}
//else
//{
//    Console.WriteLine("not equal");
//}

//var result = obj + obj1;

//Console.WriteLine(result);

// length => hemin uzunluqda reqemlerden ibaret string qaytaran funksiya yazin

string generateNumber(int length) //4
{
    var result = string.Empty;
    Random rnd = new();
    
    for (int i = 0; i < length; i++)
        result += rnd.Next(0, 10);

    return result;
}

var rndInt = generateNumber(4);
Console.WriteLine(rndInt);
Console.WriteLine(generateNumber(5));
Console.WriteLine(generateNumber(42));
Console.WriteLine(generateNumber(10));