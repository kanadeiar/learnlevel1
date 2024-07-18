namespace Task7WeatherForecastApp
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
            labelCity = new Label();
            panelMorning = new Panel();
            labelMorning = new Label();
            panelDay = new Panel();
            labelDay = new Label();
            panelEvening = new Panel();
            labelEvening = new Label();
            panelNight = new Panel();
            labelNight = new Label();
            panelMorning.SuspendLayout();
            panelDay.SuspendLayout();
            panelEvening.SuspendLayout();
            panelNight.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.LightGreen;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(651, 55);
            label1.TabIndex = 6;
            label1.Text = "Задача 7. Получение прогноза погоды с API";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Font = new Font("Segoe UI", 11F);
            labelCity.Location = new Point(12, 75);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(98, 20);
            labelCity.TabIndex = 7;
            labelCity.Text = "Город Пенза";
            // 
            // panelMorning
            // 
            panelMorning.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelMorning.BackColor = Color.PaleGoldenrod;
            panelMorning.Controls.Add(labelMorning);
            panelMorning.Location = new Point(12, 98);
            panelMorning.Name = "panelMorning";
            panelMorning.Size = new Size(651, 107);
            panelMorning.TabIndex = 8;
            // 
            // labelMorning
            // 
            labelMorning.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelMorning.Font = new Font("Segoe UI", 11F);
            labelMorning.Location = new Point(14, 13);
            labelMorning.Name = "labelMorning";
            labelMorning.Size = new Size(625, 79);
            labelMorning.TabIndex = 0;
            // 
            // panelDay
            // 
            panelDay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelDay.BackColor = Color.Orange;
            panelDay.Controls.Add(labelDay);
            panelDay.Location = new Point(12, 220);
            panelDay.Name = "panelDay";
            panelDay.Size = new Size(651, 107);
            panelDay.TabIndex = 9;
            // 
            // labelDay
            // 
            labelDay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelDay.Font = new Font("Segoe UI", 11F);
            labelDay.Location = new Point(14, 13);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(625, 79);
            labelDay.TabIndex = 0;
            // 
            // panelEvening
            // 
            panelEvening.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelEvening.BackColor = Color.Salmon;
            panelEvening.Controls.Add(labelEvening);
            panelEvening.Location = new Point(12, 343);
            panelEvening.Name = "panelEvening";
            panelEvening.Size = new Size(651, 107);
            panelEvening.TabIndex = 10;
            // 
            // labelEvening
            // 
            labelEvening.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelEvening.Font = new Font("Segoe UI", 11F);
            labelEvening.Location = new Point(14, 13);
            labelEvening.Name = "labelEvening";
            labelEvening.Size = new Size(625, 79);
            labelEvening.TabIndex = 0;
            // 
            // panelNight
            // 
            panelNight.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelNight.BackColor = Color.SkyBlue;
            panelNight.Controls.Add(labelNight);
            panelNight.Location = new Point(12, 469);
            panelNight.Name = "panelNight";
            panelNight.Size = new Size(651, 107);
            panelNight.TabIndex = 11;
            // 
            // labelNight
            // 
            labelNight.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelNight.Font = new Font("Segoe UI", 11F);
            labelNight.Location = new Point(14, 13);
            labelNight.Name = "labelNight";
            labelNight.Size = new Size(625, 79);
            labelNight.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 594);
            Controls.Add(panelNight);
            Controls.Add(panelEvening);
            Controls.Add(panelDay);
            Controls.Add(panelMorning);
            Controls.Add(labelCity);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Geekbrains. C# Уровень 1 Лекция 8.";
            Shown += MainForm_Shown;
            panelMorning.ResumeLayout(false);
            panelDay.ResumeLayout(false);
            panelEvening.ResumeLayout(false);
            panelNight.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelCity;
        private Panel panelMorning;
        private Label labelMorning;
        private Panel panelDay;
        private Label labelDay;
        private Panel panelEvening;
        private Label labelEvening;
        private Panel panelNight;
        private Label labelNight;
    }
}
