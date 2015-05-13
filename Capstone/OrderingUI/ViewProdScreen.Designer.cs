namespace OrderingUI
{
    partial class ViewProdScreen
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
            this.grpViewProdDetails = new System.Windows.Forms.GroupBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtImageName = new System.Windows.Forms.TextBox();
            this.lblImageName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.grpCompanyGeneral = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.grpViewProdDetails.SuspendLayout();
            this.grpCompanyGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpViewProdDetails
            // 
            this.grpViewProdDetails.Controls.Add(this.lblStatus);
            this.grpViewProdDetails.Controls.Add(this.txtStatus);
            this.grpViewProdDetails.Controls.Add(this.lblColour);
            this.grpViewProdDetails.Controls.Add(this.txtColour);
            this.grpViewProdDetails.Controls.Add(this.lblSize);
            this.grpViewProdDetails.Controls.Add(this.txtSize);
            this.grpViewProdDetails.Controls.Add(this.txtImageName);
            this.grpViewProdDetails.Controls.Add(this.lblImageName);
            this.grpViewProdDetails.Controls.Add(this.lblPrice);
            this.grpViewProdDetails.Controls.Add(this.lblProdName);
            this.grpViewProdDetails.Controls.Add(this.txtPrice);
            this.grpViewProdDetails.Controls.Add(this.txtProdName);
            this.grpViewProdDetails.Location = new System.Drawing.Point(12, 12);
            this.grpViewProdDetails.Name = "grpViewProdDetails";
            this.grpViewProdDetails.Size = new System.Drawing.Size(598, 182);
            this.grpViewProdDetails.TabIndex = 2;
            this.grpViewProdDetails.TabStop = false;
            this.grpViewProdDetails.Text = "Product Details: ";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(6, 118);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(39, 17);
            this.lblSize.TabIndex = 8;
            this.lblSize.Text = "Size:";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(6, 138);
            this.txtSize.Name = "txtSize";
            this.txtSize.ReadOnly = true;
            this.txtSize.Size = new System.Drawing.Size(273, 22);
            this.txtSize.TabIndex = 6;
            // 
            // txtImageName
            // 
            this.txtImageName.Location = new System.Drawing.Point(6, 93);
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.ReadOnly = true;
            this.txtImageName.Size = new System.Drawing.Size(273, 22);
            this.txtImageName.TabIndex = 5;
            // 
            // lblImageName
            // 
            this.lblImageName.AutoSize = true;
            this.lblImageName.Location = new System.Drawing.Point(6, 73);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(115, 17);
            this.lblImageName.TabIndex = 4;
            this.lblImageName.Text = "Image Filename: ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(318, 28);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(73, 17);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price/Unit:";
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Location = new System.Drawing.Point(7, 28);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(102, 17);
            this.lblProdName.TabIndex = 2;
            this.lblProdName.Text = "Product Name:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(318, 48);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(273, 22);
            this.txtPrice.TabIndex = 1;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(6, 48);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.ReadOnly = true;
            this.txtProdName.Size = new System.Drawing.Size(273, 22);
            this.txtProdName.TabIndex = 0;
            // 
            // grpCompanyGeneral
            // 
            this.grpCompanyGeneral.Controls.Add(this.txtNotes);
            this.grpCompanyGeneral.Controls.Add(this.lblNotes);
            this.grpCompanyGeneral.Controls.Add(this.txtDescription);
            this.grpCompanyGeneral.Controls.Add(this.lblDesc);
            this.grpCompanyGeneral.Location = new System.Drawing.Point(12, 242);
            this.grpCompanyGeneral.Name = "grpCompanyGeneral";
            this.grpCompanyGeneral.Size = new System.Drawing.Size(598, 181);
            this.grpCompanyGeneral.TabIndex = 10;
            this.grpCompanyGeneral.TabStop = false;
            this.grpCompanyGeneral.Text = "General Info: ";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(6, 120);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = true;
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
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(585, 50);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Text = "";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(7, 27);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(140, 17);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Product Description: ";
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(318, 73);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(53, 17);
            this.lblColour.TabIndex = 10;
            this.lblColour.Text = "Colour:";
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(318, 93);
            this.txtColour.Name = "txtColour";
            this.txtColour.ReadOnly = true;
            this.txtColour.Size = new System.Drawing.Size(273, 22);
            this.txtColour.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(318, 118);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 17);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(318, 138);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(273, 22);
            this.txtStatus.TabIndex = 11;
            // 
            // ViewProdScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 518);
            this.Controls.Add(this.grpCompanyGeneral);
            this.Controls.Add(this.grpViewProdDetails);
            this.Name = "ViewProdScreen";
            this.Text = "ViewProdScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewProdScreen_Load);
            this.grpViewProdDetails.ResumeLayout(false);
            this.grpViewProdDetails.PerformLayout();
            this.grpCompanyGeneral.ResumeLayout(false);
            this.grpCompanyGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpViewProdDetails;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtImageName;
        private System.Windows.Forms.Label lblImageName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.GroupBox grpCompanyGeneral;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.TextBox txtColour;
    }
}