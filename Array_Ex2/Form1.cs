using Microsoft.VisualBasic.Logging;
using System;
using System.Net.Quic;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Array_Ex2
{
    public partial class Form1 : Form
    {
        int[] Qualifications;
        int Sum;
        double Average;
        int index;


        int[,] Votes;
        int rowindex;
        int columnindex;
        int TotalVotes;


        int[,,] Books;
        int index1;
        int index2;
        int index3;
        int TotalBooks;

        public Form1()
        {
            InitializeComponent();
            Qualifications = new int[4];
            index = 0;
            Sum = 0;
            Average = 0.0;

            Votes = new int[2, 7];
            rowindex = 0;
            columnindex = 0;
            TotalVotes = 0;


            Books = new int[2, 2, 2];
            index1 = 0;
            index2 = 0;
            index3 = 0;
            TotalBooks = 0;
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < Qualifications.Length; i++)
            {

                Sum = Sum + Qualifications[i];
            }
            Average = Sum / Qualifications.Length;
            txtAverage.Text = Convert.ToString(Average);
            Sum = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (index == Qualifications.Length)
            {
                string data = "";
                for (int i = 0; i < Qualifications.Length; i++)
                {
                    data += Qualifications[i] + " ";
                }
                MessageBox.Show("Array is full:" + data);
                return;
            }
            try
            {
                Qualifications[index++] = Convert.ToInt32(txtQualification.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Se requiere un numero ENTERO. Error de formato ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " ");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSaveVotes_Click(object sender, EventArgs e)
        {
            string data2 = "";
            if (rowindex == Votes.GetLength(0) && columnindex == Votes.GetLength(1))
            {
                for (int i = 0; i < Votes.GetLength(0); i++)
                {
                    for (int j = 0; j < Votes.GetLength(1); j++)
                    {
                        data2 += Votes[i, j] + " ";
                    }
                }
            }

            try
            {
                Votes[rowindex, columnindex++] = Int32.Parse(txtNoVotes.Text);
                if (columnindex == Votes.GetLength(1))
                {
                    rowindex++;
                    columnindex = 0;
                }
            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Matrix is full:" + data2);
                rowindex = 0;
                columnindex = 0;
                return;
            }
            catch (FormatException exe)
            {
                MessageBox.Show("Incorrect format, an integer is required. ");
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message + " ");
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < Votes.GetLength(0); i++)
            {
                for (int j = 0; j < Votes.GetLength(1); j++)
                {
                    TotalVotes = TotalVotes + Votes[i, j];
                }
            }

            txtTotalVotes.Text = Convert.ToString(TotalVotes);
            TotalVotes = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveBooks_Click(object sender, EventArgs e)
        {
            string data = "";
            if (index1 == Books.GetLength(0) && index2 == Books.GetLength(1) && index3 == Books.GetLength(2))
            {
                for (int i = 0; i < Books.GetLength(0); i++)
                {
                    for (int j = 0; j < Books.GetLength(1); j++)
                    {
                        for (int k = 0; k < Books.GetLength(2); k++)
                        {
                            data += Books[i, j, k];
                        }
                    }
                }
            }

            try
            {
                Books[index1, index2, index3++] = Convert.ToInt32(txtNBooks.Text);
                if (index3 == Books.GetLength(2))
                {
                    index2++;
                    index3 = 0;
                }
                if (index2 == Books.GetLength(1))
                {
                    index1++;
                    index2 = 0;
                    index3 = 0;
                }
            }

            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Array is full:");
                //Career = new string[2, 3, 2];
                index2 = 0;
                index3 = 0;
                return;
            }
            catch (FormatException exe)
            {
                MessageBox.Show("Incorrect format, an integer is required. ");
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message + " ");
            }
        }

        private void btnTotalBooks_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Books.GetLength(0); i++)
            {
                for (int j = 0; j < Books.GetLength(1); j++)
                {
                    for (int k = 0; k < Books.GetLength(2); k++)
                    {
                        TotalBooks = TotalBooks + Books[i, j, k];
                    }
                }
            }

            txtTotalBooks.Text = Convert.ToString(TotalBooks);
            TotalBooks = 0;
        }
    }
}
