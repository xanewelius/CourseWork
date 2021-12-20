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
    public partial class main : Form
    {
        public static string connect = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=aPO.mdb";
        private OleDbConnection myconnect;
        OleDbCommand command;

        public main()
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
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.Items.Add("Заказы"); comboBox5.Items.Add("Клиенты"); comboBox5.Items.Add("Сотрудники"); comboBox5.SelectedIndex = 0;
            myconnect.Close();
        }
        private void FillSourse()
        {
            this.сотрудникиTableAdapter.Fill(this.aPODataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aPODataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.aPODataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aPODataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.aPODataSet.Заказы);

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
            insertfirsttable F2 = new insertfirsttable();
            insertsecondtable F3 = new insertsecondtable();
            insertthirdtable F4 = new insertthirdtable();
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
            FillSourse();
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
            try
            {
                if (comboBox3.SelectedIndex == 0)
                {

                    myconnect.Open();
                    int kod = Convert.ToInt32(textBox2.Text);
                    string qwerta = "DELETE FROM Заказы WHERE КодЗаказа = " + kod;
                    OleDbCommand command = new OleDbCommand(qwerta, myconnect);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись удалена");
                    FillSourse();
                    myconnect.Close();
                    myconnect.Close();
                }
                else if (comboBox3.SelectedIndex == 1)
                {
                    myconnect.Open();
                    int kod = Convert.ToInt32(textBox2.Text);
                    string qwertb = "DELETE FROM Клиенты WHERE КодКлиента = " + kod;
                    OleDbCommand command = new OleDbCommand(qwertb, myconnect);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись удалена");
                    FillSourse();
                    myconnect.Close();
                    myconnect.Close();
                }
                else if (comboBox3.SelectedIndex == 2)
                {
                    myconnect.Open();
                    int kod = Convert.ToInt32(textBox2.Text);
                    string qwertc = "DELETE FROM Сотрудники WHERE КодСотрудника = " + kod;
                    OleDbCommand command = new OleDbCommand(qwertc, myconnect);
                    command.ExecuteNonQuery();  
                    MessageBox.Show("Запись удалена");
                    FillSourse();
                    myconnect.Close();
                    myconnect.Close();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Неправильное значение кода", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //записать background.text !!
        }

        public void MyExecuteNonQuery(string SqlText)
        {
            //SqlConnection cn; // экземпляр класса типа SqlConnection
            //SqlCommand cmd;
            //string Conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=БдКурсовая.mdb");
            // выделение памяти с инициализацией строки соединения с базой данных
            myconnect = new OleDbConnection(connect);
            myconnect.Open(); // открыть источник данных
            command = myconnect.CreateCommand(); // задать SQL-команду
            command.CommandText = SqlText; // задать командную строку
            command.ExecuteNonQuery(); // выполнить SQL-команду
            myconnect.Close(); // закрыть источник данных
        }


        //РЕДАКТИРОВАНИЕ

        
        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == 1)
            {
                try
                {
                    int index, n;
                    string SqlText = "UPDATE [Клиенты] SET ";
                    string kod, fa, i, o, t;

                    n = dataGridView2.Rows.Count;
                    if (n == 1) return;
                    updatesecondtable f2 = new updatesecondtable();

                    // заполнить форму данными перед открытием

                    index = dataGridView2.CurrentRow.Index;
                    kod = dataGridView2[0, index].Value.ToString();
                    fa = dataGridView2[1, index].Value.ToString();
                    i = dataGridView2[2, index].Value.ToString();
                    o = dataGridView2[3, index].Value.ToString();
                    t = dataGridView2[4, index].Value.ToString();

                    // f.textBox1.Text = kod;
                    // f.textBox1.Enabled = false;
                    f2.textBox2.Text = fa;
                    f2.textBox3.Text = i;
                    f2.textBox4.Text = o;
                    f2.textBox5.Text = t;

                    if (f2.ShowDialog() == DialogResult.OK)
                    {

                        fa = f2.textBox2.Text;
                        i = f2.textBox3.Text;
                        o = f2.textBox4.Text;
                        t = f2.textBox5.Text;
                        SqlText += "[Фамилия] = '" + fa + "\', [Имя] = '" + i + "\', [Отчество] = '" + o + "\', [Телефон] = \'" + int.Parse(t) + "\' ";
                        SqlText += "WHERE [Клиенты].КодКлиента = " + int.Parse(kod);
                        MyExecuteNonQuery(SqlText);
                        MessageBox.Show("Данные обновлены!");
                        FillSourse();
                    }
                }
                catch
                {
                    MessageBox.Show("Неправильно введены данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox5.SelectedIndex == 0)
            {
                try
                {
                    int index, n;
                    string SqlText = "UPDATE [Заказы] SET ";
                    string kod, name, orderdate, clientcode, employeecode, fittingdate, dateofissue, price;

                    n = dataGridView2.Rows.Count;
                    if (n == 1) return;
                    updatefirsttable f1 = new updatefirsttable();

                    // заполнить форму данными перед открытием

                    index = dataGridView1.CurrentRow.Index;
                    kod = dataGridView1[0, index].Value.ToString();
                    name = dataGridView1[1, index].Value.ToString();
                    orderdate = dataGridView1[2, index].Value.ToString();
                    clientcode = dataGridView1[3, index].Value.ToString();
                    employeecode = dataGridView1[4, index].Value.ToString();
                    fittingdate = dataGridView1[5, index].Value.ToString();
                    dateofissue = dataGridView1[6, index].Value.ToString();
                    price = dataGridView1[7, index].Value.ToString();

                    f1.textBox1.Text = name;
                    f1.textBox7.Text = price;
                    f1.maskedTextBox1.Text = orderdate;
                    f1.maskedTextBox2.Text = fittingdate;
                    f1.maskedTextBox3.Text = dateofissue;

                    if (f1.ShowDialog() == DialogResult.OK)
                    {

                        name = f1.textBox1.Text;
                        price = f1.textBox7.Text;
                        orderdate = f1.maskedTextBox1.Text;
                        fittingdate = f1.maskedTextBox2.Text;
                        dateofissue = f1.maskedTextBox3.Text;

                        SqlText += "[НазваниеЗаказа] = '" + name + "\', [Стоимость] = '" + int.Parse(price) + "\', [ДатаЗаказа] = '" + orderdate + "\', [ДатаПримерки] = '" + fittingdate + "\', [ДатаВыдачи] = '" + dateofissue + "\' ";
                        SqlText += "WHERE [Заказы].КодЗаказа = " + int.Parse(kod);

                        MyExecuteNonQuery(SqlText);
                        MessageBox.Show("Данные обновлены!");
                        FillSourse();

                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Неправильно введены данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox5.SelectedIndex == 2)
            {
                try
                {

                    int index, n;
                    string SqlText = "UPDATE [Сотрудники] SET ";
                    string kod, fa, i, o, s, t, d;

                    n = dataGridView3.Rows.Count;
                    if (n == 1) return;
                    updatethirdtable f3 = new updatethirdtable();

                    // заполнить форму данными перед открытием

                    index = dataGridView3.CurrentRow.Index;
                    kod = dataGridView3[0, index].Value.ToString();
                    fa = dataGridView3[1, index].Value.ToString();
                    i = dataGridView3[2, index].Value.ToString();
                    o = dataGridView3[3, index].Value.ToString();
                    s = dataGridView3[4, index].Value.ToString();
                    t = dataGridView3[5, index].Value.ToString();
                    d = dataGridView3[6, index].Value.ToString();

                    // f.textBox1.Text = kod;
                    // f.textBox1.Enabled = false;
                    f3.textBox1.Text = fa;
                    f3.textBox2.Text = i;
                    f3.textBox3.Text = o;
                    f3.textBox4.Text = s;
                    f3.textBox5.Text = t;
                    f3.maskedTextBox3.Text = d;

                    if (f3.ShowDialog() == DialogResult.OK)
                    {

                        fa = f3.textBox1.Text;
                        i = f3.textBox2.Text;
                        o = f3.textBox3.Text;
                        s = f3.textBox4.Text;
                        t = f3.textBox5.Text;
                        d = f3.maskedTextBox3.Text;

                        SqlText += "[Фамилия] = '" + fa + "\', [Имя] = '" + i + "\', [Отчество] = '" + o + "\', [Специализация] = '" + s + "\', [Телефон] = '" + int.Parse(t) + "\', [ДатаРождения] = '" + d + "\' ";
                        SqlText += "WHERE [Сотрудники].КодСотрудника = " + int.Parse(kod);
                        MyExecuteNonQuery(SqlText);
                        MessageBox.Show("Данные обновлены!");
                        FillSourse();
                    }
                }
                catch
                {
                    MessageBox.Show("Неправильно введены данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 AboutBox = new AboutBox1();
            AboutBox.ShowDialog();
        }

        private void настройкаПечатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog(); // открывает окно настройки печати
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print(); // открытие окна печати 
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void omboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //upper
        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insertfirsttable F2 = new insertfirsttable();

            F2.Owner = this;
            F2.ShowDialog();
            myconnect.Close();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insertsecondtable F3 = new insertsecondtable();

            F3.Owner = this;
            F3.ShowDialog();
            myconnect.Close();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insertthirdtable F4 = new insertthirdtable();

            F4.Owner = this;
            F4.ShowDialog();
            myconnect.Close();
        }

        private void редактированиеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int index, n;
            string SqlText = "UPDATE [Сотрудники] SET ";
            string kod, fa, i, o, s, t, d;

            n = dataGridView3.Rows.Count;
            if (n == 1) return;
            updatethirdtable f3 = new updatethirdtable();

            // заполнить форму данными перед открытием

            index = dataGridView3.CurrentRow.Index;
            kod = dataGridView3[0, index].Value.ToString();
            fa = dataGridView3[1, index].Value.ToString();
            i = dataGridView3[2, index].Value.ToString();
            o = dataGridView3[3, index].Value.ToString();
            s = dataGridView3[4, index].Value.ToString();
            t = dataGridView3[5, index].Value.ToString();
            d = dataGridView3[6, index].Value.ToString();

            // f.textBox1.Text = kod;
            // f.textBox1.Enabled = false;
            f3.textBox1.Text = fa;
            f3.textBox2.Text = i;
            f3.textBox3.Text = o;
            f3.textBox4.Text = s;
            f3.textBox5.Text = t;
            f3.maskedTextBox3.Text = d;

            if (f3.ShowDialog() == DialogResult.OK)
            {

                fa = f3.textBox1.Text;
                i = f3.textBox2.Text;
                o = f3.textBox3.Text;
                s = f3.textBox4.Text;
                t = f3.textBox5.Text;
                d = f3.maskedTextBox3.Text;

                SqlText += "[Фамилия] = '" + fa + "\', [Имя] = '" + i + "\', [Отчество] = '" + o + "\', [Специализация] = '" + s + "\', [Телефон] = '" + int.Parse(t) + "\', [ДатаРождения] = '" + d + "\' ";
                SqlText += "WHERE [Сотрудники].КодСотрудника = " + int.Parse(kod);
                MyExecuteNonQuery(SqlText);
                FillSourse();
            }
        }

        private void клиентыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int index, n;
            string SqlText = "UPDATE [Клиенты] SET ";
            string kod, fa, i, o, t;

            n = dataGridView2.Rows.Count;
            if (n == 1) return;
            updatesecondtable f2 = new updatesecondtable();

            // заполнить форму данными перед открытием

            index = dataGridView2.CurrentRow.Index;
            kod = dataGridView2[0, index].Value.ToString();
            fa = dataGridView2[1, index].Value.ToString();
            i = dataGridView2[2, index].Value.ToString();
            o = dataGridView2[3, index].Value.ToString();
            t = dataGridView2[4, index].Value.ToString();

            // f.textBox1.Text = kod;
            // f.textBox1.Enabled = false;
            f2.textBox2.Text = fa;
            f2.textBox3.Text = i;
            f2.textBox4.Text = o;
            f2.textBox5.Text = t;

            if (f2.ShowDialog() == DialogResult.OK)
            {

                fa = f2.textBox2.Text;
                i = f2.textBox3.Text;
                o = f2.textBox4.Text;
                t = f2.textBox5.Text;
                SqlText += "[Фамилия] = '" + fa + "\', [Имя] = '" + i + "\', [Отчество] = '" + o + "\', [Телефон] = \'" + int.Parse(t) + "\' ";
                SqlText += "WHERE [Клиенты].КодКлиента = " + int.Parse(kod);
                MyExecuteNonQuery(SqlText);
                FillSourse();
            }
        }

        private void заказыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int index, n;
            string SqlText = "UPDATE [Заказы] SET ";
            string kod, name, orderdate, clientcode, employeecode, fittingdate, dateofissue, price;

            n = dataGridView2.Rows.Count;
            if (n == 1) return;
            updatefirsttable f1 = new updatefirsttable();

            // заполнить форму данными перед открытием

            index = dataGridView1.CurrentRow.Index;
            kod = dataGridView1[0, index].Value.ToString();
            name = dataGridView1[1, index].Value.ToString();
            orderdate = dataGridView1[2, index].Value.ToString();
            clientcode = dataGridView1[3, index].Value.ToString();
            employeecode = dataGridView1[4, index].Value.ToString();
            fittingdate = dataGridView1[5, index].Value.ToString();
            dateofissue = dataGridView1[6, index].Value.ToString();
            price = dataGridView1[7, index].Value.ToString();

            f1.textBox1.Text = name;
            f1.textBox7.Text = price;
            f1.maskedTextBox1.Text = orderdate;
            f1.maskedTextBox2.Text = fittingdate;
            f1.maskedTextBox3.Text = dateofissue;

            if (f1.ShowDialog() == DialogResult.OK)
            {

                name = f1.textBox1.Text;
                price = f1.textBox7.Text;
                orderdate = f1.maskedTextBox1.Text;
                fittingdate = f1.maskedTextBox2.Text;
                dateofissue = f1.maskedTextBox3.Text;

                SqlText += "[НазваниеЗаказа] = '" + name + "\', [Стоимость] = '" + int.Parse(price) + "\', [ДатаЗаказа] = '" + orderdate + "\', [ДатаПримерки] = '" + fittingdate + "\', [ДатаВыдачи] = '" + dateofissue + "\' ";
                SqlText += "WHERE [Заказы].КодЗаказа = " + int.Parse(kod);

                MyExecuteNonQuery(SqlText);
                FillSourse();

            }
        }
    }
}