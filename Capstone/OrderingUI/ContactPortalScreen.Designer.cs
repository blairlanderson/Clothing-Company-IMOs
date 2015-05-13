namespace OrderingUI
{
    partial class ContactPortalScreen
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
            this.btnUpdateContact = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cboUpdateContact = new System.Windows.Forms.ComboBox();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.btnNewContact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdateContact
            // 
            this.btnUpdateContact.Location = new System.Drawing.Point(220, 186);
            this.btnUpdateContact.Name = "btnUpdateContact";
            this.btnUpdateContact.Size = new System.Drawing.Size(200, 50);
            this.btnUpdateContact.TabIndex = 12;
            this.btnUpdateContact.Text = "Update Contact";
            this.btnUpdateContact.UseVisualStyleBackColor = true;
            this.btnUpdateContact.Click += new System.EventHandler(this.btnUpdateContact_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(220, 456);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 50);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cboUpdateContact
            // 
            this.cboUpdateContact.FormattingEnabled = true;
            this.cboUpdateContact.Location = new System.Drawing.Point(220, 156);
            this.cboUpdateContact.Name = "cboUpdateContact";
            this.cboUpdateContact.Size = new System.Drawing.Size(200, 24);
            this.cboUpdateContact.TabIndex = 9;
            this.cboUpdateContact.SelectedIndexChanged += new System.EventHandler(this.cboUpdateContact_SelectedIndexChanged);
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.Location = new System.Drawing.Point(220, 242);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(200, 50);
            this.btnDeleteContact.TabIndex = 8;
            this.btnDeleteContact.Text = "Delete Contact";
            this.btnDeleteContact.UseVisualStyleBackColor = true;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // btnNewContact
            // 
            this.btnNewContact.Location = new System.Drawing.Point(220, 100);
            this.btnNewContact.Name = "btnNewContact";
            this.btnNewContact.Size = new System.Drawing.Size(200, 50);
            this.btnNewContact.TabIndex = 7;
            this.btnNewContact.Text = "New Contact";
            this.btnNewContact.UseVisualStyleBackColor = true;
            this.btnNewContact.Click += new System.EventHandler(this.btnNewContact_Click);
            // 
            // ContactPortalScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 518);
            this.Controls.Add(this.btnUpdateContact);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cboUpdateContact);
            this.Controls.Add(this.btnDeleteContact);
            this.Controls.Add(this.btnNewContact);
            this.Name = "ContactPortalScreen";
            this.Text = "ContactPortalScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ContactPortalScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateContact;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboUpdateContact;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.Button btnNewContact;
    }
}