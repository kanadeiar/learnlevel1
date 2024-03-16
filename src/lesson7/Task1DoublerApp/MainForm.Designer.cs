namespace Task1DoublerApp
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
            labelNumber = new Label();
            buttonPlus = new Button();
            buttonDouble = new Button();
            buttonReset = new Button();
            label2 = new Label();
            label3 = new Label();
            labelCount = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.LightGreen;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(496, 55);
            label1.TabIndex = 0;
            label1.Text = "Задача 1. Программа удвоитель.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNumber
            // 
            labelNumber.BackColor = Color.Lime;
            labelNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNumber.Location = new Point(12, 118);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(171, 34);
            labelNumber.TabIndex = 1;
            labelNumber.Text = "0";
            labelNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonPlus
            // 
            buttonPlus.Cursor = Cursors.Hand;
            buttonPlus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPlus.Location = new Point(343, 98);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(165, 35);
            buttonPlus.TabIndex = 2;
            buttonPlus.Text = "+1";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonDouble
            // 
            buttonDouble.Cursor = Cursors.Hand;
            buttonDouble.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDouble.Location = new Point(343, 139);
            buttonDouble.Name = "buttonDouble";
            buttonDouble.Size = new Size(165, 35);
            buttonDouble.TabIndex = 2;
            buttonDouble.Text = "x2";
            buttonDouble.UseVisualStyleBackColor = true;
            buttonDouble.Click += buttonDouble_Click;
            // 
            // buttonReset
            // 
            buttonReset.Cursor = Cursors.Hand;
            buttonReset.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonReset.Location = new Point(343, 180);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(165, 35);
            buttonReset.TabIndex = 2;
            buttonReset.Text = "Сброс";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // label2
            // 
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(171, 20);
            label2.TabIndex = 3;
            label2.Text = "Текущее число:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Location = new Point(12, 164);
            label3.Name = "label3";
            label3.Size = new Size(171, 20);
            label3.TabIndex = 4;
            label3.Text = "Количество команд:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelCount
            // 
            labelCount.BackColor = Color.Cyan;
            labelCount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCount.Location = new Point(12, 184);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(171, 34);
            labelCount.TabIndex = 5;
            labelCount.Text = "0";
            labelCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 363);
            Controls.Add(labelCount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonReset);
            Controls.Add(buttonDouble);
            Controls.Add(buttonPlus);
            Controls.Add(labelNumber);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Geekbrains. C# Уровень 1.";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label labelNumber;
        private Button buttonPlus;
        private Button buttonDouble;
        private Button buttonReset;
        private Label label2;
        private Label label3;
        private Label labelCount;
    }
}
