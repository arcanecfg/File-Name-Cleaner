namespace File_Name_Cleaner
{
    partial class frmFileNameCleaner
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnFetch = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.Panel1.Controls.Add(this.lstFiles);
            this.Panel1.Controls.Add(this.txtFilter);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 54);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(509, 280);
            this.Panel1.TabIndex = 8;
            // 
            // lstFiles
            // 
            this.lstFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.lstFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFiles.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstFiles.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 20;
            this.lstFiles.Location = new System.Drawing.Point(0, 0);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(509, 253);
            this.lstFiles.TabIndex = 7;
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtFilter.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFilter.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtFilter.Location = new System.Drawing.Point(0, 253);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(509, 27);
            this.txtFilter.TabIndex = 6;
            this.txtFilter.Text = "separate;words;to;be;removed;with;semicolons";
            this.txtFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRename
            // 
            this.btnRename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnRename.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRename.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnRename.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRename.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRename.Location = new System.Drawing.Point(0, 334);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(509, 27);
            this.btnRename.TabIndex = 7;
            this.btnRename.Text = "R E N A M E";
            this.btnRename.UseVisualStyleBackColor = false;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnFetch
            // 
            this.btnFetch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnFetch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFetch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnFetch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.btnFetch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFetch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFetch.Location = new System.Drawing.Point(0, 27);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(509, 27);
            this.btnFetch.TabIndex = 6;
            this.btnFetch.Text = "F E T C H";
            this.btnFetch.UseVisualStyleBackColor = false;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPath.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtPath.Location = new System.Drawing.Point(0, 0);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(509, 27);
            this.txtPath.TabIndex = 5;
            // 
            // frmFileNameCleaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 361);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.txtPath);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmFileNameCleaner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Name Cleaner - www.WastedWolf.com";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnRename;
        internal System.Windows.Forms.Button btnFetch;
        internal System.Windows.Forms.TextBox txtPath;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.ListBox lstFiles;
        internal System.Windows.Forms.TextBox txtFilter;
    }
}

