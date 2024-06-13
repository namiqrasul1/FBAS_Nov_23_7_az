using Lesson11Stream.Models;
using System.Text;
using System.Text.Json;

// Stream 
// MemoryStream 
// FileStream   
// NetworkStream 

// AdapterStream
// StreamWriter, StreamReader
// BinaryReader, BinaryWriter

// File, FileInfo
// Directory, DirectoryInfo
// Path => @"C:\Users\namiqrasullu\Desktop\Инструкция_Microsoft_365.pdf"

//Console.WriteLine(Directory.GetCurrentDirectory());



var data = "hakuna matata 42";

//var fs = new FileStream(path: @"C:\Users\namiqrasullu\Desktop\some.txt", mode: FileMode.Create, access: FileAccess.Write);

//var bytes = Encoding.UTF8.GetBytes(data);

//try
//{
//    fs.Write(bytes, 0, bytes.Length);
//    fs.Flush();
//    fs.Write(bytes);
//}
//catch (Exception)
//{

//}
//finally
//{
//    fs.Dispose();
//}

//using (var fs1 = new FileStream(path: @"C:\Users\namiqrasullu\Desktop\some.txt", mode: FileMode.Create, access: FileAccess.Write))
//{
//    var bytes1 = Encoding.UTF8.GetBytes(data);
//    fs1.Write(bytes1, 0, bytes1.Length);
//    fs1.Flush();
//    fs1.Write(bytes1);
//}

//using var fs1 = new FileStream(path: @"C:\Users\namiqrasullu\Desktop\some.txt", mode: FileMode.Create, access: FileAccess.Write);
//var bytes1 = Encoding.UTF8.GetBytes(data);
//fs1.Write(bytes1, 0, bytes1.Length);
//fs1.Flush();
//fs1.Write(bytes1);


//List<Book> books = new()
//{
//    new Book { Id = 1, Name = "Angels and Demons", Author = "Dan Brown", Jenre = "Dedective"},
//    new Book { Id = 2, Name = "Sherlock Holmes", Author = "Arthur Conan Doyle", Jenre = "Dedective"},
//    new Book { Id = 3, Name = "Sefiller", Author = "Victor Hugo", Jenre = "Drama"}
//};

//using (var stream = new FileStream("books.txt", FileMode.OpenOrCreate))
//{
//    foreach (var book in books)
//    {
//        var bytes = Encoding.UTF8.GetBytes(book.ToString() + "\n");
//        stream.Write(bytes);
//    }
//}

//using(var stream = new FileStream("books.txt", FileMode.Open, FileAccess.Read))
//{
//    byte[] buffer = new byte[stream.Length];
//    stream.Read(buffer, 0, buffer.Length);
//    var str = Encoding.UTF8.GetString(buffer);
//    Console.WriteLine(str);
//}



// json => JavaScript Object Notation
//var book = new Book { 
//    Id = 1, 
//    Name = "Angels and Demons", 
//    Author = "Dan Brown", 
//    Jenre = "Dedective" 
//};


//var str = JsonSerializer.Serialize(book);

//Console.WriteLine(str);


//List<Book> books = new()
//{
//    new Book { Id = 1, Name = "Angels and Demons", Author = "Dan Brown", Jenre = "Dedective"},
//    new Book { Id = 2, Name = "Sherlock Holmes", Author = "Arthur Conan Doyle", Jenre = "Dedective"},
//    new Book { Id = 3, Name = "Sefiller", Author = "Victor Hugo", Jenre = "Drama"}
//};


//var json = JsonSerializer.Serialize(books);

//File.WriteAllText("books.json", json);


//var booksJson = File.ReadAllText("books.json");

//var books = JsonSerializer.Deserialize<List<Book>>(booksJson);

//Console.WriteLine();

//File.Exists("path")

#region Copy File

var sourcePath = @"C:\Users\namiqrasullu\Desktop\Инструкция_Microsoft_365.pdf";
var destPath = @"C:\Users\namiqrasullu\Desktop\New Folder\ChoxVacibPdf.pdf";



using (var source = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
{
    using (var dest = new FileStream(destPath, FileMode.Create, FileAccess.Write))
    {
        //source.CopyTo(dest);

        int len = 22;
        var bytes = new byte[len];
        var fileSize = source.Length;
        do
        {
            len = source.Read(bytes, 0, len);
            dest.Write(bytes, 0, len);
            Console.WriteLine(fileSize);
            fileSize -= len;

        } while (len > 0);
    }
}





#endregion

