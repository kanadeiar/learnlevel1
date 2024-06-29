namespace Task3GameEditorApp
{
    public partial class MainForm : Form
    {
        private TrueFalse? _data;

        public MainForm()
        {
            InitializeComponent();
        }

        private void numericUpDownNumber_ValueChanged(object sender, EventArgs e)
        {
            textBoxQuestion.Text = _data[(int)numericUpDownNumber.Value - 1].Text;
            checkBoxIsTrue.Checked = _data[(int)numericUpDownNumber.Value - 1].IsTrue;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (_data is null)
            {
                MessageBox.Show("Создайте базу данных!", "Сообщение");
                return;
            }
            _data.Add((_data.Count + 1).ToString(), true);
            numericUpDownNumber.Maximum = _data.Count;
            numericUpDownNumber.Value = _data.Count;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (numericUpDownNumber.Maximum == 1 || _data == null)
            {
                return;
            }
            _data.Remove((int)numericUpDownNumber.Value);
            numericUpDownNumber.Maximum--;
            if (numericUpDownNumber.Value > 1)
            {
                numericUpDownNumber.Value--;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _data[(int)numericUpDownNumber.Value - 1].Text = textBoxQuestion.Text;
            _data[(int)numericUpDownNumber.Value - 1].IsTrue = checkBoxIsTrue.Checked;
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            using var dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _data = new TrueFalse(dialog.FileName);
                _data.Add("123", true);
                _data.Save();
                numericUpDownNumber.Minimum = 1;
                numericUpDownNumber.Maximum = 1;
                numericUpDownNumber.Value = 1;
            }
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _data = new TrueFalse(ofd.FileName);
                _data.Load();
                numericUpDownNumber.Minimum = 1;
                numericUpDownNumber.Maximum = _data.Count;
                numericUpDownNumber.Value = 1;
            }
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            if (_data != null)
            {
                _data.Save();
            }
            else
            {
                MessageBox.Show("База данных не создана");
            }
        }

        private void menuItemClose_Click(object sender, EventArgs e) => Close();
    }
}
