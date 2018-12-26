using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace HotelReservationSoftware
{
    public partial class frmExportFormats : Form
    {
        private DataGridView DataGridView;

        public frmExportFormats(DataGridView dataGridView)
        {
            InitializeComponent();
            DataGridView = dataGridView;
        }

        private void ToExcel(DataGridView dGV, string filename)
        {
            Excel.Application xlApp = new Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;            Excel.Range xlRange;

            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets[1];

            for (int j = 0; j < dGV.Columns.Count; j++)
            {
                xlWorkSheet.Cells[1, j+1] = dGV.Columns[j].HeaderText;

            }
            xlRange = xlWorkSheet.get_Range("I1").EntireColumn;
            xlRange.NumberFormat = "@";

            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                {
                    xlWorkSheet.Cells[i + 2, j + 1] = dGV.Rows[i].Cells[j].Value;
                }
            }

            xlWorkBook.SaveAs(filename, Excel.XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
        }

        // Function for exporting to Excel
        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            try
            {
                //UTF8Encoding utf8 = new UTF8Encoding();
                //Encoding utf16 = Encoding.GetEncoding(866);
                //byte[] output = utf8.GetBytes(stOutput);
                byte[] output = Encoding.Default.GetBytes(stOutput);
                FileStream fs = new FileStream(filename, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(output, 0, output.Length); //write the encoded file

                bw.Flush();
                bw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMessage(ex.ToString(), "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // Function for exporting to HTML
        private void DataGridtoHTML(DataGridView dg, string filename)
        {
            string stOutput = "";
            StringBuilder strB = new StringBuilder();
            //create html & table
            strB.AppendLine("<html><body><center><" +
                          "table border='1' cellpadding='0' cellspacing='0'>");
            strB.AppendLine("<tr>");
            //cteate table header
            for (int i = 0; i < dg.Columns.Count; i++)
            {
                strB.AppendLine("<th align='center' valign='middle'>" +
                               dg.Columns[i].HeaderText + "</th>");
            }
            //create table body
            strB.AppendLine("</tr><tr>");
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                strB.AppendLine("<tr>");
                foreach (DataGridViewCell dgvc in dg.Rows[i].Cells)
                {
                    strB.AppendLine("<td align='center' valign='middle'>" +
                                    dgvc.Value.ToString() + "</td>");
                }
                strB.AppendLine("</tr>");

            }
            //table footer & end of html file
            strB.AppendLine("</table></center></body></html>");
            stOutput = strB.ToString();
            try
            {
                //UTF8Encoding utf8 = new UTF8Encoding();
                //Encoding utf16 = Encoding.GetEncoding(866);
                //byte[] output = utf8.GetBytes(stOutput);
                byte[] output = Encoding.Default.GetBytes(stOutput);
                FileStream fs = new FileStream(filename, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(output, 0, output.Length); //write the encoded file

                bw.Flush();
                bw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMessage(ex.ToString(), "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void DataGridToTextFile(DataGridView dataGridView, string filename)
        {
            StringBuilder builder = new StringBuilder();
            int rowcount = dataGridView.Rows.Count;
            int columncount = dataGridView.Columns.Count;

            List<string> headerCols = new List<string>();
            for (int j = 0; j < columncount - 1; j++)
            {
                headerCols.Add(dataGridView.Columns[j].HeaderText);
            }
            builder.AppendLine(string.Join("\t", headerCols));

            for (int i = 0; i < rowcount - 1; i++)
            {
                List<string> cols = new List<string>();
                for (int j = 0; j < columncount - 1; j++)
                {
                    cols.Add(dataGridView.Rows[i].Cells[j].Value.ToString());
                }
                builder.AppendLine(string.Join("\t", cols.ToArray()));
            }
            File.WriteAllText(filename, builder.ToString());
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string fileName = "Reservations_" + DateTime.Now.ToString("yyyyMMdd");

            // Export to Excel file
            if (rbExcel.Checked)
            {
               saveFileDialog.Filter = "Excel Documents (*.xls)|*.xls";
               saveFileDialog.FileName = fileName + ".xlsx";
                
                    //ToExcel(DataGridView, "d:\\bookings.xlsx");
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //ToCsV(DataGridView, saveFileDialog.FileName);
                    ToExcel(DataGridView, saveFileDialog.FileName);
                    ShowFile(saveFileDialog.FileName, "Excel");
                }
            }
            else if (rbHTML.Checked) // Export to HTML file
            {
                saveFileDialog.Filter = "HTML Documents (*.html)|*.html";
                saveFileDialog.FileName = fileName + ".html";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    DataGridtoHTML(DataGridView, saveFileDialog.FileName);
                    ShowFile(saveFileDialog.FileName, "HTML");
                }
            }
            else // Export to text file
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                saveFileDialog.FileName = fileName + ".txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    DataGridToTextFile(DataGridView, saveFileDialog.FileName);
                    ShowFile(saveFileDialog.FileName, "TXT");
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowFile(string filename, string typeOfFile)
        {
            if (MyMessageBox.ShowMessage("Експортването на файла беше успешно!\nЖелаете ли да го отворите за преглед ? ", "Експорт", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                switch (typeOfFile)
                {
                    case "Excel":
                        {
                            string excelSheet = filename;
                            var excelApp = new Excel.Application
                            {
                                Visible = true
                            };

                            Excel.Workbooks workbooks = excelApp.Workbooks;
                            Excel.Workbook sheet = workbooks.Open(excelSheet);
                            
                            break;
                        }

                    case "HTML":
                        Process.Start(filename);
                        break;
                    case "TXT":
                        Process.Start("notepad.exe", filename);
                        break;
                }
            }
            else
            {
                Close();
            }
        }
    }
}