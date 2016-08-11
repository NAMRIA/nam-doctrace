namespace DocTrace
{
    partial class PrintDialogForm
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
            this.btnChangePrinter = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtCopies = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblCopies = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblPrinter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblPrinterName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.btnChangePrinter);
            this.kryptonPanel.Controls.Add(this.lblPrinterName);
            this.kryptonPanel.Controls.Add(this.btnCancel);
            this.kryptonPanel.Controls.Add(this.txtCopies);
            this.kryptonPanel.Controls.Add(this.lblCopies);
            this.kryptonPanel.Controls.Add(this.btnOk);
            this.kryptonPanel.Controls.Add(this.lblPrinter);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(355, 115);
            this.kryptonPanel.TabIndex = 0;
            // 
            // btnChangePrinter
            // 
            this.btnChangePrinter.Location = new System.Drawing.Point(285, 22);
            this.btnChangePrinter.Name = "btnChangePrinter";
            this.btnChangePrinter.Size = new System.Drawing.Size(59, 25);
            this.btnChangePrinter.TabIndex = 0;
            this.btnChangePrinter.Values.Text = "Change";
            this.btnChangePrinter.Click += new System.EventHandler(this.btnChangePrinter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(285, 77);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 26);
            this.btnCancel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.StateCommon.Border.Rounding = 5;
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(67, 52);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(57, 24);
            this.txtCopies.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCopies.StateCommon.Border.Rounding = 5;
            this.txtCopies.TabIndex = 3;
            this.txtCopies.Text = "1";
            this.txtCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCopies
            // 
            this.lblCopies.Location = new System.Drawing.Point(11, 52);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(50, 20);
            this.lblCopies.TabIndex = 8;
            this.lblCopies.Values.Text = "Copies:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(221, 77);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(58, 26);
            this.btnOk.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOk.StateCommon.Border.Rounding = 5;
            this.btnOk.TabIndex = 4;
            this.btnOk.Values.Text = "Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblPrinter
            // 
            this.lblPrinter.Location = new System.Drawing.Point(12, 24);
            this.lblPrinter.Name = "lblPrinter";
            this.lblPrinter.Size = new System.Drawing.Size(49, 20);
            this.lblPrinter.TabIndex = 0;
            this.lblPrinter.Values.Text = "Printer:";
            // 
            // lblPrinterName
            // 
            this.lblPrinterName.Location = new System.Drawing.Point(67, 22);
            this.lblPrinterName.Name = "lblPrinterName";
            this.lblPrinterName.ReadOnly = true;
            this.lblPrinterName.Size = new System.Drawing.Size(212, 24);
            this.lblPrinterName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lblPrinterName.StateCommon.Border.Rounding = 5;
            this.lblPrinterName.TabIndex = 4;
            this.lblPrinterName.Text = "{select a printer}";
            // 
            // PrintDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 115);
            this.Controls.Add(this.kryptonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PrintDialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print Barcode";
            this.Load += new System.EventHandler(this.PrintDialog_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PrintDialogForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPrinter;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOk;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCopies;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCopies;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnChangePrinter;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox lblPrinterName;
    }
}

