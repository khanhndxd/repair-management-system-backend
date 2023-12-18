using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using repair_management_backend.DTOs.Pdf;
using System.Globalization;
using System.IO;

namespace repair_management_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PdfController : ControllerBase
    {
        [HttpPost("Generate")]
        public IActionResult GetPDF([FromBody] PdfGenerationRequest pdfGenerationRequest)
        {
            QuestPDF.Settings.License = LicenseType.Community;
            var pdfBytes = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(1, Unit.Centimetre);
                    page.Size(PageSizes.A5);
                    page.DefaultTextStyle(x => x.FontSize(6));
                    page.DefaultTextStyle(x => x.FontFamily("Arial"));
                    page.Header()
                    .Row(row =>
                    {
                        row.AutoItem().Text("Công ty TNHH Nguyễn Duy Khánh").FontSize(6);
                    });

                    page.Content().Column(column =>
                    {
                        column.Spacing(4);
                        column.Item().AlignCenter().Text("Phiếu bảo hành").FontSize(16).Bold();
                        column.Item().Table(table0 => 
                        {
                            table0.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(50);
                                columns.RelativeColumn();
                                columns.ConstantColumn(50);
                                columns.RelativeColumn();
                            });

                            table0.Cell().AlignLeft().Text("Khách hàng").FontSize(6).Bold();
                            table0.Cell().AlignLeft().Text(pdfGenerationRequest.CustomerName).FontSize(6);
                            table0.Cell().AlignLeft().Text("Số phiếu").FontSize(6).Bold();
                            table0.Cell().AlignLeft().Text(pdfGenerationRequest.RepairOrderId).FontSize(6);

                            table0.Cell().AlignLeft().Text("Địa chỉ").FontSize(6).Bold();
                            table0.Cell().AlignLeft().Text(pdfGenerationRequest.CustomerAddress).FontSize(6);
                            table0.Cell().AlignLeft().Text("Ngày tiếp nhận").FontSize(6).Bold();
                            table0.Cell().AlignLeft().Text(pdfGenerationRequest.CreatedAt.ToString("dd-MM-yyyy")).FontSize(6);

                            table0.Cell().AlignLeft().Text("Số điện thoại").FontSize(6).Bold();
                            table0.Cell().AlignLeft().Text(pdfGenerationRequest.CustomerPhone).FontSize(6);
                            table0.Cell().AlignLeft().Text("Ngày trả hàng").FontSize(6).Bold();
                            table0.Cell().AlignLeft().Text(pdfGenerationRequest.ReceiveAt.ToString("dd-MM-yyyy")).FontSize(6);

                            table0.Cell().AlignLeft().Text("Lý do bảo hành").FontSize(6).Bold();
                            table0.Cell().AlignLeft().Text(pdfGenerationRequest.RepairReason).FontSize(6);
                            table0.Cell().AlignLeft().Text("Người tạo phiếu").FontSize(6).Bold();
                            table0.Cell().AlignLeft().Text(pdfGenerationRequest.CreatedBy).FontSize(6);
                        });
                        column.Item().Text("Sản phẩm bảo hành").FontSize(9).Bold();
                        column.Item().Table(table1 =>
                        {
                            table1.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(50);
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                            });

                            table1.Header(header =>
                            {
                                header.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text("STT").FontSize(6);
                                header.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text("Mã sản phẩm").FontSize(6);
                                header.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text("Tên sản phẩm").FontSize(6);
                            });

                            var index1 = 1;
                            foreach (var item in pdfGenerationRequest.RepairProducts)
                            {
                                table1.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text(index1).FontSize(6);
                                table1.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text(item.Id).FontSize(6);
                                table1.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text(item.Name).FontSize(6);
                                index1++;
                            }
                            foreach (var item in pdfGenerationRequest.RepairCustomerProducts)
                            {
                                table1.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text(index1).FontSize(6);
                                table1.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text(item.Id).FontSize(6);
                                table1.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text(item.Name).FontSize(6);
                                index1++;
                            }
                        });
                        column.Item().Text("Công việc bảo hành").FontSize(9).Bold();
                        column.Item().Table(table2 =>
                        {
                            table2.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(50);
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                            });

                            table2.Header(header =>
                            {
                                header.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text("STT").FontSize(6);
                                header.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text("Mã công việc").FontSize(6);
                                header.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text("Tên công việc").FontSize(6);
                                header.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text("Chi phí").FontSize(6);
                            });

                            var index2 = 1;
                            foreach (var item in pdfGenerationRequest.RepairTasks)
                            {
                                table2.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text(index2).FontSize(6);
                                table2.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text(item.Id).FontSize(6);
                                table2.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text(item.Name).FontSize(6);
                                table2.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text(ConvertToVND(item.Price)).FontSize(6);
                                index2++;
                            }
                        });
                        column.Item().Text("Linh kiện thay thế").FontSize(9).Bold();
                        column.Item().Table(table3 =>
                        {
                            table3.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(50);
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                            });

                            table3.Header(header =>
                            {
                                header.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text("STT").FontSize(6);
                                header.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text("Mã linh kiện").FontSize(6);
                                header.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text("Tên linh kiện").FontSize(6);
                                header.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text("Đơn vị").FontSize(6);
                                header.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text("Số lượng").FontSize(6);
                            });

                            var index3 = 1;
                            foreach (var item in pdfGenerationRequest.Accessories)
                            {
                                table3.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text(index3).FontSize(6);
                                table3.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text(item.Id).FontSize(6);
                                table3.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text(item.Name).FontSize(6);
                                table3.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text(item.Unit).FontSize(6);
                                table3.Cell().Border((float)0.5).AlignCenter().AlignMiddle().Text(item.Quantity).FontSize(6);
                                index3++;
                            }
                        });
                        column.Item().Text($"Tổng tiền: {ConvertToVND(pdfGenerationRequest.TotalPrice)}").FontSize(10);
                        column.Item().PaddingTop(15).Table(table3 =>
                        {
                            table3.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                            });

                            table3.Cell().AlignCenter().Text("Khách hàng").FontSize(6).Bold();
                            table3.Cell().AlignCenter().Text("Người lập phiếu").FontSize(6).Bold();
                            table3.Cell().AlignCenter().Text("Kỹ thuật viên").FontSize(6).Bold();

                            table3.Cell().AlignCenter().Text("(Ký, họ tên)").FontSize(6);
                            table3.Cell().AlignCenter().Text("(Ký, họ tên)").FontSize(6);
                            table3.Cell().AlignCenter().Text("(Ký, họ tên)").FontSize(6);
                        });
                    });
                });
            }).GeneratePdf();

            Response.Headers.Add("content-disposition", "attachment; filename=baohanh.pdf");
            return File(pdfBytes, "application/pdf");
        }
        public static string ConvertToVND(double price)
        {
            // Tạo một đối tượng CultureInfo cho tiếng Việt (Việt Nam)
            CultureInfo cultureInfo = new CultureInfo("vi-VN");

            // Định dạng giá trị số thành chuỗi tiền tệ
            string formattedPrice = price.ToString("C0", cultureInfo);

            return formattedPrice;
        }
    }
}
