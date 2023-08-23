namespace Library_Book_Lending
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            panel6 = new Panel();
            infoButton = new Button();
            radioButtonRemove = new RadioButton();
            radioButtonCheck = new RadioButton();
            radioButtonAdd = new RadioButton();
            addButton = new Button();
            removeButton = new Button();
            checkButton = new Button();
            inventoryTextBox = new TextBox();
            indexTextBox = new TextBox();
            readerTextBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            chooseButton = new Button();
            savedBooksTextBox = new TextBox();
            teachersFileTextBox = new TextBox();
            studentsFileTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            savedFileButton = new Button();
            teachersFileButton = new Button();
            studentsFileButton = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            radioButtonBooks = new RadioButton();
            radioButtonTeachers = new RadioButton();
            radioButtonStudents = new RadioButton();
            radioButtonSaved = new RadioButton();
            panel2 = new Panel();
            saveAsButton = new Button();
            saveButton = new Button();
            booksFileButton = new Button();
            booksFileTextBox = new TextBox();
            label9 = new Label();
            bookNameTextBox = new TextBox();
            getBookButton = new Button();
            label10 = new Label();
            panel7 = new Panel();
            classTextBox = new TextBox();
            label12 = new Label();
            label11 = new Label();
            authorTextBox = new TextBox();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(108, 3);
            label1.Name = "label1";
            label1.Size = new Size(254, 27);
            label1.TabIndex = 0;
            label1.Text = "Индекс Nº (Авто генериран)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(108, 91);
            label2.Name = "label2";
            label2.Size = new Size(141, 27);
            label2.TabIndex = 1;
            label2.Text = "Инвентарен Nº";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(185, 333);
            label3.Name = "label3";
            label3.Size = new Size(53, 27);
            label3.TabIndex = 3;
            label3.Text = "Дата";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(310, 254);
            label4.Name = "label4";
            label4.Size = new Size(79, 27);
            label4.TabIndex = 2;
            label4.Text = "Читател";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 155);
            label5.Name = "label5";
            label5.Size = new Size(0, 26);
            label5.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(142, 66, 43);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(radioButtonRemove);
            panel1.Controls.Add(radioButtonCheck);
            panel1.Controls.Add(radioButtonAdd);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(removeButton);
            panel1.Controls.Add(checkButton);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 147);
            panel1.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(91, 147, 247);
            panel6.Controls.Add(infoButton);
            panel6.Location = new Point(429, 23);
            panel6.Name = "panel6";
            panel6.Size = new Size(55, 54);
            panel6.TabIndex = 14;
            // 
            // infoButton
            // 
            infoButton.BackgroundImage = Properties.Resources.info;
            infoButton.BackgroundImageLayout = ImageLayout.Stretch;
            infoButton.FlatStyle = FlatStyle.Flat;
            infoButton.Location = new Point(3, 3);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(49, 48);
            infoButton.TabIndex = 0;
            infoButton.UseVisualStyleBackColor = true;
            infoButton.Click += infoButton_Click;
            // 
            // radioButtonRemove
            // 
            radioButtonRemove.BackColor = Color.FromArgb(24, 58, 55);
            radioButtonRemove.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonRemove.ForeColor = Color.FromArgb(252, 239, 217);
            radioButtonRemove.Location = new Point(10, 60);
            radioButtonRemove.Name = "radioButtonRemove";
            radioButtonRemove.Size = new Size(260, 31);
            radioButtonRemove.TabIndex = 2;
            radioButtonRemove.TabStop = true;
            radioButtonRemove.Text = "Режим - Премахни ред";
            radioButtonRemove.UseVisualStyleBackColor = false;
            radioButtonRemove.CheckedChanged += radioButtonRemove_CheckedChanged;
            // 
            // radioButtonCheck
            // 
            radioButtonCheck.AutoSize = true;
            radioButtonCheck.BackColor = Color.FromArgb(24, 58, 55);
            radioButtonCheck.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonCheck.ForeColor = Color.FromArgb(252, 239, 217);
            radioButtonCheck.Location = new Point(10, 105);
            radioButtonCheck.Name = "radioButtonCheck";
            radioButtonCheck.Size = new Size(260, 31);
            radioButtonCheck.TabIndex = 1;
            radioButtonCheck.TabStop = true;
            radioButtonCheck.Text = "Режим - Отбележи върнал";
            radioButtonCheck.UseVisualStyleBackColor = false;
            radioButtonCheck.CheckedChanged += radioButtonCheck_CheckedChanged;
            // 
            // radioButtonAdd
            // 
            radioButtonAdd.BackColor = Color.FromArgb(24, 58, 55);
            radioButtonAdd.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonAdd.ForeColor = Color.FromArgb(252, 239, 217);
            radioButtonAdd.Location = new Point(10, 13);
            radioButtonAdd.Name = "radioButtonAdd";
            radioButtonAdd.Size = new Size(260, 31);
            radioButtonAdd.TabIndex = 0;
            radioButtonAdd.TabStop = true;
            radioButtonAdd.Text = "Режим - Добави ред";
            radioButtonAdd.UseVisualStyleBackColor = false;
            radioButtonAdd.CheckedChanged += radioButtonAdd_CheckedChanged;
            // 
            // addButton
            // 
            addButton.BackColor = Color.LightGreen;
            addButton.FlatAppearance.BorderColor = Color.Black;
            addButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(201, 255, 201);
            addButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 158, 93);
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.Location = new Point(404, 93);
            addButton.Name = "addButton";
            addButton.Size = new Size(102, 34);
            addButton.TabIndex = 11;
            addButton.Text = "Добави";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.IndianRed;
            removeButton.FlatAppearance.BorderColor = Color.Black;
            removeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 146, 146);
            removeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(125, 66, 66);
            removeButton.FlatStyle = FlatStyle.Flat;
            removeButton.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            removeButton.Location = new Point(392, 93);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(124, 34);
            removeButton.TabIndex = 12;
            removeButton.Text = "Премахни";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Visible = false;
            removeButton.Click += removeButton_Click;
            // 
            // checkButton
            // 
            checkButton.BackColor = Color.FromArgb(142, 202, 230);
            checkButton.FlatAppearance.BorderColor = Color.Black;
            checkButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 234, 250);
            checkButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(111, 145, 161);
            checkButton.FlatStyle = FlatStyle.Flat;
            checkButton.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            checkButton.Location = new Point(344, 93);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(219, 34);
            checkButton.TabIndex = 13;
            checkButton.Text = "Отбележи върнал";
            checkButton.UseVisualStyleBackColor = false;
            checkButton.Visible = false;
            checkButton.Click += checkButton_Click;
            // 
            // inventoryTextBox
            // 
            inventoryTextBox.BackColor = SystemColors.Window;
            inventoryTextBox.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            inventoryTextBox.Location = new Point(3, 92);
            inventoryTextBox.Multiline = true;
            inventoryTextBox.Name = "inventoryTextBox";
            inventoryTextBox.Size = new Size(99, 26);
            inventoryTextBox.TabIndex = 6;
            // 
            // indexTextBox
            // 
            indexTextBox.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            indexTextBox.Location = new Point(3, 3);
            indexTextBox.Multiline = true;
            indexTextBox.Name = "indexTextBox";
            indexTextBox.ReadOnly = true;
            indexTextBox.Size = new Size(99, 26);
            indexTextBox.TabIndex = 7;
            indexTextBox.Text = "1";
            // 
            // readerTextBox
            // 
            readerTextBox.BackColor = SystemColors.Window;
            readerTextBox.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            readerTextBox.Location = new Point(5, 254);
            readerTextBox.Multiline = true;
            readerTextBox.Name = "readerTextBox";
            readerTextBox.Size = new Size(299, 26);
            readerTextBox.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.CalendarMonthBackground = SystemColors.Control;
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(4, 328);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(175, 32);
            dateTimePicker1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(173, 193, 120);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(76, 97, 41);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.FromArgb(227, 197, 175);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(55, 61, 32);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(55, 61, 32);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(11, 533);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(178, 157, 141);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 217, 63);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(234, 239, 212);
            dataGridViewCellStyle5.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(76, 97, 41);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1043, 238);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // chooseButton
            // 
            chooseButton.BackColor = Color.FromArgb(81, 103, 89);
            chooseButton.FlatAppearance.BorderColor = Color.Black;
            chooseButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 217, 63);
            chooseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 61, 55);
            chooseButton.FlatStyle = FlatStyle.Flat;
            chooseButton.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            chooseButton.ForeColor = Color.FromArgb(252, 239, 217);
            chooseButton.Location = new Point(5, 207);
            chooseButton.Name = "chooseButton";
            chooseButton.Size = new Size(195, 36);
            chooseButton.TabIndex = 14;
            chooseButton.Text = "Избери Читател";
            chooseButton.UseVisualStyleBackColor = false;
            chooseButton.Click += chooseButton_Click;
            chooseButton.MouseDown += chooseButton_MouseDown;
            chooseButton.MouseLeave += chooseButton_MouseLeave;
            chooseButton.MouseUp += chooseButton_MouseUp;
            // 
            // savedBooksTextBox
            // 
            savedBooksTextBox.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            savedBooksTextBox.Location = new Point(66, 51);
            savedBooksTextBox.Name = "savedBooksTextBox";
            savedBooksTextBox.ReadOnly = true;
            savedBooksTextBox.Size = new Size(377, 33);
            savedBooksTextBox.TabIndex = 15;
            // 
            // teachersFileTextBox
            // 
            teachersFileTextBox.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            teachersFileTextBox.Location = new Point(66, 159);
            teachersFileTextBox.Name = "teachersFileTextBox";
            teachersFileTextBox.ReadOnly = true;
            teachersFileTextBox.Size = new Size(377, 33);
            teachersFileTextBox.TabIndex = 16;
            // 
            // studentsFileTextBox
            // 
            studentsFileTextBox.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            studentsFileTextBox.Location = new Point(66, 262);
            studentsFileTextBox.Name = "studentsFileTextBox";
            studentsFileTextBox.ReadOnly = true;
            studentsFileTextBox.Size = new Size(377, 33);
            studentsFileTextBox.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(4, 21, 31);
            label6.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(252, 239, 217);
            label6.Location = new Point(20, 10);
            label6.Name = "label6";
            label6.Size = new Size(183, 27);
            label6.TabIndex = 18;
            label6.Text = "Готов запазен файл";
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(4, 21, 31);
            label7.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(252, 239, 217);
            label7.Location = new Point(20, 120);
            label7.Name = "label7";
            label7.Size = new Size(178, 27);
            label7.TabIndex = 19;
            label7.Text = "Учителски файл";
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(4, 21, 31);
            label8.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(252, 239, 217);
            label8.Location = new Point(20, 223);
            label8.Name = "label8";
            label8.Size = new Size(178, 27);
            label8.TabIndex = 20;
            label8.Text = "Ученически файл";
            // 
            // savedFileButton
            // 
            savedFileButton.BackColor = Color.PeachPuff;
            savedFileButton.FlatAppearance.BorderColor = Color.Black;
            savedFileButton.FlatStyle = FlatStyle.Flat;
            savedFileButton.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            savedFileButton.Location = new Point(19, 52);
            savedFileButton.Name = "savedFileButton";
            savedFileButton.Size = new Size(41, 32);
            savedFileButton.TabIndex = 21;
            savedFileButton.Text = "...";
            savedFileButton.UseVisualStyleBackColor = false;
            savedFileButton.Click += savedFileButton_Click;
            // 
            // teachersFileButton
            // 
            teachersFileButton.BackColor = Color.PeachPuff;
            teachersFileButton.FlatAppearance.BorderColor = Color.Black;
            teachersFileButton.FlatStyle = FlatStyle.Flat;
            teachersFileButton.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            teachersFileButton.Location = new Point(19, 159);
            teachersFileButton.Name = "teachersFileButton";
            teachersFileButton.Size = new Size(41, 32);
            teachersFileButton.TabIndex = 22;
            teachersFileButton.Text = "...";
            teachersFileButton.UseVisualStyleBackColor = false;
            teachersFileButton.Click += teachersFileButton_Click;
            // 
            // studentsFileButton
            // 
            studentsFileButton.BackColor = Color.PeachPuff;
            studentsFileButton.FlatAppearance.BorderColor = Color.Black;
            studentsFileButton.FlatStyle = FlatStyle.Flat;
            studentsFileButton.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            studentsFileButton.Location = new Point(19, 263);
            studentsFileButton.Name = "studentsFileButton";
            studentsFileButton.Size = new Size(41, 32);
            studentsFileButton.TabIndex = 23;
            studentsFileButton.Text = "...";
            studentsFileButton.UseVisualStyleBackColor = false;
            studentsFileButton.Click += studentsFileButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(196, 73, 0);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(607, -2);
            panel3.Name = "panel3";
            panel3.Size = new Size(35, 787);
            panel3.TabIndex = 24;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(221, 142, 94);
            panel5.Location = new Point(0, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(43, 147);
            panel5.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(67, 37, 52);
            panel4.Controls.Add(radioButtonBooks);
            panel4.Controls.Add(radioButtonTeachers);
            panel4.Controls.Add(radioButtonStudents);
            panel4.Controls.Add(radioButtonSaved);
            panel4.Location = new Point(538, 493);
            panel4.Name = "panel4";
            panel4.Size = new Size(516, 40);
            panel4.TabIndex = 6;
            // 
            // radioButtonBooks
            // 
            radioButtonBooks.AutoSize = true;
            radioButtonBooks.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonBooks.ForeColor = Color.FromArgb(252, 239, 217);
            radioButtonBooks.Location = new Point(427, 6);
            radioButtonBooks.Name = "radioButtonBooks";
            radioButtonBooks.Size = new Size(83, 31);
            radioButtonBooks.TabIndex = 3;
            radioButtonBooks.TabStop = true;
            radioButtonBooks.Text = "Книги";
            radioButtonBooks.UseVisualStyleBackColor = true;
            radioButtonBooks.CheckedChanged += radioButtonBooks_CheckedChanged;
            // 
            // radioButtonTeachers
            // 
            radioButtonTeachers.AutoSize = true;
            radioButtonTeachers.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonTeachers.ForeColor = Color.FromArgb(252, 239, 217);
            radioButtonTeachers.Location = new Point(208, 6);
            radioButtonTeachers.Name = "radioButtonTeachers";
            radioButtonTeachers.Size = new Size(101, 31);
            radioButtonTeachers.TabIndex = 2;
            radioButtonTeachers.TabStop = true;
            radioButtonTeachers.Text = "Учители";
            radioButtonTeachers.UseVisualStyleBackColor = true;
            radioButtonTeachers.CheckedChanged += radioButtonTeachers_CheckedChanged;
            // 
            // radioButtonStudents
            // 
            radioButtonStudents.AutoSize = true;
            radioButtonStudents.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonStudents.ForeColor = Color.FromArgb(252, 239, 217);
            radioButtonStudents.Location = new Point(315, 6);
            radioButtonStudents.Name = "radioButtonStudents";
            radioButtonStudents.Size = new Size(106, 31);
            radioButtonStudents.TabIndex = 0;
            radioButtonStudents.TabStop = true;
            radioButtonStudents.Text = "Ученици";
            radioButtonStudents.UseVisualStyleBackColor = true;
            radioButtonStudents.CheckedChanged += radioButtonStudents_CheckedChanged;
            // 
            // radioButtonSaved
            // 
            radioButtonSaved.AutoSize = true;
            radioButtonSaved.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonSaved.ForeColor = Color.FromArgb(252, 239, 217);
            radioButtonSaved.Location = new Point(6, 6);
            radioButtonSaved.Name = "radioButtonSaved";
            radioButtonSaved.Size = new Size(196, 31);
            radioButtonSaved.TabIndex = 1;
            radioButtonSaved.TabStop = true;
            radioButtonSaved.Text = "Запазени читатели";
            radioButtonSaved.UseVisualStyleBackColor = true;
            radioButtonSaved.CheckedChanged += radioButtonSaved_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 58, 55);
            panel2.Controls.Add(saveAsButton);
            panel2.Controls.Add(saveButton);
            panel2.Controls.Add(booksFileButton);
            panel2.Controls.Add(booksFileTextBox);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(savedFileButton);
            panel2.Controls.Add(teachersFileButton);
            panel2.Controls.Add(savedBooksTextBox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(studentsFileButton);
            panel2.Controls.Add(studentsFileTextBox);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(teachersFileTextBox);
            panel2.Location = new Point(637, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 786);
            panel2.TabIndex = 25;
            // 
            // saveAsButton
            // 
            saveAsButton.BackColor = Color.FromArgb(113, 119, 68);
            saveAsButton.FlatAppearance.BorderColor = Color.Black;
            saveAsButton.FlatStyle = FlatStyle.Flat;
            saveAsButton.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            saveAsButton.ForeColor = Color.FromArgb(252, 239, 217);
            saveAsButton.Location = new Point(165, 407);
            saveAsButton.Name = "saveAsButton";
            saveAsButton.Size = new Size(140, 32);
            saveAsButton.TabIndex = 29;
            saveAsButton.Text = "Запази като";
            saveAsButton.UseVisualStyleBackColor = false;
            saveAsButton.Click += saveAsButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(61, 163, 93);
            saveButton.FlatAppearance.BorderColor = Color.Black;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.ForeColor = Color.FromArgb(252, 239, 217);
            saveButton.Location = new Point(19, 407);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(140, 32);
            saveButton.TabIndex = 28;
            saveButton.Text = "Запази";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // booksFileButton
            // 
            booksFileButton.BackColor = Color.PeachPuff;
            booksFileButton.FlatAppearance.BorderColor = Color.Black;
            booksFileButton.FlatStyle = FlatStyle.Flat;
            booksFileButton.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            booksFileButton.Location = new Point(19, 364);
            booksFileButton.Name = "booksFileButton";
            booksFileButton.Size = new Size(41, 32);
            booksFileButton.TabIndex = 26;
            booksFileButton.Text = "...";
            booksFileButton.UseVisualStyleBackColor = false;
            booksFileButton.Click += booksFileButton_Click;
            // 
            // booksFileTextBox
            // 
            booksFileTextBox.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            booksFileTextBox.Location = new Point(66, 363);
            booksFileTextBox.Name = "booksFileTextBox";
            booksFileTextBox.ReadOnly = true;
            booksFileTextBox.Size = new Size(377, 33);
            booksFileTextBox.TabIndex = 24;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(4, 21, 31);
            label9.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(252, 239, 217);
            label9.Location = new Point(20, 324);
            label9.Name = "label9";
            label9.Size = new Size(178, 27);
            label9.TabIndex = 25;
            label9.Text = "Файл с книги";
            // 
            // bookNameTextBox
            // 
            bookNameTextBox.BackColor = SystemColors.Window;
            bookNameTextBox.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            bookNameTextBox.Location = new Point(3, 132);
            bookNameTextBox.Multiline = true;
            bookNameTextBox.Name = "bookNameTextBox";
            bookNameTextBox.Size = new Size(246, 26);
            bookNameTextBox.TabIndex = 26;
            // 
            // getBookButton
            // 
            getBookButton.BackColor = Color.FromArgb(81, 103, 89);
            getBookButton.FlatAppearance.BorderColor = Color.Black;
            getBookButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 217, 63);
            getBookButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 61, 55);
            getBookButton.FlatStyle = FlatStyle.Flat;
            getBookButton.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            getBookButton.ForeColor = Color.FromArgb(252, 239, 217);
            getBookButton.Location = new Point(3, 45);
            getBookButton.Name = "getBookButton";
            getBookButton.Size = new Size(195, 36);
            getBookButton.TabIndex = 27;
            getBookButton.Text = "Избери Книга";
            getBookButton.UseVisualStyleBackColor = false;
            getBookButton.Click += getBookButton_Click;
            getBookButton.MouseDown += getBookButton_MouseDown;
            getBookButton.MouseLeave += getBookButton_MouseLeave;
            getBookButton.MouseUp += getBookButton_MouseUp;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(260, 132);
            label10.Name = "label10";
            label10.Size = new Size(128, 27);
            label10.TabIndex = 28;
            label10.Text = "Име на книга";
            // 
            // panel7
            // 
            panel7.Controls.Add(classTextBox);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(authorTextBox);
            panel7.Controls.Add(label10);
            panel7.Controls.Add(indexTextBox);
            panel7.Controls.Add(getBookButton);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(bookNameTextBox);
            panel7.Controls.Add(readerTextBox);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(chooseButton);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(inventoryTextBox);
            panel7.Controls.Add(dateTimePicker1);
            panel7.Location = new Point(13, 152);
            panel7.Name = "panel7";
            panel7.Size = new Size(401, 375);
            panel7.TabIndex = 29;
            // 
            // classTextBox
            // 
            classTextBox.BackColor = SystemColors.Window;
            classTextBox.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            classTextBox.Location = new Point(5, 291);
            classTextBox.Multiline = true;
            classTextBox.Name = "classTextBox";
            classTextBox.Size = new Size(73, 26);
            classTextBox.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(84, 292);
            label12.Name = "label12";
            label12.Size = new Size(298, 27);
            label12.TabIndex = 31;
            label12.Text = "Клас (Оставете празно ако няма)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(260, 171);
            label11.Name = "label11";
            label11.Size = new Size(135, 27);
            label11.TabIndex = 30;
            label11.Text = "Име на автора";
            // 
            // authorTextBox
            // 
            authorTextBox.BackColor = SystemColors.Window;
            authorTextBox.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            authorTextBox.Location = new Point(3, 171);
            authorTextBox.Multiline = true;
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(246, 26);
            authorTextBox.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(254, 242, 224);
            ClientSize = new Size(1092, 783);
            Controls.Add(dataGridView1);
            Controls.Add(panel4);
            Controls.Add(label5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel7);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Библиотека";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private RadioButton radioButtonCheck;
        private RadioButton radioButtonAdd;
        private TextBox inventoryTextBox;
        private TextBox readerTextBox;
        private RadioButton radioButtonRemove;
        private DateTimePicker dateTimePicker1;
        private Button addButton;
        private Button removeButton;
        private Button checkButton;
        private Button chooseButton;
        private TextBox savedBooksTextBox;
        private TextBox teachersFileTextBox;
        private TextBox studentsFileTextBox;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button savedFileButton;
        private Button teachersFileButton;
        private Button studentsFileButton;
        private Panel panel3;
        private Panel panel4;
        private RadioButton radioButtonTeachers;
        private RadioButton radioButtonSaved;
        private RadioButton radioButtonStudents;
        private Panel panel5;
        private Panel panel2;
        private Panel panel6;
        private Button infoButton;
        private RadioButton radioButtonBooks;
        private Button booksFileButton;
        private TextBox booksFileTextBox;
        private Label label9;
        private TextBox bookNameTextBox;
        private Button getBookButton;
        private Label label10;
        private Panel panel7;
        public DataGridView dataGridView1;
        private Label label11;
        private TextBox authorTextBox;
        private Button saveAsButton;
        private Button saveButton;
        private TextBox classTextBox;
        private Label label12;
        private TextBox indexTextBox;
    }
}

