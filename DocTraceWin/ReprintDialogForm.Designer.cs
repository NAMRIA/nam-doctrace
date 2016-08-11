namespace DocTrace
{
    partial class ReprintDialogForm
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
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lnkCancel = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.btnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtBarcode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblBarcode = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.lnkCancel);
            this.kryptonPanel.Controls.Add(this.btnOk);
            this.kryptonPanel.Controls.Add(this.txtBarcode);
            this.kryptonPanel.Controls.Add(this.lblBarcode);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(280, 139);
            this.kryptonPanel.TabIndex = 0;
            // 
            // lnkCancel
            // 
            this.lnkCancel.LinkBehavior = ComponentFactory.Krypton.Toolkit.KryptonLinkBehavior.NeverUnderline;
            this.lnkCancel.Location = new System.Drawing.Point(144, 96);
            this.lnkCancel.Name = "lnkCancel";
            this.lnkCancel.Size = new System.Drawing.Size(47, 20);
            this.lnkCancel.TabIndex = 10;
            this.lnkCancel.Values.Text = "Cancel";
            this.lnkCancel.LinkClicked += new System.EventHandler(this.lnkCancel_LinkClicked);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(197, 93);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(58, 26);
            this.btnOk.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOk.StateCommon.Border.Rounding = 5;
            this.btnOk.TabIndex = 9;
            this.btnOk.Values.Text = "Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(32, 51);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(223, 38);
            this.txtBarcode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBarcode.StateCommon.Border.Rounding = 5;
            this.txtBarcode.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.txtBarcode.TabIndex = 8;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBarcode
            // 
            this.lblBarcode.Location = new System.Drawing.Point(32, 12);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(96, 33);
            this.lblBarcode.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarcode.TabIndex = 7;
            this.lblBarcode.Values.Text = "Barcode:";
            // 
            // ReprintDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 139);
            this.Controls.Add(this.kryptonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReprintDialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reprint Barcode";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBarcode;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBarcode;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOk;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkCancel;
    }
}

