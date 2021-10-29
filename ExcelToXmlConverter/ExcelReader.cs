using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Xml;

namespace ExcelToXMLConverter
{
    public class ExcelReader
    {
        public Excel.Application Application;
        public Excel.Workbooks Workbooks;
        public Excel.Workbook Workbook;
        public Excel.Sheets Sheets;
        public Excel.Worksheet Sheet;
        public Excel.Range Cells;
        public Excel.Range Range;

        public ExcelReader()
        {
            Application = new Excel.Application();
            Workbooks = Application.Workbooks;
            Workbook = Application.Workbooks.Add(FIleManager.FilePath);
            Sheets = Workbook.Worksheets;
            Sheet = Workbook.Worksheets.Item[1];
            Cells = (Excel.Range)Sheet.Cells;
            Range = Sheet.UsedRange;
        }

        public XmlDocument GetXMLNode()
        {
            XmlDocument xmlDoc = new XmlDocument();

            // Xml을 선언한다(xml의 버전과 인코딩 방식을 정해준다.)
            xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "yes"));

            // 루트 노드 생성
            XmlNode root = xmlDoc.CreateNode(XmlNodeType.Element, "Localization", string.Empty);
            xmlDoc.AppendChild(root);


            //데이터 이름 뽑아내기.
            List<string> nameList = new List<string>();
            for (int i = 1; i <= Range.Columns.Count; i++)
            {
                nameList.Add(Range.Cells[1, i].Value.ToString());
            }
            //모든 컬럼을 돌며 XML로 변환.
            int startRow = 2;
            for (int row = startRow; row <= Range.Rows.Count; row++)
            {
                // 자식 노드 생성
                XmlNode NewNode = xmlDoc.CreateNode(XmlNodeType.Element, "Text", string.Empty);
                root.AppendChild(NewNode);
                for (int col = 1; col <= Range.Columns.Count; col++)
                {
                    XmlElement element = xmlDoc.CreateElement(nameList[col - 1]);
                    element.InnerText = Range.Cells[row, col].Value.ToString();
                    NewNode.AppendChild(element);
                }
            }
            return xmlDoc;
        }

        public void Free()
        {
            //저장할지 물어보는거 취소.
            this.Application.DisplayAlerts = false;
            this.Application.Quit();

            Marshal.ReleaseComObject(this.Range);
            Marshal.ReleaseComObject(this.Cells);
            Marshal.ReleaseComObject(this.Sheet);
            Marshal.ReleaseComObject(this.Sheets);
            Marshal.ReleaseComObject(this.Workbook);
            Marshal.ReleaseComObject(this.Workbooks);
            Marshal.ReleaseComObject(this.Application);
        }
    }
}
