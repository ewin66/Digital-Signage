﻿namespace TestTubeVideoPlayer
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPause = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.buttonTestAdd = new System.Windows.Forms.Button();
            this.buttonTestRemove = new System.Windows.Forms.Button();
            this.buttonTestMove = new System.Windows.Forms.Button();
            this.buttonTestClear = new System.Windows.Forms.Button();
            this._fileVideoPlayer = new VideoPlayer.FileVideoPlayer();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this._fileVideoPlayer);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 479);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OMG Video!";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPlay,
            this.toolStripButtonPause,
            this.toolStripButtonStop,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(598, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonPlay
            // 
            this.toolStripButtonPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPlay.Image = global::TestTubeVideoPlayer.Properties.Resources.control_play_blue;
            this.toolStripButtonPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPlay.Name = "toolStripButtonPlay";
            this.toolStripButtonPlay.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPlay.Text = "toolStripButtonPlay";
            this.toolStripButtonPlay.Click += new System.EventHandler(this.toolStripButtonPlay_Click);
            // 
            // toolStripButtonPause
            // 
            this.toolStripButtonPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPause.Image = global::TestTubeVideoPlayer.Properties.Resources.control_pause_blue;
            this.toolStripButtonPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPause.Name = "toolStripButtonPause";
            this.toolStripButtonPause.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPause.Text = "Pause";
            this.toolStripButtonPause.Click += new System.EventHandler(this.toolStripButtonPause_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStop.Image = global::TestTubeVideoPlayer.Properties.Resources.control_stop_blue;
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonStop.Text = "Stop";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::TestTubeVideoPlayer.Properties.Resources.control_eject_blue;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // buttonTestAdd
            // 
            this.buttonTestAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTestAdd.Location = new System.Drawing.Point(12, 497);
            this.buttonTestAdd.Name = "buttonTestAdd";
            this.buttonTestAdd.Size = new System.Drawing.Size(122, 23);
            this.buttonTestAdd.TabIndex = 2;
            this.buttonTestAdd.Text = "Test Playlist.Add()";
            this.buttonTestAdd.UseVisualStyleBackColor = true;
            this.buttonTestAdd.Click += new System.EventHandler(this.buttonTestAdd_Click);
            // 
            // buttonTestRemove
            // 
            this.buttonTestRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTestRemove.Location = new System.Drawing.Point(170, 497);
            this.buttonTestRemove.Name = "buttonTestRemove";
            this.buttonTestRemove.Size = new System.Drawing.Size(122, 23);
            this.buttonTestRemove.TabIndex = 3;
            this.buttonTestRemove.Text = "Test Playlist.Remove()";
            this.buttonTestRemove.UseVisualStyleBackColor = true;
            this.buttonTestRemove.Click += new System.EventHandler(this.buttonTestRemove_Click);
            // 
            // buttonTestMove
            // 
            this.buttonTestMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTestMove.Location = new System.Drawing.Point(328, 497);
            this.buttonTestMove.Name = "buttonTestMove";
            this.buttonTestMove.Size = new System.Drawing.Size(122, 23);
            this.buttonTestMove.TabIndex = 4;
            this.buttonTestMove.Text = "Test Playlist.Move()";
            this.buttonTestMove.UseVisualStyleBackColor = true;
            this.buttonTestMove.Click += new System.EventHandler(this.buttonTestMove_Click);
            // 
            // buttonTestClear
            // 
            this.buttonTestClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTestClear.Location = new System.Drawing.Point(486, 497);
            this.buttonTestClear.Name = "buttonTestClear";
            this.buttonTestClear.Size = new System.Drawing.Size(122, 23);
            this.buttonTestClear.TabIndex = 5;
            this.buttonTestClear.Text = "Test Playlist.Clear()";
            this.buttonTestClear.UseVisualStyleBackColor = true;
            this.buttonTestClear.Click += new System.EventHandler(this.buttonTestClear_Click);
            // 
            // FileVideoPlayer
            // 
            this._fileVideoPlayer.Autoplay = false;
            this._fileVideoPlayer.BackColor = System.Drawing.Color.Black;
            this._fileVideoPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fileVideoPlayer.Location = new System.Drawing.Point(3, 41);
            this._fileVideoPlayer.Name = "_fileVideoPlayer";
            this._fileVideoPlayer.Size = new System.Drawing.Size(598, 435);
            this._fileVideoPlayer.Source = "";
            this._fileVideoPlayer.TabIndex = 2;
            this._fileVideoPlayer.UseBlackBands = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 532);
            this.Controls.Add(this.buttonTestClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonTestMove);
            this.Controls.Add(this.buttonTestAdd);
            this.Controls.Add(this.buttonTestRemove);
            this.Name = "Form1";
            this.Text = "Rendering files with DirectShowLib for .NET";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.ToolStripButton toolStripButtonPlay;
        private System.Windows.Forms.ToolStripButton toolStripButtonPause;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button buttonTestAdd;
        private System.Windows.Forms.Button buttonTestRemove;
        private System.Windows.Forms.Button buttonTestMove;
        private System.Windows.Forms.Button buttonTestClear;
        private VideoPlayer.FileVideoPlayer _fileVideoPlayer;
    }
}

