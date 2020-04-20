namespace TomOkna
{
    partial class sale
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
            this.CountGroup = new System.Windows.Forms.GroupBox();
            this.CountBox = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.AddProd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.CountGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CountGroup
            // 
            this.CountGroup.Controls.Add(this.CountBox);
            this.CountGroup.Location = new System.Drawing.Point(597, 12);
            this.CountGroup.Name = "CountGroup";
            this.CountGroup.Size = new System.Drawing.Size(200, 100);
            this.CountGroup.TabIndex = 0;
            this.CountGroup.TabStop = false;
            this.CountGroup.Text = "Сумма";
            // 
            // CountBox
            // 
            this.CountBox.AutoSize = true;
            this.CountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountBox.Location = new System.Drawing.Point(37, 34);
            this.CountBox.Name = "CountBox";
            this.CountBox.Size = new System.Drawing.Size(51, 55);
            this.CountBox.TabIndex = 0;
            this.CountBox.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.AddProd);
            this.groupBox1.Location = new System.Drawing.Point(597, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 329);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddProd
            // 
            this.AddProd.Location = new System.Drawing.Point(11, 9);
            this.AddProd.Name = "AddProd";
            this.AddProd.Size = new System.Drawing.Size(180, 40);
            this.AddProd.TabIndex = 0;
            this.AddProd.Text = "Добавить";
            this.AddProd.UseVisualStyleBackColor = true;
            this.AddProd.Click += new System.EventHandler(this.AddProd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameProduct,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 335);
            this.dataGridView1.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // NameProduct
            // 
            this.NameProduct.HeaderText = "Наименование";
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Количесво";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список заказа";
            // 
            // sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CountGroup);
            this.Name = "sale";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.CountGroup.ResumeLayout(false);
            this.CountGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CountGroup;
        private System.Windows.Forms.Label CountBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddProd;
        private System.Windows.Forms.DataGridView dataGridView1;
       
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}