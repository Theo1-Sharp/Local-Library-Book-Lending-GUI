using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using OpenXmlPowerTools;
using Font = System.Drawing.Font;

namespace Library_Book_Lending
{
    public static class TableManagement
    {
        private static Uri FixUri(string brokenUri)
        {
            return new Uri("http://broken-link/");
        }

        public static void GetExcelFile(string path, string fileInternalName, TextBox textBox, string textBoxText)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    //Fix problematic URI's
                    UriFixer.FixInvalidUri(fs, brokenUri => FixUri(brokenUri));
                }

                using (var workbook = new XLWorkbook(path))
                {
                    Dictionary<string, List<string>> tempDic = new Dictionary<string, List<string>>();

                    List<string> tempList = new List<string>();

                    IXLWorksheet worksheet = workbook.Worksheet(1);

                    int lastColumn = 0;

                    try
                    {
                        lastColumn = worksheet.LastColumnUsed().ColumnNumber();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Избрахте таблица с празни колони!", "Грешка засечена!");
                        return;
                    }

                    textBox.Text = textBoxText;

                    int maxTableHeight = worksheet
                        .Columns()
                        .Select(c => c.Cells().Count())
                        .Max();

                    var firstHeaderCell = worksheet.FirstRowUsed().RowNumber();




                    for (int columnId = 1; columnId <= lastColumn; columnId++)
                    {
                        var firstColumnCellAddress = worksheet.Cell(firstHeaderCell, columnId);

                        var lastColumnCellAddress = worksheet.Cell(maxTableHeight, columnId);

                        var column = worksheet
                            .Range(firstColumnCellAddress + ":" + lastColumnCellAddress)
                            .Cells()
                            .Select(x => x.Value.ToString())
                            .ToArray();


                        tempList.AddRange(column);
                        tempDic[column[0]] = tempList.Skip(1).ToList();
                        tempList = new List<string>();
                    }

                    Form1.excelFilesDic[fileInternalName] = tempDic;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Таблицата не трябва да е отворена извън програмата!", "Грешка засечена!");
                return;
            }
        }

        public static void CreateEmptyTable()
        {
            if (!Form1.excelFilesDic.ContainsKey("SavedBooks"))
            {
                Dictionary<string, List<string>> tempDic = new Dictionary<string, List<string>>();

                string[] columnNames = { "Индекс", "Инв.№", "Заглавие", "Автор", "Клас", "Читател", "Дата", "Върнал" };

                for (int i = 0; i < columnNames.Length; i++)
                {
                    tempDic[columnNames[i]] = new List<string>();
                }

                Form1.excelFilesDic["SavedBooks"] = tempDic;
            }
        }

        public static void CreateNewExcelTable(string path)
        {
            if (!Form1.excelFilesDic.ContainsKey("SavedBooks"))
            {
                Dictionary<string, List<string>> tempDic = new Dictionary<string, List<string>>();

                string[] columnNames = { "Индекс", "Инв.№", "Заглавие", "Автор", "Клас", "Читател", "Дата", "Върнал" };

                for (int i = 0; i < columnNames.Length; i++)
                {
                    tempDic[columnNames[i]] = new List<string>();
                }

                Form1.excelFilesDic["SavedBooks"] = tempDic;
            }

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                //Fix problematic URI's
                UriFixer.FixInvalidUri(fs, brokenUri => FixUri(brokenUri));
            }

            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Sheet1");

            int col = 1;
            foreach (var columnName in Form1.excelFilesDic["SavedBooks"].Keys)
            {
                worksheet.Cell(1, col).Value = columnName;
                int row = 2;
                foreach (var cell in Form1.excelFilesDic["SavedBooks"][columnName])
                {
                    worksheet.Cell(row, col).Value = cell;
                    row++;
                }
                col++;
            }

            workbook.SaveAs(path);
        }

        public static void UpdateExcelTable(string path)
        {
            if (!Form1.excelFilesDic.ContainsKey("SavedBooks"))
            {
                Dictionary<string, List<string>> tempDic = new Dictionary<string, List<string>>();

                string[] columnNames = { "Индекс", "Инв.№", "Заглавие", "Автор", "Клас", "Читател", "Дата", "Върнал" };

                for (int i = 0; i < columnNames.Length; i++)
                {
                    tempDic[columnNames[i]] = new List<string>();
                }

                Form1.excelFilesDic["SavedBooks"] = tempDic;
            }

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                //Fix problematic URI's
                UriFixer.FixInvalidUri(fs, brokenUri => FixUri(brokenUri));
            }

            var workbook = new XLWorkbook(path);
            var worksheet = workbook.Worksheet(1);

            int col = 1;
            foreach (var columnName in Form1.excelFilesDic["SavedBooks"].Keys)
            {
                worksheet.Cell(1, col).Value = columnName;
                int row = 2;
                foreach (var cell in Form1.excelFilesDic["SavedBooks"][columnName])
                {
                    worksheet.Cell(row, col).Value = cell;
                    row++;
                }
                col++;
            }

            workbook.Save();
        }

        public static void UpdateDataGridView(string fileInternalName, DataGridView dataGridView1)
        {
            dataGridView1.AllowUserToResizeColumns = true;

            Cursor.Current = Cursors.WaitCursor;

            dataGridView1.Columns.Clear();

            if (Form1.excelFilesDic.Keys.Contains(fileInternalName))
            {
                var tempDic = Form1.excelFilesDic[fileInternalName];

                foreach (var item in tempDic.Keys)
                {
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        Name = item,
                        HeaderText = item
                    });
                }
                foreach (DataGridViewTextBoxColumn item in dataGridView1.Columns)
                {
                    item.HeaderCell.Style.Font = new Font("Bahnschrift SemiCondensed", 14, FontStyle.Bold);
                }

                int highestCount = tempDic.Select(x => x.Value.Count).Max();

                for (int i = 0; i < highestCount; i++)
                {
                    var row = tempDic.Select(x => x.Value[i]).ToArray();

                    dataGridView1.Rows.Add(row);
                }
            }

            switch (fileInternalName)
            {
                case "Books":
                    dataGridView1.ReadOnly = true;
                    break;
                case "Teachers":
                    dataGridView1.ReadOnly = true;
                    break;
                case "Students":
                    dataGridView1.ReadOnly = true;
                    break;
                case "SavedBooks":
                    dataGridView1.ReadOnly = false;
                    break;
            }

            Cursor.Current = Cursors.Default;
        }
    }
}
