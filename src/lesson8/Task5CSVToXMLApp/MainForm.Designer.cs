namespace Task5CSVToXMLApp
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
            listBoxData = new ListBox();
            buttonLoad = new Button();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.LightGreen;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(579, 55);
            label1.TabIndex = 4;
            label1.Text = "Задача 5. Конвертор из CSV в XML.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBoxData
            // 
            listBoxData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxData.FormattingEnabled = true;
            listBoxData.ItemHeight = 15;
            listBoxData.Location = new Point(12, 79);
            listBoxData.Name = "listBoxData";
            listBoxData.Size = new Size(579, 349);
            listBoxData.TabIndex = 5;
            // 
            // buttonLoad
            // 
            buttonLoad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonLoad.Cursor = Cursors.Hand;
            buttonLoad.Location = new Point(12, 435);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(286, 63);
            buttonLoad.TabIndex = 6;
            buttonLoad.Text = "Загрузить данные по студентам из SCV файла";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.Location = new Point(304, 435);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(286, 63);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Сохранить данные по студентам в XML файла";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 510);
            Controls.Add(buttonSave);
            Controls.Add(buttonLoad);
            Controls.Add(listBoxData);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Geekbrains. C# Уровень 1 Лекция 8.";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ListBox listBoxData;
        private Button buttonLoad;
        private Button buttonSave;
    }
}
