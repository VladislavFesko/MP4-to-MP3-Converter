using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP4_to_MP3_Converter
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        string videoPath, videoName, musicPath, musicName;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = false, Filter = "Video file|*.mp4" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoPath = openFileDialog.FileName;
                videoName = openFileDialog.SafeFileName;
            }
            videoPathBox.Text = videoPath;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                musicPath = folderBrowserDialog.SelectedPath;
                musicName = videoName.Substring(0, videoName.Length - 4);
                musicPath += ("\\" + musicName + ".mp3");
            }
            savePathBox.Text = musicPath;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            var convert = new NReco.VideoConverter.FFMpegConverter();
            convert.ConvertMedia(videoPathBox.Text.Trim(), savePathBox.Text.Trim(), "mp3");
        }
    }
}
