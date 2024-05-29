namespace Task2GuessNumberApp
{
    partial class TryInputForm
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
            label1 = new Label();
            textBoxNumber = new TextBox();
            buttonTry = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите число от 1 до 100:";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNumber.Location = new Point(12, 27);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(242, 23);
            textBoxNumber.TabIndex = 2;
            // 
            // buttonTry
            // 
            buttonTry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonTry.Location = new Point(12, 68);
            buttonTry.Name = "buttonTry";
            buttonTry.Size = new Size(242, 114);
            buttonTry.TabIndex = 3;
            buttonTry.Text = "Попытаться отгадать число";
            buttonTry.UseVisualStyleBackColor = true;
            buttonTry.Click += buttonTry_Click;
            // 
            // TryInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 196);
            Controls.Add(buttonTry);
            Controls.Add(textBoxNumber);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TryInputForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Попытка отгадать число";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNumber;
        private Button buttonTry;
    }
}