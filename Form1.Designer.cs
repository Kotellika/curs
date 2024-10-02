namespace Curs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.multipBT = new System.Windows.Forms.Button();
            this.plusBT = new System.Windows.Forms.Button();
            this.minusBT = new System.Windows.Forms.Button();
            this.switchBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.matrADGV = new System.Windows.Forms.DataGridView();
            this.switchToA = new System.Windows.Forms.Button();
            this.switchToB = new System.Windows.Forms.Button();
            this.transpA = new System.Windows.Forms.Button();
            this.transpB = new System.Windows.Forms.Button();
            this.findOpredA = new System.Windows.Forms.Button();
            this.findOpredB = new System.Windows.Forms.Button();
            this.multA = new System.Windows.Forms.Button();
            this.multB = new System.Windows.Forms.Button();
            this.multNumA = new System.Windows.Forms.TextBox();
            this.multNumB = new System.Windows.Forms.TextBox();
            this.matrBDGV = new System.Windows.Forms.DataGridView();
            this.matrResDGV = new System.Windows.Forms.DataGridView();
            this.DelCountToBBT = new System.Windows.Forms.Button();
            this.AddCountToBBT = new System.Windows.Forms.Button();
            this.DelCountToABT = new System.Windows.Forms.Button();
            this.AddCountToABT = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matrADGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrBDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrResDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // multipBT
            // 
            this.multipBT.Location = new System.Drawing.Point(233, 161);
            this.multipBT.Name = "multipBT";
            this.multipBT.Size = new System.Drawing.Size(75, 23);
            this.multipBT.TabIndex = 0;
            this.multipBT.Text = "A x B";
            this.multipBT.UseVisualStyleBackColor = true;
            this.multipBT.Click += new System.EventHandler(this.multipBT_Click);
            // 
            // plusBT
            // 
            this.plusBT.Location = new System.Drawing.Point(233, 190);
            this.plusBT.Name = "plusBT";
            this.plusBT.Size = new System.Drawing.Size(75, 23);
            this.plusBT.TabIndex = 1;
            this.plusBT.Text = "A + B";
            this.plusBT.UseVisualStyleBackColor = true;
            this.plusBT.Click += new System.EventHandler(this.plusBT_Click);
            // 
            // minusBT
            // 
            this.minusBT.Location = new System.Drawing.Point(233, 219);
            this.minusBT.Name = "minusBT";
            this.minusBT.Size = new System.Drawing.Size(75, 23);
            this.minusBT.TabIndex = 2;
            this.minusBT.Text = "A - B";
            this.minusBT.UseVisualStyleBackColor = true;
            this.minusBT.Click += new System.EventHandler(this.minusBT_Click);
            // 
            // switchBT
            // 
            this.switchBT.Location = new System.Drawing.Point(233, 92);
            this.switchBT.Name = "switchBT";
            this.switchBT.Size = new System.Drawing.Size(75, 63);
            this.switchBT.TabIndex = 3;
            this.switchBT.Text = "<---\r\n--->\r\n";
            this.switchBT.UseVisualStyleBackColor = true;
            this.switchBT.Click += new System.EventHandler(this.switchBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Матрица А";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Матрица B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(654, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Результат";
            // 
            // matrADGV
            // 
            this.matrADGV.AllowUserToAddRows = false;
            this.matrADGV.AllowUserToDeleteRows = false;
            this.matrADGV.AllowUserToResizeColumns = false;
            this.matrADGV.AllowUserToResizeRows = false;
            this.matrADGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.matrADGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrADGV.ColumnHeadersVisible = false;
            this.matrADGV.Location = new System.Drawing.Point(21, 92);
            this.matrADGV.Name = "matrADGV";
            this.matrADGV.RowHeadersVisible = false;
            this.matrADGV.Size = new System.Drawing.Size(191, 150);
            this.matrADGV.TabIndex = 7;
            // 
            // switchToA
            // 
            this.switchToA.Location = new System.Drawing.Point(626, 248);
            this.switchToA.Name = "switchToA";
            this.switchToA.Size = new System.Drawing.Size(114, 23);
            this.switchToA.TabIndex = 10;
            this.switchToA.Text = "Переместить в А";
            this.switchToA.UseVisualStyleBackColor = true;
            this.switchToA.Click += new System.EventHandler(this.switchToA_Click);
            // 
            // switchToB
            // 
            this.switchToB.Location = new System.Drawing.Point(626, 277);
            this.switchToB.Name = "switchToB";
            this.switchToB.Size = new System.Drawing.Size(114, 23);
            this.switchToB.TabIndex = 11;
            this.switchToB.Text = "Переместить в B";
            this.switchToB.UseVisualStyleBackColor = true;
            this.switchToB.Click += new System.EventHandler(this.switchToB_Click);
            // 
            // transpA
            // 
            this.transpA.Location = new System.Drawing.Point(53, 277);
            this.transpA.Name = "transpA";
            this.transpA.Size = new System.Drawing.Size(114, 23);
            this.transpA.TabIndex = 12;
            this.transpA.Text = "Транспонировать";
            this.transpA.UseVisualStyleBackColor = true;
            this.transpA.Click += new System.EventHandler(this.transpA_Click);
            // 
            // transpB
            // 
            this.transpB.Location = new System.Drawing.Point(379, 277);
            this.transpB.Name = "transpB";
            this.transpB.Size = new System.Drawing.Size(114, 23);
            this.transpB.TabIndex = 13;
            this.transpB.Text = "Транспонировать";
            this.transpB.UseVisualStyleBackColor = true;
            this.transpB.Click += new System.EventHandler(this.transpB_Click);
            // 
            // findOpredA
            // 
            this.findOpredA.Location = new System.Drawing.Point(53, 306);
            this.findOpredA.Name = "findOpredA";
            this.findOpredA.Size = new System.Drawing.Size(131, 23);
            this.findOpredA.TabIndex = 14;
            this.findOpredA.Text = "Найти определитель";
            this.findOpredA.UseVisualStyleBackColor = true;
            this.findOpredA.Click += new System.EventHandler(this.findOpredA_Click);
            // 
            // findOpredB
            // 
            this.findOpredB.Location = new System.Drawing.Point(379, 306);
            this.findOpredB.Name = "findOpredB";
            this.findOpredB.Size = new System.Drawing.Size(131, 23);
            this.findOpredB.TabIndex = 15;
            this.findOpredB.Text = "Найти определитель";
            this.findOpredB.UseVisualStyleBackColor = true;
            this.findOpredB.Click += new System.EventHandler(this.findOpredB_Click);
            // 
            // multA
            // 
            this.multA.Location = new System.Drawing.Point(53, 335);
            this.multA.Name = "multA";
            this.multA.Size = new System.Drawing.Size(112, 23);
            this.multA.TabIndex = 18;
            this.multA.Text = "Умножить на";
            this.multA.UseVisualStyleBackColor = true;
            this.multA.Click += new System.EventHandler(this.multA_Click);
            // 
            // multB
            // 
            this.multB.Location = new System.Drawing.Point(379, 335);
            this.multB.Name = "multB";
            this.multB.Size = new System.Drawing.Size(112, 23);
            this.multB.TabIndex = 19;
            this.multB.Text = "Умножить на";
            this.multB.UseVisualStyleBackColor = true;
            this.multB.Click += new System.EventHandler(this.multB_Click);
            // 
            // multNumA
            // 
            this.multNumA.Location = new System.Drawing.Point(171, 335);
            this.multNumA.Name = "multNumA";
            this.multNumA.Size = new System.Drawing.Size(36, 20);
            this.multNumA.TabIndex = 20;
            this.multNumA.Text = "1";
            this.multNumA.TextChanged += new System.EventHandler(this.multNumA_TextChanged);
            // 
            // multNumB
            // 
            this.multNumB.Location = new System.Drawing.Point(497, 335);
            this.multNumB.Name = "multNumB";
            this.multNumB.Size = new System.Drawing.Size(36, 20);
            this.multNumB.TabIndex = 21;
            this.multNumB.Text = "1";
            this.multNumB.TextChanged += new System.EventHandler(this.multNumB_TextChanged);
            // 
            // matrBDGV
            // 
            this.matrBDGV.AllowUserToAddRows = false;
            this.matrBDGV.AllowUserToDeleteRows = false;
            this.matrBDGV.AllowUserToResizeColumns = false;
            this.matrBDGV.AllowUserToResizeRows = false;
            this.matrBDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.matrBDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrBDGV.ColumnHeadersVisible = false;
            this.matrBDGV.Location = new System.Drawing.Point(337, 92);
            this.matrBDGV.Name = "matrBDGV";
            this.matrBDGV.RowHeadersVisible = false;
            this.matrBDGV.Size = new System.Drawing.Size(191, 150);
            this.matrBDGV.TabIndex = 22;
            // 
            // matrResDGV
            // 
            this.matrResDGV.AllowUserToAddRows = false;
            this.matrResDGV.AllowUserToDeleteRows = false;
            this.matrResDGV.AllowUserToResizeColumns = false;
            this.matrResDGV.AllowUserToResizeRows = false;
            this.matrResDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.matrResDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrResDGV.ColumnHeadersVisible = false;
            this.matrResDGV.Enabled = false;
            this.matrResDGV.Location = new System.Drawing.Point(586, 92);
            this.matrResDGV.Name = "matrResDGV";
            this.matrResDGV.RowHeadersVisible = false;
            this.matrResDGV.Size = new System.Drawing.Size(191, 150);
            this.matrResDGV.TabIndex = 23;
            // 
            // DelCountToBBT
            // 
            this.DelCountToBBT.Location = new System.Drawing.Point(437, 248);
            this.DelCountToBBT.Name = "DelCountToBBT";
            this.DelCountToBBT.Size = new System.Drawing.Size(35, 23);
            this.DelCountToBBT.TabIndex = 27;
            this.DelCountToBBT.Text = "-";
            this.DelCountToBBT.UseVisualStyleBackColor = true;
            this.DelCountToBBT.Click += new System.EventHandler(this.DelCountToBBT_Click);
            // 
            // AddCountToBBT
            // 
            this.AddCountToBBT.Location = new System.Drawing.Point(396, 248);
            this.AddCountToBBT.Name = "AddCountToBBT";
            this.AddCountToBBT.Size = new System.Drawing.Size(35, 23);
            this.AddCountToBBT.TabIndex = 26;
            this.AddCountToBBT.Text = "+";
            this.AddCountToBBT.UseVisualStyleBackColor = true;
            this.AddCountToBBT.Click += new System.EventHandler(this.AddCountToBBT_Click);
            // 
            // DelCountToABT
            // 
            this.DelCountToABT.Location = new System.Drawing.Point(117, 248);
            this.DelCountToABT.Name = "DelCountToABT";
            this.DelCountToABT.Size = new System.Drawing.Size(35, 23);
            this.DelCountToABT.TabIndex = 31;
            this.DelCountToABT.Text = "-";
            this.DelCountToABT.UseVisualStyleBackColor = true;
            this.DelCountToABT.Click += new System.EventHandler(this.DelCountToABT_Click);
            // 
            // AddCountToABT
            // 
            this.AddCountToABT.Location = new System.Drawing.Point(76, 248);
            this.AddCountToABT.Name = "AddCountToABT";
            this.AddCountToABT.Size = new System.Drawing.Size(35, 23);
            this.AddCountToABT.TabIndex = 30;
            this.AddCountToABT.Text = "+";
            this.AddCountToABT.UseVisualStyleBackColor = true;
            this.AddCountToABT.Click += new System.EventHandler(this.AddCountToABT_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(233, 248);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "Строки";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(233, 271);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(70, 17);
            this.checkBox2.TabIndex = 33;
            this.checkBox2.Text = "Столбцы";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Справка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(685, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Выполнено: kka.23";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.DelCountToABT);
            this.Controls.Add(this.AddCountToABT);
            this.Controls.Add(this.DelCountToBBT);
            this.Controls.Add(this.AddCountToBBT);
            this.Controls.Add(this.matrResDGV);
            this.Controls.Add(this.matrBDGV);
            this.Controls.Add(this.multNumB);
            this.Controls.Add(this.multNumA);
            this.Controls.Add(this.multB);
            this.Controls.Add(this.multA);
            this.Controls.Add(this.findOpredB);
            this.Controls.Add(this.findOpredA);
            this.Controls.Add(this.transpB);
            this.Controls.Add(this.transpA);
            this.Controls.Add(this.switchToB);
            this.Controls.Add(this.switchToA);
            this.Controls.Add(this.matrADGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.switchBT);
            this.Controls.Add(this.minusBT);
            this.Controls.Add(this.plusBT);
            this.Controls.Add(this.multipBT);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Калькулятор матриц";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matrADGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrBDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrResDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button multipBT;
        private System.Windows.Forms.Button plusBT;
        private System.Windows.Forms.Button minusBT;
        private System.Windows.Forms.Button switchBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView matrADGV;
        private System.Windows.Forms.Button switchToA;
        private System.Windows.Forms.Button switchToB;
        private System.Windows.Forms.Button transpA;
        private System.Windows.Forms.Button transpB;
        private System.Windows.Forms.Button findOpredA;
        private System.Windows.Forms.Button findOpredB;
        private System.Windows.Forms.Button multA;
        private System.Windows.Forms.Button multB;
        private System.Windows.Forms.TextBox multNumA;
        private System.Windows.Forms.TextBox multNumB;
        private System.Windows.Forms.DataGridView matrBDGV;
        private System.Windows.Forms.DataGridView matrResDGV;
        private System.Windows.Forms.Button DelCountToBBT;
        private System.Windows.Forms.Button AddCountToBBT;
        private System.Windows.Forms.Button DelCountToABT;
        private System.Windows.Forms.Button AddCountToABT;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

