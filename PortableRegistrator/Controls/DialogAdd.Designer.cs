
namespace PortableRegistrator.Controls
{
    partial class DialogAdd
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxProgramName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxFileAssociations = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUrlAssociations = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxOpenParameters = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxPropertiesParameters = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(465, 243);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 37);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(345, 243);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 37);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Program Name:";
            // 
            // tbxProgramName
            // 
            this.tbxProgramName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxProgramName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbxProgramName.Location = new System.Drawing.Point(181, 12);
            this.tbxProgramName.Name = "tbxProgramName";
            this.tbxProgramName.Size = new System.Drawing.Size(397, 29);
            this.tbxProgramName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Associations:";
            // 
            // tbxFileAssociations
            // 
            this.tbxFileAssociations.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbxFileAssociations.Location = new System.Drawing.Point(181, 117);
            this.tbxFileAssociations.Multiline = true;
            this.tbxFileAssociations.Name = "tbxFileAssociations";
            this.tbxFileAssociations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxFileAssociations.Size = new System.Drawing.Size(116, 163);
            this.tbxFileAssociations.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "URL Associations:";
            // 
            // tbxUrlAssociations
            // 
            this.tbxUrlAssociations.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbxUrlAssociations.Location = new System.Drawing.Point(477, 117);
            this.tbxUrlAssociations.Multiline = true;
            this.tbxUrlAssociations.Name = "tbxUrlAssociations";
            this.tbxUrlAssociations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxUrlAssociations.Size = new System.Drawing.Size(100, 87);
            this.tbxUrlAssociations.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Open Parameters:";
            // 
            // tbxOpenParameters
            // 
            this.tbxOpenParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxOpenParameters.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbxOpenParameters.Location = new System.Drawing.Point(181, 47);
            this.tbxOpenParameters.Name = "tbxOpenParameters";
            this.tbxOpenParameters.Size = new System.Drawing.Size(397, 29);
            this.tbxOpenParameters.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(68, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 45);
            this.label5.TabIndex = 5;
            this.label5.Text = "Each line \r\none Extension\r\nwith leading \'.\'";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(355, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "Each line \r\none URL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Properties Parameters:";
            // 
            // tbxPropertiesParameters
            // 
            this.tbxPropertiesParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPropertiesParameters.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbxPropertiesParameters.Location = new System.Drawing.Point(181, 82);
            this.tbxPropertiesParameters.Name = "tbxPropertiesParameters";
            this.tbxPropertiesParameters.Size = new System.Drawing.Size(397, 29);
            this.tbxPropertiesParameters.TabIndex = 13;
            // 
            // DialogAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(590, 294);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxPropertiesParameters);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxOpenParameters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxUrlAssociations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxFileAssociations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxProgramName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogAdd";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add new Program-Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxProgramName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFileAssociations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUrlAssociations;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxOpenParameters;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxPropertiesParameters;
    }
}