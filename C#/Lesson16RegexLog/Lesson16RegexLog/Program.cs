using Serilog;
using System.Configuration;
using System.Text.RegularExpressions;

//string pattern = "he..o";
//string pattern = "^H";
//string pattern = "h$";
//string pattern = "^[a-z]";
//string pattern = "^[A-Z]";
//string pattern = "^[A-Za-z]";
//string pattern = "(^H)*(h$)";
//string pattern = "[0-3][0-9].[0-1][0-9].[0-9][0-9]";
//string pattern = @"(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[13-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})";

//string pattern = @"[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+";


//var regex = new Regex(pattern);
//var text = Console.ReadLine();
//if (regex.IsMatch(text!))
//{
//    Console.WriteLine("matched");
//}
//else
//    Console.WriteLine("unmathed");


#region Log

//string path = "app.log";
//try
//{
//	var data = Console.ReadLine();
//	if (string.IsNullOrWhiteSpace(data))
//		throw new Exception("Data is null");
//}
//catch (Exception ex)
//{
//	File.AppendAllText(path, ex.Message);
//}

#endregion

// Nlog
// Log4net
// Serilog

#region Serilog

//var path = ConfigurationManager.AppSettings["logFilePath"];

//var template = "[{Timestamp:HH:mm} {Level:u3}] {Message}{NewLine}{Exception}";
//Log.Logger = new LoggerConfiguration()
//                .MinimumLevel.Debug()
//                .WriteTo.Console(outputTemplate: template)
//                .WriteTo.File(path: path, outputTemplate: template)
//                .CreateLogger();

//Log.Debug("some debug");
//Log.Information("some info");
//Log.Warning("some warning");
//Log.Error("some error");
//Log.Error("some error");
//Log.Error("some error");
//Log.Error("some error");
//Log.Error("some error");
//Log.Error("some error");
//Log.Fatal("some fatal");


//Console.WriteLine(ConfigurationSettings.AppSettings!["logFilePath"]); // oldversion

// 1. Categories
// 2. Cart | Basket
// 3. Profile
// 4. Logout

// Profile
// 1. Edit account
// 2. Change Password
// 3. History



#endregion