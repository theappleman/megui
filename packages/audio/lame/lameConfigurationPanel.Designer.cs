namespace MeGUI.packages.audio.lame
{
    partial class lameConfigurationPanel
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
            this.cbrMode = new System.Windows.Forms.RadioButton();
            this.abrMode = new System.Windows.Forms.RadioButton();
            this.vbrMode = new System.Windows.Forms.RadioButton();
            this.vbrValue = new System.Windows.Forms.NumericUpDown();
            this.abrValue = new System.Windows.Forms.NumericUpDown();
            this.cbrBitrate = new System.Windows.Forms.ComboBox();
            this.encoderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vbrValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abrValue)).BeginInit();
            this.SuspendLayout();
            // 
            // encoderGroupBox
            // 
            this.encoderGroupBox.Controls.Add(this.cbrBitrate);
            this.encoderGroupBox.Controls.Add(this.abrValue);
            this.encoderGroupBox.Controls.Add(this.vbrValue);
            this.encoderGroupBox.Controls.Add(this.vbrMode);
            this.encoderGroupBox.Controls.Add(this.abrMode);
            this.encoderGroupBox.Controls.Add(this.cbrMode);
            this.encoderGroupBox.Location = new System.Drawing.Point(0, 175);
            this.encoderGroupBox.Size = new System.Drawing.Size(394, 98);
            this.encoderGroupBox.Text = "  Lame MP3 Encoding Mode  ";
            // 
            // cbrMode
            // 
            this.cbrMode.AutoSize = true;
            this.cbrMode.Location = new System.Drawing.Point(6, 19);
            this.cbrMode.Name = "cbrMode";
            this.cbrMode.Size = new System.Drawing.Size(47, 17);
            this.cbrMode.TabIndex = 0;
            this.cbrMode.TabStop = true;
            this.cbrMode.Text = "CBR";
            this.cbrMode.UseVisualStyleBackColor = true;
            this.cbrMode.CheckedChanged += new System.EventHandler(this.cbrMode_CheckedChanged);
            // 
            // abrMode
            // 
            this.abrMode.AutoSize = true;
            this.abrMode.Location = new System.Drawing.Point(6, 45);
            this.abrMode.Name = "abrMode";
            this.abrMode.Size = new System.Drawing.Size(47, 17);
            this.abrMode.TabIndex = 1;
            this.abrMode.TabStop = true;
            this.abrMode.Text = "ABR";
            this.abrMode.UseVisualStyleBackColor = true;
            this.abrMode.CheckedChanged += new System.EventHandler(this.abrMode_CheckedChanged);
            // 
            // vbrMode
            // 
            this.vbrMode.AutoSize = true;
            this.vbrMode.Location = new System.Drawing.Point(6, 71);
            this.vbrMode.Name = "vbrMode";
            this.vbrMode.Size = new System.Drawing.Size(47, 17);
            this.vbrMode.TabIndex = 2;
            this.vbrMode.TabStop = true;
            this.vbrMode.Text = "VBR";
            this.vbrMode.UseVisualStyleBackColor = true;
            this.vbrMode.CheckedChanged += new System.EventHandler(this.vbrMode_CheckedChanged);
            // 
            // vbrValue
            // 
            this.vbrValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vbrValue.Location = new System.Drawing.Point(112, 71);
            this.vbrValue.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.vbrValue.Name = "vbrValue";
            this.vbrValue.Size = new System.Drawing.Size(276, 20);
            this.vbrValue.TabIndex = 8;
            this.vbrValue.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // abrValue
            // 
            this.abrValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.abrValue.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.abrValue.Location = new System.Drawing.Point(112, 45);
            this.abrValue.Maximum = new decimal(new int[] {
            320,
            0,
            0,
            0});
            this.abrValue.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.abrValue.Name = "abrValue";
            this.abrValue.Size = new System.Drawing.Size(276, 20);
            this.abrValue.TabIndex = 9;
            this.abrValue.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // cbrBitrate
            // 
            this.cbrBitrate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbrBitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbrBitrate.Location = new System.Drawing.Point(112, 18);
            this.cbrBitrate.Name = "cbrBitrate";
            this.cbrBitrate.Size = new System.Drawing.Size(276, 21);
            this.cbrBitrate.TabIndex = 10;
            // 
            // lameConfigurationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "lameConfigurationPanel";
            this.Size = new System.Drawing.Size(394, 277);
            this.encoderGroupBox.ResumeLayout(false);
            this.encoderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vbrValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abrValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton vbrMode;
        private System.Windows.Forms.RadioButton abrMode;
        private System.Windows.Forms.RadioButton cbrMode;
        private System.Windows.Forms.NumericUpDown abrValue;
        private System.Windows.Forms.NumericUpDown vbrValue;
        private System.Windows.Forms.ComboBox cbrBitrate;


    }
}
