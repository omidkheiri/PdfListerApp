using System;
using System.IO;
using System.Linq;

namespace PdfListerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\pdf"; // Change this to your PDF directory
            PdfProcessor pdfProcessor = new PdfProcessor();

            var pdfFiles = pdfProcessor.ListPdfFiles(directoryPath);
            foreach (var pdfFile in pdfFiles)
            {
                pdfProcessor.CreateTextFileFromPdf(pdfFile);
            }

            Console.WriteLine("Processing completed.");
        }
    }
}