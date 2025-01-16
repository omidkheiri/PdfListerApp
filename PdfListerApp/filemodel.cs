namespace PdfListerApp.PdfListerApp
{
    internal class filemodel
    {
        [Newtonsoft.Json.JsonProperty("pdfContent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public byte[] data { get; set; }
    }
}
