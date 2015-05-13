namespace OrderingUI
{
    partial class CompanyContactScreen
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
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpContactHeader = new System.Windows.Forms.GroupBox();
            this.txtSalutation = new System.Windows.Forms.TextBox();
            this.lblSalutation = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grpCompanyInfo = new System.Windows.Forms.GroupBox();
            this.txtSignature = new System.Windows.Forms.TextBox();
            this.lblSignature = new System.Windows.Forms.Label();
            this.txtBranchId = new System.Windows.Forms.TextBox();
            this.lblBranchId = new System.Windows.Forms.Label();
            this.txtExt = new System.Windows.Forms.TextBox();
            this.lblExt = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpContactHeader.SuspendLayout();
            this.grpCompanyInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(535, 483);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 0;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(93, 483);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 483);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpContactHeader
            // 
            this.grpContactHeader.Controls.Add(this.txtSalutation);
            this.grpContactHeader.Controls.Add(this.lblSalutation);
            this.grpContactHeader.Controls.Add(this.txtLastName);
            this.grpContactHeader.Controls.Add(this.lblLastName);
            this.grpContactHeader.Controls.Add(this.txtFirstName);
            this.grpContactHeader.Controls.Add(this.lblFirstName);
            this.grpContactHeader.Location = new System.Drawing.Point(13, 13);
            this.grpContactHeader.Name = "grpContactHeader";
            this.grpContactHeader.Size = new System.Drawing.Size(597, 138);
            this.grpContactHeader.TabIndex = 4;
            this.grpContactHeader.TabStop = false;
            this.grpContactHeader.Text = "Add New Company Contact: ";
            // 
            // txtSalutation
            // 
            this.txtSalutation.Location = new System.Drawing.Point(6, 49);
            this.txtSalutation.Name = "txtSalutation";
            this.txtSalutation.Size = new System.Drawing.Size(200, 22);
            this.txtSalutation.TabIndex = 5;
            // 
            // lblSalutation
            // 
            this.lblSalutation.AutoSize = true;
            this.lblSalutation.Location = new System.Drawing.Point(6, 28);
            this.lblSalutation.Name = "lblSalutation";
            this.lblSalutation.Size = new System.Drawing.Size(79, 17);
            this.lblSalutation.TabIndex = 4;
            this.lblSalutation.Text = "Salutation: ";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(336, 95);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 22);
            this.txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(336, 74);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 17);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(6, 95);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 74);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 17);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // grpCompanyInfo
            // 
            this.grpCompanyInfo.Controls.Add(this.txtSignature);
            this.grpCompanyInfo.Controls.Add(this.lblSignature);
            this.grpCompanyInfo.Controls.Add(this.txtBranchId);
            this.grpCompanyInfo.Controls.Add(this.lblBranchId);
            this.grpCompanyInfo.Controls.Add(this.txtExt);
            this.grpCompanyInfo.Controls.Add(this.lblExt);
            this.grpCompanyInfo.Controls.Add(this.txtTitle);
            this.grpCompanyInfo.Controls.Add(this.lblTitle);
            this.grpCompanyInfo.Location = new System.Drawing.Point(12, 157);
            this.grpCompanyInfo.Name = "grpCompanyInfo";
            this.grpCompanyInfo.Size = new System.Drawing.Size(597, 184);
            this.grpCompanyInfo.TabIndex = 5;
            this.grpCompanyInfo.TabStop = false;
            this.grpCompanyInfo.Text = "Company related Information: ";
            // 
            // txtSignature
            // 
            this.txtSignature.Location = new System.Drawing.Point(6, 141);
            this.txtSignature.Name = "txtSignature";
            this.txtSignature.Size = new System.Drawing.Size(200, 22);
            this.txtSignature.TabIndex = 9;
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Location = new System.Drawing.Point(6, 120);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(73, 17);
            this.lblSignature.TabIndex = 8;
            this.lblSignature.Text = "Signature:";
            // 
            // txtBranchId
            // 
            this.txtBranchId.Location = new System.Drawing.Point(6, 95);
            this.txtBranchId.Name = "txtBranchId";
            this.txtBranchId.Size = new System.Drawing.Size(200, 22);
            this.txtBranchId.TabIndex = 5;
            // 
            // lblBranchId
            // 
            this.lblBranchId.AutoSize = true;
            this.lblBranchId.Location = new System.Drawing.Point(6, 74);
            this.lblBranchId.Name = "lblBranchId";
            this.lblBranchId.Size = new System.Drawing.Size(74, 17);
            this.lblBranchId.TabIndex = 4;
            this.lblBranchId.Text = "Branch ID:";
            // 
            // txtExt
            // 
            this.txtExt.Location = new System.Drawing.Point(337, 95);
            this.txtExt.Name = "txtExt";
            this.txtExt.Size = new System.Drawing.Size(200, 22);
            this.txtExt.TabIndex = 3;
            // 
            // lblExt
            // 
            this.lblExt.AutoSize = true;
            this.lblExt.Location = new System.Drawing.Point(337, 74);
            this.lblExt.Name = "lblExt";
            this.lblExt.Size = new System.Drawing.Size(77, 17);
            this.lblExt.TabIndex = 2;
            this.lblExt.Text = "Extension: ";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(7, 49);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(7, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // CompanyContactScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 518);
            this.Controls.Add(this.grpCompanyInfo);
            this.Controls.Add(this.grpContactHeader);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFinish);
            this.Name = "CompanyContactScreen";
            this.Text = "CompanyContact";
            this.Load += new System.EventHandler(this.CompanyContactScreen_Load);
            this.grpContactHeader.ResumeLayout(false);
            this.grpContactHeader.PerformLayout();
            this.grpCompanyInfo.ResumeLayout(false);
            this.grpCompanyInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpContactHeader;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox grpCompanyInfo;
        private System.Windows.Forms.TextBox txtExt;
        private System.Windows.Forms.Label lblExt;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSalutation;
        private System.Windows.Forms.TextBox txtBranchId;
        private System.Windows.Forms.Label lblBranchId;
        private System.Windows.Forms.TextBox txtSalutation;
        private System.Windows.Forms.TextBox txtSignature;
        private System.Windows.Forms.Label lblSignature;
    }
}