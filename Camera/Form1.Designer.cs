namespace Camera
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.CMB_Devices = new System.Windows.Forms.ComboBox();
            this.CMB_Resolution = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PXB_Picture = new System.Windows.Forms.PictureBox();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.SFD_Save = new System.Windows.Forms.SaveFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PXB_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // CMB_Devices
            // 
            this.CMB_Devices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CMB_Devices.FormattingEnabled = true;
            this.CMB_Devices.Location = new System.Drawing.Point(3, 363);
            this.CMB_Devices.Name = "CMB_Devices";
            this.CMB_Devices.Size = new System.Drawing.Size(385, 21);
            this.CMB_Devices.TabIndex = 0;
            this.CMB_Devices.SelectedIndexChanged += new System.EventHandler(this.CMB_Devices_SelectedIndexChanged);
            // 
            // CMB_Resolution
            // 
            this.CMB_Resolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CMB_Resolution.FormattingEnabled = true;
            this.CMB_Resolution.Location = new System.Drawing.Point(3, 318);
            this.CMB_Resolution.Name = "CMB_Resolution";
            this.CMB_Resolution.Size = new System.Drawing.Size(385, 21);
            this.CMB_Resolution.TabIndex = 1;
            this.CMB_Resolution.SelectedIndexChanged += new System.EventHandler(this.CMB_Resolution_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PXB_Picture, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CMB_Devices, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CMB_Resolution, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Save, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 450);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // PXB_Picture
            // 
            this.PXB_Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PXB_Picture.Location = new System.Drawing.Point(3, 3);
            this.PXB_Picture.Name = "PXB_Picture";
            this.PXB_Picture.Size = new System.Drawing.Size(385, 309);
            this.PXB_Picture.TabIndex = 3;
            this.PXB_Picture.TabStop = false;
            // 
            // BTN_Save
            // 
            this.BTN_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Save.Location = new System.Drawing.Point(3, 408);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(385, 39);
            this.BTN_Save.TabIndex = 4;
            this.BTN_Save.Text = "Capture";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click_1);
            // 
            // SFD_Save
            // 
            this.SFD_Save.CreatePrompt = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(395, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(321, 446);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Best Camera App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PXB_Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CMB_Devices;
        private System.Windows.Forms.ComboBox CMB_Resolution;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.PictureBox PXB_Picture;
        private System.Windows.Forms.SaveFileDialog SFD_Save;
        private System.Windows.Forms.ListBox listBox1;
    }
}

