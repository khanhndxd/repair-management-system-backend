using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.IO;

namespace repair_management_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PdfController : ControllerBase
    {
        [HttpGet("generate")]
        public IActionResult GetPDF()
        {
            QuestPDF.Settings.License = LicenseType.Community;
            var pdfBytes = Document.Create(document =>
            {
                document.Page(page =>
                {
                    page.Margin(2, Unit.Centimetre);
                    page.DefaultTextStyle(x => x.FontSize(12));
                    page.DefaultTextStyle(x => x.FontFamily("Arial"));
                    page.Header()
                    .Row(row =>
                    {
                        row.Spacing(25);

                        row.RelativeItem()

                            .Column(column =>
                            {
                                column.Item()
                                .Text("Phiếu bảo hành")
                                .SemiBold()
                                .FontSize(30)
                                .FontColor(Colors.Blue.Medium);

                                column.Item()
                                .Text("Q&A Table")
                                .Underline()
                                .FontSize(20)
                                .FontColor(Colors.Blue.Medium);
                            });
                    });

                    page.Content()
                    .PaddingVertical(25).Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            // s.no, question,qtype, weightage, sortorder
                            columns.ConstantColumn(50);
                            columns.RelativeColumn();
                            columns.RelativeColumn();
                            columns.ConstantColumn(60);
                            columns.ConstantColumn(60);
                        });
                        table.Header(header =>
                        {
                            header.Cell().Text("S.No");
                            header.Cell().AlignRight().Text("Question");
                            header.Cell().AlignRight().Text("QType");
                            header.Cell().AlignRight().Text("Weightage");
                            header.Cell().AlignRight().Text("Sortorder");

                        });
                        table.Cell().Text("1");
                        table.Cell().Text("what is the important aspects of IT?");
                        table.Cell().AlignRight().Text("Essay");
                        table.Cell().AlignRight().Text("5");
                        table.Cell().AlignRight().Text("6");

                        table.Cell().Text("2");
                        table.Cell().Text("an extension of image file?");
                        table.Cell().AlignRight().Text("Choice");
                        table.Cell().AlignRight().Text("2");
                        table.Cell().AlignRight().Text("1");

                        table.Cell().Text("3");
                        table.Cell().Text("What are security controls?");
                        table.Cell().AlignRight().Text("Essay");
                        table.Cell().AlignRight().Text("5");
                        table.Cell().AlignRight().Text("7");

                        table.Cell().Text("4");
                        table.Cell().Text("compliance standard?");
                        table.Cell().AlignRight().Text("Choice");
                        table.Cell().AlignRight().Text("2");
                        table.Cell().AlignRight().Text("2");

                        table.Cell().Text("5");
                        table.Cell().Text("Risk is the failure in component?");
                        table.Cell().AlignRight().Text("Choice");
                        table.Cell().AlignRight().Text("2");
                        table.Cell().AlignRight().Text("3");

                        table.Cell().Text("6");
                        table.Cell().Text("Third party tools in software?");
                        table.Cell().AlignRight().Text("Essay");
                        table.Cell().AlignRight().Text("5");
                        table.Cell().AlignRight().Text("5");

                        table.Cell().Text("7");
                        table.Cell().Text("What are cloud based solutions?");
                        table.Cell().AlignRight().Text("Essay");
                        table.Cell().AlignRight().Text("5");
                        table.Cell().AlignRight().Text("4");

                    });
                });
            }).GeneratePdf();

            Response.Headers.Add("content-disposition", "attachment; filename=hello.pdf");
            return File(pdfBytes, "application/pdf");
        }
    }
}
