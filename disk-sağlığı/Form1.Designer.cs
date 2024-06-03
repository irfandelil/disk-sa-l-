namespace disk_sağlığı
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
            lblDiskHealth = new Label();
            lblDiskSpace = new Label();
            btnRefresh = new Button();
            progressBarDiskHealth = new ProgressBar();
            progressBarDiskSpace = new ProgressBar();
            SuspendLayout();
            // 
            // lblDiskHealth
            // 
            lblDiskHealth.AutoSize = true;
            lblDiskHealth.Location = new Point(218, 82);
            lblDiskHealth.Name = "lblDiskHealth";
            lblDiskHealth.Size = new Size(0, 20);
            lblDiskHealth.TabIndex = 0;
            // 
            // lblDiskSpace
            // 
            lblDiskSpace.AutoSize = true;
            lblDiskSpace.Location = new Point(218, 158);
            lblDiskSpace.Name = "lblDiskSpace";
            lblDiskSpace.Size = new Size(0, 20);
            lblDiskSpace.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(183, 226);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Yenile";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // progressBarDiskHealth
            // 
            progressBarDiskHealth.Location = new Point(47, 82);
            progressBarDiskHealth.Name = "progressBarDiskHealth";
            progressBarDiskHealth.Size = new Size(125, 20);
            progressBarDiskHealth.TabIndex = 3;
            // 
            // progressBarDiskSpace
            // 
            progressBarDiskSpace.Location = new Point(47, 158);
            progressBarDiskSpace.Name = "progressBarDiskSpace";
            progressBarDiskSpace.Size = new Size(125, 20);
            progressBarDiskSpace.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 316);
            Controls.Add(progressBarDiskSpace);
            Controls.Add(progressBarDiskHealth);
            Controls.Add(btnRefresh);
            Controls.Add(lblDiskSpace);
            Controls.Add(lblDiskHealth);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Disk Healther";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDiskHealth;
        private Label lblDiskSpace;
        private Button btnRefresh;
        private ProgressBar progressBarDiskHealth;
        private ProgressBar progressBarDiskSpace;
    }
}
