// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using TestEncryptDecrypt;



string e = EncryptDecrypt.EncryptString("nhập mã hóa vào đây");
string d = EncryptDecrypt.DecryptString(e);

Console.WriteLine(e+"\n");
Console.WriteLine(d);

