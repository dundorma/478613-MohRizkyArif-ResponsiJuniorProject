namespace responsi2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtNama = new TextBox();
            pictureBox1 = new PictureBox();
            Logo = new Label();
            btnInsert = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            dgKaryawan = new DataGridView();
            txtDep = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgKaryawan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(14, 108);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 0;
            label1.Text = "Nama Karyawan :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(13, 152);
            label2.Name = "label2";
            label2.Size = new Size(132, 21);
            label2.TabIndex = 1;
            label2.Text = "Dep. Karyawan    :";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(152, 108);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(160, 23);
            txtNama.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 50);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Logo
            // 
            Logo.AutoSize = true;
            Logo.Font = new Font("Segoe UI", 12F);
            Logo.Location = new Point(76, 29);
            Logo.Name = "Logo";
            Logo.Size = new Size(45, 21);
            Logo.TabIndex = 5;
            Logo.Text = "Logo";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(9, 202);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(185, 33);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(439, 202);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(185, 33);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(221, 202);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(185, 33);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // dgKaryawan
            // 
            dgKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgKaryawan.Location = new Point(9, 256);
            dgKaryawan.Name = "dgKaryawan";
            dgKaryawan.Size = new Size(615, 182);
            dgKaryawan.TabIndex = 9;
            dgKaryawan.CellClick += dgKaryawan_CellContentClick;
            dgKaryawan.CellContentClick += dgKaryawan_CellContentClick;
            // 
            // txtDep
            // 
            txtDep.FormattingEnabled = true;
            txtDep.Location = new Point(152, 152);
            txtDep.Name = "txtDep";
            txtDep.Size = new Size(160, 23);
            txtDep.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.Location = new Point(448, 14);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 11;
            label3.Text = "ID Departemen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveBorder;
            label4.Location = new Point(448, 29);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 12;
            label4.Text = "1 : HR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveBorder;
            label5.Location = new Point(448, 59);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 13;
            label5.Text = "3 : Developer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveBorder;
            label6.Location = new Point(448, 44);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 14;
            label6.Text = "2 : Engineer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveBorder;
            label7.Location = new Point(448, 74);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 15;
            label7.Text = "4 : Product M";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveBorder;
            label8.Location = new Point(448, 89);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 16;
            label8.Text = "5 : Finance";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveBorder;
            pictureBox2.Location = new Point(439, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(185, 189);
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDep);
            Controls.Add(dgKaryawan);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(Logo);
            Controls.Add(pictureBox1);
            Controls.Add(txtNama);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgKaryawan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNama;
        private PictureBox pictureBox1;
        private Label Logo;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnEdit;
        private DataGridView dgKaryawan;
        private ComboBox txtDep;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox2;
    }
}
