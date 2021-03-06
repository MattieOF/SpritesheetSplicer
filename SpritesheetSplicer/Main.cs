﻿using System;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using WK.Libraries.BetterFolderBrowserNS;
using System.Drawing.Imaging;
using System.ComponentModel;

namespace SpritesheetSplicer
{
    public struct Vector2
    {
        public int x, y;

        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public partial class Main : Form
    {
        private Image spritesheet;
        private bool loadedSpritesheet = false;
        private ImageFormat format;
        private string formatExtension;

        public Main()
        {
            InitializeComponent();
            spriteFormatBox.SelectedIndex = 0;
        }

        private void browseOutputFolderButton_Click(object sender, EventArgs e)
        {
            BetterFolderBrowser folderBrowser = new BetterFolderBrowser();
            folderBrowser.Title = "Find Output Folder";
            folderBrowser.Multiselect = false;
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                outputFolderField.Text = folderBrowser.SelectedFolder;
            }
        }

        private void loadSpritesheetButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog spritesheetFileDialog = new OpenFileDialog();
            spritesheetFileDialog.Title = "Browse for spritesheet";
            spritesheetFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.tiff";
            spritesheetFileDialog.RestoreDirectory = true;

            if (spritesheetFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Open spritesheet
                try
                {
                    spritesheet = Image.FromFile(spritesheetFileDialog.FileName);
                    spritesheetImage.Image = spritesheet;
                    statusBarLabel.Text = "Loaded image: " + spritesheetFileDialog.FileName;
                    loadedSpritesheet = true;
                } catch (Exception ex)
                {
                    statusBarLabel.Text = "Failed to load spritesheet. " + ex.Message;
                }
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            spritesheet?.Dispose();
        }

        private void SetProgress(int current, int max, string label)
        {
            statusProgressBar.Maximum = max;
            statusProgressBar.Value = current;
            statusBarLabel.Text = label;
        }

        private void sliceButton_Click(object sender, EventArgs e)
        {
            GetFormat();
            if (!slicingBackgroundWorker.IsBusy) slicingBackgroundWorker.RunWorkerAsync();
        }

        private void GetFormat()
        {
            switch(spriteFormatBox.SelectedIndex)
            {
                case 0:
                    format = ImageFormat.Png;
                    formatExtension = ".png";
                    break;
                case 1:
                    format = ImageFormat.Jpeg;
                    formatExtension = ".jpeg";
                    break;
                case 2:
                    format = ImageFormat.Bmp;
                    formatExtension = ".bmp";
                    break;
                case 3:
                    format = ImageFormat.Tiff;
                    formatExtension = ".tiff";
                    break;
                case 4:
                    format = ImageFormat.Icon;
                    formatExtension = ".ico";
                    break;
                default:
                    format = ImageFormat.Png;
                    formatExtension = ".png";
                    break;
            }
        }

        private void slicingBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Also, have a dropdown so we can select the format for the individual sprites to be saved as
            // Thanks to u/infamous_ruslan for a tip to use Bitmap.Clone, making the code much MUCH cleaner

            BackgroundWorker worker = sender as BackgroundWorker;

            // Check spritesheet has been loaded
            if (!loadedSpritesheet)
            {
                MessageBox.Show("A spritesheet has not yet been loaded.", "Error splicing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check path is filled in
            // TODO check path is valid?
            if (string.IsNullOrWhiteSpace(outputFolderField.Text))
            {
                MessageBox.Show("Output directory is empty", "Error splicing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }

            // Create vectors from user inputs
            Vector2 cellSize = new Vector2((int)spriteSizeX.Value, (int)spriteSizeY.Value);
            Vector2 seperatorSize = new Vector2((int)marginSizeX.Value, (int)marginSizeY.Value);

            // Check cell size is valid
            if (cellSize.x == 0 || cellSize.y == 0)
            {
                MessageBox.Show("Cell size is 0", "Error splicing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }

            // Check width and height match expected values for values entered
            bool widthMatches = (cellCountX.Value * cellSize.x) + ((cellCountX.Value - 1) * seperatorSize.x)
                + (marginLeftCheckbox.Checked ? seperatorSize.x : 0) + (marginRightCheckbox.Checked ? seperatorSize.x : 0) == spritesheet.Width;

            if (!widthMatches)
            {
                MessageBox.Show("Width (" + spritesheet.Width + ") doesn't match expected width", "Error splicing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }

            bool heightMatches = (cellCountY.Value * cellSize.y) + ((cellCountY.Value - 1) * seperatorSize.y)
                + (marginTopCheckbox.Checked ? seperatorSize.y : 0) + (marginBottomCheckbox.Checked ? seperatorSize.y : 0) == spritesheet.Height;

            if (!heightMatches)
            {
                MessageBox.Show("Height (" + spritesheet.Height + ") doesn't match expected height", "Error splicing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }

            Bitmap bitmap = new Bitmap(spritesheet);
            List<Bitmap> splicedSprites = new List<Bitmap>();

            int totalSprites = (int)(cellCountX.Value * cellCountY.Value);

            int xPos = 0, yPos = 0, spriteIterator = 0;
            for (int i = 0; i < cellCountY.Value; i++)
            {
                xPos = 0;
                for (int j = 0; j < cellCountX.Value; j++)
                {
                    if (worker.CancellationPending) e.Cancel = true;

                    float progress = (float)(spriteIterator + 1) / (float)(totalSprites);
                    progress *= 100;
                    worker.ReportProgress((int)progress);
                    Bitmap sprite;

                    // Get current xPos and yPos
                    xPos = cellSize.x * j;
                    xPos = xPos + (seperatorSize.x * j);
                    if (marginLeftCheckbox.Checked) xPos += seperatorSize.x;

                    yPos = cellSize.y * i;
                    yPos = yPos + (seperatorSize.y * i);
                    if (marginTopCheckbox.Checked) yPos += seperatorSize.y;

                    // Calculate rectangle bounds
                    Rectangle spriteBounds = new Rectangle(xPos, yPos, cellSize.x, cellSize.y);

                    // Clone sprite from spritesheet
                    sprite = bitmap.Clone(spriteBounds, bitmap.PixelFormat);

                    spriteIterator++;
                    splicedSprites.Add(sprite);
                }
            }

            // Save bitmaps
            int saveIterator = 0;
            foreach (Bitmap bm in splicedSprites)
            {
                try
                {
                    if (worker.CancellationPending) e.Cancel = true;
                    bm.Save(outputFolderField.Text + "//Sprite_" + saveIterator.ToString() + formatExtension, format);
                    float progress = (float)(saveIterator + 1) / (float)(totalSprites);
                    progress *= 100;
                    worker.ReportProgress((int)progress);
                    saveIterator++;
                }
                catch (Exception ex)
                {
                    if (ex.Message == "A generic error occurred in GDI+.")
                    {
                        MessageBox.Show("A \"generic error\" occured in GDI+. This often means your antivirus is blocking the apps ability to " +
                            "save files where you have asked for them to be saved, so try temporarily disabling your antivirus.", "Error splicing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("An error occured while saving your sprites. Press OK to see the exception. " +
                            "Create an issue on the GitHub page, if you want.", "Error splicing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error splicing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void slicingBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            statusProgressBar.Visible = true;
            int totalSprites = (int)(cellCountX.Value * cellCountY.Value);
            float normalCount = (float)(e.ProgressPercentage) / 100f;
            normalCount *= (float)totalSprites;
            SetProgress(e.ProgressPercentage, 100, "Sprite " + ((int)normalCount).ToString() + "/" + totalSprites.ToString());
        }

        private void slicingBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            statusProgressBar.Visible = false;
            if (e.Cancelled)
            {
                statusBarLabel.Text = "Cancelled slicing.";
            } else
            {
                int totalSprites = (int)(cellCountX.Value * cellCountY.Value);
                statusBarLabel.Text = "Completed slicing. Total: " + totalSprites.ToString() + " sprites.";
            }
        }
    }
}
