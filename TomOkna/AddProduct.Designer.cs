namespace TomOkna
{
    partial class AddProduct
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.windowCompanyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.windowCompanyDataSet = new TomOkna.WindowCompanyDataSet();
            this.appliancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appliancesTableAdapter = new TomOkna.WindowCompanyDataSetTableAdapters.AppliancesTableAdapter();
            this.appliancesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new TomOkna.WindowCompanyDataSetTableAdapters.ClientsTableAdapter();
            this.fKOrdersApplianc47DBAE45BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new TomOkna.WindowCompanyDataSetTableAdapters.OrdersTableAdapter();
            this.fKOrdersClientF46E78A0CBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowCompanyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrdersApplianc47DBAE45BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrdersClientF46E78A0CBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.fKOrdersClientF46E78A0CBindingSource;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(434, 420);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "FirstName";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.windowCompanyDataSetBindingSource;
            // 
            // windowCompanyDataSetBindingSource
            // 
            this.windowCompanyDataSetBindingSource.DataSource = this.windowCompanyDataSet;
            this.windowCompanyDataSetBindingSource.Position = 0;
            // 
            // windowCompanyDataSet
            // 
            this.windowCompanyDataSet.DataSetName = "WindowCompanyDataSet";
            this.windowCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appliancesBindingSource
            // 
            this.appliancesBindingSource.DataMember = "Appliances";
            this.appliancesBindingSource.DataSource = this.windowCompanyDataSetBindingSource;
            // 
            // appliancesTableAdapter
            // 
            this.appliancesTableAdapter.ClearBeforeFill = true;
            // 
            // appliancesBindingSource1
            // 
            this.appliancesBindingSource1.DataMember = "Appliances";
            this.appliancesBindingSource1.DataSource = this.windowCompanyDataSetBindingSource;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // fKOrdersApplianc47DBAE45BindingSource
            // 
            this.fKOrdersApplianc47DBAE45BindingSource.DataMember = "FK__Orders__Applianc__47DBAE45";
            this.fKOrdersApplianc47DBAE45BindingSource.DataSource = this.appliancesBindingSource;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // fKOrdersClientF46E78A0CBindingSource
            // 
            this.fKOrdersClientF46E78A0CBindingSource.DataMember = "FK__Orders__Client_F__46E78A0C";
            this.fKOrdersClientF46E78A0CBindingSource.DataSource = this.clientsBindingSource;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(454, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 466);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.listBox1);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowCompanyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrdersApplianc47DBAE45BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrdersClientF46E78A0CBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource windowCompanyDataSetBindingSource;
        private WindowCompanyDataSet windowCompanyDataSet;
        private System.Windows.Forms.BindingSource appliancesBindingSource;
        private WindowCompanyDataSetTableAdapters.AppliancesTableAdapter appliancesTableAdapter;
        private System.Windows.Forms.BindingSource appliancesBindingSource1;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private WindowCompanyDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource fKOrdersApplianc47DBAE45BindingSource;
        private WindowCompanyDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource fKOrdersClientF46E78A0CBindingSource;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
    }
}