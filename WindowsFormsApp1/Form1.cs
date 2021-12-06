using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aPODataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.aPODataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aPODataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.aPODataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aPODataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.aPODataSet.Заказы);

        }
                                                                                        //Таблицы
        private void aФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
                                                                                       //GroupBox1 - Сортировка
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        //Сортировка по Стоимости
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                DataView myDataView = new DataView(aPODataSet.Заказы);
                заказыBindingSource.Sort = "Стоимость ASC";
                dataGridView1.DataSource = заказыBindingSource;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                DataView myDataView = new DataView(aPODataSet.Заказы);
                заказыBindingSource.Sort = "Стоимость DESC";
                dataGridView1.DataSource = заказыBindingSource;
            }
        }
        //Сортировка по Дате Выдачи
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                DataView myDataView = new DataView(aPODataSet.Заказы);
                заказыBindingSource.Sort = "ДатаВыдачи ASC";
                dataGridView1.DataSource = заказыBindingSource;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                DataView myDataView = new DataView(aPODataSet.Заказы);
                заказыBindingSource.Sort = "ДатаВыдачи DESC";
                dataGridView1.DataSource = заказыBindingSource;
            }
        }
        //Сортировка по Дате Примерки
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                DataView myDataView = new DataView(aPODataSet.Заказы);
                заказыBindingSource.Sort = "ДатаПримерки ASC";
                dataGridView1.DataSource = заказыBindingSource;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                DataView myDataView = new DataView(aPODataSet.Заказы);
                заказыBindingSource.Sort = "ДатаПримерки DESC";
                dataGridView1.DataSource = заказыBindingSource;
            }
        }
        //Сортировка по Дате Заказа
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                DataView myDataView = new DataView(aPODataSet.Заказы);
                заказыBindingSource.Sort = "ДатаЗаказа ASC";
                dataGridView1.DataSource = заказыBindingSource;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                DataView myDataView = new DataView(aPODataSet.Заказы);
                заказыBindingSource.Sort = "ДатаЗаказа DESC";
                dataGridView1.DataSource = заказыBindingSource;
            }
        }
                                                                                                //GroupBox2 - Фильтр (Поиск по Фамилии)
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                //dataGridView3.Update();
                if (textBox1.Text != "")
                {
                    клиентыBindingSource.Filter = $"Фамилия = '" + textBox1.Text + "'";
                }
                else
                {
                    клиентыBindingSource.Filter = $"";
                    dataGridView2.DataSource = клиентыBindingSource;
                }
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                //dataGridView2.Update();
                if (textBox1.Text != "")
                {
                    сотрудникиBindingSource.Filter = $"Фамилия = '" + textBox1.Text + "'";
                }
                else
                {
                    сотрудникиBindingSource.Filter = $"";
                    dataGridView3.DataSource = сотрудникиBindingSource;
                }
            }
        }
                                                                            //GroupBox3 - Добавление данных в таблицы
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        //
    }
}
