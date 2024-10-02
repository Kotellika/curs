using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs
{
    public partial class Form1 : Form
    {
        // создали двумерные массивы, представляющте наши матрицы
        double[,] matrixA; 
        double[,] matrixB;
        double[,] matrixResult;
        // Матрица для промежуточных вычислений
        double[,] tempMatrix;
        // Для добавления строк или столбцов
        bool rowsBl = true;
        bool columnsBl = true;

        public Form1()
        {

            InitializeComponent();

            matrADGV.EditingControlShowing += DataGridView_EditingControlShowing;
            matrBDGV.EditingControlShowing += DataGridView_EditingControlShowing;
            matrResDGV.EditingControlShowing += DataGridView_EditingControlShowing;

            // Изменить в парамертрах 
            matrADGV.ColumnCount = 3;
            matrADGV.RowCount = 3;
            matrBDGV.ColumnCount = 3;
            matrBDGV.RowCount = 3;
            matrResDGV.ColumnCount = 3;
            matrResDGV.RowCount = 3;


        }

        public void DataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox textBox)
            {
                // Удаляем предыдущий обработчик KeyPress, если он был
                textBox.KeyPress -= DataGridViewTextBox_KeyPress;
                // Добавляем новый обработчик KeyPress
                textBox.KeyPress += DataGridViewTextBox_KeyPress;
            }
        }
        public void DataGridViewTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем только цифры, десятичные точки и -
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar !='-')
            {
                e.Handled = true;
            }

            // Разрешаем только одну десятичную точку
            TextBox textBox = sender as TextBox;
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        // Проверяем, равны ли измерения
        public bool CheckDemen(double[,] matrA, double[,] matrB)
        {
            return matrA.GetLength(0) == matrB.GetLength(0) && matrA.GetLength(1) == matrB.GetLength(1);
        }


        // Заполнение матриц на форме
        public void FillMatrixDG(double [,] matr , DataGridView dataGrid)
        {
            int fDemLength = matr.GetLength(0);
            int sDemLength = matr.GetLength(1);
            // Возможно ошибка тут -----------------------------------
            dataGrid.RowCount = fDemLength;
            dataGrid.ColumnCount = sDemLength;
            //---------------------------------------------------------
            for (int i =0;i< fDemLength; i++)
            {
                for (int j = 0; j< sDemLength; j++)
                {
                    dataGrid.Rows[i].Cells[j].Value = matr[i,j];
                }
            }
        }

        // Используется для заполнения матриц A or B from DataGrid
        public double [,] CopyDGVtoMatrix(DataGridView dataGrid)
        {
            int fDemLength = dataGrid.RowCount;
            int sDemLength = dataGrid.ColumnCount;
            double[,] matr = new double[fDemLength, sDemLength];
            for (int i = 0; i < fDemLength; i++)
            {
                for (int j = 0; j < sDemLength; j++)
                {
                    matr[i, j] =  Convert.ToDouble(dataGrid.Rows[i].Cells[j].Value);
                }
            }
            return matr;
        }


        // Обнровляем все дата гриды
        public void UpdateAllDG()
        {
            matrADGV.Refresh();
            matrBDGV.Refresh();
            matrResDGV.Refresh();
        }
        public double[,] SnDOfMatrix(double[,] a, double[,] b, int sw)
        {

            double[,] result = new double[a.GetLength(0), a.GetLength(1)];
            switch (sw)
            {
                case 0:
                    for (int i = 0; i < a.GetLength(0); i++)
                    {
                        for (int j = 0; j < a.GetLength(1); j++)
                        {
                            result[i, j] = a[i, j] - b[i, j];
                        }
                    }
                    break;
                case 1:
                    for (int i = 0; i < a.GetLength(0); i++)
                    {
                        for (int j = 0; j < a.GetLength(1); j++)
                        {
                            result[i, j] = a[i, j] + b[i, j];
                        }
                    }
                    break;
            }
            return result;

        }


            private void switchBT_Click(object sender, EventArgs e)
        {
            matrixA = CopyDGVtoMatrix(matrADGV);
            matrixB = CopyDGVtoMatrix(matrBDGV);
            tempMatrix = matrixA;
            matrixA = matrixB;  
            matrixB = tempMatrix;
            FillMatrixDG(matrixA, matrADGV);
            FillMatrixDG(matrixB, matrBDGV);
            // Собственно смена наших матриц
            UpdateAllDG();
        }


        // Для перемножения матриц
        public double[,] MultiplyMatrices(double[,] matrixA, double[,] matrixB)
        {
            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            int rowsB = matrixB.GetLength(0);
            int colsB = matrixB.GetLength(1);

            double[,] resultMatrix = new double[rowsA, colsB];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    resultMatrix[i, j] = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            return resultMatrix;
        }

        private void multipBT_Click(object sender, EventArgs e)
        {
            matrixA = CopyDGVtoMatrix(matrADGV);
            matrixB = CopyDGVtoMatrix(matrBDGV);
            if (matrixA.GetLength(1) != matrixB.GetLength(0))
            {
                MessageBox.Show("Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");
            }
            else
            {
                matrixResult = MultiplyMatrices(matrixA, matrixB);
                FillMatrixDG(matrixResult, matrResDGV);
                UpdateAllDG();
            }
        }

        private void plusBT_Click(object sender, EventArgs e)
        {
            matrixA = CopyDGVtoMatrix(matrADGV);
            matrixB = CopyDGVtoMatrix(matrBDGV);
            matrixResult = new double[matrixA.GetLength(0), matrixA.GetLength(1)];
            if (!CheckDemen(matrixA,matrixB))
            {
                MessageBox.Show("Размеры матриц должны быть одинаковыми.");
            }
            else
            {
                matrixResult = SnDOfMatrix(matrixA, matrixB, 1);
                FillMatrixDG(matrixResult, matrResDGV);
                UpdateAllDG();
            }
        }

        private void minusBT_Click(object sender, EventArgs e)
        {
            matrixA = CopyDGVtoMatrix(matrADGV);
            matrixB = CopyDGVtoMatrix(matrBDGV);
            matrixResult = new double[matrixA.GetLength(0), matrixA.GetLength(1)];
            if (matrixA.GetLength(0) != matrixA.GetLength(1) || matrixB.GetLength(0) != matrixB.GetLength(1))
            {
                MessageBox.Show("Размеры матриц должны быть одинаковыми.");
            }
            else
            {
                matrixResult = SnDOfMatrix(matrixA, matrixB, 0);
                FillMatrixDG(matrixResult, matrResDGV);
                UpdateAllDG();
            }
        }

        private void switchToA_Click(object sender, EventArgs e)
        {
            matrixA = matrixResult;
            FillMatrixDG(matrixA, matrADGV);
            UpdateAllDG();
        }

        private void switchToB_Click(object sender, EventArgs e)
        {
            matrixB = matrixResult;
            FillMatrixDG(matrixB, matrBDGV);
            UpdateAllDG();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            rowsBl = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            columnsBl = checkBox2.Checked;
        }




        // требуется чтобы оставался ед элемент
        public bool demenCheck(DataGridView view)
        {
            return view.Rows.Count > 1 && view.Columns.Count > 1; 
        }
        
        // ддобавление столбцов и строк A------------------------------------
        private void AddCountToABT_Click(object sender, EventArgs e)
        {
            // добавть проверку на то, чтобы оставался только один стодбец и 1 строка
            if (rowsBl == true && columnsBl == true || rowsBl == false && columnsBl == false)
            {
                matrADGV.ColumnCount++;
                matrADGV.RowCount++;

            }
            else if (rowsBl == true)
            {
                matrADGV.RowCount++;
            }
            else if (columnsBl == true)
            {
                matrADGV.ColumnCount++;
            }
            matrixA = CopyDGVtoMatrix(matrADGV);
            
        }



        // удаление столбцов и строк A
        private void DelCountToABT_Click(object sender, EventArgs e)
        {
            if (demenCheck(matrADGV))
            {
                if (rowsBl == true && columnsBl == true || rowsBl == false && columnsBl == false)
                {
                    matrADGV.ColumnCount--;
                    matrADGV.RowCount--;

                }
                else if (rowsBl == true)
                {
                    matrADGV.RowCount--;
                }
                else if (columnsBl == true)
                {
                    matrADGV.ColumnCount--;
                }
                matrixA = CopyDGVtoMatrix(matrADGV);
            }
            else MessageBox.Show("Матрица не может быть меньше 1х1");
        }
        // ддобавление столбцов и строк B
        private void AddCountToBBT_Click(object sender, EventArgs e)
        {
            if (rowsBl == true && columnsBl == true || rowsBl == false && columnsBl == false)
            {
                matrBDGV.ColumnCount++;
                matrBDGV.RowCount++;

            }
            else if (rowsBl == true)
            {
                matrBDGV.RowCount++;
            }
            else if (columnsBl == true)
            {
                matrBDGV.ColumnCount++;
            }
            matrixB = CopyDGVtoMatrix(matrBDGV);
        }
        // удаление столбцов и строк B
        private void DelCountToBBT_Click(object sender, EventArgs e)
        {
            if (demenCheck(matrBDGV))
            {
                if (rowsBl == true && columnsBl == true || rowsBl == false && columnsBl == false)
                {
                    matrBDGV.ColumnCount--;
                    matrBDGV.RowCount--;

                }
                else if (rowsBl == true)
                {
                    matrBDGV.RowCount--;
                }
                else if (columnsBl == true)
                {
                    matrBDGV.ColumnCount--;
                }
                matrixB = CopyDGVtoMatrix(matrBDGV);
            }
            else MessageBox.Show("Матрица не может быть меньше 1х1");
        }
        //---------------------------------------------------------------

        // Умножение матриц на число -------------------------
        int numA = 1;
        int numB = 1;

        private void multA_Click(object sender, EventArgs e)
        {
            matrixA = CopyDGVtoMatrix(matrADGV);
            matrixResult = matrixA;
            for (int i =0;i<matrixA.GetLength(0);i++)
            {
                for (int j=0;j<matrixA.GetLength(1);j++)
                {
                    matrixResult[i, j] = matrixA[i, j] * numA;
                }
            }
            FillMatrixDG(matrixResult, matrResDGV);
            UpdateAllDG();
        }

        private void multB_Click(object sender, EventArgs e)
        {
            matrixB = CopyDGVtoMatrix(matrBDGV);
            matrixResult = matrixB;
            for (int i = 0; i < matrixB.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    matrixResult[i, j] = matrixB[i, j] * numB;
                }
            }
            FillMatrixDG(matrixResult, matrResDGV);
            UpdateAllDG();
        }
        private void multNumA_TextChanged(object sender, EventArgs e)
        {
            string input = multNumA.Text;
            int number;

            // Проверка, является ли ввод числом
            if (!int.TryParse(input, out number))
            {
                MessageBox.Show("Неверный формат данных.");
                multNumA.Text = "";
            }
            else
            {
                numA = number;
            }
        }

        private void multNumB_TextChanged(object sender, EventArgs e)
        {
            string input = multNumB.Text;
            int number;

            // Проверка, является ли ввод числом
            if (!int.TryParse(input, out number))
            {
                MessageBox.Show("Неверный формат данных.");
                multNumB.Text = "";
            }
            else
            {
                numB = number;
            }
        }

        // --------------------------------------------------

        // трансп -------------------
        private void transpA_Click(object sender, EventArgs e)
        {
            matrixA = CopyDGVtoMatrix(matrADGV);
            matrixResult = new double[matrixA.GetLength(1), matrixA.GetLength(0)];
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    matrixResult[j, i] = matrixA[i, j];
                }
            }
            FillMatrixDG(matrixResult, matrResDGV);
            UpdateAllDG();
        }

        private void transpB_Click(object sender, EventArgs e)
        {
            matrixB = CopyDGVtoMatrix(matrBDGV);
            matrixResult = new double[matrixB.GetLength(1), matrixB.GetLength(0)];
            for (int i = 0; i < matrixB.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    matrixResult[j, i] = matrixB[i, j];
                }
            }
            FillMatrixDG(matrixResult, matrResDGV);
            UpdateAllDG();
        }

        //для определителя --------------------------------------------------
        public double FindOpred(double[,] matr)
        {
            int n = matr.GetLength(0);
            return Determinant(matr, n);
        }
        // determinanta
        public double Determinant(double[,] matr, int n)
        {
            if (n == 1)
                return matr[0, 0];

            if (n == 2)
                return matr[0, 0] * matr[1, 1] - matr[0, 1] * matr[1, 0];

            double det = 0;
            for (int p = 0; p < n; p++)
            {
                double[,] subMatrix = CreateSubMatrix(matr, n, p);
                det += matr[0, p] * Determinant(subMatrix, n - 1) * ((p % 2 == 0) ? 1 : -1);
            }

            return det;
        }
        //sozdaem submatr
        public double[,] CreateSubMatrix(double[,] matr, int n, int excludeCol)
        {
            double[,] result = new double[n - 1, n - 1];
            for (int i = 1; i < n; i++)
            {
                int colCount = 0;
                for (int j = 0; j < n; j++)
                {
                    if (j == excludeCol)
                        continue;
                    result[i - 1, colCount] = matr[i, j];
                    colCount++;
                }
            }
            return result;
        }

        private void findOpredA_Click(object sender, EventArgs e)
        {
            matrixA = CopyDGVtoMatrix(matrADGV);
            if (matrixA.GetLength(0)!= matrixA.GetLength(1))
            {
                MessageBox.Show("Матрица должна быть квадратной");
            }
            else
            {
                MessageBox.Show("Определитель равен " + FindOpred(matrixA));
            }
        }

        private void findOpredB_Click(object sender, EventArgs e)
        {
            matrixB = CopyDGVtoMatrix(matrBDGV);
            if (matrixB.GetLength(0) != matrixB.GetLength(1))
            {
                MessageBox.Show("Матрица должна быть квадратной");
            }
            else
            {
                MessageBox.Show("Определитель равен " + FindOpred(matrixB));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Калькулятор матриц позволяет умножать складывать и вычитать матрицы + другие операции. Для добавления или удаления строк и столбцов переключите соотвествующий пункт и нажмите + или - у соотвествующей матрицы. " + 
                "Резултат выбранного действия появится в третьей матрице, после чего его можно будет перенести в одну из других.");
        }

        // ------------------------------------------------------------------



    }
}
