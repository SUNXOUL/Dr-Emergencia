using iTextSharp.text;
using iTextSharp.text.pdf;



namespace DrEmergencias
{
    public class RptSuplidor : PdfFootSuplidor
    {

        PdfWriter _PdfWriter;
        int maxColumn = 4;
        Document _document;
        PdfPTable _pdfPTable = new PdfPTable(8);
        PdfPCell _pdfPCell;
        Font _fontStyle;
        MemoryStream _memotyStream = new MemoryStream();



        public byte[] Report(List<Suplidor> suplidor)
        {
            // _ganancias = ganancias;
            _document = new Document(PageSize.NOTE, 10f, 10f, 20f, 30f);
            _fontStyle = FontFactory.GetFont("Tahoma", 8f, 1);

            _PdfWriter = PdfWriter.GetInstance(_document, _memotyStream);
            _PdfWriter.PageEvent = new PdfFootSuplidor();

            _document.Open();

            Paragraph titlePricipal = new Paragraph();
            titlePricipal.Font = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 14f);
            titlePricipal.Alignment = Element.ALIGN_CENTER;
            titlePricipal.Add("Lista De Ganancias");
            titlePricipal.SpacingAfter = 5;
            _document.Add(titlePricipal);

            Font fonttabla = new Font(Font.FontFamily.TIMES_ROMAN, 12, Font.BOLD);
            Font font = new Font(Font.FontFamily.TIMES_ROMAN, 12, Font.NORMAL);

            //tabla detalle monto mensual
            PdfPTable tblLocal = new PdfPTable(3);
            tblLocal.WidthPercentage = 100;
            float[] widths = new float[] { 3f, 5f, 3f };
            tblLocal.SetWidths(widths);

            PdfPCell clId = new PdfPCell(new Phrase("Id", fonttabla));
            PdfPCell clFecha = new PdfPCell(new Phrase("Nombre", fonttabla));
            PdfPCell clGanancia = new PdfPCell(new Phrase("Contacto", fonttabla));
        

            tblLocal.AddCell(clId);
            tblLocal.AddCell(clFecha);
            tblLocal.AddCell(clGanancia);
        

            PdfPCell cell = new PdfPCell();
            foreach (var supli in suplidor)
            {
                cell = new PdfPCell(new Phrase(supli.SuplidorID.ToString(), font));
                tblLocal.AddCell(cell);
                cell = new PdfPCell(new Phrase(supli.Nombre.ToString(), font));
                tblLocal.AddCell(cell);
                cell = new PdfPCell(new Phrase(supli.Contacto.ToString(), font));
                tblLocal.AddCell(cell);
            }

            _document.Add(tblLocal);

            this.OnEndPage(_PdfWriter, _document);
            _document.Close();

            return _memotyStream.ToArray();
        }


    }
}