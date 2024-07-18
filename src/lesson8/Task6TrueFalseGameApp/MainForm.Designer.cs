namespace Task6TrueFalseGameApp
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
            buttonStart = new Button();
            labelQuestion = new Label();
            buttonYes = new Button();
            buttonNo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.LightGreen;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(657, 55);
            label1.TabIndex = 5;
            label1.Text = "Задача 6. Игра \"Верю - не верю\"";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            buttonStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonStart.Cursor = Cursors.Hand;
            buttonStart.Font = new Font("Segoe UI", 12F);
            buttonStart.Location = new Point(12, 314);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(657, 83);
            buttonStart.TabIndex = 6;
            buttonStart.Text = "Начало игры";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelQuestion
            // 
            labelQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelQuestion.Font = new Font("Segoe UI", 12F);
            labelQuestion.Location = new Point(12, 78);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(654, 221);
            labelQuestion.TabIndex = 7;
            labelQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonYes
            // 
            buttonYes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonYes.Cursor = Cursors.Hand;
            buttonYes.Font = new Font("Segoe UI", 12F);
            buttonYes.Location = new Point(12, 314);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new Size(320, 83);
            buttonYes.TabIndex = 8;
            buttonYes.Text = "Да";
            buttonYes.UseVisualStyleBackColor = true;
            buttonYes.Visible = false;
            buttonYes.Click += buttonYes_Click;
            // 
            // buttonNo
            // 
            buttonNo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonNo.Cursor = Cursors.Hand;
            buttonNo.Font = new Font("Segoe UI", 12F);
            buttonNo.Location = new Point(349, 314);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new Size(320, 83);
            buttonNo.TabIndex = 9;
            buttonNo.Text = "Нет";
            buttonNo.UseVisualStyleBackColor = true;
            buttonNo.Visible = false;
            buttonNo.Click += buttonNo_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 409);
            Controls.Add(buttonNo);
            Controls.Add(buttonYes);
            Controls.Add(labelQuestion);
            Controls.Add(buttonStart);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Geekbrains. C# Уровень 1 Лекция 8.";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button buttonStart;
        private Label labelQuestion;
        private Button buttonYes;
        private Button buttonNo;
    }
}
