using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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
            if (checkData() || _data.Count == 0) return;

            writeValuesToForm();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (checkData()) return;

            _data.Add(string.Empty, true);
            numericUpDownNumber.Maximum = _data.Count;
            numericUpDownNumber.Value = _data.Count;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (checkData()) return;
            if (_data.Count <= 1)
            {
                MessageBox.Show("Нельзя удалить последний элемент в списке.", "Ошибка");
                return;
            }

            _data.Remove((int)numericUpDownNumber.Value);
            numericUpDownNumber.Maximum--;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (checkData()) return;

            readValuesFromForm();
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            using var dialog = new SaveFileDialog
            {
                InitialDirectory = Application.StartupPath,
                Filter = "Файлы XML (*.xml)|*.xml|Все файлы (*.*)|*.*"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!dialog.FileName.EndsWith(".xml"))
                    dialog.FileName += ".xml";
                _data = new TrueFalse(dialog.FileName);
                _data.Add("Вопрос", false);
                try
                {
                    _data.Save();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Ошибка создания нового файла.\n{exception.Message}");
                    return;
                }
                numericUpDownNumber.Minimum = 1;
                numericUpDownNumber.Maximum = 1;
                numericUpDownNumber.Value = 1;
                writeValuesToForm();
            }
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                InitialDirectory = Application.StartupPath,
                Filter = "Файлы XML (*.xml)|*.xml|Все файлы (*.*)|*.*"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _data = new TrueFalse(dialog.FileName);
                try
                {
                    _data.Load();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Ошибка открытия файла.\n{exception.Message}");
                    return;
                }
                numericUpDownNumber.Minimum = 1;
                numericUpDownNumber.Maximum = _data.Count;
                numericUpDownNumber.Value = 1;
                writeValuesToForm();
            }
        }

        private void writeValuesToForm()
        {
            textBoxQuestion.Text = _data[(int)numericUpDownNumber.Value - 1].Text;
            checkBoxIsTrue.Checked = _data[(int)numericUpDownNumber.Value - 1].IsTrue;
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            if (checkData()) return;
            if (_data.Count == 0)
            {
                MessageBox.Show("Пустой список вопросов.", "Ошибка");
                return;
            }

            readValuesFromForm();

            try
            {
                _data.Save();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка сохранения в файл.\n{exception.Message}");
            }
        }

        private void menuItemSaveAs_Click(object sender, EventArgs e)
        {
            if (checkData()) return;
            if (_data.Count == 0)
            {
                MessageBox.Show("Пустой список вопросов.", "Ошибка");
                return;
            }

            using var dialog = new SaveFileDialog
            {
                InitialDirectory = Application.StartupPath,
                Filter = "Файлы XML (*.xml)|*.xml|Все файлы (*.*)|*.*"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!dialog.FileName.EndsWith(".xml"))
                    dialog.FileName += ".xml";

                readValuesFromForm();

                try
                {
                    var data = new TrueFalse(dialog.FileName);
                    for (var i = 0; i < _data.Count; i++)
                    {
                        data.Add(_data[i].Text, _data[i].IsTrue);
                    }

                    _data = data;
                    _data.Save();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Ошибка сохранения в файл.\n{exception.Message}");
                }
            }
        }

        private bool checkData()
        {
            if (_data is null)
            {
                MessageBox.Show("Пустой список вопросов. Создайте новый или откройте сохраненный список.", "Ошибка");
                return true;
            }

            return false;
        }

        private void readValuesFromForm()
        {
            _data[(int)numericUpDownNumber.Value - 1].Text = textBoxQuestion.Text;
            _data[(int)numericUpDownNumber.Value - 1].IsTrue = checkBoxIsTrue.Checked;
        }

        private void menuItemClose_Click(object sender, EventArgs e) => Close();

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            var form = new AboutForm();
            form.ShowDialog();
        }
    }
}
