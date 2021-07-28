using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class Form1 : Form
    {
        TestEntities context = new TestEntities();
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DateTime basTarihDate = baslangicTarihiTextBox.Text == "" ? DateTime.Now : DateTime.Parse(baslangicTarihiTextBox.Text);
            DateTime bitTarihDate = bitisTarihiTextBox.Text == "" ? DateTime.Now.AddDays(10) : DateTime.Parse(bitisTarihiTextBox.Text);

            int baslangicTarih = Convert.ToInt32(basTarihDate.ToOADate());
            int bitisTarih = Convert.ToInt32(bitTarihDate.ToOADate());

            var procedureList = context.ProcedureTest(malKoduTextBox.Text, baslangicTarih, bitisTarih).ToList();
            dataGridView1.DataSource = procedureList;

        }


    }
}
