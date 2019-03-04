using System.IO;
using ClickNCheck.Models;
namespace ClickNCheck.Services
{
    public class PDFGenerator
    {
        public static void GeneratePDF(User user)
        {
            // instantiate a html to pdf converter object 
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            string path = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"Files\RecruiterMail.html");
            string page = System.IO.File.ReadAllText(path);
            page = page.Replace("{id}", user.ID);
            page = page.Replace("{title}", user.Title);
            page = page.Replace("{name}", user.Name);
            page = page.Replace("{surname", user.Surname);
            page = page.Replace("{dob}", user.DOB);
            page = page.Replace("{gender}", user.Gender);
            page = page.Replace("{address}", user.Address);
            page = page.Replace("{time}", user.Time);
            page = page.Replace("{description}", user.Description);
            page = page.Replace("{status}", user.Status);

            // create a new pdf document converting an url 
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(page);
            
            // save pdf document 
            byte[] pdf = doc.Save();
            File.WriteAllBytes(Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"Files\results.pdf"), pdf);
            // close pdf document 
            doc.Close();
        }
    }
}

