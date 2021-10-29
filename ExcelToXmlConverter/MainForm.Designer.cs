namespace ExcelToJsonConverter2
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.NewFIleTextBox = new System.Windows.Forms.TextBox();
            this.FindPathButton = new System.Windows.Forms.Button();
            this.CovertButton = new System.Windows.Forms.Button();
            this.BottonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.DirectoryOpenButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.OpenFindButton = new System.Windows.Forms.Button();
            this.OpenJsonButton = new System.Windows.Forms.Button();
            this.TopLayout.SuspendLayout();
            this.BottonLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopLayout
            // 
            this.TopLayout.ColumnCount = 3;
            this.TopLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.83333F));
            this.TopLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.TopLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TopLayout.Controls.Add(this.FilePathLabel, 0, 0);
            this.TopLayout.Controls.Add(this.label1, 0, 1);
            this.TopLayout.Controls.Add(this.FilePathTextBox, 1, 0);
            this.TopLayout.Controls.Add(this.NewFIleTextBox, 1, 1);
            this.TopLayout.Controls.Add(this.FindPathButton, 2, 0);
            this.TopLayout.Controls.Add(this.CovertButton, 2, 1);
            this.TopLayout.Location = new System.Drawing.Point(14, 14);
            this.TopLayout.Name = "TopLayout";
            this.TopLayout.Padding = new System.Windows.Forms.Padding(2);
            this.TopLayout.RowCount = 2;
            this.TopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopLayout.Size = new System.Drawing.Size(604, 83);
            this.TopLayout.TabIndex = 0;
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Font = new System.Drawing.Font("굴림체", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FilePathLabel.Location = new System.Drawing.Point(13, 14);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(105, 14);
            this.FilePathLabel.TabIndex = 0;
            this.FilePathLabel.Text = "변환할 파일 : ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림체", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "새 파일 이름";
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FilePathTextBox.Enabled = false;
            this.FilePathTextBox.Location = new System.Drawing.Point(124, 6);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(324, 30);
            this.FilePathTextBox.TabIndex = 2;
            // 
            // NewFIleTextBox
            // 
            this.NewFIleTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NewFIleTextBox.Location = new System.Drawing.Point(124, 46);
            this.NewFIleTextBox.Name = "NewFIleTextBox";
            this.NewFIleTextBox.Size = new System.Drawing.Size(324, 30);
            this.NewFIleTextBox.TabIndex = 2;
            // 
            // FindPathButton
            // 
            this.FindPathButton.Font = new System.Drawing.Font("굴림체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FindPathButton.Location = new System.Drawing.Point(454, 5);
            this.FindPathButton.Name = "FindPathButton";
            this.FindPathButton.Size = new System.Drawing.Size(144, 33);
            this.FindPathButton.TabIndex = 3;
            this.FindPathButton.Text = "찾아보기";
            this.FindPathButton.UseVisualStyleBackColor = true;
            this.FindPathButton.Click += new System.EventHandler(this.FindPathButton_Click);
            // 
            // CovertButton
            // 
            this.CovertButton.Font = new System.Drawing.Font("굴림체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CovertButton.Location = new System.Drawing.Point(454, 44);
            this.CovertButton.Name = "CovertButton";
            this.CovertButton.Size = new System.Drawing.Size(144, 34);
            this.CovertButton.TabIndex = 3;
            this.CovertButton.Text = "변환";
            this.CovertButton.UseVisualStyleBackColor = true;
            this.CovertButton.Click += new System.EventHandler(this.CovertButton_Click);
            // 
            // BottonLayout
            // 
            this.BottonLayout.ColumnCount = 4;
            this.BottonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BottonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BottonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BottonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BottonLayout.Controls.Add(this.ExitButton, 3, 0);
            this.BottonLayout.Controls.Add(this.DirectoryOpenButton, 2, 0);
            this.BottonLayout.Controls.Add(this.OpenFindButton, 0, 0);
            this.BottonLayout.Controls.Add(this.OpenJsonButton, 1, 0);
            this.BottonLayout.Location = new System.Drawing.Point(14, 382);
            this.BottonLayout.Name = "BottonLayout";
            this.BottonLayout.Padding = new System.Windows.Forms.Padding(2);
            this.BottonLayout.RowCount = 1;
            this.BottonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottonLayout.Size = new System.Drawing.Size(604, 48);
            this.BottonLayout.TabIndex = 1;
            // 
            // DirectoryOpenButton
            // 
            this.DirectoryOpenButton.Font = new System.Drawing.Font("굴림체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DirectoryOpenButton.Location = new System.Drawing.Point(305, 5);
            this.DirectoryOpenButton.Name = "DirectoryOpenButton";
            this.DirectoryOpenButton.Size = new System.Drawing.Size(144, 38);
            this.DirectoryOpenButton.TabIndex = 0;
            this.DirectoryOpenButton.Text = "파일 위치 열기";
            this.DirectoryOpenButton.UseVisualStyleBackColor = true;
            this.DirectoryOpenButton.Click += new System.EventHandler(this.DirectoryOpenButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("굴림체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExitButton.Location = new System.Drawing.Point(455, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(144, 38);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "종료";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(14, 103);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(604, 273);
            this.ResultTextBox.TabIndex = 2;
            // 
            // OpenFindButton
            // 
            this.OpenFindButton.Font = new System.Drawing.Font("굴림체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OpenFindButton.Location = new System.Drawing.Point(5, 5);
            this.OpenFindButton.Name = "OpenFindButton";
            this.OpenFindButton.Size = new System.Drawing.Size(144, 38);
            this.OpenFindButton.TabIndex = 1;
            this.OpenFindButton.Text = "엑셀 파일 열기";
            this.OpenFindButton.UseVisualStyleBackColor = true;
            this.OpenFindButton.Click += new System.EventHandler(this.OpenFindButton_Click);
            // 
            // OpenJsonButton
            // 
            this.OpenJsonButton.Font = new System.Drawing.Font("굴림체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OpenJsonButton.Location = new System.Drawing.Point(155, 5);
            this.OpenJsonButton.Name = "OpenJsonButton";
            this.OpenJsonButton.Size = new System.Drawing.Size(144, 38);
            this.OpenJsonButton.TabIndex = 2;
            this.OpenJsonButton.Text = "변환된 파일 열기";
            this.OpenJsonButton.UseVisualStyleBackColor = true;
            this.OpenJsonButton.Click += new System.EventHandler(this.OpenJsonButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(631, 443);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.BottonLayout);
            this.Controls.Add(this.TopLayout);
            this.Font = new System.Drawing.Font("굴림체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExcelToJsonConverter";
            this.TopLayout.ResumeLayout(false);
            this.TopLayout.PerformLayout();
            this.BottonLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TopLayout;
        private System.Windows.Forms.TableLayoutPanel BottonLayout;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.TextBox NewFIleTextBox;
        private System.Windows.Forms.Button FindPathButton;
        private System.Windows.Forms.Button CovertButton;
        private System.Windows.Forms.Button DirectoryOpenButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button OpenFindButton;
        private System.Windows.Forms.Button OpenJsonButton;
    }
}

