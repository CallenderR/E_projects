using E_APP02.SERVICES.FILE_SERVICES.FILE_HELPER;
using System.Reflection;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;
using UglyToad.PdfPig.Core;
using UglyToad.PdfPig.DocumentLayoutAnalysis.TextExtractor;
using UglyToad.PdfPig.DocumentLayoutAnalysis.WordExtractor;
using UglyToad.PdfPig.Fonts.Standard14Fonts;
using UglyToad.PdfPig.Writer;
namespace E_APP02.SERVICES.FILE_SERVICES.PDF_FILES
{
    internal class Read_Pdf
    {
        private static File_Helper01 File_H01 = new File_Helper01();
        private  readonly string[] data01 = new string[100];
        private static readonly string[] file_location = { File_H01.all_embedded_pdf().Split('\n')[0].Trim(),
                                                  File_H01.all_embedded_pdf().Split('\n')[1].Trim(),
                                                  File_H01.all_embedded_pdf().Split('\n')[2].Trim(),
                                                  File_H01.all_embedded_pdf().Split('\n')[3].Trim(),
                                                  File_H01.all_embedded_pdf().Split('\n')[4].Trim()
        };
        private static readonly Assembly assembly = Assembly.GetExecutingAssembly();
        private static readonly Stream[] stream = { assembly.GetManifestResourceStream(file_location[0]),
                                           assembly.GetManifestResourceStream(file_location[1]),
                                           assembly.GetManifestResourceStream(file_location[2]),
                                           assembly.GetManifestResourceStream(file_location[3]),
                                           assembly.GetManifestResourceStream(file_location[4])
        };
        private  readonly PdfDocument[] document = { PdfDocument.Open(stream[0]),
        PdfDocument.Open(stream[1]),
        PdfDocument.Open(stream[2]),
        PdfDocument.Open(stream[3]),
        PdfDocument.Open(stream[4])
        };
        private  readonly PdfDocumentBuilder builder = new PdfDocumentBuilder();



        public  string book_of_enoch02 => data01[0];

        public  string Book_of_Jasher => data01[1];

        public  string The_Holy_Bible_KJV => data01[2];
        public  string book_of_jubilees => data01[4];

        public  string Corrupting_the_Image => data01[3];

        public Read_Pdf()
        {
         //   load_pdf_data01();
        //  load_pdf_data02();
              load_pdf_data03();
        }


        private void load_pdf_data01()
        {

            foreach (UglyToad.PdfPig.Content.Page page in document[0].GetPages())
            {
           
                IEnumerable<Word> words = page.GetWords(NearestNeighbourWordExtractor.Instance);
                foreach (var a in words)
                {
                    data01[0] += a.TextOrientation;
                    
                }
 
            }
            foreach (UglyToad.PdfPig.Content.Page page in document[1].GetPages())
            {
 
                IEnumerable<Word> words = page.GetWords(NearestNeighbourWordExtractor.Instance);
                foreach (var a in words)
                {
                    data01[1] += a.TextOrientation;

                }
    
            }
            foreach (UglyToad.PdfPig.Content.Page page in document[2].GetPages())
            {
           
                IEnumerable<Word> words = page.GetWords(NearestNeighbourWordExtractor.Instance);
                foreach (var a in words)
                {
                    data01[2] += a.TextOrientation;

                }
   
            }
            foreach (UglyToad.PdfPig.Content.Page page in document[3].GetPages())
            {
              
                IEnumerable<Word> words = page.GetWords(NearestNeighbourWordExtractor.Instance);
                foreach (var a in words)
                {
                    data01[3] += a.TextOrientation;

                }
           
            }
            foreach (UglyToad.PdfPig.Content.Page page in document[4].GetPages())
            {
            
                IEnumerable<Word> words = page.GetWords(NearestNeighbourWordExtractor.Instance);
                foreach (var a in words)
                {
                    data01[4] += a.TextOrientation;

                }
         
            }

        }
        private void load_pdf_data02()
        {
            Parallel.For(0, document.Length, i =>
            {
                data01[i] = string.Join(
                    "\n",
                    document[i]
                        .GetPages()
                        .Select(p => ContentOrderTextExtractor.GetText(p))
                );
            });
        }
        private void load_pdf_data03()
        {
            for (int i = 0; i < document.Length; i++)
            {
                data01[i] = string.Join(
                    "\n",
                    document[i]
                        .GetPages()
                        .SelectMany(p => p.GetWords(NearestNeighbourWordExtractor.Instance))
                        .Select(w => w.Text)
                );
            }
        }
        public string make_pdf_file(string input)
        {
            PdfPageBuilder page = builder.AddPage(PageSize.A4);
            // Fonts must be registered with the document builder prior to use to prevent duplication.
            PdfDocumentBuilder.AddedFont font = builder.AddStandard14Font(Standard14Font.Helvetica);
            page.AddText($"{input}", 12, new PdfPoint(25, 700), font);
            byte[] documentBytes = builder.Build();
            File.WriteAllBytes(@"C:\Users\calle\Downloads\newPdf.pdf", documentBytes);
            data01[5] = "PDF Created";
            return data01[5];

        }

    }
}
