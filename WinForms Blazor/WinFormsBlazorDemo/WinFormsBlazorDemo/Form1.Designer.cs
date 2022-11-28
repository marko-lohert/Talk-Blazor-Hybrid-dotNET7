namespace WinFormsBlazorDemo
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
            this.blazorWebViewDeleteAllFiles = new Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView();
            this.lblReportsManagement = new System.Windows.Forms.Label();
            this.lblBackup = new System.Windows.Forms.Label();
            this.lblRestore = new System.Windows.Forms.Label();
            this.lblBackupLocation = new System.Windows.Forms.Label();
            this.lblBackupFolder = new System.Windows.Forms.Label();
            this.lblRestoreLocation = new System.Windows.Forms.Label();
            this.lblRestoreFolder = new System.Windows.Forms.Label();
            this.btnBackupOptions = new System.Windows.Forms.Button();
            this.btnBackupStart = new System.Windows.Forms.Button();
            this.btnRestoreOptions = new System.Windows.Forms.Button();
            this.btnRestoreStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // blazorWebViewDeleteAllFiles
            // 
            this.blazorWebViewDeleteAllFiles.Location = new System.Drawing.Point(534, 52);
            this.blazorWebViewDeleteAllFiles.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.blazorWebViewDeleteAllFiles.Name = "blazorWebViewDeleteAllFiles";
            this.blazorWebViewDeleteAllFiles.Size = new System.Drawing.Size(266, 289);
            this.blazorWebViewDeleteAllFiles.TabIndex = 0;
            this.blazorWebViewDeleteAllFiles.Text = "blazorWebView1";
            // 
            // lblReportsManagement
            // 
            this.lblReportsManagement.AutoSize = true;
            this.lblReportsManagement.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReportsManagement.Location = new System.Drawing.Point(3, 6);
            this.lblReportsManagement.Name = "lblReportsManagement";
            this.lblReportsManagement.Size = new System.Drawing.Size(244, 32);
            this.lblReportsManagement.TabIndex = 1;
            this.lblReportsManagement.Text = "Reports Management";
            // 
            // lblBackup
            // 
            this.lblBackup.AutoSize = true;
            this.lblBackup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBackup.Location = new System.Drawing.Point(2, 52);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(75, 28);
            this.lblBackup.TabIndex = 2;
            this.lblBackup.Text = "Backup";
            // 
            // lblRestore
            // 
            this.lblRestore.AutoSize = true;
            this.lblRestore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRestore.Location = new System.Drawing.Point(225, 52);
            this.lblRestore.Name = "lblRestore";
            this.lblRestore.Size = new System.Drawing.Size(77, 28);
            this.lblRestore.TabIndex = 3;
            this.lblRestore.Text = "Restore";
            // 
            // lblBackupLocation
            // 
            this.lblBackupLocation.AutoSize = true;
            this.lblBackupLocation.Location = new System.Drawing.Point(10, 89);
            this.lblBackupLocation.Name = "lblBackupLocation";
            this.lblBackupLocation.Size = new System.Drawing.Size(62, 20);
            this.lblBackupLocation.TabIndex = 4;
            this.lblBackupLocation.Text = "Locaton";
            // 
            // lblBackupFolder
            // 
            this.lblBackupFolder.AutoSize = true;
            this.lblBackupFolder.Location = new System.Drawing.Point(78, 89);
            this.lblBackupFolder.Name = "lblBackupFolder";
            this.lblBackupFolder.Size = new System.Drawing.Size(73, 20);
            this.lblBackupFolder.TabIndex = 5;
            this.lblBackupFolder.Text = "c:\\backup";
            // 
            // lblRestoreLocation
            // 
            this.lblRestoreLocation.AutoSize = true;
            this.lblRestoreLocation.Location = new System.Drawing.Point(225, 89);
            this.lblRestoreLocation.Name = "lblRestoreLocation";
            this.lblRestoreLocation.Size = new System.Drawing.Size(62, 20);
            this.lblRestoreLocation.TabIndex = 6;
            this.lblRestoreLocation.Text = "Locaton";
            // 
            // lblRestoreFolder
            // 
            this.lblRestoreFolder.AutoSize = true;
            this.lblRestoreFolder.Location = new System.Drawing.Point(281, 89);
            this.lblRestoreFolder.Name = "lblRestoreFolder";
            this.lblRestoreFolder.Size = new System.Drawing.Size(73, 20);
            this.lblRestoreFolder.TabIndex = 7;
            this.lblRestoreFolder.Text = "c:\\backup";
            // 
            // btnBackupOptions
            // 
            this.btnBackupOptions.Location = new System.Drawing.Point(10, 122);
            this.btnBackupOptions.Name = "btnBackupOptions";
            this.btnBackupOptions.Size = new System.Drawing.Size(94, 29);
            this.btnBackupOptions.TabIndex = 8;
            this.btnBackupOptions.Text = "Options...";
            this.btnBackupOptions.UseVisualStyleBackColor = true;
            // 
            // btnBackupStart
            // 
            this.btnBackupStart.Location = new System.Drawing.Point(10, 166);
            this.btnBackupStart.Name = "btnBackupStart";
            this.btnBackupStart.Size = new System.Drawing.Size(94, 29);
            this.btnBackupStart.TabIndex = 9;
            this.btnBackupStart.Text = "Backup";
            this.btnBackupStart.UseVisualStyleBackColor = true;
            // 
            // btnRestoreOptions
            // 
            this.btnRestoreOptions.Location = new System.Drawing.Point(225, 122);
            this.btnRestoreOptions.Name = "btnRestoreOptions";
            this.btnRestoreOptions.Size = new System.Drawing.Size(94, 29);
            this.btnRestoreOptions.TabIndex = 10;
            this.btnRestoreOptions.Text = "Options...";
            this.btnRestoreOptions.UseVisualStyleBackColor = true;
            // 
            // btnRestoreStart
            // 
            this.btnRestoreStart.Location = new System.Drawing.Point(225, 166);
            this.btnRestoreStart.Name = "btnRestoreStart";
            this.btnRestoreStart.Size = new System.Drawing.Size(94, 29);
            this.btnRestoreStart.TabIndex = 11;
            this.btnRestoreStart.Text = "Backup";
            this.btnRestoreStart.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(694, 409);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRestoreStart);
            this.Controls.Add(this.btnRestoreOptions);
            this.Controls.Add(this.btnBackupStart);
            this.Controls.Add(this.btnBackupOptions);
            this.Controls.Add(this.lblRestoreFolder);
            this.Controls.Add(this.lblRestoreLocation);
            this.Controls.Add(this.lblBackupFolder);
            this.Controls.Add(this.lblBackupLocation);
            this.Controls.Add(this.lblRestore);
            this.Controls.Add(this.lblBackup);
            this.Controls.Add(this.lblReportsManagement);
            this.Controls.Add(this.blazorWebViewDeleteAllFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView blazorWebViewDeleteAllFiles;
        private Label lblReportsManagement;
        private Label lblBackup;
        private Label lblRestore;
        private Label lblBackupLocation;
        private Label lblBackupFolder;
        private Label lblRestoreLocation;
        private Label lblRestoreFolder;
        private Button btnBackupOptions;
        private Button btnBackupStart;
        private Button btnRestoreOptions;
        private Button btnRestoreStart;
        private Button btnExit;
    }
}