
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
            SelectFileBTN = new System.Windows.Forms.Button();
            ProjectPath = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            WebConfigFoldsSelect = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            WebConfigSelect = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            strtBTN = new System.Windows.Forms.Button();
            clnBTN = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SelectFileBTN
            // 
            SelectFileBTN.Location = new System.Drawing.Point(577, 106);
            SelectFileBTN.Name = "SelectFileBTN";
            SelectFileBTN.Size = new System.Drawing.Size(94, 23);
            SelectFileBTN.TabIndex = 0;
            SelectFileBTN.Text = "Select File";
            SelectFileBTN.UseVisualStyleBackColor = true;
            SelectFileBTN.Click += SelectFileBTN_Click;
            // 
            // ProjectPath
            // 
            ProjectPath.BackColor = System.Drawing.Color.FromArgb(167, 169, 190);
            ProjectPath.Location = new System.Drawing.Point(80, 106);
            ProjectPath.Name = "ProjectPath";
            ProjectPath.Size = new System.Drawing.Size(491, 23);
            ProjectPath.TabIndex = 1;
            ProjectPath.TextChanged += SelectFilePathtxt_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.FromArgb(167, 169, 190);
            label3.Location = new System.Drawing.Point(80, 66);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(186, 32);
            label3.TabIndex = 10;
            label3.Text = "Pasta do Projeto";
            // 
            // WebConfigFoldsSelect
            // 
            WebConfigFoldsSelect.BackColor = System.Drawing.Color.FromArgb(167, 169, 190);
            WebConfigFoldsSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            WebConfigFoldsSelect.FormattingEnabled = true;
            WebConfigFoldsSelect.Location = new System.Drawing.Point(322, 174);
            WebConfigFoldsSelect.MaxDropDownItems = 15;
            WebConfigFoldsSelect.Name = "WebConfigFoldsSelect";
            WebConfigFoldsSelect.Size = new System.Drawing.Size(349, 23);
            WebConfigFoldsSelect.TabIndex = 14;
            WebConfigFoldsSelect.SelectedIndexChanged += WebConfigFoldsSelect_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(167, 169, 190);
            label1.Location = new System.Drawing.Point(80, 163);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(234, 32);
            label1.TabIndex = 15;
            label1.Text = "Pasta do WebConfig:\r\n";
            // 
            // WebConfigSelect
            // 
            WebConfigSelect.BackColor = System.Drawing.Color.FromArgb(167, 169, 190);
            WebConfigSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            WebConfigSelect.FormattingEnabled = true;
            WebConfigSelect.Location = new System.Drawing.Point(363, 240);
            WebConfigSelect.Name = "WebConfigSelect";
            WebConfigSelect.Size = new System.Drawing.Size(308, 23);
            WebConfigSelect.TabIndex = 16;
            WebConfigSelect.SelectedIndexChanged += WebConfigSelect_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(167, 169, 190);
            label2.Location = new System.Drawing.Point(80, 235);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(276, 32);
            label2.TabIndex = 17;
            label2.Text = "Selecione o  WebConfig:";
            // 
            // strtBTN
            // 
            strtBTN.BackColor = System.Drawing.Color.FromArgb(242, 95, 76);
            strtBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            strtBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(229, 49, 112);
            strtBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 192, 128);
            strtBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            strtBTN.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            strtBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            strtBTN.Location = new System.Drawing.Point(520, 330);
            strtBTN.Name = "strtBTN";
            strtBTN.Size = new System.Drawing.Size(151, 50);
            strtBTN.TabIndex = 18;
            strtBTN.Text = "INICIAR";
            strtBTN.UseVisualStyleBackColor = false;
            strtBTN.Click += strtBTN_Click;
            // 
            // clnBTN
            // 
            clnBTN.BackColor = System.Drawing.Color.FromArgb(167, 169, 190);
            clnBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            clnBTN.FlatAppearance.BorderSize = 0;
            clnBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            clnBTN.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            clnBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            clnBTN.Location = new System.Drawing.Point(80, 330);
            clnBTN.Name = "clnBTN";
            clnBTN.Size = new System.Drawing.Size(151, 50);
            clnBTN.TabIndex = 19;
            clnBTN.Text = "Limpar";
            clnBTN.UseVisualStyleBackColor = false;
            clnBTN.Click += clnBTN_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(626, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(126, 72);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(15, 14, 23);
            ClientSize = new System.Drawing.Size(730, 405);
            Controls.Add(pictureBox1);
            Controls.Add(clnBTN);
            Controls.Add(strtBTN);
            Controls.Add(label2);
            Controls.Add(WebConfigSelect);
            Controls.Add(label1);
            Controls.Add(WebConfigFoldsSelect);
            Controls.Add(label3);
            Controls.Add(ProjectPath);
            Controls.Add(SelectFileBTN);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(746, 444);
            MinimumSize = new System.Drawing.Size(746, 444);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "WEB Config";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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

