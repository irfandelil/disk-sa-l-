using System;
using System.Windows.Forms;

namespace disk_sağlığı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckDiskHealth();
        }

        private void CheckDiskHealth()
        {
            // Ana sürücüyü (C:\) kontrol etmek için
            string driveName = "C:\\";

            try
            {
                // Disk bilgilerini al
                DriveInfo driveInfo = new DriveInfo(driveName);

                // Disk sağlığını kontrol et
                if (driveInfo.IsReady)
                {
                    double freeSpacePercentage = ((double)driveInfo.AvailableFreeSpace / driveInfo.TotalSize) * 100;

                    // Disk sağlığı durumunu belirle
                    if (freeSpacePercentage > 20) // Örnek bir eşik değeri
                    {
                        lblDiskHealth.Text = "Disk sağlığı: İyi";
                        lblDiskHealth.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblDiskHealth.Text = "Disk sağlığı: Kötü";
                        lblDiskHealth.ForeColor = System.Drawing.Color.Red;
                    }

                    lblDiskSpace.Text = string.Format("Boş alan: {0:0.00} GB / {1:0.00} GB", driveInfo.AvailableFreeSpace / (1024.0 * 1024.0 * 1024.0), driveInfo.TotalSize / (1024.0 * 1024.0 * 1024.0));

                    // Progress bar'ın değerini ayarla
                    progressBarDiskHealth.Value = (int)freeSpacePercentage;

                    // Kullanılan disk boyutunu gösteren progress bar'ı güncelle
                    progressBarDiskSpace.Value = 100 - (int)freeSpacePercentage;
                }
                else
                {
                    lblDiskHealth.Text = "Disk durumu: Ulaşılamaz";
                    lblDiskHealth.ForeColor = System.Drawing.Color.Gray;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CheckDiskHealth();
            MessageBox.Show("Disk Yenilendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnShowProperties_Click(object sender, EventArgs e)
        {
            // Yeni bir form aç ve bilgisayar özelliklerini göster
            FormComputerProperties computerPropertiesForm = new FormComputerProperties();
            computerPropertiesForm.Show();
        }
    }
}