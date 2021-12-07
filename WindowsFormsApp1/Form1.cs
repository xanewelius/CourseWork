using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static string connect = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=aPO.mdb";
        private OleDbConnection myconnect;
        
        public Form1()
        {
            InitializeComponent();
            myconnect = new OleDbConnection(connect);
            myconnect.Open();
           
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("По возрастанию"); comboBox1.Items.Add("По убыванию"); comboBox1.SelectedIndex = 0;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Items.Add("Клиенты"); comboBox2.Items.Add("Сотрудники"); comboBox2.SelectedIndex = 0;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Items.Add("Заказы"); comboBox3.Items.Add("Клиенты"); comboBox3.Items.Add("Сотрудники"); comboBox3.SelectedIndex = 0;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.Items.Add("Заказы"); comboBox4.Items.Add("Клиенты"); comboBox4.Items.Add("Сотрудники"); comboBox4.SelectedIndex = 0;
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
        //комбо                                                                      //GroupBox1 - Сортировка
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        //Сортировка по Стоимости
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                DataView myDataView = new DataView(aPODataSet.Заказы);
                клиентыЗаказыBindingSource.Sort = "Стоимость ASC";
                dataGridView1.DataSource = клиентыЗаказыBindingSource;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                DataView myDataView = new DataView(aPODataSet.Заказы);
                клиентыЗаказыBindingSource.Sort = "Стоимость DESC";
                dataGridView1.DataSource = клиентыЗаказыBindingSource;
            }
        }
        //Сортировка по Дате Выдачи
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                DataView myDataView = new DataView(aPODataSet.Заказы);
                клиентыЗаказыBindingSource.Sort = "ДатаВыдачи ASC";
                dataGridView1.DataSource = клиентыЗаказыBindingSource;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                DataView myDataView = new DataView(aPODataSet.Заказы);
                клиентыЗаказыBindingSource.Sort = "ДатаВыдачи DESC";
                dataGridView1.DataSource = клиентыЗаказыBindingSource;
            }
        }
        //Сортировка по Дате Примерки
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                DataView myDataView = new DataView(aPODataSet.Заказы);
                клиентыЗаказыBindingSource.Sort = "ДатаПримерки ASC";
                dataGridView1.DataSource = клиентыЗаказыBindingSource;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                DataView myDataView = new DataView(aPODataSet.Заказы);
                клиентыЗаказыBindingSource.Sort = "ДатаПримерки DESC";
                dataGridView1.DataSource = клиентыЗаказыBindingSource;
            }
        }
        //Сортировка по Дате Заказа
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                DataView myDataView = new DataView(aPODataSet.Заказы);
                клиентыЗаказыBindingSource.Sort = "ДатаЗаказа ASC";
                dataGridView1.DataSource = клиентыЗаказыBindingSource;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                DataView myDataView = new DataView(aPODataSet.Заказы);
                клиентыЗаказыBindingSource.Sort = "ДатаЗаказа DESC";
                dataGridView1.DataSource = клиентыЗаказыBindingSource;
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
                    сотрудникиBindingSource1.Filter = $"Фамилия = '" + textBox1.Text + "'";
                }
                else
                {
                    сотрудникиBindingSource1.Filter = $"";
                    dataGridView3.DataSource = сотрудникиBindingSource1;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int a = Convert.ToInt32(comboBox2.SelectedIndex);
            Form2 F2 = new Form2();
            Form3 F3 = new Form3();
            Form4 F4 = new Form4();
            if (comboBox3.SelectedIndex == 0)
            {
                F2.Owner = this;
                F2.ShowDialog();
                myconnect.Close();
            } 
            else if (comboBox3.SelectedIndex == 1)
            {
                F3.Owner = this;
                F3.ShowDialog();
                myconnect.Close();
            }
            else if (comboBox3.SelectedIndex == 2)
            {
                F4.Owner = this;
                F4.ShowDialog();
                myconnect.Close();
            }

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aPODataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Update(this.aPODataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aPODataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Update(this.aPODataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aPODataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Update(this.aPODataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aPODataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.aPODataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aPODataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.aPODataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aPODataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.aPODataSet.Заказы);

        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                myconnect.Open();
                int kod = Convert.ToInt32(textBox2.Text);
                string qwert = "DELETE FROM Заказы WHERE КодЗаказа = " + kod;
                OleDbCommand command = new OleDbCommand(qwert, myconnect);
                command.ExecuteNonQuery();
                MessageBox.Show("1");
                myconnect.Close();
                myconnect.Close();
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                myconnect.Open();
                int kod = Convert.ToInt32(textBox2.Text);
                string qwert = "DELETE FROM Клиенты WHERE КодКлиента = " + kod;
                OleDbCommand command = new OleDbCommand(qwert, myconnect);
                command.ExecuteNonQuery();
                MessageBox.Show("2");
                myconnect.Close();
                myconnect.Close();
            }
            else if (comboBox3.SelectedIndex == 2)
            {
                myconnect.Open();
                int kod = Convert.ToInt32(textBox2.Text);
                string qwert = "DELETE FROM Сотрудники WHERE КодСотрудника = " + kod;
                OleDbCommand command = new OleDbCommand(qwert, myconnect);
                command.ExecuteNonQuery();
                MessageBox.Show("3");
                myconnect.Close();
                myconnect.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //записать background.text !!
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
