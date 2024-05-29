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
            menuStrip1 = new MenuStrip();
            играToolStripMenuItem = new ToolStripMenuItem();
            startGameToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label4 = new Label();
            labelWinNumber = new Label();
            buttonUndo = new Button();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.LightGreen;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(557, 55);
            label1.TabIndex = 0;
            label1.Text = "Задача 1. Игра \"Удвоитель\".";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNumber
            // 
            labelNumber.BackColor = Color.Lime;
            labelNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNumber.Location = new Point(12, 136);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(171, 34);
            labelNumber.TabIndex = 1;
            labelNumber.Text = "0";
            labelNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonPlus
            // 
            buttonPlus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPlus.Cursor = Cursors.Hand;
            buttonPlus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPlus.Location = new Point(404, 109);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(165, 35);
            buttonPlus.TabIndex = 2;
            buttonPlus.Text = "+1";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonDouble
            // 
            buttonDouble.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDouble.Cursor = Cursors.Hand;
            buttonDouble.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDouble.Location = new Point(404, 150);
            buttonDouble.Name = "buttonDouble";
            buttonDouble.Size = new Size(165, 35);
            buttonDouble.TabIndex = 2;
            buttonDouble.Text = "x2";
            buttonDouble.UseVisualStyleBackColor = true;
            buttonDouble.Click += buttonDouble_Click;
            // 
            // buttonReset
            // 
            buttonReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonReset.Cursor = Cursors.Hand;
            buttonReset.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonReset.Location = new Point(404, 191);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(165, 35);
            buttonReset.TabIndex = 2;
            buttonReset.Text = "Сброс";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // label2
            // 
            label2.Location = new Point(12, 116);
            label2.Name = "label2";
            label2.Size = new Size(171, 20);
            label2.TabIndex = 3;
            label2.Text = "Текущее число:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Location = new Point(12, 182);
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
            labelCount.Location = new Point(12, 202);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(171, 34);
            labelCount.TabIndex = 5;
            labelCount.Text = "0";
            labelCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { играToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(581, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            играToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startGameToolStripMenuItem });
            играToolStripMenuItem.Name = "играToolStripMenuItem";
            играToolStripMenuItem.Size = new Size(46, 20);
            играToolStripMenuItem.Text = "Игра";
            // 
            // startGameToolStripMenuItem
            // 
            startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            startGameToolStripMenuItem.Size = new Size(157, 22);
            startGameToolStripMenuItem.Text = "Запустить игру";
            startGameToolStripMenuItem.Click += startGameToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(12, 259);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 15);
            panel1.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.Location = new Point(12, 282);
            label4.Name = "label4";
            label4.Size = new Size(171, 20);
            label4.TabIndex = 4;
            label4.Text = "Загаданное число:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelWinNumber
            // 
            labelWinNumber.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelWinNumber.BackColor = Color.Gold;
            labelWinNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelWinNumber.Location = new Point(12, 301);
            labelWinNumber.Name = "labelWinNumber";
            labelWinNumber.Size = new Size(171, 34);
            labelWinNumber.TabIndex = 8;
            labelWinNumber.Text = "0";
            labelWinNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonUndo
            // 
            buttonUndo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUndo.Cursor = Cursors.Hand;
            buttonUndo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonUndo.Location = new Point(405, 301);
            buttonUndo.Name = "buttonUndo";
            buttonUndo.Size = new Size(165, 35);
            buttonUndo.TabIndex = 9;
            buttonUndo.Text = "Отмена";
            buttonUndo.UseVisualStyleBackColor = true;
            buttonUndo.Click += buttonUndo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.КУр2;
            pictureBox1.Location = new Point(189, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 344);
            Controls.Add(pictureBox1);
            Controls.Add(buttonUndo);
            Controls.Add(labelWinNumber);
            Controls.Add(panel1);
            Controls.Add(labelCount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonReset);
            Controls.Add(buttonDouble);
            Controls.Add(buttonPlus);
            Controls.Add(labelNumber);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Geekbrains. C# Уровень 1 Лекция 7.";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem играToolStripMenuItem;
        private ToolStripMenuItem startGameToolStripMenuItem;
        private Panel panel1;
        private Label label4;
        private Label labelWinNumber;
        private Button buttonUndo;
        private PictureBox pictureBox1;
    }
}
