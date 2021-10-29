using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Xml;

namespace ExcelToXMLConverter
{
    public class FIleManager
    {
        public static string @FilePath { get; set; }
        public static string @NewFileName { get; set; }
        public static string @FileName { get; set; }

        public static void SetNewFileName()
        {
            //파일 경로가 있을때.
            if (!string.IsNullOrEmpty(FilePath))
            {
                string path = FilePath.Substring(0, FilePath.LastIndexOf('\\') + 1);
                //새로운파일 이름 입력 안했을 때.
                if (string.IsNullOrEmpty(NewFileName))
                {
                    string newName = FilePath.Substring(FilePath.LastIndexOf('\\') + 1, FileName.Split('.')[0].Length) + @".xml";
                    NewFileName = path + newName;
                }

                //입력 했을 때.
                else
                {
                    if (NewFileName.Contains(".xml"))
                    {
                        //json입력.
                        NewFileName = path + NewFileName;
                    }
                    else
                    {
                        NewFileName = path + NewFileName + @".xml";
                    }
                }
            }
        }

        public static bool IsExist()
        {
            return File.Exists(NewFileName);
        }

        public static void SaveXmlFile(XmlDocument xml)
        {
            xml.Save(NewFileName);
        }
    }
}
