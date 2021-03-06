﻿namespace ManufacturingTest2
{
    partial class AddMaterial
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MaterialDesc = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MaterialCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MaterialVendor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaterialName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MaterialDesc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MaterialCost);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MaterialVendor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MaterialName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(364, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter A Material";
            // 
            // MaterialDesc
            // 
            this.MaterialDesc.Location = new System.Drawing.Point(125, 150);
            this.MaterialDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaterialDesc.Name = "MaterialDesc";
            this.MaterialDesc.Size = new System.Drawing.Size(229, 130);
            this.MaterialDesc.TabIndex = 7;
            this.MaterialDesc.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
            // 
            // MaterialCost
            // 
            this.MaterialCost.Location = new System.Drawing.Point(195, 114);
            this.MaterialCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaterialCost.Name = "MaterialCost";
            this.MaterialCost.Size = new System.Drawing.Size(160, 22);
            this.MaterialCost.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cost";
            // 
            // MaterialVendor
            // 
            this.MaterialVendor.FormattingEnabled = true;
            this.MaterialVendor.Location = new System.Drawing.Point(195, 81);
            this.MaterialVendor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaterialVendor.Name = "MaterialVendor";
            this.MaterialVendor.Size = new System.Drawing.Size(160, 24);
            this.MaterialVendor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vendor";
            // 
            // MaterialName
            // 
            this.MaterialName.Location = new System.Drawing.Point(195, 49);
            this.MaterialName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.Size = new System.Drawing.Size(160, 22);
            this.MaterialName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.Location = new System.Drawing.Point(388, 289);
            this.btnAddMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(100, 28);
            this.btnAddMaterial.TabIndex = 1;
            this.btnAddMaterial.Text = "Confirm";
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // AddMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 332);
            this.Controls.Add(this.btnAddMaterial);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddMaterial";
            this.Text = "Add Material";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddMaterial_FormClosing);
            this.Load += new System.EventHandler(this.AddMaterial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox MaterialVendor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaterialName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MaterialCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.RichTextBox MaterialDesc;
    }
}

