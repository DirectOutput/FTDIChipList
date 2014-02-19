namespace FTDIChipList
{
    partial class FTDIDevices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTDIDevices));
            this.DeviceList = new System.Windows.Forms.DataGridView();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.DeviceListType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceListDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceListSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CopyToClipboardButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DeviceList)).BeginInit();
            this.SuspendLayout();
            // 
            // DeviceList
            // 
            this.DeviceList.AllowUserToAddRows = false;
            this.DeviceList.AllowUserToDeleteRows = false;
            this.DeviceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeviceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeviceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeviceListType,
            this.DeviceListDescription,
            this.DeviceListSerial});
            this.DeviceList.Location = new System.Drawing.Point(1, 1);
            this.DeviceList.MultiSelect = false;
            this.DeviceList.Name = "DeviceList";
            this.DeviceList.ReadOnly = true;
            this.DeviceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeviceList.Size = new System.Drawing.Size(846, 322);
            this.DeviceList.TabIndex = 0;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.Location = new System.Drawing.Point(760, 329);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // DeviceListType
            // 
            this.DeviceListType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeviceListType.FillWeight = 20F;
            this.DeviceListType.HeaderText = "Type";
            this.DeviceListType.Name = "DeviceListType";
            this.DeviceListType.ReadOnly = true;
            // 
            // DeviceListDescription
            // 
            this.DeviceListDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeviceListDescription.FillWeight = 40F;
            this.DeviceListDescription.HeaderText = "Description";
            this.DeviceListDescription.Name = "DeviceListDescription";
            this.DeviceListDescription.ReadOnly = true;
            // 
            // DeviceListSerial
            // 
            this.DeviceListSerial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeviceListSerial.FillWeight = 40F;
            this.DeviceListSerial.HeaderText = "Serial Number";
            this.DeviceListSerial.Name = "DeviceListSerial";
            this.DeviceListSerial.ReadOnly = true;
            // 
            // CopyToClipboardButton
            // 
            this.CopyToClipboardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyToClipboardButton.Location = new System.Drawing.Point(583, 329);
            this.CopyToClipboardButton.Name = "CopyToClipboardButton";
            this.CopyToClipboardButton.Size = new System.Drawing.Size(159, 23);
            this.CopyToClipboardButton.TabIndex = 2;
            this.CopyToClipboardButton.Text = "Copy serial to clipboard";
            this.CopyToClipboardButton.UseVisualStyleBackColor = true;
            this.CopyToClipboardButton.Click += new System.EventHandler(this.CopyToClipboardButton_Click);
            // 
            // FTDIDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 359);
            this.Controls.Add(this.CopyToClipboardButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.DeviceList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FTDIDevices";
            this.Text = "FTDI Chip Device List";
            ((System.ComponentModel.ISupportInitialize)(this.DeviceList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DeviceList;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceListType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceListDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceListSerial;
        private System.Windows.Forms.Button CopyToClipboardButton;
    }
}

