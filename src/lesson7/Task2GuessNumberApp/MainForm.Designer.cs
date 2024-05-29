namespace Task2GuessNumberApp
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
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            играToolStripMenuItem = new ToolStripMenuItem();
            startGameToolStripMenuItem = new ToolStripMenuItem();
            groupBoxTrying = new GroupBox();
            buttonTry = new Button();
            textBoxNumber = new TextBox();
            label2 = new Label();
            labelTryingCount = new Label();
            buttonFormTry = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            groupBoxTrying.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.LightGreen;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 37);
            label1.Margin = new Padding(3, 3, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(637, 55);
            label1.TabIndex = 1;
            label1.Text = "Задача 2. Игра \"Угадай число\".";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.Гусь;
            pictureBox1.Location = new Point(269, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(380, 320);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { играToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(661, 24);
            menuStrip1.TabIndex = 3;
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
            // groupBoxTrying
            // 
            groupBoxTrying.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxTrying.Controls.Add(buttonFormTry);
            groupBoxTrying.Controls.Add(buttonTry);
            groupBoxTrying.Controls.Add(textBoxNumber);
            groupBoxTrying.Controls.Add(label2);
            groupBoxTrying.Location = new Point(12, 105);
            groupBoxTrying.Name = "groupBoxTrying";
            groupBoxTrying.Size = new Size(244, 342);
            groupBoxTrying.TabIndex = 4;
            groupBoxTrying.TabStop = false;
            groupBoxTrying.Text = "Угадывание числа";
            // 
            // buttonTry
            // 
            buttonTry.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonTry.Location = new Point(6, 66);
            buttonTry.Name = "buttonTry";
            buttonTry.Size = new Size(232, 102);
            buttonTry.TabIndex = 2;
            buttonTry.Text = "Попытаться отгадать число";
            buttonTry.UseVisualStyleBackColor = true;
            buttonTry.Click += buttonTry_Click;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNumber.Location = new Point(6, 37);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(232, 23);
            textBoxNumber.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 0;
            label2.Text = "Введите число от 1 до 100:";
            // 
            // labelTryingCount
            // 
            labelTryingCount.AutoSize = true;
            labelTryingCount.Location = new Point(262, 105);
            labelTryingCount.Name = "labelTryingCount";
            labelTryingCount.Size = new Size(90, 15);
            labelTryingCount.TabIndex = 5;
            labelTryingCount.Text = "Игра не начата";
            // 
            // buttonFormTry
            // 
            buttonFormTry.Location = new Point(6, 197);
            buttonFormTry.Name = "buttonFormTry";
            buttonFormTry.Size = new Size(232, 111);
            buttonFormTry.TabIndex = 3;
            buttonFormTry.Text = "Попробовать отгадать в отдельном окне";
            buttonFormTry.UseVisualStyleBackColor = true;
            buttonFormTry.Click += buttonFormTry_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 459);
            Controls.Add(labelTryingCount);
            Controls.Add(groupBoxTrying);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Geekbrains. C# Уровень 1 Лекция 7.";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBoxTrying.ResumeLayout(false);
            groupBoxTrying.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem играToolStripMenuItem;
        private ToolStripMenuItem startGameToolStripMenuItem;
        private GroupBox groupBoxTrying;
        private Label label2;
        private Button buttonTry;
        private TextBox textBoxNumber;
        private Label labelTryingCount;
        private Button buttonFormTry;
    }
}
