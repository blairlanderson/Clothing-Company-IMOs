namespace OrderingUI
{
    partial class EditCompanyScreen
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpCompanyGeneral = new System.Windows.Forms.GroupBox();
            this.cboProvince = new System.Windows.Forms.ComboBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblCxName = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.txtAddressB = new System.Windows.Forms.TextBox();
            this.txtAddressA = new System.Windows.Forms.TextBox();
            this.lblFaxNum = new System.Windows.Forms.Label();
            this.txtFaxNum = new System.Windows.Forms.TextBox();
            this.txtAltPhoneNum = new System.Windows.Forms.TextBox();
            this.lblAltPhone = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.grpCompanyAddress = new System.Windows.Forms.GroupBox();
            this.grpEditCompanyHeader = new System.Windows.Forms.GroupBox();
            this.btnManageContacts = new System.Windows.Forms.Button();
            this.grpCompanyGeneral.SuspendLayout();
            this.grpCompanyAddress.SuspendLayout();
            this.grpEditCompanyHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 483);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(6, 120);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(585, 50);
            this.txtNotes.TabIndex = 5;
            this.txtNotes.Text = "";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(6, 100);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(49, 17);
            this.lblNotes.TabIndex = 4;
            this.lblNotes.Text = "Notes:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(7, 47);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(585, 50);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Text = "";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(7, 27);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(150, 17);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Company Description: ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(535, 483);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpCompanyGeneral
            // 
            this.grpCompanyGeneral.Controls.Add(this.txtNotes);
            this.grpCompanyGeneral.Controls.Add(this.lblNotes);
            this.grpCompanyGeneral.Controls.Add(this.txtDescription);
            this.grpCompanyGeneral.Controls.Add(this.lblDesc);
            this.grpCompanyGeneral.Location = new System.Drawing.Point(12, 283);
            this.grpCompanyGeneral.Name = "grpCompanyGeneral";
            this.grpCompanyGeneral.Size = new System.Drawing.Size(598, 181);
            this.grpCompanyGeneral.TabIndex = 14;
            this.grpCompanyGeneral.TabStop = false;
            this.grpCompanyGeneral.Text = "General Info: ";
            this.grpCompanyGeneral.Enter += new System.EventHandler(this.grpCompanyGeneral_Enter);
            // 
            // cboProvince
            // 
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.Items.AddRange(new object[] {
            "Select Province..",
            "Alberta",
            "British Columbia",
            "Manitoba",
            "New Brunswick",
            "Newfoundland",
            "Northwest Territories",
            "Nova Scotia",
            "Nunavut",
            "Ontario",
            "Prince Edward Island",
            "Quebec",
            "Saskatchewan",
            "Yukon"});
            this.cboProvince.Location = new System.Drawing.Point(5, 183);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(295, 24);
            this.cboProvince.TabIndex = 11;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(-1, 210);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(92, 17);
            this.lblPostalCode.TabIndex = 10;
            this.lblPostalCode.Text = "Postal Code: ";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(5, 230);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(295, 22);
            this.txtPostalCode.TabIndex = 9;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(6, 163);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(71, 17);
            this.lblProvince.TabIndex = 8;
            this.lblProvince.Text = "Province: ";
            // 
            // lblCxName
            // 
            this.lblCxName.AutoSize = true;
            this.lblCxName.Location = new System.Drawing.Point(7, 28);
            this.lblCxName.Name = "lblCxName";
            this.lblCxName.Size = new System.Drawing.Size(112, 17);
            this.lblCxName.TabIndex = 2;
            this.lblCxName.Text = "Company Name:";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(6, 93);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(273, 22);
            this.txtPhoneNum.TabIndex = 1;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(6, 48);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(273, 22);
            this.txtCompanyName.TabIndex = 0;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(5, 138);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(295, 22);
            this.txtCity.TabIndex = 5;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(5, 118);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 17);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City";
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(5, 73);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(107, 17);
            this.lblAddressLine2.TabIndex = 3;
            this.lblAddressLine2.Text = "Address Line 2:";
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(6, 28);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(107, 17);
            this.lblAddressLine1.TabIndex = 2;
            this.lblAddressLine1.Text = "Address Line 1:";
            // 
            // txtAddressB
            // 
            this.txtAddressB.Location = new System.Drawing.Point(5, 93);
            this.txtAddressB.Name = "txtAddressB";
            this.txtAddressB.Size = new System.Drawing.Size(295, 22);
            this.txtAddressB.TabIndex = 1;
            // 
            // txtAddressA
            // 
            this.txtAddressA.Location = new System.Drawing.Point(5, 48);
            this.txtAddressA.Name = "txtAddressA";
            this.txtAddressA.Size = new System.Drawing.Size(295, 22);
            this.txtAddressA.TabIndex = 0;
            // 
            // lblFaxNum
            // 
            this.lblFaxNum.AutoSize = true;
            this.lblFaxNum.Location = new System.Drawing.Point(6, 163);
            this.lblFaxNum.Name = "lblFaxNum";
            this.lblFaxNum.Size = new System.Drawing.Size(88, 17);
            this.lblFaxNum.TabIndex = 8;
            this.lblFaxNum.Text = "Fax Number:";
            // 
            // txtFaxNum
            // 
            this.txtFaxNum.Location = new System.Drawing.Point(6, 183);
            this.txtFaxNum.Name = "txtFaxNum";
            this.txtFaxNum.Size = new System.Drawing.Size(273, 22);
            this.txtFaxNum.TabIndex = 6;
            // 
            // txtAltPhoneNum
            // 
            this.txtAltPhoneNum.Location = new System.Drawing.Point(6, 138);
            this.txtAltPhoneNum.Name = "txtAltPhoneNum";
            this.txtAltPhoneNum.Size = new System.Drawing.Size(273, 22);
            this.txtAltPhoneNum.TabIndex = 5;
            // 
            // lblAltPhone
            // 
            this.lblAltPhone.AutoSize = true;
            this.lblAltPhone.Location = new System.Drawing.Point(6, 118);
            this.lblAltPhone.Name = "lblAltPhone";
            this.lblAltPhone.Size = new System.Drawing.Size(131, 17);
            this.lblAltPhone.TabIndex = 4;
            this.lblAltPhone.Text = "Alt Phone Number: ";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Location = new System.Drawing.Point(6, 73);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(111, 17);
            this.lblPhoneNum.TabIndex = 3;
            this.lblPhoneNum.Text = "Phone Number: ";
            // 
            // grpCompanyAddress
            // 
            this.grpCompanyAddress.Controls.Add(this.cboProvince);
            this.grpCompanyAddress.Controls.Add(this.lblPostalCode);
            this.grpCompanyAddress.Controls.Add(this.txtPostalCode);
            this.grpCompanyAddress.Controls.Add(this.lblProvince);
            this.grpCompanyAddress.Controls.Add(this.txtCity);
            this.grpCompanyAddress.Controls.Add(this.lblCity);
            this.grpCompanyAddress.Controls.Add(this.lblAddressLine2);
            this.grpCompanyAddress.Controls.Add(this.lblAddressLine1);
            this.grpCompanyAddress.Controls.Add(this.txtAddressB);
            this.grpCompanyAddress.Controls.Add(this.txtAddressA);
            this.grpCompanyAddress.Location = new System.Drawing.Point(303, 12);
            this.grpCompanyAddress.Name = "grpCompanyAddress";
            this.grpCompanyAddress.Size = new System.Drawing.Size(307, 265);
            this.grpCompanyAddress.TabIndex = 13;
            this.grpCompanyAddress.TabStop = false;
            this.grpCompanyAddress.Text = "Address Information: ";
            // 
            // grpEditCompanyHeader
            // 
            this.grpEditCompanyHeader.Controls.Add(this.lblFaxNum);
            this.grpEditCompanyHeader.Controls.Add(this.txtFaxNum);
            this.grpEditCompanyHeader.Controls.Add(this.txtAltPhoneNum);
            this.grpEditCompanyHeader.Controls.Add(this.lblAltPhone);
            this.grpEditCompanyHeader.Controls.Add(this.lblPhoneNum);
            this.grpEditCompanyHeader.Controls.Add(this.lblCxName);
            this.grpEditCompanyHeader.Controls.Add(this.txtPhoneNum);
            this.grpEditCompanyHeader.Controls.Add(this.txtCompanyName);
            this.grpEditCompanyHeader.Location = new System.Drawing.Point(12, 12);
            this.grpEditCompanyHeader.Name = "grpEditCompanyHeader";
            this.grpEditCompanyHeader.Size = new System.Drawing.Size(285, 265);
            this.grpEditCompanyHeader.TabIndex = 12;
            this.grpEditCompanyHeader.TabStop = false;
            this.grpEditCompanyHeader.Text = "Edit";
            // 
            // btnManageContacts
            // 
            this.btnManageContacts.Location = new System.Drawing.Point(338, 483);
            this.btnManageContacts.Name = "btnManageContacts";
            this.btnManageContacts.Size = new System.Drawing.Size(191, 23);
            this.btnManageContacts.TabIndex = 17;
            this.btnManageContacts.Text = "Manage Company Contacts";
            this.btnManageContacts.UseVisualStyleBackColor = true;
            this.btnManageContacts.Click += new System.EventHandler(this.btnManageContacts_Click);
            // 
            // EditCompanyScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 518);
            this.Controls.Add(this.btnManageContacts);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grpCompanyGeneral);
            this.Controls.Add(this.grpCompanyAddress);
            this.Controls.Add(this.grpEditCompanyHeader);
            this.Name = "EditCompanyScreen";
            this.Text = "EditCompanyScreen";
            this.Load += new System.EventHandler(this.EditCompanyScreen_Load);
            this.grpCompanyGeneral.ResumeLayout(false);
            this.grpCompanyGeneral.PerformLayout();
            this.grpCompanyAddress.ResumeLayout(false);
            this.grpCompanyAddress.PerformLayout();
            this.grpEditCompanyHeader.ResumeLayout(false);
            this.grpEditCompanyHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grpCompanyGeneral;
        private System.Windows.Forms.ComboBox cboProvince;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblCxName;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.TextBox txtAddressB;
        private System.Windows.Forms.TextBox txtAddressA;
        private System.Windows.Forms.Label lblFaxNum;
        private System.Windows.Forms.TextBox txtFaxNum;
        private System.Windows.Forms.TextBox txtAltPhoneNum;
        private System.Windows.Forms.Label lblAltPhone;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.GroupBox grpCompanyAddress;
        private System.Windows.Forms.GroupBox grpEditCompanyHeader;
        private System.Windows.Forms.Button btnManageContacts;
    }
}