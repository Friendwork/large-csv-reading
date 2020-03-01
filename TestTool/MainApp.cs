using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTool
{
    public partial class MainApp : Form
    {

        private int currentPage = 1;

        public MainApp()
        {
            InitializeComponent();
            GridViewData.DoubleBuffered(true);
            AllowDrop = true;

            openFileDialog1.FileOk += OpenFileDialog1_FileOk;
            openFileDialog2.FileOk += OpenFileDialog2_FileOk;
        }

        #region READ FILE

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            FileOpenDialog.ShowDialog();
        }

        private async void FileOpenDialog_FileOk(object sender, CancelEventArgs e)
        {
            TxtFile.Text = FileOpenDialog.FileName;
            currentPage = 1;
            readFileLines();
            await loadReadFileData();
        }

        private async void TxtFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                await loadReadFileData();
            }
        }

        private void readFileLines()
        {
            LblLines.Text = "Counting...";
            FileStream fs = new FileStream(TxtFile.Text, FileMode.Open, FileAccess.Read, FileShare.None, 1024 * 1024);

            long lineCount = 0;
            byte[] buffer = new byte[1024 * 1024];
            int bytesRead;

            do
            {
                bytesRead = fs.Read(buffer, 0, buffer.Length);
                for (int i = 0; i < bytesRead; i++)
                    if (buffer[i] == '\n')
                        lineCount++;
            }
            while (bytesRead > 0);
            LblLines.Text = String.Format("{0:n0}", lineCount) + " line includes header";
            fs.Close();
        }

        private async Task loadReadFileData()
        {
            FileInfo fileInfo = new FileInfo(TxtFile.Text);
            double size = fileInfo.Length;
            TxtFileSize.Text = Math.Round((size / 1024 / 1024), 2) + " MB (" + size + " bytes)";

            // read lines
            int pageSize = int.Parse(TxtRows.Text);
            using (var reader = File.OpenText(TxtFile.Text))
            {
                // read header
                String line = await reader.ReadLineAsync();
                if (line == null)
                {
                    return;
                }
                string[] headers = line.Split(new char[] { ',' });
                GridViewData.Columns.Clear();
                GridViewData.Columns.Add("Line", "Line");
                foreach (string header in headers)
                {
                    GridViewData.Columns.Add(header, header);
                }

                int currentRow = 0;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    currentRow++;
                    if (currentRow >= pageSize * currentPage)
                    {
                        break;
                    }
                    if ((currentPage - 1) * pageSize <= currentRow)
                    {
                        string[] values = line.Split(new char[] { ',' });
                        var list = values.ToList();
                        list.Insert(0, currentRow.ToString());
                        values = list.ToArray();
                        GridViewData.Rows.Add(values);
                    }
                }
            }
        }

        private async void MainApp_DragDrop(object sender, DragEventArgs e)
        {
            if (TabControl.SelectedTab == MainTab)
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                TxtFile.Text = files[0];
                currentPage = 1;
                readFileLines();
                await loadReadFileData();
            }
            else
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                TxtFile1.Text = files[0];
                if(files.Length > 1)
                {
                    TxtFile2.Text = files[1];
                }
            }
        }

        private void MainApp_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private async void BtnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            await loadReadFileData();
        }

        private async void BtnPre_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                await loadReadFileData();
            }
        }

        private async void TxtRows_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.currentPage = 1;
                await loadReadFileData();
            }
        }

        private async void BtnGo_Click(object sender, EventArgs e)
        {
            currentPage = int.Parse(TxtPage.Text);
            await loadReadFileData();
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            TxtFile1.Text = openFileDialog1.FileName;
        }

        private void OpenFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            TxtFile2.Text = openFileDialog2.FileName;
        }

        CancellationTokenSource source;

        private async void BtnCompare_Click(object sender, EventArgs e)
        {
            source = new CancellationTokenSource();

            await Task.Factory.StartNew(() =>
            {
                var reader1 = File.OpenText(TxtFile1.Text);
                var reader2 = File.OpenText(TxtFile2.Text);

                string line1 = null;
                while ((line1 = reader1.ReadLine()) != null)
                {
                    String line2 = reader2.ReadLine();
                    if (!line1.Equals(line2))
                    {
                        TxtOutput.Text += line1 + "\n" + line2 + "==========\n";
                    }
                }

                reader1.Close();
                reader2.Close();
            }, source.Token);
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            try
            {
                source.Cancel();
            }
            catch { }
        }
    }
}
