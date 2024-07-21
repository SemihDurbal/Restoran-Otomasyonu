namespace YasinOrtacRestaurant
{
    partial class Urunler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.urunEkleButton = new System.Windows.Forms.Button();
            this.urunSilButton = new System.Windows.Forms.Button();
            this.urunDuzenleButton = new System.Windows.Forms.Button();
            this.urunTablosu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.urunismitxtbox = new System.Windows.Forms.TextBox();
            this.urunfiyatitxtbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.urunTablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // urunEkleButton
            // 
            this.urunEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urunEkleButton.Location = new System.Drawing.Point(829, 292);
            this.urunEkleButton.Name = "urunEkleButton";
            this.urunEkleButton.Size = new System.Drawing.Size(287, 57);
            this.urunEkleButton.TabIndex = 0;
            this.urunEkleButton.Text = "ÜRÜN EKLE";
            this.urunEkleButton.UseVisualStyleBackColor = true;
            this.urunEkleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // urunSilButton
            // 
            this.urunSilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urunSilButton.Location = new System.Drawing.Point(829, 434);
            this.urunSilButton.Name = "urunSilButton";
            this.urunSilButton.Size = new System.Drawing.Size(287, 57);
            this.urunSilButton.TabIndex = 1;
            this.urunSilButton.Text = "ÜRÜN SİL";
            this.urunSilButton.UseVisualStyleBackColor = true;
            this.urunSilButton.Click += new System.EventHandler(this.urunSilButton_Click);
            // 
            // urunDuzenleButton
            // 
            this.urunDuzenleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urunDuzenleButton.Location = new System.Drawing.Point(1094, 365);
            this.urunDuzenleButton.Name = "urunDuzenleButton";
            this.urunDuzenleButton.Size = new System.Drawing.Size(292, 57);
            this.urunDuzenleButton.TabIndex = 2;
            this.urunDuzenleButton.Text = "ÜRÜN DÜZENLE";
            this.urunDuzenleButton.UseVisualStyleBackColor = true;
            this.urunDuzenleButton.Click += new System.EventHandler(this.urunDuzenleButton_Click);
            // 
            // urunTablosu
            // 
            this.urunTablosu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urunTablosu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.urunTablosu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.urunTablosu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.urunTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.urunTablosu.DefaultCellStyle = dataGridViewCellStyle2;
            this.urunTablosu.Location = new System.Drawing.Point(44, 32);
            this.urunTablosu.Name = "urunTablosu";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.urunTablosu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.urunTablosu.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.urunTablosu.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.urunTablosu.RowTemplate.Height = 24;
            this.urunTablosu.Size = new System.Drawing.Size(753, 559);
            this.urunTablosu.TabIndex = 3;
            this.urunTablosu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.urunTablosu_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(900, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "ÜRÜN İSMİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(877, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "ÜRÜN FİYATI";
            // 
            // urunismitxtbox
            // 
            this.urunismitxtbox.Location = new System.Drawing.Point(1048, 100);
            this.urunismitxtbox.Multiline = true;
            this.urunismitxtbox.Name = "urunismitxtbox";
            this.urunismitxtbox.Size = new System.Drawing.Size(228, 44);
            this.urunismitxtbox.TabIndex = 6;
            // 
            // urunfiyatitxtbox
            // 
            this.urunfiyatitxtbox.Location = new System.Drawing.Point(1048, 156);
            this.urunfiyatitxtbox.Multiline = true;
            this.urunfiyatitxtbox.Name = "urunfiyatitxtbox";
            this.urunfiyatitxtbox.Size = new System.Drawing.Size(228, 44);
            this.urunfiyatitxtbox.TabIndex = 7;
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1410, 620);
            this.Controls.Add(this.urunfiyatitxtbox);
            this.Controls.Add(this.urunismitxtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urunTablosu);
            this.Controls.Add(this.urunDuzenleButton);
            this.Controls.Add(this.urunSilButton);
            this.Controls.Add(this.urunEkleButton);
            this.Name = "Urunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urunler";
            this.Load += new System.EventHandler(this.Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunTablosu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button urunEkleButton;
        private System.Windows.Forms.Button urunSilButton;
        private System.Windows.Forms.Button urunDuzenleButton;
        private System.Windows.Forms.DataGridView urunTablosu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox urunismitxtbox;
        private System.Windows.Forms.TextBox urunfiyatitxtbox;
    }
}