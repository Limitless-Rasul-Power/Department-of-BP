using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WindowsForms_Task_3
{
    public static class PdfHelper
    {
        public static PdfPCell CreateNewCell(string cellName, int colSpan)
        {
            return new PdfPCell(new Phrase(cellName))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                MinimumHeight = 22f,
                Colspan = colSpan
            };
        }

    }

}
