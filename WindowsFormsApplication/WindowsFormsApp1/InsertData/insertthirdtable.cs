﻿using System;
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
    public partial class insertthirdtable : Form
    {
        public static string connect = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=aPO.mdb";
        private OleDbConnection myconnect;
        main frm1 = new main();

        public insertthirdtable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection myconnect = new OleDbConnection(connect);
            myconnect.Open();

            OleDbCommand command = new OleDbCommand();
            command.Connection = myconnect;

            try
            {
                command.CommandText = "INSERT INTO Сотрудники (Фамилия, Имя, Отчество, Специализация, Телефон, ДатаРождения) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + int.Parse(textBox5.Text) + "','" + maskedTextBox3.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Данные добавлены!");
                myconnect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aPODataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            frm1.сотрудникиTableAdapter.Update(frm1.aPODataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aPODataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            frm1.клиентыTableAdapter.Update(frm1.aPODataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aPODataSet.Заказы". При необходимости она может быть перемещена или удалена.
            frm1.заказыTableAdapter.Update(frm1.aPODataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aPODataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            frm1.сотрудникиTableAdapter.Fill(frm1.aPODataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aPODataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            frm1.клиентыTableAdapter.Fill(frm1.aPODataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aPODataSet.Заказы". При необходимости она может быть перемещена или удалена.
            frm1.заказыTableAdapter.Fill(frm1.aPODataSet.Заказы);
            Close();
        }
    }
}
