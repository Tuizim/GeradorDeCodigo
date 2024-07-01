
namespace InterfaceWebConfig
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SelectFileBTN = new System.Windows.Forms.Button();
            this.ProjectPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WebConfigFoldsSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WebConfigSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.strtBTN = new System.Windows.Forms.Button();
            this.clnBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectFileBTN
            // 
            this.SelectFileBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(190)))));
            this.SelectFileBTN.FlatAppearance.BorderSize = 2;
            this.SelectFileBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SelectFileBTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SelectFileBTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectFileBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.SelectFileBTN.Location = new System.Drawing.Point(577, 104);
            this.SelectFileBTN.Name = "SelectFileBTN";
            this.SelectFileBTN.Size = new System.Drawing.Size(94, 26);
            this.SelectFileBTN.TabIndex = 0;
            this.SelectFileBTN.Text = "Select File";
            this.SelectFileBTN.UseVisualStyleBackColor = true;
            this.SelectFileBTN.Click += new System.EventHandler(this.SelectFileBTN_Click);
            // 
            // ProjectPath
            // 
            this.ProjectPath.BackColor = System.Drawing.Color.White;
            this.ProjectPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProjectPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProjectPath.Location = new System.Drawing.Point(80, 106);
            this.ProjectPath.Name = "ProjectPath";
            this.ProjectPath.Size = new System.Drawing.Size(491, 22);
            this.ProjectPath.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(190)))));
            this.label3.Location = new System.Drawing.Point(76, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pasta do Projeto";
            // 
            // WebConfigFoldsSelect
            // 
            this.WebConfigFoldsSelect.BackColor = System.Drawing.Color.White;
            this.WebConfigFoldsSelect.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.WebConfigFoldsSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WebConfigFoldsSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WebConfigFoldsSelect.FormattingEnabled = true;
            this.WebConfigFoldsSelect.Location = new System.Drawing.Point(322, 178);
            this.WebConfigFoldsSelect.MaxDropDownItems = 15;
            this.WebConfigFoldsSelect.Name = "WebConfigFoldsSelect";
            this.WebConfigFoldsSelect.Size = new System.Drawing.Size(349, 23);
            this.WebConfigFoldsSelect.TabIndex = 14;
            this.WebConfigFoldsSelect.SelectedIndexChanged += new System.EventHandler(this.WebConfigFoldsSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(76, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pasta do WebConfig:\r\n";
            // 
            // WebConfigSelect
            // 
            this.WebConfigSelect.BackColor = System.Drawing.Color.White;
            this.WebConfigSelect.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.WebConfigSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WebConfigSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WebConfigSelect.FormattingEnabled = true;
            this.WebConfigSelect.Location = new System.Drawing.Point(363, 244);
            this.WebConfigSelect.Name = "WebConfigSelect";
            this.WebConfigSelect.Size = new System.Drawing.Size(308, 23);
            this.WebConfigSelect.TabIndex = 16;
            this.WebConfigSelect.SelectedIndexChanged += new System.EventHandler(this.WebConfigSelect_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(190)))));
            this.label2.Location = new System.Drawing.Point(76, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Selecione o  WebConfig:";
            // 
            // strtBTN
            // 
            this.strtBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(95)))), ((int)(((byte)(76)))));
            this.strtBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.strtBTN.Enabled = false;
            this.strtBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.strtBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.strtBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strtBTN.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.strtBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.strtBTN.Location = new System.Drawing.Point(520, 330);
            this.strtBTN.Name = "strtBTN";
            this.strtBTN.Size = new System.Drawing.Size(151, 50);
            this.strtBTN.TabIndex = 18;
            this.strtBTN.Text = "INICIAR";
            this.strtBTN.UseVisualStyleBackColor = false;
            this.strtBTN.Click += new System.EventHandler(this.strtBTN_Click);
            // 
            // clnBTN
            // 
            this.clnBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(190)))));
            this.clnBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clnBTN.FlatAppearance.BorderSize = 0;
            this.clnBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clnBTN.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clnBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clnBTN.Location = new System.Drawing.Point(76, 330);
            this.clnBTN.Name = "clnBTN";
            this.clnBTN.Size = new System.Drawing.Size(151, 50);
            this.clnBTN.TabIndex = 19;
            this.clnBTN.Text = "Limpar";
            this.clnBTN.UseVisualStyleBackColor = false;
            this.clnBTN.Click += new System.EventHandler(this.clnBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(602, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(730, 405);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clnBTN);
            this.Controls.Add(this.strtBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WebConfigSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WebConfigFoldsSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProjectPath);
            this.Controls.Add(this.SelectFileBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(746, 444);
            this.MinimumSize = new System.Drawing.Size(746, 444);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WEB Config";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SelectFileBTN;
        private System.Windows.Forms.TextBox ProjectPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox WebConfigFoldsSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox WebConfigSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button strtBTN;
        private System.Windows.Forms.Button clnBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

