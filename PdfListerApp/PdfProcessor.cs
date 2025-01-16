using Newtonsoft.Json;
using PdfListerApp.PdfListerApp;
using System;
using System.IO;
using System.Linq;

namespace PdfListerApp
{
   public class PdfProcessor
    {
        public string[] ListPdfFiles(string directoryPath)
        {
            return Directory.GetFiles(directoryPath, "*.pdf");
        }

        public void CreateTextFileFromPdf(string pdfFilePath)
        {
            try
            {
                byte[] pdfBytes = File.ReadAllBytes(pdfFilePath);
                string pdfName = Path.GetFileNameWithoutExtension(pdfFilePath);
                string textFilePath = Path.Combine(Path.GetDirectoryName(pdfFilePath), pdfName + ".txt");

                string base64String = Convert.ToBase64String(pdfBytes);
                




                using (FileStream fileStream = new FileStream(pdfFilePath, FileMode.Open, FileAccess.Read))
                {
                    // Now you can use the FileStream object to read the PDF data
                    // For example, you can read the entire file into a byte array:
                    //byte[] pdfData = new byte[fileStream.Length];
                    var str = JsonConvert.SerializeObject(new filemodel { data = pdfBytes });

                    //string pdfName = Path.GetFileNameWithoutExtension(pdfFilePath);
                    //string textFilePath = Path.Combine(Path.GetDirectoryName(pdfFilePath), pdfName + ".txt");
                    File.WriteAllText(textFilePath, str);

                }




            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing file {pdfFilePath}: {ex.Message}");
            }
        }
    }

   
}