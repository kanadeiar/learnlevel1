namespace Task3GameEditorApp
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
            menuStripMain = new MenuStrip();
            menuItemFile = new ToolStripMenuItem();
            menuItemNew = new ToolStripMenuItem();
            menuItemOpen = new ToolStripMenuItem();
            menuItemSave = new ToolStripMenuItem();
            menuItemDivider = new ToolStripSeparator();
            menuItemClose = new ToolStripMenuItem();
            menuItemHelp = new ToolStripMenuItem();
            menuItemAbout = new ToolStripMenuItem();
            textBoxQuestion = new TextBox();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonSave = new Button();
            numericUpDownNumber = new NumericUpDown();
            checkBoxIsTrue = new CheckBox();
            menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumber).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.LightGreen;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(754, 55);
            label1.TabIndex = 2;
            label1.Text = "Задача 3. Приложение редактор вопросв игры верю - не верю.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStripMain
            // 
            menuStripMain.Font = new Font("Microsoft Sans Serif", 10F);
            menuStripMain.Items.AddRange(new ToolStripItem[] { menuItemFile, menuItemHelp });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(778, 25);
            menuStripMain.TabIndex = 3;
            menuStripMain.Text = "menuStrip1";
            // 
            // menuItemFile
            // 
            menuItemFile.DropDownItems.AddRange(new ToolStripItem[] { menuItemNew, menuItemOpen, menuItemSave, menuItemDivider, menuItemClose });
            menuItemFile.Name = "menuItemFile";
            menuItemFile.Size = new Size(57, 21);
            menuItemFile.Text = "Файл";
            // 
            // menuItemNew
            // 
            menuItemNew.Name = "menuItemNew";
            menuItemNew.Size = new Size(145, 22);
            menuItemNew.Text = "Новый";
            menuItemNew.Click += menuItemNew_Click;
            // 
            // menuItemOpen
            // 
            menuItemOpen.Name = "menuItemOpen";
            menuItemOpen.Size = new Size(145, 22);
            menuItemOpen.Text = "Открыть";
            menuItemOpen.Click += menuItemOpen_Click;
            // 
            // menuItemSave
            // 
            menuItemSave.Name = "menuItemSave";
            menuItemSave.Size = new Size(145, 22);
            menuItemSave.Text = "Сохранить";
            menuItemSave.Click += menuItemSave_Click;
            // 
            // menuItemDivider
            // 
            menuItemDivider.Name = "menuItemDivider";
            menuItemDivider.Size = new Size(142, 6);
            // 
            // menuItemClose
            // 
            menuItemClose.Name = "menuItemClose";
            menuItemClose.Size = new Size(145, 22);
            menuItemClose.Text = "Закрыть";
            menuItemClose.Click += menuItemClose_Click;
            // 
            // menuItemHelp
            // 
            menuItemHelp.DropDownItems.AddRange(new ToolStripItem[] { menuItemAbout });
            menuItemHelp.Name = "menuItemHelp";
            menuItemHelp.Size = new Size(75, 21);
            menuItemHelp.Text = "Справка";
            // 
            // menuItemAbout
            // 
            menuItemAbout.Name = "menuItemAbout";
            menuItemAbout.Size = new Size(162, 22);
            menuItemAbout.Text = "О программе";
            menuItemAbout.Click += menuItemAbout_Click;
            // 
            // textBoxQuestion
            // 
            textBoxQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxQuestion.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxQuestion.Location = new Point(12, 105);
            textBoxQuestion.Multiline = true;
            textBoxQuestion.Name = "textBoxQuestion";
            textBoxQuestion.ScrollBars = ScrollBars.Vertical;
            textBoxQuestion.Size = new Size(754, 290);
            textBoxQuestion.TabIndex = 4;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAdd.BackColor = Color.FromArgb(192, 255, 192);
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.Font = new Font("Microsoft Sans Serif", 12F);
            buttonAdd.Location = new Point(12, 409);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(108, 33);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDelete.BackColor = Color.FromArgb(255, 192, 192);
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.Font = new Font("Microsoft Sans Serif", 12F);
            buttonDelete.ForeColor = SystemColors.ControlText;
            buttonDelete.Location = new Point(126, 409);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(108, 33);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSave.BackColor = Color.FromArgb(192, 192, 255);
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.Font = new Font("Microsoft Sans Serif", 12F);
            buttonSave.Location = new Point(272, 409);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(108, 33);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // numericUpDownNumber
            // 
            numericUpDownNumber.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            numericUpDownNumber.Font = new Font("Microsoft Sans Serif", 12F);
            numericUpDownNumber.Location = new Point(398, 413);
            numericUpDownNumber.Name = "numericUpDownNumber";
            numericUpDownNumber.Size = new Size(98, 26);
            numericUpDownNumber.TabIndex = 8;
            numericUpDownNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownNumber.ValueChanged += numericUpDownNumber_ValueChanged;
            // 
            // checkBoxIsTrue
            // 
            checkBoxIsTrue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxIsTrue.AutoSize = true;
            checkBoxIsTrue.Cursor = Cursors.Hand;
            checkBoxIsTrue.Font = new Font("Microsoft Sans Serif", 12F);
            checkBoxIsTrue.Location = new Point(513, 414);
            checkBoxIsTrue.Name = "checkBoxIsTrue";
            checkBoxIsTrue.Size = new Size(87, 24);
            checkBoxIsTrue.TabIndex = 9;
            checkBoxIsTrue.Text = "Правда";
            checkBoxIsTrue.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 454);
            Controls.Add(checkBoxIsTrue);
            Controls.Add(numericUpDownNumber);
            Controls.Add(buttonSave);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxQuestion);
            Controls.Add(label1);
            Controls.Add(menuStripMain);
            Font = new Font("Microsoft Sans Serif", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStripMain;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Geekbrains. C# Уровень 1 Лекция 8.";
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStripMain;
        private ToolStripMenuItem menuItemFile;
        private ToolStripMenuItem menuItemNew;
        private ToolStripMenuItem menuItemOpen;
        private ToolStripMenuItem menuItemSave;
        private ToolStripSeparator menuItemDivider;
        private ToolStripMenuItem menuItemClose;
        private TextBox textBoxQuestion;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonSave;
        private NumericUpDown numericUpDownNumber;
        private CheckBox checkBoxIsTrue;
        private ToolStripMenuItem menuItemHelp;
        private ToolStripMenuItem menuItemAbout;
    }
}
