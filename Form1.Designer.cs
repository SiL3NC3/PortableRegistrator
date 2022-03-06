
namespace PortableRegistrator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnSelectExe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxProgramName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbRegisteredPortables = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUnregister = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxPortablePath = new System.Windows.Forms.TextBox();
            this.cbProgramType = new System.Windows.Forms.ComboBox();
            this.lblFileAssociations = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblURLAssociations = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnConfig = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPropertiesParameter = new System.Windows.Forms.Label();
            this.lblOpenParameters = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.llGithub = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Portable executable:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(578, 244);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(124, 34);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnSelectExe
            // 
            this.btnSelectExe.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectExe.Location = new System.Drawing.Point(676, 57);
            this.btnSelectExe.Name = "btnSelectExe";
            this.btnSelectExe.Size = new System.Drawing.Size(25, 25);
            this.btnSelectExe.TabIndex = 4;
            this.btnSelectExe.Text = "...";
            this.btnSelectExe.UseVisualStyleBackColor = true;
            this.btnSelectExe.Click += new System.EventHandler(this.btnSelectExe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Program Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Program Name:";
            // 
            // tbxProgramName
            // 
            this.tbxProgramName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbxProgramName.Location = new System.Drawing.Point(173, 247);
            this.tbxProgramName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxProgramName.Name = "tbxProgramName";
            this.tbxProgramName.Size = new System.Drawing.Size(204, 29);
            this.tbxProgramName.TabIndex = 8;
            this.tbxProgramName.TextChanged += new System.EventHandler(this.tbxProgramName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Portable\"";
            // 
            // cbRegisteredPortables
            // 
            this.cbRegisteredPortables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRegisteredPortables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegisteredPortables.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbRegisteredPortables.FormattingEnabled = true;
            this.cbRegisteredPortables.Location = new System.Drawing.Point(175, 71);
            this.cbRegisteredPortables.Name = "cbRegisteredPortables";
            this.cbRegisteredPortables.Size = new System.Drawing.Size(392, 29);
            this.cbRegisteredPortables.TabIndex = 10;
            this.cbRegisteredPortables.SelectedIndexChanged += new System.EventHandler(this.cbRegisteredPortables_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(13, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Registered Portables:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnUnregister);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbRegisteredPortables);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 128);
            this.panel1.TabIndex = 17;
            // 
            // btnUnregister
            // 
            this.btnUnregister.Location = new System.Drawing.Point(578, 68);
            this.btnUnregister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUnregister.Name = "btnUnregister";
            this.btnUnregister.Size = new System.Drawing.Size(124, 34);
            this.btnUnregister.TabIndex = 34;
            this.btnUnregister.Text = "UNREGISTER";
            this.btnUnregister.UseVisualStyleBackColor = true;
            this.btnUnregister.Click += new System.EventHandler(this.btnUnregister_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(168, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(252, 30);
            this.label9.TabIndex = 20;
            this.label9.Text = "Unregister portable App";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 249);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "\"";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(170, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(289, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "Register a new portable app";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxPortablePath
            // 
            this.tbxPortablePath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPortablePath.Location = new System.Drawing.Point(175, 57);
            this.tbxPortablePath.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPortablePath.Name = "tbxPortablePath";
            this.tbxPortablePath.ReadOnly = true;
            this.tbxPortablePath.Size = new System.Drawing.Size(496, 25);
            this.tbxPortablePath.TabIndex = 3;
            this.tbxPortablePath.TextChanged += new System.EventHandler(this.tbxPortablePath_TextChanged);
            // 
            // cbProgramType
            // 
            this.cbProgramType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProgramType.FormattingEnabled = true;
            this.cbProgramType.Location = new System.Drawing.Point(175, 99);
            this.cbProgramType.Name = "cbProgramType";
            this.cbProgramType.Size = new System.Drawing.Size(202, 29);
            this.cbProgramType.TabIndex = 6;
            this.cbProgramType.SelectedIndexChanged += new System.EventHandler(this.cbProgramType_SelectedIndexChanged);
            // 
            // lblFileAssociations
            // 
            this.lblFileAssociations.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileAssociations.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFileAssociations.Location = new System.Drawing.Point(327, 137);
            this.lblFileAssociations.Name = "lblFileAssociations";
            this.lblFileAssociations.Size = new System.Drawing.Size(373, 17);
            this.lblFileAssociations.TabIndex = 23;
            this.lblFileAssociations.Text = "lblFileAssociations";
            this.lblFileAssociations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(187, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "FileAssociations:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(187, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "URLAssociations:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblURLAssociations
            // 
            this.lblURLAssociations.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURLAssociations.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblURLAssociations.Location = new System.Drawing.Point(327, 161);
            this.lblURLAssociations.Name = "lblURLAssociations";
            this.lblURLAssociations.Size = new System.Drawing.Size(373, 17);
            this.lblURLAssociations.TabIndex = 27;
            this.lblURLAssociations.Text = "lblURLAssociations";
            this.lblURLAssociations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "exe files (*.exe)|*.exe";
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(623, 13);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(79, 34);
            this.btnConfig.TabIndex = 28;
            this.btnConfig.Text = "CONFIG";
            this.toolTip1.SetToolTip(this.btnConfig, "Program Types setup");
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 34);
            this.button1.TabIndex = 29;
            this.button1.Text = "RESET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(187, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "OpenParameter:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(187, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "PropertiesParameter:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPropertiesParameter
            // 
            this.lblPropertiesParameter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropertiesParameter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPropertiesParameter.Location = new System.Drawing.Point(327, 209);
            this.lblPropertiesParameter.Name = "lblPropertiesParameter";
            this.lblPropertiesParameter.Size = new System.Drawing.Size(373, 17);
            this.lblPropertiesParameter.TabIndex = 32;
            this.lblPropertiesParameter.Text = "lblPropertiesParameter";
            this.lblPropertiesParameter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOpenParameters
            // 
            this.lblOpenParameters.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenParameters.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOpenParameters.Location = new System.Drawing.Point(327, 185);
            this.lblOpenParameters.Name = "lblOpenParameters";
            this.lblOpenParameters.Size = new System.Drawing.Size(373, 17);
            this.lblOpenParameters.TabIndex = 33;
            this.lblOpenParameters.Text = "lblOpenParameters";
            this.lblOpenParameters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblOpenParameters);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblPropertiesParameter);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnRegister);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnSelectExe);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblURLAssociations);
            this.panel2.Controls.Add(this.tbxPortablePath);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tbxProgramName);
            this.panel2.Controls.Add(this.lblFileAssociations);
            this.panel2.Controls.Add(this.cbProgramType);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 292);
            this.panel2.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.llGithub);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(0, 491);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(713, 45);
            this.panel3.TabIndex = 35;
            // 
            // llGithub
            // 
            this.llGithub.AutoSize = true;
            this.llGithub.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llGithub.Location = new System.Drawing.Point(543, 13);
            this.llGithub.Name = "llGithub";
            this.llGithub.Size = new System.Drawing.Size(74, 17);
            this.llGithub.TabIndex = 0;
            this.llGithub.TabStop = true;
            this.llGithub.Text = "Github.com";
            this.llGithub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llGithub_LinkClicked);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(97, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(452, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Made with 💙 for Portable Software - Source code and release available at \r\n";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(170, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(263, 30);
            this.label14.TabIndex = 34;
            this.label14.Text = "PORTABLE REGISTRATOR";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.btnConfig);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(0, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(713, 60);
            this.panel4.TabIndex = 36;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Location = new System.Drawing.Point(0, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(713, 14);
            this.panel5.TabIndex = 37;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Location = new System.Drawing.Point(0, -1);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10);
            this.panel6.Size = new System.Drawing.Size(160, 127);
            this.panel6.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PortableRegistrator.Properties.Resources.Wallpaperfx_3d_Bluefx_Desktop_Usb;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(140, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 537);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PORTABLE Registrator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnSelectExe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxProgramName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbRegisteredPortables;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxPortablePath;
        private System.Windows.Forms.ComboBox cbProgramType;
        private System.Windows.Forms.Label lblFileAssociations;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblURLAssociations;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPropertiesParameter;
        private System.Windows.Forms.Label lblOpenParameters;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel llGithub;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnUnregister;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

