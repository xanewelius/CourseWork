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

        public Form2()
        {
            
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
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
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd MM yyyy";
                command.CommandText = "INSERT INTO Заказы (НазваниеЗаказа, ДатаЗаказа, КодКлиента, КодСотрудника, ДатаПримерки, ДатаВыдачи, Стоимость) VALUES ('" + textBox1.Text +"','" + dateTimePicker1.Format +"','"+ textBox3.Text +"','"+ textBox4.Text +"','"+ dateTimePicker2.Format + "','"+ dateTimePicker3.Format + "','"+ textBox7.Text +"')";
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
