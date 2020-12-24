
namespace SpritesheetSplicer
{
    partial class Main
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
            this.spritesheetImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadSpritesheetButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.spriteSizeX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.spriteSizeY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.marginSizeY = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.marginSizeX = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.outputFolderField = new System.Windows.Forms.TextBox();
            this.browseOutputFolderButton = new System.Windows.Forms.Button();
            this.sliceButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.marginLeftCheckbox = new System.Windows.Forms.CheckBox();
            this.marginRightCheckbox = new System.Windows.Forms.CheckBox();
            this.marginBottomCheckbox = new System.Windows.Forms.CheckBox();
            this.marginTopCheckbox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cellCountY = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cellCountX = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.statusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.slicingBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.spritesheetImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteSizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteSizeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marginSizeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marginSizeX)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cellCountY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellCountX)).BeginInit();
            this.SuspendLayout();
            // 
            // spritesheetImage
            // 
            this.spritesheetImage.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.spritesheetImage.Location = new System.Drawing.Point(13, 13);
            this.spritesheetImage.Name = "spritesheetImage";
            this.spritesheetImage.Size = new System.Drawing.Size(264, 553);
            this.spritesheetImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spritesheetImage.TabIndex = 0;
            this.spritesheetImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Nova Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Spritesheet Splicer";
            // 
            // loadSpritesheetButton
            // 
            this.loadSpritesheetButton.Location = new System.Drawing.Point(306, 41);
            this.loadSpritesheetButton.Name = "loadSpritesheetButton";
            this.loadSpritesheetButton.Size = new System.Drawing.Size(166, 23);
            this.loadSpritesheetButton.TabIndex = 2;
            this.loadSpritesheetButton.Text = "Load Spritesheet";
            this.loadSpritesheetButton.UseVisualStyleBackColor = true;
            this.loadSpritesheetButton.Click += new System.EventHandler(this.loadSpritesheetButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Nova Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sprite Size";
            // 
            // spriteSizeX
            // 
            this.spriteSizeX.Location = new System.Drawing.Point(335, 102);
            this.spriteSizeX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spriteSizeX.Name = "spriteSizeX";
            this.spriteSizeX.Size = new System.Drawing.Size(47, 20);
            this.spriteSizeX.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Nova Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Nova Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Y";
            // 
            // spriteSizeY
            // 
            this.spriteSizeY.Location = new System.Drawing.Point(335, 129);
            this.spriteSizeY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spriteSizeY.Name = "spriteSizeY";
            this.spriteSizeY.Size = new System.Drawing.Size(47, 20);
            this.spriteSizeY.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Nova Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Y";
            // 
            // marginSizeY
            // 
            this.marginSizeY.Location = new System.Drawing.Point(335, 214);
            this.marginSizeY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.marginSizeY.Name = "marginSizeY";
            this.marginSizeY.Size = new System.Drawing.Size(47, 20);
            this.marginSizeY.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Nova Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(305, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "X";
            // 
            // marginSizeX
            // 
            this.marginSizeX.Location = new System.Drawing.Point(335, 187);
            this.marginSizeX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.marginSizeX.Name = "marginSizeX";
            this.marginSizeX.Size = new System.Drawing.Size(47, 20);
            this.marginSizeX.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Nova Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(301, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "Seperator Size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Nova Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(301, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 26);
            this.label8.TabIndex = 13;
            this.label8.Text = "Output Folder";
            // 
            // outputFolderField
            // 
            this.outputFolderField.Location = new System.Drawing.Point(310, 397);
            this.outputFolderField.Name = "outputFolderField";
            this.outputFolderField.Size = new System.Drawing.Size(162, 20);
            this.outputFolderField.TabIndex = 14;
            // 
            // browseOutputFolderButton
            // 
            this.browseOutputFolderButton.Location = new System.Drawing.Point(310, 423);
            this.browseOutputFolderButton.Name = "browseOutputFolderButton";
            this.browseOutputFolderButton.Size = new System.Drawing.Size(162, 23);
            this.browseOutputFolderButton.TabIndex = 15;
            this.browseOutputFolderButton.Text = "Browse";
            this.browseOutputFolderButton.UseVisualStyleBackColor = true;
            this.browseOutputFolderButton.Click += new System.EventHandler(this.browseOutputFolderButton_Click);
            // 
            // sliceButton
            // 
            this.sliceButton.Location = new System.Drawing.Point(310, 538);
            this.sliceButton.Name = "sliceButton";
            this.sliceButton.Size = new System.Drawing.Size(162, 23);
            this.sliceButton.TabIndex = 16;
            this.sliceButton.Text = "Slice";
            this.sliceButton.UseVisualStyleBackColor = true;
            this.sliceButton.Click += new System.EventHandler(this.sliceButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusProgressBar,
            this.statusBarLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 569);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(484, 22);
            this.statusStrip.TabIndex = 17;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusBarLabel
            // 
            this.statusBarLabel.Name = "statusBarLabel";
            this.statusBarLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // marginLeftCheckbox
            // 
            this.marginLeftCheckbox.AutoSize = true;
            this.marginLeftCheckbox.Location = new System.Drawing.Point(310, 240);
            this.marginLeftCheckbox.Name = "marginLeftCheckbox";
            this.marginLeftCheckbox.Size = new System.Drawing.Size(75, 17);
            this.marginLeftCheckbox.TabIndex = 18;
            this.marginLeftCheckbox.Text = "Margin left";
            this.marginLeftCheckbox.UseVisualStyleBackColor = true;
            // 
            // marginRightCheckbox
            // 
            this.marginRightCheckbox.AutoSize = true;
            this.marginRightCheckbox.Location = new System.Drawing.Point(310, 263);
            this.marginRightCheckbox.Name = "marginRightCheckbox";
            this.marginRightCheckbox.Size = new System.Drawing.Size(81, 17);
            this.marginRightCheckbox.TabIndex = 19;
            this.marginRightCheckbox.Text = "Margin right";
            this.marginRightCheckbox.UseVisualStyleBackColor = true;
            // 
            // marginBottomCheckbox
            // 
            this.marginBottomCheckbox.AutoSize = true;
            this.marginBottomCheckbox.Location = new System.Drawing.Point(389, 263);
            this.marginBottomCheckbox.Name = "marginBottomCheckbox";
            this.marginBottomCheckbox.Size = new System.Drawing.Size(93, 17);
            this.marginBottomCheckbox.TabIndex = 21;
            this.marginBottomCheckbox.Text = "Margin bottom";
            this.marginBottomCheckbox.UseVisualStyleBackColor = true;
            // 
            // marginTopCheckbox
            // 
            this.marginTopCheckbox.AutoSize = true;
            this.marginTopCheckbox.Location = new System.Drawing.Point(389, 240);
            this.marginTopCheckbox.Name = "marginTopCheckbox";
            this.marginTopCheckbox.Size = new System.Drawing.Size(76, 17);
            this.marginTopCheckbox.TabIndex = 20;
            this.marginTopCheckbox.Text = "Margin top";
            this.marginTopCheckbox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Nova Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(305, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 26);
            this.label9.TabIndex = 26;
            this.label9.Text = "Y";
            // 
            // cellCountY
            // 
            this.cellCountY.Location = new System.Drawing.Point(335, 345);
            this.cellCountY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cellCountY.Name = "cellCountY";
            this.cellCountY.Size = new System.Drawing.Size(47, 20);
            this.cellCountY.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Nova Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(305, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 26);
            this.label10.TabIndex = 24;
            this.label10.Text = "X";
            // 
            // cellCountX
            // 
            this.cellCountX.Location = new System.Drawing.Point(335, 318);
            this.cellCountX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cellCountX.Name = "cellCountX";
            this.cellCountX.Size = new System.Drawing.Size(47, 20);
            this.cellCountX.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Nova Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(301, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 26);
            this.label11.TabIndex = 22;
            this.label11.Text = "Cell Count";
            // 
            // statusProgressBar
            // 
            this.statusProgressBar.Name = "statusProgressBar";
            this.statusProgressBar.Size = new System.Drawing.Size(100, 16);
            this.statusProgressBar.Visible = false;
            // 
            // slicingBackgroundWorker
            // 
            this.slicingBackgroundWorker.WorkerReportsProgress = true;
            this.slicingBackgroundWorker.WorkerSupportsCancellation = true;
            this.slicingBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.slicingBackgroundWorker_DoWork);
            this.slicingBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.slicingBackgroundWorker_ProgressChanged);
            this.slicingBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.slicingBackgroundWorker_RunWorkerCompleted);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 591);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cellCountY);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cellCountX);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.marginBottomCheckbox);
            this.Controls.Add(this.marginTopCheckbox);
            this.Controls.Add(this.marginRightCheckbox);
            this.Controls.Add(this.marginLeftCheckbox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.sliceButton);
            this.Controls.Add(this.browseOutputFolderButton);
            this.Controls.Add(this.outputFolderField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.marginSizeY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.marginSizeX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.spriteSizeY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.spriteSizeX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loadSpritesheetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spritesheetImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spritesheet Splicer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.spritesheetImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteSizeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteSizeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marginSizeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marginSizeX)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cellCountY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellCountX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox spritesheetImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loadSpritesheetButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown spriteSizeX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown spriteSizeY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown marginSizeY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown marginSizeX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox outputFolderField;
        private System.Windows.Forms.Button browseOutputFolderButton;
        private System.Windows.Forms.Button sliceButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel;
        private System.Windows.Forms.CheckBox marginLeftCheckbox;
        private System.Windows.Forms.CheckBox marginRightCheckbox;
        private System.Windows.Forms.CheckBox marginBottomCheckbox;
        private System.Windows.Forms.CheckBox marginTopCheckbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown cellCountY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown cellCountX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripProgressBar statusProgressBar;
        private System.ComponentModel.BackgroundWorker slicingBackgroundWorker;
    }
}

