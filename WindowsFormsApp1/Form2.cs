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
    public partial class Form2 : Form
    {
        
        public static string connect = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=aPO.mdb";
        private OleDbConnection myconnect;
        Form1 frm1 = new Form1();

        public Form2()
        {
            
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aPODataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            frm1.сотрудникиTableAdapter.Update(frm1.aPODataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aPODataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            frm1.клиентыTableAdapter.Update(frm1.aPODataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aPODataSet.Заказы". При необходимости она может быть перемещена или удалена.
            frm1.заказыTableAdapter.Update(frm1.aPODataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aPODataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection myconnect = new OleDbConnection(connect);
            myconnect.Open();

            OleDbCommand command = new OleDbCommand();
            command.Connection = myconnect;

            try
            {
                command.CommandText = "INSERT INTO Заказы (НазваниеЗаказа, ДатаЗаказа, КодКлиента, КодСотрудника, ДатаПримерки, ДатаВыдачи, Стоимость) VALUES ('" + textBox1.Text +"','" + maskedTextBox1.Text +"','"+ textBox3.Text +"','"+ textBox4.Text +"','"+ maskedTextBox2.Text + "','"+ maskedTextBox3.Text + "','"+ textBox7.Text +"')";
                command.ExecuteNonQuery();
                myconnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
