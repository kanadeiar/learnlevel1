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
            menuStripMain.Items.AddRange(new ToolStripItem[] { menuItemFile });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(778, 24);
            menuStripMain.TabIndex = 3;
            menuStripMain.Text = "menuStrip1";
            // 
            // menuItemFile
            // 
            menuItemFile.DropDownItems.AddRange(new ToolStripItem[] { menuItemNew, menuItemOpen, menuItemSave, menuItemDivider, menuItemClose });
            menuItemFile.Name = "menuItemFile";
            menuItemFile.Size = new Size(48, 20);
            menuItemFile.Text = "Файл";
            // 
            // menuItemNew
            // 
            menuItemNew.Name = "menuItemNew";
            menuItemNew.Size = new Size(180, 22);
            menuItemNew.Text = "Новый";
            menuItemNew.Click += menuItemNew_Click;
            // 
            // menuItemOpen
            // 
            menuItemOpen.Name = "menuItemOpen";
            menuItemOpen.Size = new Size(180, 22);
            menuItemOpen.Text = "Открыть";
            // 
            // menuItemSave
            // 
            menuItemSave.Name = "menuItemSave";
            menuItemSave.Size = new Size(180, 22);
            menuItemSave.Text = "Сохранить";
            // 
            // menuItemDivider
            // 
            menuItemDivider.Name = "menuItemDivider";
            menuItemDivider.Size = new Size(177, 6);
            // 
            // menuItemClose
            // 
            menuItemClose.Name = "menuItemClose";
            menuItemClose.Size = new Size(180, 22);
            menuItemClose.Text = "Закрыть";
            menuItemClose.Click += menuItemClose_Click;
            // 
            // textBoxQuestion
            // 
            textBoxQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxQuestion.Location = new Point(12, 105);
            textBoxQuestion.Multiline = true;
            textBoxQuestion.Name = "textBoxQuestion";
            textBoxQuestion.ScrollBars = ScrollBars.Vertical;
            textBoxQuestion.Size = new Size(754, 295);
            textBoxQuestion.TabIndex = 4;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAdd.Location = new Point(12, 419);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(108, 23);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDelete.Location = new Point(126, 419);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(108, 23);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSave.Location = new Point(272, 419);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(108, 23);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // numericUpDownNumber
            // 
            numericUpDownNumber.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            numericUpDownNumber.Location = new Point(398, 419);
            numericUpDownNumber.Name = "numericUpDownNumber";
            numericUpDownNumber.Size = new Size(98, 23);
            numericUpDownNumber.TabIndex = 8;
            // 
            // checkBoxIsTrue
            // 
            checkBoxIsTrue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxIsTrue.AutoSize = true;
            checkBoxIsTrue.Location = new Point(502, 422);
            checkBoxIsTrue.Name = "checkBoxIsTrue";
            checkBoxIsTrue.Size = new Size(66, 19);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStripMain;
            Name = "MainForm";
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
    }
}
