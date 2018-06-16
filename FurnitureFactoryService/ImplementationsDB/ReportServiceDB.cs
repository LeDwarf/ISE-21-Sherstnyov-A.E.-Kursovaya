using FurnitureFactoryService.BindingModels;
using FurnitureFactoryService.Interfaces;
using FurnitureFactoryService.ViewModels;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.IO;
using System.Linq;

namespace FurnitureFactoryService.ImplementationsDB
{
    public class ReportServiceDB : IReportService
    {
        private FurnitureFactoryDbContext context;

        public ReportServiceDB(FurnitureFactoryDbContext context)
        {
            this.context = context;
        }

        public List<SalaryViewModel> GetSalary(ReportBindingModel model)
        {
            return context.Orders
                            .Include(rec => rec.Employee)
                            .Where(rec => rec.DateBegin >=  model.DateFrom && rec.DateDone <= model.DateTo)
                            .Select(rec => new SalaryViewModel
                            {
                                EmployeeFIO = rec.Employee.EmployeeFIO,
                                DateDone = SqlFunctions.DateName("dd", rec.DateDone) + " " +
                                            SqlFunctions.DateName("mm", rec.DateDone) + " " +
                                            SqlFunctions.DateName("yyyy", rec.DateDone),
                                Salary = rec.Employee.Salary
                            })
                            .ToList();
        }

        public void SaveSalary(ReportBindingModel model)
        {
            if (!File.Exists("TIMCYR.TTF"))
            {
                File.WriteAllBytes("TIMCYR.TTF", Properties.Resources.TIMCYR);
            }
            FileStream fs = new FileStream(model.FileName, FileMode.OpenOrCreate, FileAccess.Write);
            iTextSharp.text.Document doc = new iTextSharp.text.Document();
            doc.SetMargins(0.5f, 0.5f, 0.5f, 0.5f);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);

            doc.Open();
            BaseFont baseFont = BaseFont.CreateFont("TIMCYR.TTF", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            var phraseTitle = new Phrase("Зарплата",
                new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD));
            iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph(phraseTitle)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingAfter = 12
            };
            doc.Add(paragraph);

            var phrasePeriod = new Phrase("c " + model.DateFrom.Value.ToShortDateString() +
                                    " по " + model.DateTo.Value.ToShortDateString(),
                                    new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD));
            paragraph = new iTextSharp.text.Paragraph(phrasePeriod)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingAfter = 12
            };
            doc.Add(paragraph);

            PdfPTable table = new PdfPTable(3)
            {
                TotalWidth = 800F
            };
            PdfPCell cell = new PdfPCell();
            var fontForCellBold = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.BOLD);
            table.AddCell(new PdfPCell(new Phrase("ФИО сотрудника", fontForCellBold))
            {
                HorizontalAlignment = Element.ALIGN_CENTER
            });
            table.AddCell(new PdfPCell(new Phrase("Дата начисления", fontForCellBold))
            {
                HorizontalAlignment = Element.ALIGN_CENTER
            });
            table.AddCell(new PdfPCell(new Phrase("Сумма", fontForCellBold))
            {
                HorizontalAlignment = Element.ALIGN_CENTER
            });
            var list = GetSalary(model);
            var fontForCells = new iTextSharp.text.Font(baseFont, 10);
            List<string> employees = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {               
                if (!employees.Contains(list[i].EmployeeFIO))
                {
                    cell = new PdfPCell(new Phrase(list[i].EmployeeFIO, fontForCells));
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(list[i].DateDone, fontForCells));
                    cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(list[i].Salary.ToString(), fontForCells));
                    cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                    table.AddCell(cell);
                    employees.Add(list[i].EmployeeFIO);
                }                               
            }
            cell = new PdfPCell(new Phrase("", fontForCellBold))
            {
                Border = 0
            };
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase("Итого:", fontForCellBold))
            {
                HorizontalAlignment = Element.ALIGN_RIGHT,
                Border = 0
            };
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(list.Sum(rec => rec.Salary).ToString(), fontForCellBold))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                Border = 0
            };
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase("", fontForCellBold))
            {
                Border = 0
            };
            table.AddCell(cell);
            doc.Add(table);

            doc.Close();
        }
    }
}
