namespace SchemaFactor.Vst.MidiWifi
{
    partial class MainWindow
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
            this.DebugLabel = new System.Windows.Forms.Label();
            this.AboutButton = new System.Windows.Forms.Button();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.RX_LED = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // DebugLabel
            // 
            this.DebugLabel.BackColor = System.Drawing.Color.Transparent;
            this.DebugLabel.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebugLabel.ForeColor = System.Drawing.Color.White;
            this.DebugLabel.Location = new System.Drawing.Point(9, 69);
            this.DebugLabel.Margin = new System.Windows.Forms.Padding(0);
            this.DebugLabel.Name = "DebugLabel";
            this.DebugLabel.Size = new System.Drawing.Size(557, 20);
            this.DebugLabel.TabIndex = 34;
            this.DebugLabel.Text = "--";
            this.DebugLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.Red;
            this.AboutButton.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AboutButton.Location = new System.Drawing.Point(110, 193);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(87, 26);
            this.AboutButton.TabIndex = 38;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // OptionsButton
            // 
            this.OptionsButton.BackColor = System.Drawing.Color.Red;
            this.OptionsButton.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsButton.Location = new System.Drawing.Point(110, 161);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(87, 26);
            this.OptionsButton.TabIndex = 39;
            this.OptionsButton.Text = "Options";
            this.OptionsButton.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RX_LED
            // 
            this.RX_LED.BackColor = System.Drawing.Color.Transparent;
            this.RX_LED.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RX_LED.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RX_LED.ForeColor = System.Drawing.Color.White;
            this.RX_LED.Location = new System.Drawing.Point(244, 32);
            this.RX_LED.Margin = new System.Windows.Forms.Padding(0);
            this.RX_LED.Name = "RX_LED";
            this.RX_LED.Size = new System.Drawing.Size(78, 21);
            this.RX_LED.TabIndex = 40;
            this.RX_LED.Text = "Receive";
            this.RX_LED.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.RX_LED);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(this.DebugLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.Size = new System.Drawing.Size(578, 107);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DebugLabel;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label RX_LED;


    }
}

