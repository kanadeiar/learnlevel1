namespace Task2NumericUpDown
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
            label1 = new Label();
            textBoxNumber = new TextBox();
            numericUpDownNumber = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumber).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.LightGreen;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(624, 55);
            label1.TabIndex = 2;
            label1.Text = "Задача 2. Связь свойства Text элемента TextBox со свойством Value элемента NumericUpDown.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(12, 115);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(352, 23);
            textBoxNumber.TabIndex = 3;
            textBoxNumber.TextChanged += textBoxNumber_TextChanged;
            // 
            // numericUpDownNumber
            // 
            numericUpDownNumber.Location = new Point(12, 181);
            numericUpDownNumber.Maximum = new decimal(new int[] { 65000, 0, 0, 0 });
            numericUpDownNumber.Name = "numericUpDownNumber";
            numericUpDownNumber.Size = new Size(352, 23);
            numericUpDownNumber.TabIndex = 4;
            numericUpDownNumber.ValueChanged += numericUpDownNumber_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 5;
            label2.Text = "Число:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 163);
            label3.Name = "label3";
            label3.Size = new Size(140, 15);
            label3.TabIndex = 6;
            label3.Text = "Связано с этим числом:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 372);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numericUpDownNumber);
            Controls.Add(textBoxNumber);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Geekbrains. C# Уровень 1 Лекция 8.";
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNumber;
        private NumericUpDown numericUpDownNumber;
        private Label label2;
        private Label label3;
    }
}
