namespace _505930_Steven_ResponsiJunpro
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
            label3 = new Label();
            tbName = new TextBox();
            cbDept = new ComboBox();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvData = new DataGridView();
            btnLoad = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 51);
            label1.Name = "label1";
            label1.Size = new Size(163, 27);
            label1.TabIndex = 0;
            label1.Text = "Nama Aplikasi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(93, 108);
            label2.Name = "label2";
            label2.Size = new Size(124, 17);
            label2.TabIndex = 1;
            label2.Text = "Nama Karyawan :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(93, 178);
            label3.Name = "label3";
            label3.Size = new Size(116, 17);
            label3.TabIndex = 2;
            label3.Text = "Dep. Karyawan :";
            // 
            // tbName
            // 
            tbName.Font = new Font("Arial", 11.25F);
            tbName.Location = new Point(223, 105);
            tbName.Name = "tbName";
            tbName.Size = new Size(285, 25);
            tbName.TabIndex = 3;
            // 
            // cbDept
            // 
            cbDept.Font = new Font("Arial", 11.25F);
            cbDept.FormattingEnabled = true;
            cbDept.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            cbDept.Location = new Point(223, 175);
            cbDept.Name = "cbDept";
            cbDept.Size = new Size(285, 25);
            cbDept.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(596, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(201, 158);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Id Department :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 124);
            label8.Name = "label8";
            label8.Size = new Size(94, 17);
            label8.TabIndex = 10;
            label8.Text = "FIN : Finance";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 97);
            label7.Name = "label7";
            label7.Size = new Size(152, 17);
            label7.TabIndex = 9;
            label7.Text = "PM : Product Manager";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 71);
            label6.Name = "label6";
            label6.Size = new Size(116, 17);
            label6.TabIndex = 8;
            label6.Text = "DEV : Developer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 47);
            label5.Name = "label5";
            label5.Size = new Size(109, 17);
            label5.TabIndex = 7;
            label5.Text = "ENG : Engineer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(156, 17);
            label4.TabIndex = 6;
            label4.Text = "HR : Human Resource";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(151, 227);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(190, 54);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(402, 227);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(190, 54);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(651, 227);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(190, 54);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(93, 297);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(704, 202);
            dgvData.TabIndex = 9;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(727, 505);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(190, 54);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 570);
            Controls.Add(btnLoad);
            Controls.Add(dgvData);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(groupBox1);
            Controls.Add(cbDept);
            Controls.Add(tbName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbName;
        private ComboBox cbDept;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btn_insert;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvData;
        private Button btnLoad;
    }
}
