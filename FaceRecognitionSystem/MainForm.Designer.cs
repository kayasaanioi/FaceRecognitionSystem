namespace FaceRecognitionSystem
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.ImageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveStreamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camera1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camera2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camera3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wantedListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wantedListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBoxFrameGrabber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageBoxFrameGrabber
            // 
            this.ImageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageBoxFrameGrabber.Location = new System.Drawing.Point(12, 51);
            this.ImageBoxFrameGrabber.Name = "ImageBoxFrameGrabber";
            this.ImageBoxFrameGrabber.Size = new System.Drawing.Size(600, 450);
            this.ImageBoxFrameGrabber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBoxFrameGrabber.TabIndex = 2;
            this.ImageBoxFrameGrabber.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(685, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "CAPTURE IMAGE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(618, 51);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(254, 191);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(701, 295);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "FILE NAME  :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.liveStreamsToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecordToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "&Files";
            // 
            // addRecordToolStripMenuItem
            // 
            this.addRecordToolStripMenuItem.Name = "addRecordToolStripMenuItem";
            this.addRecordToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.addRecordToolStripMenuItem.Text = "Add Record";
            this.addRecordToolStripMenuItem.Click += new System.EventHandler(this.addRecordToolStripMenuItem_Click);
            // 
            // liveStreamsToolStripMenuItem
            // 
            this.liveStreamsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.camera1ToolStripMenuItem,
            this.camera2ToolStripMenuItem,
            this.camera3ToolStripMenuItem});
            this.liveStreamsToolStripMenuItem.Name = "liveStreamsToolStripMenuItem";
            this.liveStreamsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.liveStreamsToolStripMenuItem.Text = "Live &Streams";
            // 
            // camera1ToolStripMenuItem
            // 
            this.camera1ToolStripMenuItem.Name = "camera1ToolStripMenuItem";
            this.camera1ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.camera1ToolStripMenuItem.Text = "Camera 1";
            this.camera1ToolStripMenuItem.Click += new System.EventHandler(this.camera1ToolStripMenuItem_Click_1);
            // 
            // camera2ToolStripMenuItem
            // 
            this.camera2ToolStripMenuItem.Name = "camera2ToolStripMenuItem";
            this.camera2ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.camera2ToolStripMenuItem.Text = "Camera 2";
            // 
            // camera3ToolStripMenuItem
            // 
            this.camera3ToolStripMenuItem.Name = "camera3ToolStripMenuItem";
            this.camera3ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.camera3ToolStripMenuItem.Text = "Camera 3";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wantedListsToolStripMenuItem,
            this.wantedListToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // wantedListsToolStripMenuItem
            // 
            this.wantedListsToolStripMenuItem.Name = "wantedListsToolStripMenuItem";
            this.wantedListsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.wantedListsToolStripMenuItem.Text = "Wanted Lists";
            this.wantedListsToolStripMenuItem.Click += new System.EventHandler(this.wantedListsToolStripMenuItem_Click);
            // 
            // wantedListToolStripMenuItem
            // 
            this.wantedListToolStripMenuItem.Name = "wantedListToolStripMenuItem";
            this.wantedListToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.wantedListToolStripMenuItem.Text = "Recorded Videos";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ImageBoxFrameGrabber);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Face Recognition System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBoxFrameGrabber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox ImageBoxFrameGrabber;
        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wantedListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wantedListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liveStreamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camera1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camera2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camera3ToolStripMenuItem;
    }
}

