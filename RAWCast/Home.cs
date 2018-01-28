using ImageMagick;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAWCast
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        String currentDirectory = "";
       

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void SelectFolderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var fb = new FolderBrowserDialog();
                if (fb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ImageListBox.Items.Clear();
                    currentDirectory = fb.SelectedPath;
                    FolderLocation.Text = currentDirectory;
                    var dirInfo = new DirectoryInfo(currentDirectory);
                    var files = dirInfo.GetFiles().Where(c => (c.Extension.ToLower().Equals(".jpg") || c.Extension.ToLower().Equals(".jpeg") || c.Extension.ToLower().Equals(".cr2") || c.Extension.ToLower().Equals(".png")));
                    foreach (var img in files)
                    {
                        ImageListBox.Items.Add(img.Name);

                    }
                    if (ImageListBox.Items.Count >= 1){
                        String firstImage = (String) ImageListBox.Items[0];
                        if (LoadImage(firstImage))
                        {
                            ImageListBox.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There eas an error at: " + ex.Message + " " + ex.Source);
            }

        }

        private void ShowDevicesBtn_Click(object sender, EventArgs e)
        {

        }

        private void SendLinkBtn_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }



        private void CastBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(System.Reflection.Assembly.GetExecutingAssembly().CodeBase.ToString());

        }
        private Boolean LoadImage(String Filename)
        {
            if (!string.IsNullOrEmpty(Filename) && (!string.IsNullOrEmpty(currentDirectory)))
            {
                String extension = Filename.Substring(Filename.LastIndexOf('.') + 1);
                if(extension.ToLower() != "cr2")
                {
                    String imagePath = Path.Combine(currentDirectory, Filename);
                    ImagePreviewBox.Image.Dispose();
                    MemoryStream ms = new MemoryStream(File.ReadAllBytes(imagePath));
                    ImagePreviewBox.Image = Image.FromStream(ms);
                    return true;
                }
                else
                {
                    String imagePath = Path.Combine(currentDirectory, Filename);
                    ImagePreviewBox.Image.Dispose();
                    MemoryStream converted_img = Converter.ConvertImage(imagePath);
                    ImagePreviewBox.Image = Image.FromStream(converted_img);
                    return true;
                }
            }
            return false;

        }
        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (ImageListBox.Items.Count > 1)
            {

                if (ImageListBox.SelectedIndex < ImageListBox.Items.Count-1)
                {
                    int nextFileIndex = ImageListBox.SelectedIndex + 1;
                    String previousFileName = (String)ImageListBox.Items[nextFileIndex];
                    if (LoadImage(previousFileName))
                    {
                        ImageListBox.SelectedIndex = nextFileIndex;
                    }
                }
            }

        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            if (ImageListBox.Items.Count > 1)
            {

                if (ImageListBox.SelectedIndex>0) {
                    int previousFileIndex = ImageListBox.SelectedIndex - 1;
                    String previousFileName = (String) ImageListBox.Items[previousFileIndex];
                    if (LoadImage(previousFileName))
                    {
                        ImageListBox.SelectedIndex = previousFileIndex;
                    }
                }

            }


        }

        private void ImageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            String selectedFileName = ImageListBox.SelectedItems[0].ToString();
            LoadImage(selectedFileName);
            
        }

        private void FolderLocation_Click(object sender, EventArgs e)
        {

        }

        private void ImagePreviewBox_Click(object sender, EventArgs e)
        {

        }
    }
}
