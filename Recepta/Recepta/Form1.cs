using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Recepta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            
            PrintDocument pd = new PrintDocument();
            PrintDialog pdi = new PrintDialog();
            pdi.UseEXDialog = true;
            pdi.Document = pd;
            if (pdi.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }            
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            PaperSize pSize = new PaperSize("Recepta", 341, 756);
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.PaperSize = pSize;
            Pen pen = new Pen(Color.Black);
            e.Graphics.DrawRectangle(pen, 246, 246, 341, 756);
            e.Graphics.DrawRectangle(pen, 246, 406, 341, 400);
            e.Graphics.DrawRectangle(pen, 475, 406, 112, 117);
            e.Graphics.DrawRectangle(pen, 475, 406, 112, 39);
            e.Graphics.DrawRectangle(pen, 475, 445, 112, 39);
            e.Graphics.DrawRectangle(pen, 475, 484, 112, 39);           
            e.Graphics.DrawLine(pen, new Point(246, 523), new Point(587, 523));
            e.Graphics.DrawString("Recepta", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(248, 248));
            e.Graphics.DrawString("Świadczeniodawca", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(248, 388));
            e.Graphics.DrawString("Oddział NFZ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(482, 430));
            e.Graphics.DrawString(NFZBox.SelectedIndex.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(520, 415));
            e.Graphics.DrawString("Uprawnienia", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(482, 469));
            e.Graphics.DrawString(rightsBox.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(520, 454));
            e.Graphics.DrawString("Ch. przewlekłe", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(482, 508));
            e.Graphics.DrawString(diseaseBox.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(520, 493));
            e.Graphics.DrawString("Pacjent", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(248, 407));
            e.Graphics.DrawString(nameBox.Text + " "+ surnameBox.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(248, 419));
            e.Graphics.DrawString("wiek - ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(248, 463));
            e.Graphics.DrawString(ageBox.Text + " lat", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(280, 463));
            e.Graphics.DrawString("PESEL", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(248, 508));
            e.Graphics.DrawString(peselBox.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(292, 508));
            e.Graphics.DrawString("Rp.", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(248, 523));
            e.Graphics.DrawString(medicamentsBox.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(248, 538));
            e.Graphics.DrawString("Data wystawienia", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(248, 805));
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(248, 820));
            e.Graphics.DrawLine(pen, new Point(248, 864), new Point(390, 864));
            e.Graphics.DrawString("Data realizacji od dnia", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(248, 865));
            e.Graphics.DrawString("X", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(286, 880));
            e.Graphics.DrawLine(pen, new Point(248, 933), new Point(390, 933));
            e.Graphics.DrawString("Dane id. i podpis lekarza", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(420, 805));
            e.Graphics.DrawString("wydruk własny", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(440, 972));
            e.Graphics.DrawString("Dane podmiotu drukującego", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(402, 985));
        }

        private void nameBox_Leave(object sender, EventArgs e)
        {
            if (nameBox.Text.Length == 0)
            {
                MessageBox.Show("Uzupełnij imię", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void surnameBox_Leave(object sender, EventArgs e)
        {
            if (surnameBox.Text.Length == 0)
            {
                MessageBox.Show("Uzupełnij nazwisko", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ageBox_Leave(object sender, EventArgs e)
        {
            if (ageBox.Text.Length == 0)
            {
                MessageBox.Show("Uzupełnij wiek", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void peselBox_Leave(object sender, EventArgs e)
        {
            if (peselBox.Text.Length != 11)
            {
                MessageBox.Show("Uzupełnij pesel", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void prescriptionBox_Leave(object sender, EventArgs e)
        {
            if (prescriptionBox.Text.Length != 22)
            {
                MessageBox.Show("Uzupełnij nr recepty (22 cyfry)", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void medicamentsBox_Leave(object sender, EventArgs e)
        {
            if (medicamentsBox.Text.Length == 0) 
            {
                MessageBox.Show("Uzupełnij nazwy leków", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
