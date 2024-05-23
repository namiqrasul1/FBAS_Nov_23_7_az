//int a = 42;

//ref int b = ref a;
//b = 1;

//int @int = 4_2_0_0_00_0;

#region Arrays

//int[] nums = new int[30];
//int[] nums1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
//int[] nums2 = { 1, 2, 3, 4, 5, 6, 7 };
//int[] nums3 = [1, 2, 3, 4, 6, 7];

// zero-based indexer
//nums[1] = 2;

//for (int i = 0; i < nums1.Length; i++)
//{
//    Console.Write($"{nums1[i]} ");
//}

//Console.WriteLine();


//int[] nums = [1, 2, 3, 4, 6, 7];

//foreach (int num in nums)
//{
//    //num = 2; // error, foreach iteration variable
//    Console.Write(num + " ");
//}

//int[] nums = [1, 2, 435, 47, 4, 2, 12, 578, 1, 23412, 46, 7, 3, 4, 6, 7];
//Array.Resize(ref nums, 10);

//Array.Clear(nums);

//Array.Reverse(nums);

//Array.Fill(nums, 7);
//Array.Fill(nums, 7, 5, 5);

//Array.Sort(nums);

//foreach (int num in nums)
//{
//    Console.Write(num + " ");
//}


//int[] n = new int[nums.Length];

//Array.Copy(sourceArray: nums, 
//            length: nums.Length,
//            destinationArray: n 
//            );

//foreach (var item in n)
//{
//    Console.WriteLine(item);
//}

// MultiDimentional Array
// Rectangular Array
// Jagged Array

// Rectangular Array
/*
 [1,2,3],
 [2,23,4]
 
 */

//int[,] nums = new int[2, 4]
//{
//    { 1,2,3,4 },
//    { 2,3,4,5 },
//};

//nums[1, 3] = 6;

//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}

//// Jagger
//int[][] jaggedArray = new int[3][];
//jaggedArray[0] = new int[3] { 1, 2, 3 };
//jaggedArray[1] = new int[40];
//jaggedArray[2] = new int[60];

//jaggedArray[1][20] = 42;

//foreach (var arr in jaggedArray)
//{
//    foreach (var item in arr)
//    {
//        Console.Write($"{item} ");
//    }
//    Console.WriteLine();
//}


#endregion

#region String

// string (class String)

//string str = "11011010011Hakuna Matata10101";

////var trim = str.Trim();
////Console.WriteLine(trim + "asjhdas");

////var trim = str.Trim('1');
////var trim = str.Trim('1', '0');
////Console.WriteLine(trim);

//var trimSrart = str.TrimStart('1', '0');
//var trimEnd = str.TrimEnd('1', '0');
//Console.WriteLine(trimSrart);
//Console.WriteLine(trimEnd);

//string user = "namiqrasul";

//var username = Console.ReadLine();

//if (user == username?.Trim())
//    Console.WriteLine("Welcome my app");
//else
//    Console.WriteLine("Invalid username");


//string txt = "11011010011Hakuna Matata10101";

//txt = txt.Replace("101", "A");
//Console.WriteLine(txt);


//var txt = "From they fine john he give of rich he. They age and draw mrs like. Improving end distrusts may instantly was household applauded incommode. Why kept very ever home mrs. Considered sympathize ten uncommonly occasional assistance sufficient not. Letter of on become he tended active enable to. Vicinity relation sensible sociable surprise screened no up as.";

////var words = txt.Split(' ');
//string[] sentences = txt.Split('.', '?', '!');

//Console.WriteLine(sentences.Length);


//var str = "hakuna  matata ";

//var s = str.Split(' ');
//Console.WriteLine(s.Length);


//string str = "hakuna";

//str = str.Insert(2, "MATATA");

//Console.WriteLine(str);

//var str = "hakuna";
//Console.WriteLine(str.CompareTo("Hakuna"));

// boyuk    => 1
// beraber  => 0
// kichik   => -1

//var str = "hakuna.comm";
//if (str.Contains("a"))
//    Console.WriteLine("icherisinde a var");

//Console.WriteLine(str.EndsWith(".com"));

//Console.WriteLine(str.IndexOf('a'));
//Console.WriteLine(str.IndexOf("una"));
//Console.WriteLine(str.LastIndexOf("a"));

//str = str.Remove(2, 2);
//str = str.Remove(2);
//Console.WriteLine(str);

//Console.WriteLine(str.Substring(2, 5));

//string str = "";
//string str1 = string.Empty;
//string str2 = null;
//string str3 = " 1";

//if(string.IsNullOrWhiteSpace(str3))
//    Console.WriteLine("boshdur");

#endregion

#region DateTime

//DateTime dt = new DateTime(2024, 5, 23);

//DateTime dt = DateTime.Now;

//dt = dt.AddYears(1);
//dt = dt.AddDays(100);

//Console.WriteLine(dt.Year);
//Console.WriteLine(dt.Day);
//Console.WriteLine(dt.Month);
//Console.WriteLine(dt.DayOfWeek);
//Console.WriteLine(dt.DayOfYear);

//Console.WriteLine(dt.ToString());
//Console.WriteLine(dt.ToLongDateString());
//Console.WriteLine(dt.ToShortDateString());
//Console.WriteLine(dt.ToShortTimeString());
//Console.WriteLine(dt.ToLongTimeString());


//DateOnly d = new(2,2,2);

//Console.WriteLine(d);

Random rnd = new();
Thread.Sleep(2000);
Console.WriteLine(rnd.Next(1, 10));
rnd.Shuffle(new int[3]);

Console.Clear();


#endregion