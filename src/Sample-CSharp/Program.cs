using System.IO;
using System.IO.Compression;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// ToDo: raise issue here

static void WriteToDirectory(ZipArchiveEntry entry, string destDirectory)
{
    string destFileName = Path.Combine(destDirectory, entry.FullName);
    entry.ExtractToFile(destFileName);
}
