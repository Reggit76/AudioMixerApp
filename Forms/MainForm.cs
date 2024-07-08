using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AudioMixer;
using NAudio.Wave;

namespace AudioMixerApp
{
    public partial class MainForm : Form
    {
        private AudioPlayer audioPlayer;
        private Equalizer equalizer;

        public MainForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
            audioPlayer = new AudioPlayer();
            equalizer = new Equalizer();
        }

        private void InitializeCustomComponents()
        {
            // Ползунки эквалайзера
            for (int i = 1; i <= 10; i++)
            {
                TrackBar trkFreq = this.Controls.Find("trkFreq" + i, true).FirstOrDefault() as TrackBar;
                if (trkFreq != null)
                {
                    trkFreq.Minimum = -12;
                    trkFreq.Maximum = 12;
                    trkFreq.Value = 0;
                    trkFreq.Scroll += trkFreq_Scroll;
                }
            }

            // Ползунок громкости
            TrackBar trkVolume = this.Controls.Find("trkVolume", true).FirstOrDefault() as TrackBar;
            if (trkVolume != null)
            {
                trkVolume.Scroll += trkVolume_Scroll;
            }

            // Ползунок объёмности звука
            TrackBar trkSpatial = this.Controls.Find("trkSpatial", true).FirstOrDefault() as TrackBar;
            if (trkSpatial != null)
            {
                trkSpatial.Scroll += trkSpatial_Scroll;
            }

            // Кнопка выбора файла
            Button btnSelectFile = this.Controls.Find("btnSelectFile", true).FirstOrDefault() as Button;
            if (btnSelectFile != null)
            {
                btnSelectFile.Click += BtnSelectFile_Click;
            }

            // Кнопка сохранения изменений
            Button btnSave = this.Controls.Find("btnSave", true).FirstOrDefault() as Button;
            if (btnSave != null)
            {
                btnSave.Click += BtnSave_Click;
            }
        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                audioPlayer.Load(openFileDialog.FileName);
                var audioFile = audioPlayer.AudioFile;
                // Обновление информации о файле в интерфейсе
                Label lblFileName = this.Controls.Find("lblFileName", true).FirstOrDefault() as Label;
                if (lblFileName != null)
                {
                    lblFileName.Text = "Name: \n" + Path.GetFileName(openFileDialog.FileName);
                }

                Label lblDuration = this.Controls.Find("lblDuration", true).FirstOrDefault() as Label;
                if (lblDuration != null)
                {
                    lblDuration.Text = "Duration: \n" + audioFile.TotalTime.ToString();
                }

                Label lblFileType = this.Controls.Find("lblFileType", true).FirstOrDefault() as Label;
                if (lblFileType != null)
                {
                    lblFileType.Text = "File type: \n" + Path.GetExtension(openFileDialog.FileName).ToUpper();
                }

                Label lblFileSize = this.Controls.Find("lblFileSize", true).FirstOrDefault() as Label;
                if (lblFileSize != null)
                {
                    lblFileSize.Text = "File size: \n" + new FileInfo(openFileDialog.FileName).Length.ToString() + " bytes";
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                audioPlayer.Save(saveFileDialog.FileName);
            }
        }

        private void trkFreq_Scroll(object sender, EventArgs e)
        {
            float[] gains = new float[10];
            for (int i = 1; i <= 10; i++)
            {
                TrackBar trkFreq = this.Controls.Find("trkFreq" + i, true).FirstOrDefault() as TrackBar;
                if (trkFreq != null)
                {
                    gains[i - 1] = trkFreq.Value;
                }
            }
            equalizer.ApplyEqualizer(audioPlayer.AudioFile, gains);
        }

        private void trkVolume_Scroll(object sender, EventArgs e)
        {
            TrackBar trkVolume = sender as TrackBar;
            if (trkVolume != null)
            {
                audioPlayer.SetVolume(trkVolume.Value);
            }
        }

        private void trkSpatial_Scroll(object sender, EventArgs e)
        {
            TrackBar trkSpatial = sender as TrackBar;
            if (trkSpatial != null)
            {
                audioPlayer.SetSpatial(trkSpatial.Value);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Логика инициализации при загрузке формы, если необходимо
        }
    }
}
