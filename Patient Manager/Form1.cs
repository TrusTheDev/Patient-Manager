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
using static Patient_Manager.Controllers.DocxController;
using System.IO.Compression;



namespace Patient_Manager
{
    public partial class Form1 : Form
    {
        String PatientDocPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\PatientDocs\Septiembre.docx";
        public Form1()
        {
            InitializeComponent();
            label1.Text = GetDate();


                DocX document = RepairDocx(PatientDocPath);
                foreach (var fila in document.Tables[0].Rows)
                {
                    string textoCelda = fila.Cells[0].Paragraphs[0].Text;
                    Console.WriteLine(textoCelda);
                }
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
