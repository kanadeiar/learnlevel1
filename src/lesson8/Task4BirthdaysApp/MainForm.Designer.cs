namespace Task4BirthdaysApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            listBoxBirthdays = new ListBox();
            label2 = new Label();
            textBoxSurname = new TextBox();
            label3 = new Label();
            textBoxName = new TextBox();
            label4 = new Label();
            datePickerBirth = new DateTimePicker();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            labelFilePath = new Label();
            label5 = new Label();
            menuStripMain = new MenuStrip();
            toolStripFile = new ToolStripMenuItem();
            toolStripNew = new ToolStripMenuItem();
            toolStripOpen = new ToolStripMenuItem();
            toolStripSave = new ToolStripMenuItem();
            toolStripSaveAs = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            toolStripClose = new ToolStripMenuItem();
            toolStripHelp = new ToolStripMenuItem();
            toolStripAbout = new ToolStripMenuItem();
            menuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.LightGreen;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(683, 55);
            label1.TabIndex = 3;
            label1.Text = "Задача 4. Дни рождения.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBoxBirthdays
            // 
            listBoxBirthdays.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxBirthdays.FormattingEnabled = true;
            listBoxBirthdays.ItemHeight = 15;
            listBoxBirthdays.Location = new Point(245, 108);
            listBoxBirthdays.Name = "listBoxBirthdays";
            listBoxBirthdays.Size = new Size(450, 364);
            listBoxBirthdays.TabIndex = 4;
            listBoxBirthdays.SelectedIndexChanged += listBoxBirthdays_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 108);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 5;
            label2.Text = "Фамилия:";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(12, 126);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(216, 23);
            textBoxSurname.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 166);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 7;
            label3.Text = "Имя:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 184);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(216, 23);
            textBoxName.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 223);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 9;
            label4.Text = "День рождения:";
            // 
            // datePickerBirth
            // 
            datePickerBirth.Location = new Point(12, 241);
            datePickerBirth.Name = "datePickerBirth";
            datePickerBirth.Size = new Size(216, 23);
            datePickerBirth.TabIndex = 10;
            // 
            // buttonAdd
            // 
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.Location = new Point(12, 288);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(216, 43);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Cursor = Cursors.Hand;
            buttonEdit.Location = new Point(12, 337);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(104, 43);
            buttonEdit.TabIndex = 12;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.Location = new Point(124, 337);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(104, 43);
            buttonDelete.TabIndex = 13;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelFilePath
            // 
            labelFilePath.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelFilePath.AutoSize = true;
            labelFilePath.Location = new Point(51, 473);
            labelFilePath.Name = "labelFilePath";
            labelFilePath.Size = new Size(65, 15);
            labelFilePath.TabIndex = 14;
            labelFilePath.Text = "не выбран";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(7, 473);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 15;
            label5.Text = "Файл:";
            // 
            // menuStripMain
            // 
            menuStripMain.Items.AddRange(new ToolStripItem[] { toolStripFile, toolStripHelp });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(707, 24);
            menuStripMain.TabIndex = 16;
            menuStripMain.Text = "menuStrip1";
            // 
            // toolStripFile
            // 
            toolStripFile.DropDownItems.AddRange(new ToolStripItem[] { toolStripNew, toolStripOpen, toolStripSave, toolStripSaveAs, toolStripMenuItem1, toolStripClose });
            toolStripFile.Name = "toolStripFile";
            toolStripFile.Size = new Size(48, 20);
            toolStripFile.Text = "Файл";
            // 
            // toolStripNew
            // 
            toolStripNew.Name = "toolStripNew";
            toolStripNew.Size = new Size(166, 22);
            toolStripNew.Text = "Новый";
            toolStripNew.Click += toolStripNew_Click;
            // 
            // toolStripOpen
            // 
            toolStripOpen.Name = "toolStripOpen";
            toolStripOpen.Size = new Size(166, 22);
            toolStripOpen.Text = "Открыть";
            toolStripOpen.Click += toolStripOpen_Click;
            // 
            // toolStripSave
            // 
            toolStripSave.Name = "toolStripSave";
            toolStripSave.Size = new Size(166, 22);
            toolStripSave.Text = "Сохранить";
            toolStripSave.Click += toolStripSave_Click;
            // 
            // toolStripSaveAs
            // 
            toolStripSaveAs.Name = "toolStripSaveAs";
            toolStripSaveAs.Size = new Size(166, 22);
            toolStripSaveAs.Text = "Сохранить как ...";
            toolStripSaveAs.Click += toolStripSaveAs_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(163, 6);
            // 
            // toolStripClose
            // 
            toolStripClose.Name = "toolStripClose";
            toolStripClose.Size = new Size(166, 22);
            toolStripClose.Text = "Закрыть";
            toolStripClose.Click += toolStripClose_Click;
            // 
            // toolStripHelp
            // 
            toolStripHelp.DropDownItems.AddRange(new ToolStripItem[] { toolStripAbout });
            toolStripHelp.Name = "toolStripHelp";
            toolStripHelp.Size = new Size(68, 20);
            toolStripHelp.Text = "Помощь";
            // 
            // toolStripAbout
            // 
            toolStripAbout.Name = "toolStripAbout";
            toolStripAbout.Size = new Size(149, 22);
            toolStripAbout.Text = "О программе";
            toolStripAbout.Click += toolStripAbout_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 493);
            Controls.Add(label5);
            Controls.Add(labelFilePath);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(datePickerBirth);
            Controls.Add(label4);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(textBoxSurname);
            Controls.Add(label2);
            Controls.Add(listBoxBirthdays);
            Controls.Add(label1);
            Controls.Add(menuStripMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStripMain;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Geekbrains. C# Уровень 1 Лекция 8.";
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxBirthdays;
        private Label label2;
        private TextBox textBoxSurname;
        private Label label3;
        private TextBox textBoxName;
        private Label label4;
        private DateTimePicker datePickerBirth;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private Label labelFilePath;
        private Label label5;
        private MenuStrip menuStripMain;
        private ToolStripMenuItem toolStripFile;
        private ToolStripMenuItem toolStripNew;
        private ToolStripMenuItem toolStripOpen;
        private ToolStripMenuItem toolStripSave;
        private ToolStripMenuItem toolStripSaveAs;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem toolStripClose;
        private ToolStripMenuItem toolStripHelp;
        private ToolStripMenuItem toolStripAbout;
    }
}
