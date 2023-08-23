using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Color = System.Drawing.Color;
using Control = System.Windows.Forms.Control;

namespace Library_Book_Lending
{
    public partial class Form1 : Form
    {
        string[] addControls = { "addButton" };
        string[] removeControls = { "removeButton" };
        string[] checkControls = { "checkButton" };

        public static Dictionary<string, Dictionary<string, List<string>>> excelFilesDic
            = new Dictionary<string, Dictionary<string, List<string>>>();

        Dictionary<string, string> filePaths = new Dictionary<string, string>();

        public OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Files|*.xlsx;*.xlsm" };
        public SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Files|*.xlsx;*.xlsm" };

        //Leaving this to have a way of iterating over controls.
        //private void IterateControls(Control parent)
        //{
        //    foreach (Control control in parent.Controls)
        //    {
        //        if (control.HasChildren)
        //        {
        //            IterateControls(control);
        //        }
        //    }
        //}

        public Form1()
        {
            InitializeComponent();

            string customGreen = "#373D20";

            string customBrown = "#8D7767";

            int count = 1;

            dataGridView1.TopLeftHeaderCell.Style.BackColor = (Color)ColorTranslator.FromHtml("#5C4226");

            //Going to keep this one incase I need alternating column colors
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (count % 2 == 0)
                {
                    DataGridViewColumnHeaderCell headerCell = column.HeaderCell;
                    headerCell.Style.BackColor = (Color)ColorTranslator.FromHtml(customGreen);
                }
                count++;
            }

            count = 1;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (count % 2 == 0)
                {
                    DataGridViewRowHeaderCell headerCell = row.HeaderCell;
                    headerCell.Style.BackColor = (Color)ColorTranslator.FromHtml(customBrown);
                }
                count++;
            }

            TableManagement.CreateEmptyTable();
        }

        public void MakeVisile(string[] arr, bool input)
        {
            foreach (string name in arr)
            {
                Control c = this.Controls.Find(name, true).FirstOrDefault();

                c.Visible = input;

                if (name == addControls[0])
                {
                    foreach (Control child in c.Controls)
                    {
                        child.Visible = input;
                    }

                    continue;
                }

                c.Visible = input;
            }
        }

        /*
         Button for displaying help information.
         */

        private void infoButton_Click(object sender, EventArgs e)
        {
            string resourceName = "Library_Book_Lending.Text.txt";
            Assembly assembly = Assembly.GetExecutingAssembly();

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string title = "Информация за работа.";

                string result = reader.ReadToEnd();

                MessageBox.Show(result, title);
            }
        }

        /*
         Buttons for writing inside the textboxes using data from the DataGridView.
         */

        private void getBookButton_Click(object sender, EventArgs e)
        {
            if (radioButtonIsChecked("radioButtonBooks"))
            {
                var currentRow = dataGridView1
                    .CurrentRow
                    .Cells
                    .Cast<DataGridViewCell>()
                    .ToArray();

                foreach (DataGridViewCell cell in currentRow)
                {
                    string columnHeaderName = dataGridView1.Columns[cell.ColumnIndex].HeaderText;
                    switch (columnHeaderName)
                    {
                        case "Инв.№":
                            inventoryTextBox.Text = cell.Value.ToString();
                            break;
                        case "Инв .№":
                            inventoryTextBox.Text = cell.Value.ToString();
                            break;
                        case "Инв. №":
                            inventoryTextBox.Text = cell.Value.ToString();
                            break;
                        case "Автор":
                            authorTextBox.Text = cell.Value.ToString();
                            break;
                        case "Заглавие":
                            bookNameTextBox.Text = cell.Value.ToString();
                            break;
                    }
                }
            }
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            if (radioButtonIsChecked("radioButtonTeachers") ||
                radioButtonIsChecked("radioButtonStudents"))
            {
                var currentRow = dataGridView1
                    .CurrentRow
                    .Cells
                    .Cast<DataGridViewCell>()
                    .ToArray();

                foreach (DataGridViewCell cell in currentRow)
                {
                    string columnHeaderName = dataGridView1.Columns[cell.ColumnIndex].HeaderText;
                    switch (columnHeaderName)
                    {
                        case "Учители":
                            readerTextBox.Text = cell.Value.ToString();
                            classTextBox.Text = "";
                            break;
                        case "Имена":
                            readerTextBox.Text = cell.Value.ToString();
                            break;
                        case "Клас":
                            classTextBox.Text = cell.Value.ToString();
                            break;
                    }
                }
            }
        }

        private void chooseButton_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Button).ForeColor = Color.Black;
        }
        private void chooseButton_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.FromArgb(252, 239, 217);
        }

        private void chooseButton_MouseUp(object sender, MouseEventArgs e)
        {
            (sender as Button).ForeColor = Color.FromArgb(252, 239, 217);
        }



        private void getBookButton_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Button).ForeColor = Color.Black;
        }

        private void getBookButton_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.FromArgb(252, 239, 217);
        }
        private void getBookButton_MouseUp(object sender, MouseEventArgs e)
        {
            (sender as Button).ForeColor = Color.FromArgb(252, 239, 217);
        }

        /*
         Buttons for choosing operation method. 
         */

        private void savedFileButton_Click(object sender, EventArgs e)
        {
            uploadFileButtons("SavedBooks", "radioButtonSaved", savedBooksTextBox);
        }

        private void teachersFileButton_Click(object sender, EventArgs e)
        {
            uploadFileButtons("Teachers", "radioButtonTeachers", teachersFileTextBox);
        }

        private void studentsFileButton_Click(object sender, EventArgs e)
        {
            uploadFileButtons("Students", "radioButtonStudents", studentsFileTextBox);
        }

        private void booksFileButton_Click(object sender, EventArgs e)
        {
            uploadFileButtons("Books", "radioButtonBooks", booksFileTextBox);
        }

        public void uploadFileButtons(string fileInternalName, string radioButtonName, TextBox textBox)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string sFileName = Path.GetFileName(ofd.FileName);

                TableManagement.GetExcelFile(ofd.FileName, fileInternalName, textBox, sFileName);

                if (radioButtonIsChecked(radioButtonName))
                {
                    TableManagement.UpdateDataGridView(fileInternalName, dataGridView1);
                }

                filePaths[fileInternalName] = ofd.FileName;
            }
        }

        /*
         Buttons for choosing operation method. 
         */

        private void radioButtonAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAdd.Checked == true)
            {
                MakeVisile(addControls, true);
            }
            else
            {
                MakeVisile(addControls, false);
            }
        }

        private void radioButtonRemove_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRemove.Checked == true)
            {
                MakeVisile(removeControls, true);
            }
            else
            {
                MakeVisile(removeControls, false);
            }
        }

        private void radioButtonCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCheck.Checked == true)
            {
                MakeVisile(checkControls, true);
            }
            else
            {
                MakeVisile(checkControls, false);
            }
        }

        /* Action buttons for changing the saved table */

        private void addButton_Click(object sender, EventArgs e)
        {
            if (excelFilesDic.ContainsKey("SavedBooks"))
            {
                var tempDic = excelFilesDic["SavedBooks"];

                tempDic["Индекс"].Add(indexTextBox.Text);
                tempDic["Инв.№"].Add(inventoryTextBox.Text);
                tempDic["Заглавие"].Add(bookNameTextBox.Text);
                tempDic["Автор"].Add(authorTextBox.Text);
                tempDic["Клас"].Add(classTextBox.Text);
                tempDic["Читател"].Add(readerTextBox.Text);
                tempDic["Дата"].Add(dateTimePicker1.Text);
                tempDic["Върнал"].Add("Не");

                UpdateIndexID();

                if (radioButtonIsChecked("radioButtonSaved"))
                {
                    TableManagement.UpdateDataGridView("SavedBooks", dataGridView1);
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (excelFilesDic.ContainsKey("SavedBooks"))
            {
                if (dataGridView1.CurrentRow != null)
                {
                    var tempDic = excelFilesDic["SavedBooks"];

                    var indexRowCell = dataGridView1
                        .CurrentRow
                        .Cells
                        .Cast<DataGridViewCell>()
                        .ToArray()
                        .FirstOrDefault(x => dataGridView1.Columns[x.ColumnIndex].HeaderText == "Индекс");

                    int rowDicIndex = tempDic["Индекс"].IndexOf(indexRowCell.Value.ToString());


                    for (int i = 0; i < tempDic.Count; i++)
                    {
                        tempDic.ElementAt(i).Value.RemoveAt(rowDicIndex);
                    }

                    if (radioButtonIsChecked("radioButtonSaved"))
                    {
                        TableManagement.UpdateDataGridView("SavedBooks", dataGridView1);
                    }

                    UpdateIndexID();
                }
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (excelFilesDic.ContainsKey("SavedBooks"))
            {
                if (dataGridView1.CurrentRow != null)
                {
                    var tempDic = excelFilesDic["SavedBooks"];

                    var currentRow = dataGridView1
                       .CurrentRow
                       .Cells
                       .Cast<DataGridViewCell>()
                       .ToArray();

                    var indexRowCell = currentRow
                        .FirstOrDefault(x => dataGridView1.Columns[x.ColumnIndex].HeaderText == "Индекс");

                    var checkedBookCell = currentRow
                        .FirstOrDefault(x => dataGridView1.Columns[x.ColumnIndex].HeaderText == "Върнал"); ;

                    var rowID = tempDic["Индекс"].IndexOf(indexRowCell.Value.ToString());

                    if (checkedBookCell.Value.ToString() == "Не")
                    {
                        tempDic["Върнал"][rowID] = "Да";
                    }
                    else
                    {
                        tempDic["Върнал"][rowID] = "Не";
                    }
                }

                if (radioButtonIsChecked("radioButtonSaved"))
                {
                    TableManagement.UpdateDataGridView("SavedBooks", dataGridView1);
                }
            }
        }

        /*
         Buttons for choosing excel files. 
         */

        private void radioButtonStudents_CheckedChanged(object sender, EventArgs e)
        {
            TableManagement.UpdateDataGridView("Students", dataGridView1);
        }

        private void radioButtonTeachers_CheckedChanged(object sender, EventArgs e)
        {
            TableManagement.UpdateDataGridView("Teachers", dataGridView1);
        }

        private void radioButtonSaved_CheckedChanged(object sender, EventArgs e)
        {
            TableManagement.UpdateDataGridView("SavedBooks", dataGridView1);

            UpdateIndexID();
        }
        private void radioButtonBooks_CheckedChanged(object sender, EventArgs e)
        {
            TableManagement.UpdateDataGridView("Books", dataGridView1);
        }

        /*
         Save/Update excel file methods
         */

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var currentCell = dataGridView1.CurrentCell;

            var headerColumnName = dataGridView1.Columns[currentCell.ColumnIndex].HeaderText;

            if (radioButtonIsChecked("radioButtonSaved"))
            {
                if (excelFilesDic.Keys.Contains("SavedBooks"))
                {
                    excelFilesDic["SavedBooks"][headerColumnName][currentCell.RowIndex] =
                        currentCell.Value.ToString();
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (filePaths.ContainsKey("SavedBooks"))
            {
                if (File.Exists(filePaths["SavedBooks"]))
                {
                    Save(filePaths["SavedBooks"]);
                    return;
                }
                SaveAs();
            }
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        public void Save(string path)
        {
            TableManagement.UpdateExcelTable(path);
        }

        public void SaveAs()
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string sFileName = Path.GetFileName(sfd.FileName);

                TableManagement.CreateNewExcelTable(sfd.FileName);

                savedBooksTextBox.Text = sFileName;

                filePaths["SavedBooks"] = sfd.FileName;
            }
        }

        /* See if the given radio button is already checked. */

        public bool radioButtonIsChecked(string name)
        {
            var selectedRadioButton = this.Controls.Find("panel4", true).FirstOrDefault()
            .Controls
            .Cast<RadioButton>()
            .Where(x => x.GetType() == typeof(RadioButton))
            .FirstOrDefault(x => x.Checked == true);

            if (selectedRadioButton == null)
            {
                return false;
            }

            if (selectedRadioButton.Name == name)
            {
                return true;
            }
            return false;
        }

        /* Auto update IndexID */

        public void UpdateIndexID()
        {
            if (excelFilesDic.Keys.Contains("SavedBooks"))
            {
                var indexColumn = excelFilesDic["SavedBooks"]["Индекс"];

                if (indexColumn.Count == 0)
                {
                    indexTextBox.Text = "1";
                    return;
                }

                int highestIndex = indexColumn.Select(int.Parse).Max();

                indexTextBox.Text = (highestIndex + 1).ToString();
            }
        }
    }
}