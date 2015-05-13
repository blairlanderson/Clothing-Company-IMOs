namespace OrderingUI
{
    partial class CatalogPortalScreen
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
            this.btnBack = new System.Windows.Forms.Button();
            this.cboUpdateCatalog = new System.Windows.Forms.ComboBox();
            this.btnDeleteCatalog = new System.Windows.Forms.Button();
            this.btnUpdateCatalog = new System.Windows.Forms.Button();
            this.btnNewCatalog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(212, 456);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 50);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cboUpdateCatalog
            // 
            this.cboUpdateCatalog.FormattingEnabled = true;
            this.cboUpdateCatalog.Location = new System.Drawing.Point(212, 156);
            this.cboUpdateCatalog.Name = "cboUpdateCatalog";
            this.cboUpdateCatalog.Size = new System.Drawing.Size(200, 24);
            this.cboUpdateCatalog.TabIndex = 14;
            this.cboUpdateCatalog.SelectedIndexChanged += new System.EventHandler(this.cboUpdateCatalog_SelectedIndexChanged);
            // 
            // btnDeleteCatalog
            // 
            this.btnDeleteCatalog.Location = new System.Drawing.Point(212, 242);
            this.btnDeleteCatalog.Name = "btnDeleteCatalog";
            this.btnDeleteCatalog.Size = new System.Drawing.Size(200, 50);
            this.btnDeleteCatalog.TabIndex = 13;
            this.btnDeleteCatalog.Text = "Delete Catalog";
            this.btnDeleteCatalog.UseVisualStyleBackColor = true;
            this.btnDeleteCatalog.Click += new System.EventHandler(this.btnDeleteCatalog_Click);
            // 
            // btnUpdateCatalog
            // 
            this.btnUpdateCatalog.Location = new System.Drawing.Point(212, 186);
            this.btnUpdateCatalog.Name = "btnUpdateCatalog";
            this.btnUpdateCatalog.Size = new System.Drawing.Size(200, 50);
            this.btnUpdateCatalog.TabIndex = 12;
            this.btnUpdateCatalog.Text = "Update Catalog";
            this.btnUpdateCatalog.UseVisualStyleBackColor = true;
            this.btnUpdateCatalog.Click += new System.EventHandler(this.btnUpdateCatalog_Click);
            // 
            // btnNewCatalog
            // 
            this.btnNewCatalog.Location = new System.Drawing.Point(212, 100);
            this.btnNewCatalog.Name = "btnNewCatalog";
            this.btnNewCatalog.Size = new System.Drawing.Size(200, 50);
            this.btnNewCatalog.TabIndex = 11;
            this.btnNewCatalog.Text = "New Catalog";
            this.btnNewCatalog.UseVisualStyleBackColor = true;
            this.btnNewCatalog.Click += new System.EventHandler(this.btnNewCatalog_Click);
            // 
            // CatalogPortalScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 518);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cboUpdateCatalog);
            this.Controls.Add(this.btnDeleteCatalog);
            this.Controls.Add(this.btnUpdateCatalog);
            this.Controls.Add(this.btnNewCatalog);
            this.Name = "CatalogPortalScreen";
            this.Text = "CatalogPortalScreen";
            this.Load += new System.EventHandler(this.CatalogPortalScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboUpdateCatalog;
        private System.Windows.Forms.Button btnDeleteCatalog;
        private System.Windows.Forms.Button btnUpdateCatalog;
        private System.Windows.Forms.Button btnNewCatalog;

    }
}