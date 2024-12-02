namespace _504042_HanifahPutriAriani_ResponsiJuniorProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblNamaKaryawan = new System.Windows.Forms.Label();
            this.lblDepkaryawan = new System.Windows.Forms.Label();
            this.tbNamaKaryawan = new System.Windows.Forms.TextBox();
            this.DropDepKaryawan = new System.Windows.Forms.DomainUpDown();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblIDDepartemen = new System.Windows.Forms.Label();
            this.btn_Load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 41);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(64, 28);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(34, 16);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "logo";
            // 
            // lblNamaKaryawan
            // 
            this.lblNamaKaryawan.AutoSize = true;
            this.lblNamaKaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaKaryawan.Location = new System.Drawing.Point(9, 78);
            this.lblNamaKaryawan.Name = "lblNamaKaryawan";
            this.lblNamaKaryawan.Size = new System.Drawing.Size(112, 16);
            this.lblNamaKaryawan.TabIndex = 2;
            this.lblNamaKaryawan.Text = "Nama Karyawan :";
            // 
            // lblDepkaryawan
            // 
            this.lblDepkaryawan.AutoSize = true;
            this.lblDepkaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepkaryawan.Location = new System.Drawing.Point(9, 108);
            this.lblDepkaryawan.Name = "lblDepkaryawan";
            this.lblDepkaryawan.Size = new System.Drawing.Size(101, 16);
            this.lblDepkaryawan.TabIndex = 3;
            this.lblDepkaryawan.Text = "Dep.Karyawan :";
            // 
            // tbNamaKaryawan
            // 
            this.tbNamaKaryawan.Location = new System.Drawing.Point(127, 78);
            this.tbNamaKaryawan.Name = "tbNamaKaryawan";
            this.tbNamaKaryawan.Size = new System.Drawing.Size(174, 20);
            this.tbNamaKaryawan.TabIndex = 4;
            // 
            // DropDepKaryawan
            // 
            this.DropDepKaryawan.Location = new System.Drawing.Point(127, 104);
            this.DropDepKaryawan.Name = "DropDepKaryawan";
            this.DropDepKaryawan.Size = new System.Drawing.Size(174, 20);
            this.DropDepKaryawan.TabIndex = 5;
            this.DropDepKaryawan.Text = "dropdown";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 158);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(109, 30);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(127, 158);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(109, 30);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(242, 158);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(501, 225);
            this.dataGridView1.TabIndex = 9;
            // 
            // lblIDDepartemen
            // 
            this.lblIDDepartemen.AutoSize = true;
            this.lblIDDepartemen.BackColor = System.Drawing.Color.LightGray;
            this.lblIDDepartemen.Location = new System.Drawing.Point(412, 46);
            this.lblIDDepartemen.Name = "lblIDDepartemen";
            this.lblIDDepartemen.Size = new System.Drawing.Size(87, 78);
            this.lblIDDepartemen.TabIndex = 10;
            this.lblIDDepartemen.Text = "ID Departemen :\r\nHR : HR\r\nENG : Engineer\r\nDEV : Developer\r\nPM : Product M\r\nFIN : " +
    "Finance\r\n";
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(404, 158);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(109, 30);
            this.btn_Load.TabIndex = 11;
            this.btn_Load.Text = "Load Data";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.lblIDDepartemen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.DropDepKaryawan);
            this.Controls.Add(this.tbNamaKaryawan);
            this.Controls.Add(this.lblDepkaryawan);
            this.Controls.Add(this.lblNamaKaryawan);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblNamaKaryawan;
        private System.Windows.Forms.Label lblDepkaryawan;
        private System.Windows.Forms.TextBox tbNamaKaryawan;
        private System.Windows.Forms.DomainUpDown DropDepKaryawan;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblIDDepartemen;
        private System.Windows.Forms.Button btn_Load;
    }
}

