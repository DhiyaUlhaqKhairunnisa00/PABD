namespace Disconnected_Environment
{
    partial class Data_Status_Mahasiswa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Mhs = new System.Windows.Forms.Label();
            this.Nim = new System.Windows.Forms.Label();
            this.StMhs = new System.Windows.Forms.Label();
            this.Thmsk = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.nmMhs = new System.Windows.Forms.ComboBox();
            this.statusMhs = new System.Windows.Forms.ComboBox();
            this.ThMasuk = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(576, 224);
            this.dataGridView1.TabIndex = 0;
            // 
            // Mhs
            // 
            this.Mhs.AutoSize = true;
            this.Mhs.Location = new System.Drawing.Point(106, 275);
            this.Mhs.Name = "Mhs";
            this.Mhs.Size = new System.Drawing.Size(134, 20);
            this.Mhs.TabIndex = 1;
            this.Mhs.Text = "Nama Mahasiswa";
            this.Mhs.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nim
            // 
            this.Nim.AutoSize = true;
            this.Nim.Location = new System.Drawing.Point(106, 313);
            this.Nim.Name = "Nim";
            this.Nim.Size = new System.Drawing.Size(183, 20);
            this.Nim.TabIndex = 2;
            this.Nim.Text = "Nomor Induk Mahasiswa";
            this.Nim.Click += new System.EventHandler(this.label2_Click);
            // 
            // StMhs
            // 
            this.StMhs.AutoSize = true;
            this.StMhs.Location = new System.Drawing.Point(100, 362);
            this.StMhs.Name = "StMhs";
            this.StMhs.Size = new System.Drawing.Size(139, 20);
            this.StMhs.TabIndex = 3;
            this.StMhs.Text = "Status Mahasiswa";
            // 
            // Thmsk
            // 
            this.Thmsk.AutoSize = true;
            this.Thmsk.Location = new System.Drawing.Point(99, 400);
            this.Thmsk.Name = "Thmsk";
            this.Thmsk.Size = new System.Drawing.Size(105, 20);
            this.Thmsk.TabIndex = 4;
            this.Thmsk.Text = "Tahun Masuk";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(548, 275);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 36);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(548, 317);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 42);
            this.ClearBtn.TabIndex = 6;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(548, 365);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 39);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(666, 62);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(75, 40);
            this.OpenBtn.TabIndex = 8;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // nmMhs
            // 
            this.nmMhs.FormattingEnabled = true;
            this.nmMhs.Location = new System.Drawing.Point(316, 280);
            this.nmMhs.Name = "nmMhs";
            this.nmMhs.Size = new System.Drawing.Size(194, 28);
            this.nmMhs.TabIndex = 9;
            // 
            // statusMhs
            // 
            this.statusMhs.FormattingEnabled = true;
            this.statusMhs.Location = new System.Drawing.Point(316, 362);
            this.statusMhs.Name = "statusMhs";
            this.statusMhs.Size = new System.Drawing.Size(194, 28);
            this.statusMhs.TabIndex = 10;
            // 
            // ThMasuk
            // 
            this.ThMasuk.FormattingEnabled = true;
            this.ThMasuk.Location = new System.Drawing.Point(316, 400);
            this.ThMasuk.Name = "ThMasuk";
            this.ThMasuk.Size = new System.Drawing.Size(194, 28);
            this.ThMasuk.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "txtNim";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ThMasuk);
            this.Controls.Add(this.statusMhs);
            this.Controls.Add(this.nmMhs);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.Thmsk);
            this.Controls.Add(this.StMhs);
            this.Controls.Add(this.Nim);
            this.Controls.Add(this.Mhs);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Halaman Status Mahasiswa";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Mhs;
        private System.Windows.Forms.Label Nim;
        private System.Windows.Forms.Label StMhs;
        private System.Windows.Forms.Label Thmsk;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.ComboBox nmMhs;
        private System.Windows.Forms.ComboBox statusMhs;
        private System.Windows.Forms.ComboBox ThMasuk;
        private System.Windows.Forms.Label label5;
    }
}