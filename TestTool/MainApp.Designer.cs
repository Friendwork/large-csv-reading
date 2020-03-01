namespace TestTool
{
    partial class MainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.MainTab = new System.Windows.Forms.TabPage();
            this.BtnGo = new System.Windows.Forms.Button();
            this.TxtPage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnPre = new System.Windows.Forms.Button();
            this.TxtRows = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GridViewData = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtFileSize = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblLines = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSelectFile = new System.Windows.Forms.Button();
            this.TxtFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.FileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtFile1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtFile2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BtnCompare = new System.Windows.Forms.Button();
            this.TxtOutput = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.BtnStop = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.MainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewData)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.MainTab);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Location = new System.Drawing.Point(16, 11);
            this.TabControl.Margin = new System.Windows.Forms.Padding(0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1583, 817);
            this.TabControl.TabIndex = 0;
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.BtnGo);
            this.MainTab.Controls.Add(this.TxtPage);
            this.MainTab.Controls.Add(this.label7);
            this.MainTab.Controls.Add(this.BtnNext);
            this.MainTab.Controls.Add(this.BtnPre);
            this.MainTab.Controls.Add(this.TxtRows);
            this.MainTab.Controls.Add(this.label6);
            this.MainTab.Controls.Add(this.GridViewData);
            this.MainTab.Controls.Add(this.panel1);
            this.MainTab.Controls.Add(this.BtnSelectFile);
            this.MainTab.Controls.Add(this.TxtFile);
            this.MainTab.Controls.Add(this.label1);
            this.MainTab.Location = new System.Drawing.Point(4, 25);
            this.MainTab.Margin = new System.Windows.Forms.Padding(0);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(4);
            this.MainTab.Size = new System.Drawing.Size(1575, 788);
            this.MainTab.TabIndex = 0;
            this.MainTab.Text = "Read File";
            this.MainTab.UseVisualStyleBackColor = true;
            // 
            // BtnGo
            // 
            this.BtnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGo.Location = new System.Drawing.Point(1497, 214);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(52, 23);
            this.BtnGo.TabIndex = 11;
            this.BtnGo.Text = "Go";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // TxtPage
            // 
            this.TxtPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPage.Location = new System.Drawing.Point(1434, 214);
            this.TxtPage.Name = "TxtPage";
            this.TxtPage.Size = new System.Drawing.Size(44, 22);
            this.TxtPage.TabIndex = 10;
            this.TxtPage.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1360, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Page : ";
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(317, 211);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 23);
            this.BtnNext.TabIndex = 8;
            this.BtnNext.Text = "Next >>";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnPre
            // 
            this.BtnPre.Location = new System.Drawing.Point(213, 211);
            this.BtnPre.Name = "BtnPre";
            this.BtnPre.Size = new System.Drawing.Size(75, 23);
            this.BtnPre.TabIndex = 7;
            this.BtnPre.Text = "<< Prev";
            this.BtnPre.UseVisualStyleBackColor = true;
            this.BtnPre.Click += new System.EventHandler(this.BtnPre_Click);
            // 
            // TxtRows
            // 
            this.TxtRows.Location = new System.Drawing.Point(89, 211);
            this.TxtRows.Name = "TxtRows";
            this.TxtRows.Size = new System.Drawing.Size(100, 22);
            this.TxtRows.TabIndex = 6;
            this.TxtRows.Text = "100";
            this.TxtRows.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRows_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rows : ";
            // 
            // GridViewData
            // 
            this.GridViewData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewData.Location = new System.Drawing.Point(32, 254);
            this.GridViewData.Name = "GridViewData";
            this.GridViewData.Size = new System.Drawing.Size(1517, 509);
            this.GridViewData.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TxtFileSize);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.LblLines);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(32, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1517, 124);
            this.panel1.TabIndex = 3;
            // 
            // TxtFileSize
            // 
            this.TxtFileSize.AutoSize = true;
            this.TxtFileSize.Location = new System.Drawing.Point(93, 49);
            this.TxtFileSize.Name = "TxtFileSize";
            this.TxtFileSize.Size = new System.Drawing.Size(92, 16);
            this.TxtFileSize.TabIndex = 3;
            this.TxtFileSize.Text = "0 MB (0 bytes)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "FileSize :";
            // 
            // LblLines
            // 
            this.LblLines.AutoSize = true;
            this.LblLines.Location = new System.Drawing.Point(93, 16);
            this.LblLines.Name = "LblLines";
            this.LblLines.Size = new System.Drawing.Size(39, 16);
            this.LblLines.TabIndex = 1;
            this.LblLines.Text = "0 line";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lines : ";
            // 
            // BtnSelectFile
            // 
            this.BtnSelectFile.Location = new System.Drawing.Point(648, 17);
            this.BtnSelectFile.Name = "BtnSelectFile";
            this.BtnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectFile.TabIndex = 2;
            this.BtnSelectFile.Text = "Browse...";
            this.BtnSelectFile.UseVisualStyleBackColor = true;
            this.BtnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // TxtFile
            // 
            this.TxtFile.Location = new System.Drawing.Point(86, 17);
            this.TxtFile.Name = "TxtFile";
            this.TxtFile.Size = new System.Drawing.Size(544, 22);
            this.TxtFile.TabIndex = 1;
            this.TxtFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFile_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "File";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnStop);
            this.tabPage2.Controls.Add(this.TxtOutput);
            this.tabPage2.Controls.Add(this.BtnCompare);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.TxtFile2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.TxtFile1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1575, 788);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compare File";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FileOpenDialog
            // 
            this.FileOpenDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.FileOpenDialog_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtFile1
            // 
            this.TxtFile1.Location = new System.Drawing.Point(65, 15);
            this.TxtFile1.Name = "TxtFile1";
            this.TxtFile1.Size = new System.Drawing.Size(328, 22);
            this.TxtFile1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "File 1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1050, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Browse...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtFile2
            // 
            this.TxtFile2.Location = new System.Drawing.Point(700, 15);
            this.TxtFile2.Name = "TxtFile2";
            this.TxtFile2.Size = new System.Drawing.Size(328, 22);
            this.TxtFile2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(643, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "File 2";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(533, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 20);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Is sorted?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // BtnCompare
            // 
            this.BtnCompare.Location = new System.Drawing.Point(524, 62);
            this.BtnCompare.Name = "BtnCompare";
            this.BtnCompare.Size = new System.Drawing.Size(103, 43);
            this.BtnCompare.TabIndex = 11;
            this.BtnCompare.Text = "Compare";
            this.BtnCompare.UseVisualStyleBackColor = true;
            this.BtnCompare.Click += new System.EventHandler(this.BtnCompare_Click);
            // 
            // TxtOutput
            // 
            this.TxtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtOutput.Location = new System.Drawing.Point(28, 140);
            this.TxtOutput.Multiline = true;
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.Size = new System.Drawing.Size(1527, 623);
            this.TxtOutput.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(668, 62);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(92, 43);
            this.BtnStop.TabIndex = 13;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 834);
            this.Controls.Add(this.TabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestTool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainApp_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainApp_DragEnter);
            this.TabControl.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.MainTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage MainTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog FileOpenDialog;
        private System.Windows.Forms.TextBox TxtFile;
        private System.Windows.Forms.Button BtnSelectFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblLines;
        private System.Windows.Forms.Label TxtFileSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView GridViewData;
        private System.Windows.Forms.TextBox TxtRows;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPre;
        private System.Windows.Forms.TextBox TxtPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtFile2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtFile1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BtnCompare;
        private System.Windows.Forms.TextBox TxtOutput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button BtnStop;
    }
}

