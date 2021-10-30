using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        String[] paths, files;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                for(int i = 0; i < files.Length; i++)
                {
                    PlaylistSongs.Items.Add(files[i]);
                }
            }
        }

        private void PlaylistSongs_SelectedIndexChanged(object sender, EventArgs e)
        { 
            axWindowsMediaPlayer1.URL = paths[PlaylistSongs.SelectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(axWindowsMediaPlayer1.URL.Length > 0)
            {
                axWindowsMediaPlayer1.fullScreen = true;
            }
        }

        private void MusicPlayerApp_Load(object sender, EventArgs e)
        {

        }
    }
}
