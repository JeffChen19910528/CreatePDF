using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;

namespace CreatePDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Document myDoc = new Document();
            try
            {
                FileStream fs = new FileStream(@"c:\tmp\test.pdf", FileMode.Create);
                PdfWriter.GetInstance(myDoc, fs);
                Paragraph p = new Paragraph("Hello World!", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 20f));
                myDoc.Open();
                myDoc.Add(p);//加入文章段落
                myDoc.AddTitle("Tutorial-Hello World!");//文件標題
                myDoc.AddAuthor("Jeff");//文件作者
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (myDoc.IsOpen()) myDoc.Close();
            }
        }

        private void CreateJPG_Click(object sender, EventArgs e)
        {
            Document myDoc = new Document();
            try
            {
                FileStream fs = new FileStream(@"c:\tmp\test.pdf", FileMode.Create);
                PdfWriter.GetInstance(myDoc, fs);
                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(@"c:\tmp\pic7.png");
                myDoc.Open();
                myDoc.Add(image);//加入影像
                myDoc.AddTitle("Tutorial-Add image files");//文件標題
                myDoc.AddAuthor("Jeff");//文件作者
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (myDoc.IsOpen()) myDoc.Close();
            }
        }
    }
}
