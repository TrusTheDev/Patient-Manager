using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;
using static Patient_Manager.Controllers.DateController;
using static Patient_Manager.Controllers.gridViewController;
using System.IO.Compression;
using Patient_Manager.Models;



namespace Patient_Manager
{
    public partial class Form1 : Form
    {
        String PatientDocPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\PatientDocs\";
        public Form1()
        {
            InitializeComponent();
            label1.Text = GetDate();


            DocXModel model = new DocXModel("2024", PatientDocPath + "Septiembre", ".docx");
            dataGridView2 = docxToGridView(dataGridView2, model.Document);



        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
