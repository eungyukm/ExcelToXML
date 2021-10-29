using System;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Xml;

namespace ExcelToXMLConverter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FindPathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();

            string pathName = dialog.FileName;
            string fileName = dialog.SafeFileName;
            //파일을 가져왔을 때만.
            if (!string.IsNullOrEmpty(pathName))
            {
                FIleManager.FilePath = pathName;
                FIleManager.FileName = fileName;
                FilePathTextBox.Text = pathName;
                ResultTextBox.Text += ("변환할 파일 : " + pathName);
                ResultTextBox.Text += Environment.NewLine;
            }
        }

        private void CovertButton_Click(object sender, EventArgs e)
        {
            //파일 위치 입력 안했을 때.
            if (string.IsNullOrEmpty(FIleManager.FilePath))
            {
                ResultTextBox.Text += ("파일을 선택해야 합니다." + Environment.NewLine);
                return;
            }

            else
            {
                FIleManager.NewFileName = this.NewFIleTextBox.Text;
                FIleManager.SetNewFileName();
            }
            this.ResultTextBox.Text += ("저장될 파일 : " + FIleManager.NewFileName);

            //같은게 있을 때 경고창.
            if (FIleManager.IsExist())
            {
                if(MessageBox.Show("파일이 이미 존재합니다 덮어쓸까요?", "아이고...", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) != DialogResult.OK)
                {
                    this.ResultTextBox.Clear();
                    this.ResultTextBox.Text += ("파일명을 다시 입력해 주세요." + Environment.NewLine);
                    return;
                }
                
            }

            this.ResultTextBox.Text += Environment.NewLine;
            this.ResultTextBox.Text += ("변환을 시작합니다=============" + Environment.NewLine);

            ExcelReader excelReader = new ExcelReader();
            this.ResultTextBox.Text += (string.Format("변수 갯수 : {0}", excelReader.Range.Columns.Count) + Environment.NewLine);

            JArray dataArray = excelReader.GetJsonArray();
            XmlDocument xmlDoc = excelReader.GetXMLNode();



            this.ResultTextBox.Text += (string.Format("객체 갯수 : {0}", dataArray.Count) + Environment.NewLine);

            

            this.ResultTextBox.Text += ("변환종료 저장합니다=============" + Environment.NewLine);
            FIleManager.SaveXmlFile(xmlDoc);
            // TODO : 제거
            //FIleManager.SaveJSonFile(dataArray);

            excelReader.Free();
        }

        private void DirectoryOpenButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FIleManager.FileName))
                MessageBox.Show("먼저 파일을 찾아주세요.", "에헤이!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            //위치 열어주기.
            else
            {
                string filePath = FIleManager.FilePath;
                string dirPath = filePath.Substring(0, filePath.LastIndexOf('\\'));
                Process.Start(dirPath);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenFindButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FIleManager.FileName))
                MessageBox.Show("먼저 파일을 찾아주세요.", "쓰읍!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            //위치 열어주기.
            else
            {
                Process.Start(FIleManager.FilePath);
            }
        }

        private void OpenJsonButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FIleManager.NewFileName))
                MessageBox.Show("먼저 변환을 해야 합니다.", "노놉!!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            //위치 열어주기.
            else
            {
                Process.Start(FIleManager.NewFileName);
            }
        }
    }
}
