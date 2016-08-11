namespace DocTrace
{
    partial class VerifyForm
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
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lnkNewScan = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.lblDateCreated = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtDateCreated = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lnkClose = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtQRCode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtTitle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblTitle = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.grpQRCode = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.lblScan = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.grpBarCode = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.pdfViewer = new PDFView.PDFViewer();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpQRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpQRCode.Panel)).BeginInit();
            this.grpQRCode.Panel.SuspendLayout();
            this.grpQRCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpBarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpBarCode.Panel)).BeginInit();
            this.grpBarCode.Panel.SuspendLayout();
            this.grpBarCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.lnkNewScan);
            this.kryptonPanel.Controls.Add(this.lblDateCreated);
            this.kryptonPanel.Controls.Add(this.txtDateCreated);
            this.kryptonPanel.Controls.Add(this.lnkClose);
            this.kryptonPanel.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel.Controls.Add(this.txtQRCode);
            this.kryptonPanel.Controls.Add(this.txtTitle);
            this.kryptonPanel.Controls.Add(this.lblTitle);
            this.kryptonPanel.Controls.Add(this.grpQRCode);
            this.kryptonPanel.Controls.Add(this.lblScan);
            this.kryptonPanel.Controls.Add(this.grpBarCode);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(923, 640);
            this.kryptonPanel.TabIndex = 0;
            // 
            // lnkNewScan
            // 
            this.lnkNewScan.Location = new System.Drawing.Point(125, 203);
            this.lnkNewScan.Name = "lnkNewScan";
            this.lnkNewScan.Size = new System.Drawing.Size(63, 20);
            this.lnkNewScan.TabIndex = 19;
            this.lnkNewScan.Values.Text = "New scan";
            this.lnkNewScan.Visible = false;
            this.lnkNewScan.LinkClicked += new System.EventHandler(this.lnkNewScan_LinkClicked);
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.Location = new System.Drawing.Point(89, 329);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(135, 33);
            this.lblDateCreated.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCreated.TabIndex = 18;
            this.lblDateCreated.Values.Text = "Date created";
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.Location = new System.Drawing.Point(46, 368);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.ReadOnly = true;
            this.txtDateCreated.Size = new System.Drawing.Size(220, 36);
            this.txtDateCreated.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDateCreated.StateCommon.Border.Rounding = 10;
            this.txtDateCreated.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateCreated.TabIndex = 17;
            this.txtDateCreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lnkClose
            // 
            this.lnkClose.Location = new System.Drawing.Point(136, 595);
            this.lnkClose.Name = "lnkClose";
            this.lnkClose.Size = new System.Drawing.Size(40, 20);
            this.lnkClose.TabIndex = 16;
            this.lnkClose.Values.Text = "Close";
            this.lnkClose.LinkClicked += new System.EventHandler(this.lnkClose_LinkClicked);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(107, 234);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(99, 33);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 15;
            this.kryptonLabel1.Values.Text = "QR Code";
            // 
            // txtQRCode
            // 
            this.txtQRCode.Location = new System.Drawing.Point(46, 273);
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.ReadOnly = true;
            this.txtQRCode.Size = new System.Drawing.Size(220, 38);
            this.txtQRCode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtQRCode.StateCommon.Border.Rounding = 10;
            this.txtQRCode.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQRCode.TabIndex = 14;
            this.txtQRCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(17, 472);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(278, 83);
            this.txtTitle.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTitle.StateCommon.Border.Rounding = 5;
            this.txtTitle.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.TabIndex = 13;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(129, 433);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(54, 33);
            this.lblTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Values.Text = "Title";
            // 
            // grpQRCode
            // 
            this.grpQRCode.Location = new System.Drawing.Point(81, 51);
            this.grpQRCode.Name = "grpQRCode";
            // 
            // grpQRCode.Panel
            // 
            this.grpQRCode.Panel.Controls.Add(this.picCapture);
            this.grpQRCode.Size = new System.Drawing.Size(150, 150);
            this.grpQRCode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grpQRCode.StateCommon.Border.Rounding = 10;
            this.grpQRCode.TabIndex = 11;
            // 
            // picCapture
            // 
            this.picCapture.BackColor = System.Drawing.Color.White;
            this.picCapture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCapture.Location = new System.Drawing.Point(0, 0);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(142, 142);
            this.picCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCapture.TabIndex = 16;
            this.picCapture.TabStop = false;
            // 
            // lblScan
            // 
            this.lblScan.Location = new System.Drawing.Point(127, 12);
            this.lblScan.Name = "lblScan";
            this.lblScan.Size = new System.Drawing.Size(58, 33);
            this.lblScan.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScan.TabIndex = 10;
            this.lblScan.Values.Text = "Scan";
            // 
            // grpBarCode
            // 
            this.grpBarCode.Location = new System.Drawing.Point(316, 12);
            this.grpBarCode.Name = "grpBarCode";
            // 
            // grpBarCode.Panel
            // 
            this.grpBarCode.Panel.Controls.Add(this.pdfViewer);
            this.grpBarCode.Size = new System.Drawing.Size(595, 603);
            this.grpBarCode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grpBarCode.StateCommon.Border.Rounding = 10;
            this.grpBarCode.TabIndex = 9;
            // 
            // pdfViewer
            // 
            this.pdfViewer.AllowBookmarks = true;
            this.pdfViewer.ContinousPages = false;
            this.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer.FileName = null;
            this.pdfViewer.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.ShowBottomToolBar = false;
            this.pdfViewer.Size = new System.Drawing.Size(587, 595);
            this.pdfViewer.TabIndex = 0;
            this.pdfViewer.UseXPDF = false;
            // 
            // VerifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 640);
            this.Controls.Add(this.kryptonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "VerifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verify QR Code";
            this.Load += new System.EventHandler(this.VerifyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpQRCode.Panel)).EndInit();
            this.grpQRCode.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpQRCode)).EndInit();
            this.grpQRCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpBarCode.Panel)).EndInit();
            this.grpBarCode.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpBarCode)).EndInit();
            this.grpBarCode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup grpQRCode;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblScan;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup grpBarCode;
        private PDFView.PDFViewer pdfViewer;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtQRCode;
        private System.Windows.Forms.PictureBox picCapture;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkClose;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDateCreated;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDateCreated;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkNewScan;
    }
}