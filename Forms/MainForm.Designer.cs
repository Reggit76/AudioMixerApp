namespace AudioMixerApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.grpFileInfo = new System.Windows.Forms.GroupBox();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.lblFileType = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.trkFreq1 = new System.Windows.Forms.TrackBar();
            this.trkFreq2 = new System.Windows.Forms.TrackBar();
            this.trkFreq3 = new System.Windows.Forms.TrackBar();
            this.trkFreq4 = new System.Windows.Forms.TrackBar();
            this.trkFreq5 = new System.Windows.Forms.TrackBar();
            this.trkFreq6 = new System.Windows.Forms.TrackBar();
            this.trkFreq7 = new System.Windows.Forms.TrackBar();
            this.trkFreq8 = new System.Windows.Forms.TrackBar();
            this.trkFreq9 = new System.Windows.Forms.TrackBar();
            this.trkFreq10 = new System.Windows.Forms.TrackBar();
            this.Equalizer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.trkVolume = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.trkSpatial = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpFileInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpatial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectFile.Location = new System.Drawing.Point(12, 541);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(138, 49);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Выбрать файл";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // grpFileInfo
            // 
            this.grpFileInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.grpFileInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpFileInfo.Controls.Add(this.lblFileSize);
            this.grpFileInfo.Controls.Add(this.lblFileType);
            this.grpFileInfo.Controls.Add(this.lblDuration);
            this.grpFileInfo.Controls.Add(this.lblFileName);
            this.grpFileInfo.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpFileInfo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grpFileInfo.Location = new System.Drawing.Point(12, 12);
            this.grpFileInfo.Name = "grpFileInfo";
            this.grpFileInfo.Size = new System.Drawing.Size(138, 509);
            this.grpFileInfo.TabIndex = 1;
            this.grpFileInfo.TabStop = false;
            this.grpFileInfo.Text = "File information";
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(6, 289);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(75, 21);
            this.lblFileSize.TabIndex = 3;
            this.lblFileSize.Text = "File size: ";
            // 
            // lblFileType
            // 
            this.lblFileType.AutoSize = true;
            this.lblFileType.Location = new System.Drawing.Point(6, 202);
            this.lblFileType.Name = "lblFileType";
            this.lblFileType.Size = new System.Drawing.Size(80, 21);
            this.lblFileType.TabIndex = 2;
            this.lblFileType.Text = "File type: ";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(6, 117);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(81, 21);
            this.lblDuration.TabIndex = 1;
            this.lblDuration.Text = "Duration: ";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(6, 34);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(61, 21);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "Name: ";
            // 
            // trkFreq1
            // 
            this.trkFreq1.Location = new System.Drawing.Point(209, 46);
            this.trkFreq1.Name = "trkFreq1";
            this.trkFreq1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkFreq1.Size = new System.Drawing.Size(45, 276);
            this.trkFreq1.TabIndex = 2;
            this.trkFreq1.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // trkFreq2
            // 
            this.trkFreq2.Location = new System.Drawing.Point(260, 46);
            this.trkFreq2.Name = "trkFreq2";
            this.trkFreq2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkFreq2.Size = new System.Drawing.Size(45, 276);
            this.trkFreq2.TabIndex = 3;
            this.trkFreq2.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // trkFreq3
            // 
            this.trkFreq3.Location = new System.Drawing.Point(311, 46);
            this.trkFreq3.Name = "trkFreq3";
            this.trkFreq3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkFreq3.Size = new System.Drawing.Size(45, 276);
            this.trkFreq3.TabIndex = 4;
            this.trkFreq3.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // trkFreq4
            // 
            this.trkFreq4.Location = new System.Drawing.Point(362, 46);
            this.trkFreq4.Name = "trkFreq4";
            this.trkFreq4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkFreq4.Size = new System.Drawing.Size(45, 276);
            this.trkFreq4.TabIndex = 5;
            this.trkFreq4.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // trkFreq5
            // 
            this.trkFreq5.Location = new System.Drawing.Point(413, 46);
            this.trkFreq5.Name = "trkFreq5";
            this.trkFreq5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkFreq5.Size = new System.Drawing.Size(45, 276);
            this.trkFreq5.TabIndex = 6;
            this.trkFreq5.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // trkFreq6
            // 
            this.trkFreq6.Location = new System.Drawing.Point(464, 46);
            this.trkFreq6.Name = "trkFreq6";
            this.trkFreq6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkFreq6.Size = new System.Drawing.Size(45, 276);
            this.trkFreq6.TabIndex = 7;
            this.trkFreq6.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // trkFreq7
            // 
            this.trkFreq7.Location = new System.Drawing.Point(515, 46);
            this.trkFreq7.Name = "trkFreq7";
            this.trkFreq7.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkFreq7.Size = new System.Drawing.Size(45, 276);
            this.trkFreq7.TabIndex = 8;
            this.trkFreq7.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // trkFreq8
            // 
            this.trkFreq8.Location = new System.Drawing.Point(566, 46);
            this.trkFreq8.Name = "trkFreq8";
            this.trkFreq8.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkFreq8.Size = new System.Drawing.Size(45, 276);
            this.trkFreq8.TabIndex = 9;
            this.trkFreq8.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // trkFreq9
            // 
            this.trkFreq9.Location = new System.Drawing.Point(617, 46);
            this.trkFreq9.Name = "trkFreq9";
            this.trkFreq9.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkFreq9.Size = new System.Drawing.Size(45, 276);
            this.trkFreq9.TabIndex = 10;
            this.trkFreq9.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // trkFreq10
            // 
            this.trkFreq10.Location = new System.Drawing.Point(668, 46);
            this.trkFreq10.Name = "trkFreq10";
            this.trkFreq10.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkFreq10.Size = new System.Drawing.Size(45, 276);
            this.trkFreq10.TabIndex = 11;
            this.trkFreq10.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // Equalizer
            // 
            this.Equalizer.AutoSize = true;
            this.Equalizer.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Equalizer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Equalizer.Location = new System.Drawing.Point(205, 12);
            this.Equalizer.Name = "Equalizer";
            this.Equalizer.Size = new System.Drawing.Size(74, 21);
            this.Equalizer.TabIndex = 12;
            this.Equalizer.Text = "Equalizer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(221, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "32";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(272, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "64";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(370, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "250";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(320, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "125";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(578, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "4k";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(528, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "2k";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(475, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "1k";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(421, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "500";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(675, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "16k";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(628, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "8k";
            // 
            // trkVolume
            // 
            this.trkVolume.Location = new System.Drawing.Point(784, 46);
            this.trkVolume.Name = "trkVolume";
            this.trkVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkVolume.Size = new System.Drawing.Size(45, 276);
            this.trkVolume.TabIndex = 23;
            this.trkVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(781, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "Volume";
            // 
            // trkSpatial
            // 
            this.trkSpatial.Location = new System.Drawing.Point(913, 46);
            this.trkSpatial.Name = "trkSpatial";
            this.trkSpatial.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkSpatial.Size = new System.Drawing.Size(45, 276);
            this.trkSpatial.TabIndex = 25;
            this.trkSpatial.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(910, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 18);
            this.label12.TabIndex = 26;
            this.label12.Text = "Spatial";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(872, 541);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 49);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1022, 602);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.trkSpatial);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.trkVolume);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Equalizer);
            this.Controls.Add(this.trkFreq10);
            this.Controls.Add(this.trkFreq9);
            this.Controls.Add(this.trkFreq8);
            this.Controls.Add(this.trkFreq7);
            this.Controls.Add(this.trkFreq6);
            this.Controls.Add(this.trkFreq5);
            this.Controls.Add(this.trkFreq4);
            this.Controls.Add(this.trkFreq3);
            this.Controls.Add(this.trkFreq2);
            this.Controls.Add(this.trkFreq1);
            this.Controls.Add(this.grpFileInfo);
            this.Controls.Add(this.btnSelectFile);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpFileInfo.ResumeLayout(false);
            this.grpFileInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpatial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.GroupBox grpFileInfo;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Label lblFileType;
        private System.Windows.Forms.TrackBar trkFreq1;
        private System.Windows.Forms.TrackBar trkFreq2;
        private System.Windows.Forms.TrackBar trkFreq3;
        private System.Windows.Forms.TrackBar trkFreq4;
        private System.Windows.Forms.TrackBar trkFreq5;
        private System.Windows.Forms.TrackBar trkFreq6;
        private System.Windows.Forms.TrackBar trkFreq7;
        private System.Windows.Forms.TrackBar trkFreq8;
        private System.Windows.Forms.TrackBar trkFreq9;
        private System.Windows.Forms.TrackBar trkFreq10;
        private System.Windows.Forms.Label Equalizer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trkVolume;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trkSpatial;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSave;
    }
}
