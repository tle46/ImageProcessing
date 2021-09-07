namespace ImageProcessing
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnDarken = new System.Windows.Forms.Button();
            this.btnLighten = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnBluefilter = new System.Windows.Forms.Button();
            this.btnGreenfilter = new System.Windows.Forms.Button();
            this.btnRedfilter = new System.Windows.Forms.Button();
            this.btnSunset = new System.Windows.Forms.Button();
            this.btnGrayscale = new System.Windows.Forms.Button();
            this.btnPolarize = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnPixel4 = new System.Windows.Forms.Button();
            this.btnFlipHor = new System.Windows.Forms.Button();
            this.btnFlipVer = new System.Windows.Forms.Button();
            this.btnBlur = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEdge = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbNoise = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(11, 318);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(72, 28);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(13, 13);
            this.picImage.Margin = new System.Windows.Forms.Padding(4);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(427, 295);
            this.picImage.TabIndex = 3;
            this.picImage.TabStop = false;
            // 
            // btnDarken
            // 
            this.btnDarken.Location = new System.Drawing.Point(19, 69);
            this.btnDarken.Margin = new System.Windows.Forms.Padding(4);
            this.btnDarken.Name = "btnDarken";
            this.btnDarken.Size = new System.Drawing.Size(100, 28);
            this.btnDarken.TabIndex = 1;
            this.btnDarken.Text = "Darken";
            this.btnDarken.UseVisualStyleBackColor = true;
            this.btnDarken.Click += new System.EventHandler(this.btnDarken_Click);
            // 
            // btnLighten
            // 
            this.btnLighten.Location = new System.Drawing.Point(19, 33);
            this.btnLighten.Margin = new System.Windows.Forms.Padding(4);
            this.btnLighten.Name = "btnLighten";
            this.btnLighten.Size = new System.Drawing.Size(100, 28);
            this.btnLighten.TabIndex = 0;
            this.btnLighten.Text = "Lighten";
            this.btnLighten.UseVisualStyleBackColor = true;
            this.btnLighten.Click += new System.EventHandler(this.btnLighten_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.Location = new System.Drawing.Point(23, 37);
            this.btnNegative.Margin = new System.Windows.Forms.Padding(4);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(100, 28);
            this.btnNegative.TabIndex = 0;
            this.btnNegative.Text = "Negative";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnBluefilter
            // 
            this.btnBluefilter.Location = new System.Drawing.Point(16, 105);
            this.btnBluefilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnBluefilter.Name = "btnBluefilter";
            this.btnBluefilter.Size = new System.Drawing.Size(100, 28);
            this.btnBluefilter.TabIndex = 2;
            this.btnBluefilter.Text = "Blue Filter";
            this.btnBluefilter.UseVisualStyleBackColor = true;
            this.btnBluefilter.Click += new System.EventHandler(this.btnBluefilter_Click);
            // 
            // btnGreenfilter
            // 
            this.btnGreenfilter.Location = new System.Drawing.Point(16, 69);
            this.btnGreenfilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnGreenfilter.Name = "btnGreenfilter";
            this.btnGreenfilter.Size = new System.Drawing.Size(100, 28);
            this.btnGreenfilter.TabIndex = 1;
            this.btnGreenfilter.Text = "Green Filter";
            this.btnGreenfilter.UseVisualStyleBackColor = true;
            this.btnGreenfilter.Click += new System.EventHandler(this.btnGreenfilter_Click);
            // 
            // btnRedfilter
            // 
            this.btnRedfilter.Location = new System.Drawing.Point(16, 33);
            this.btnRedfilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnRedfilter.Name = "btnRedfilter";
            this.btnRedfilter.Size = new System.Drawing.Size(100, 28);
            this.btnRedfilter.TabIndex = 0;
            this.btnRedfilter.Text = "Red Filter";
            this.btnRedfilter.UseVisualStyleBackColor = true;
            this.btnRedfilter.Click += new System.EventHandler(this.btnRedfilter_Click);
            // 
            // btnSunset
            // 
            this.btnSunset.Location = new System.Drawing.Point(19, 105);
            this.btnSunset.Margin = new System.Windows.Forms.Padding(4);
            this.btnSunset.Name = "btnSunset";
            this.btnSunset.Size = new System.Drawing.Size(100, 28);
            this.btnSunset.TabIndex = 2;
            this.btnSunset.Text = "Sunset Effect";
            this.btnSunset.UseVisualStyleBackColor = true;
            this.btnSunset.Click += new System.EventHandler(this.btnSunset_Click);
            // 
            // btnGrayscale
            // 
            this.btnGrayscale.Location = new System.Drawing.Point(23, 73);
            this.btnGrayscale.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrayscale.Name = "btnGrayscale";
            this.btnGrayscale.Size = new System.Drawing.Size(100, 28);
            this.btnGrayscale.TabIndex = 1;
            this.btnGrayscale.Text = "Grayscale";
            this.btnGrayscale.UseVisualStyleBackColor = true;
            this.btnGrayscale.Click += new System.EventHandler(this.btnGrayscale_Click);
            // 
            // btnPolarize
            // 
            this.btnPolarize.Location = new System.Drawing.Point(23, 109);
            this.btnPolarize.Margin = new System.Windows.Forms.Padding(4);
            this.btnPolarize.Name = "btnPolarize";
            this.btnPolarize.Size = new System.Drawing.Size(100, 28);
            this.btnPolarize.TabIndex = 2;
            this.btnPolarize.Text = "Polarize";
            this.btnPolarize.UseVisualStyleBackColor = true;
            this.btnPolarize.Click += new System.EventHandler(this.btnPolarize_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(23, 141);
            this.btnRotate.Margin = new System.Windows.Forms.Padding(4);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(100, 28);
            this.btnRotate.TabIndex = 3;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(23, 105);
            this.btnSwitch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(100, 28);
            this.btnSwitch.TabIndex = 2;
            this.btnSwitch.Text = "Switch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnPixel4
            // 
            this.btnPixel4.Location = new System.Drawing.Point(23, 145);
            this.btnPixel4.Margin = new System.Windows.Forms.Padding(4);
            this.btnPixel4.Name = "btnPixel4";
            this.btnPixel4.Size = new System.Drawing.Size(100, 28);
            this.btnPixel4.TabIndex = 3;
            this.btnPixel4.Text = "Pixelate";
            this.btnPixel4.UseVisualStyleBackColor = true;
            this.btnPixel4.Click += new System.EventHandler(this.btnPixel4_Click);
            // 
            // btnFlipHor
            // 
            this.btnFlipHor.Location = new System.Drawing.Point(23, 33);
            this.btnFlipHor.Margin = new System.Windows.Forms.Padding(4);
            this.btnFlipHor.Name = "btnFlipHor";
            this.btnFlipHor.Size = new System.Drawing.Size(100, 28);
            this.btnFlipHor.TabIndex = 0;
            this.btnFlipHor.Text = "Flip Hor.";
            this.btnFlipHor.UseVisualStyleBackColor = true;
            this.btnFlipHor.Click += new System.EventHandler(this.btnFlipHor_Click);
            // 
            // btnFlipVer
            // 
            this.btnFlipVer.Location = new System.Drawing.Point(23, 69);
            this.btnFlipVer.Margin = new System.Windows.Forms.Padding(4);
            this.btnFlipVer.Name = "btnFlipVer";
            this.btnFlipVer.Size = new System.Drawing.Size(100, 28);
            this.btnFlipVer.TabIndex = 1;
            this.btnFlipVer.Text = "Flip Ver.";
            this.btnFlipVer.UseVisualStyleBackColor = true;
            this.btnFlipVer.Click += new System.EventHandler(this.btnFlipVer_Click);
            // 
            // btnBlur
            // 
            this.btnBlur.Location = new System.Drawing.Point(23, 181);
            this.btnBlur.Margin = new System.Windows.Forms.Padding(4);
            this.btnBlur.Name = "btnBlur";
            this.btnBlur.Size = new System.Drawing.Size(100, 28);
            this.btnBlur.TabIndex = 4;
            this.btnBlur.Text = "Blur";
            this.btnBlur.UseVisualStyleBackColor = true;
            this.btnBlur.Click += new System.EventHandler(this.btnBlur_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(23, 217);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(100, 28);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRedfilter);
            this.groupBox1.Controls.Add(this.btnBluefilter);
            this.groupBox1.Controls.Add(this.btnGreenfilter);
            this.groupBox1.Location = new System.Drawing.Point(170, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 146);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLighten);
            this.groupBox2.Controls.Add(this.btnDarken);
            this.groupBox2.Controls.Add(this.btnSunset);
            this.groupBox2.Location = new System.Drawing.Point(309, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 146);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lighten/Darken";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGrayscale);
            this.groupBox3.Controls.Add(this.btnPolarize);
            this.groupBox3.Controls.Add(this.btnNegative);
            this.groupBox3.Controls.Add(this.btnPixel4);
            this.groupBox3.Controls.Add(this.btnSort);
            this.groupBox3.Controls.Add(this.btnBlur);
            this.groupBox3.Location = new System.Drawing.Point(447, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 261);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Effects";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnFlipHor);
            this.groupBox4.Controls.Add(this.btnFlipVer);
            this.groupBox4.Controls.Add(this.btnSwitch);
            this.groupBox4.Controls.Add(this.btnRotate);
            this.groupBox4.Location = new System.Drawing.Point(447, 280);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(140, 183);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Flip";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(11, 353);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(152, 27);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEdge
            // 
            this.btnEdge.Location = new System.Drawing.Point(19, 21);
            this.btnEdge.Name = "btnEdge";
            this.btnEdge.Size = new System.Drawing.Size(100, 28);
            this.btnEdge.TabIndex = 0;
            this.btnEdge.Text = "Edge Detection";
            this.btnEdge.UseVisualStyleBackColor = true;
            this.btnEdge.Click += new System.EventHandler(this.btnEdge_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbNoise);
            this.groupBox5.Controls.Add(this.btnEdge);
            this.groupBox5.Location = new System.Drawing.Point(11, 385);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(152, 78);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Edge Detection";
            // 
            // cbNoise
            // 
            this.cbNoise.AutoSize = true;
            this.cbNoise.Location = new System.Drawing.Point(7, 51);
            this.cbNoise.Name = "cbNoise";
            this.cbNoise.Size = new System.Drawing.Size(119, 21);
            this.cbNoise.TabIndex = 1;
            this.cbNoise.Text = "Reduce Noise";
            this.cbNoise.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(91, 318);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 28);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 487);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picImage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnDarken;
        private System.Windows.Forms.Button btnLighten;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnBluefilter;
        private System.Windows.Forms.Button btnGreenfilter;
        private System.Windows.Forms.Button btnRedfilter;
        private System.Windows.Forms.Button btnSunset;
        private System.Windows.Forms.Button btnGrayscale;
        private System.Windows.Forms.Button btnPolarize;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnPixel4;
        private System.Windows.Forms.Button btnFlipHor;
        private System.Windows.Forms.Button btnFlipVer;
        private System.Windows.Forms.Button btnBlur;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEdge;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbNoise;
        private System.Windows.Forms.Button btnSave;
    }
}

