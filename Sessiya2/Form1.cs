using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sessiya2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.dataSet1.Workers);
            textBoxCodeWorker.Focus();
            label1.Text = @"Введите код сотрудника 
    для авторизации";
            loginbuttonWorker.Click += (s, a) => {
                if (textBoxCodeWorker.Text == "")
                {
                    MessageBox.Show("В поле ввода кода сотрудника нет значения!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    workersTableAdapter.FillByWorkerCode(dataSet1.Workers, textBoxCodeWorker.Text);
                    if (dataSet1.Workers.Count == 0)
                        MessageBox.Show("Неправильный код сотрудника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (dataSet1.Workers.Count == 1)
                    {
                        this.Hide();
                        MainForm newForm = new MainForm();
                        newForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Невозможная ситуация! В БД существует 2 записи с одинаковыми логинами и паролями");
                    }
                }
            };
            ExitButton.Click += (s, eEBC) => { Application.Exit(); };
        }
    }
}

