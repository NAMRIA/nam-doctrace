namespace DocTrace
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlStart = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lblVerify = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.lnkReprint = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.lblStartMessage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnStart = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlLogin = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lnkChangePassword = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.txtPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblPassword = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblUsername = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlNewPassword = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lnkSetPassword = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.txtNewPasswordConfirm = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtNewPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblNewPasswordConfirm = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblNewPassword = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnlSetDetails = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblPDFFile = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbDateTime = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.txtTitle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lnkUploadSelectFile = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.lblTitle = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnSetDetailsNext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.grpBarCode = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.pdfViewer = new PDFView.PDFViewer();
            this.pnlPrint = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtQRCode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lnkProcessAnother = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.lnkPrint = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.btnPrintFinish = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlStart)).BeginInit();
            this.pnlStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLogin)).BeginInit();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNewPassword)).BeginInit();
            this.pnlNewPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSetDetails)).BeginInit();
            this.pnlSetDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpBarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpBarCode.Panel)).BeginInit();
            this.grpBarCode.Panel.SuspendLayout();
            this.grpBarCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPrint)).BeginInit();
            this.pnlPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.pnlStart);
            this.kryptonPanel.Controls.Add(this.pnlLogin);
            this.kryptonPanel.Controls.Add(this.pnlSetDetails);
            this.kryptonPanel.Controls.Add(this.pnlPrint);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(1223, 494);
            this.kryptonPanel.TabIndex = 0;
            // 
            // pnlStart
            // 
            this.pnlStart.Controls.Add(this.lblVerify);
            this.pnlStart.Controls.Add(this.lnkReprint);
            this.pnlStart.Controls.Add(this.lblStartMessage);
            this.pnlStart.Controls.Add(this.btnStart);
            this.pnlStart.Location = new System.Drawing.Point(1091, 232);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(669, 404);
            this.pnlStart.TabIndex = 2;
            // 
            // lblVerify
            // 
            this.lblVerify.Location = new System.Drawing.Point(22, 359);
            this.lblVerify.Name = "lblVerify";
            this.lblVerify.Size = new System.Drawing.Size(104, 20);
            this.lblVerify.TabIndex = 3;
            this.lblVerify.Values.Text = "Verify a QR Code";
            this.lblVerify.LinkClicked += new System.EventHandler(this.lblVerify_LinkClicked);
            // 
            // lnkReprint
            // 
            this.lnkReprint.Location = new System.Drawing.Point(18, 333);
            this.lnkReprint.Name = "lnkReprint";
            this.lnkReprint.Size = new System.Drawing.Size(112, 20);
            this.lnkReprint.TabIndex = 2;
            this.lnkReprint.Values.Text = "Reprint a QR Code";
            this.lnkReprint.LinkClicked += new System.EventHandler(this.lnkReprint_LinkClicked);
            // 
            // lblStartMessage
            // 
            this.lblStartMessage.Location = new System.Drawing.Point(165, 100);
            this.lblStartMessage.Name = "lblStartMessage";
            this.lblStartMessage.Size = new System.Drawing.Size(319, 117);
            this.lblStartMessage.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartMessage.TabIndex = 1;
            this.lblStartMessage.Values.Text = "Please prepare the scanned PDF \nfile of the document.\r\n\r\nClick \'start\' to proceed" +
    ".";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(524, 333);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(132, 59);
            this.btnStart.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnStart.StateCommon.Border.Rounding = 10;
            this.btnStart.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.TabIndex = 0;
            this.btnStart.Values.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.lnkChangePassword);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.pnlNewPassword);
            this.pnlLogin.Location = new System.Drawing.Point(906, 409);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(669, 404);
            this.pnlLogin.TabIndex = 4;
            // 
            // lnkChangePassword
            // 
            this.lnkChangePassword.Location = new System.Drawing.Point(282, 211);
            this.lnkChangePassword.Name = "lnkChangePassword";
            this.lnkChangePassword.Size = new System.Drawing.Size(107, 20);
            this.lnkChangePassword.TabIndex = 8;
            this.lnkChangePassword.Values.Text = "Change password";
            this.lnkChangePassword.LinkClicked += new System.EventHandler(this.lnkChangePassword_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(283, 179);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = 'l';
            this.txtPassword.Size = new System.Drawing.Size(161, 26);
            this.txtPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPassword.StateCommon.Border.Rounding = 5;
            this.txtPassword.StateCommon.Content.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(169, 175);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(108, 33);
            this.lblPassword.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Values.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(283, 140);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(161, 30);
            this.txtUsername.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUsername.StateCommon.Border.Rounding = 5;
            this.txtUsername.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(216, 140);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 33);
            this.lblUsername.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Values.Text = "User:";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Location = new System.Drawing.Point(524, 333);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(132, 59);
            this.btnLogin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StateCommon.Border.Rounding = 10;
            this.btnLogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Values.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlNewPassword
            // 
            this.pnlNewPassword.Controls.Add(this.lnkSetPassword);
            this.pnlNewPassword.Controls.Add(this.txtNewPasswordConfirm);
            this.pnlNewPassword.Controls.Add(this.txtNewPassword);
            this.pnlNewPassword.Controls.Add(this.lblNewPasswordConfirm);
            this.pnlNewPassword.Controls.Add(this.lblNewPassword);
            this.pnlNewPassword.Location = new System.Drawing.Point(36, 244);
            this.pnlNewPassword.Name = "pnlNewPassword";
            this.pnlNewPassword.Size = new System.Drawing.Size(433, 128);
            this.pnlNewPassword.TabIndex = 13;
            this.pnlNewPassword.Visible = false;
            // 
            // lnkSetPassword
            // 
            this.lnkSetPassword.Location = new System.Drawing.Point(246, 85);
            this.lnkSetPassword.Name = "lnkSetPassword";
            this.lnkSetPassword.Size = new System.Drawing.Size(83, 20);
            this.lnkSetPassword.TabIndex = 13;
            this.lnkSetPassword.Values.Text = "Set password";
            this.lnkSetPassword.LinkClicked += new System.EventHandler(this.lnkSetPassword_LinkClicked);
            // 
            // txtNewPasswordConfirm
            // 
            this.txtNewPasswordConfirm.Location = new System.Drawing.Point(246, 53);
            this.txtNewPasswordConfirm.Name = "txtNewPasswordConfirm";
            this.txtNewPasswordConfirm.PasswordChar = 'l';
            this.txtNewPasswordConfirm.Size = new System.Drawing.Size(161, 26);
            this.txtNewPasswordConfirm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNewPasswordConfirm.StateCommon.Border.Rounding = 5;
            this.txtNewPasswordConfirm.StateCommon.Content.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtNewPasswordConfirm.TabIndex = 11;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(246, 21);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = 'l';
            this.txtNewPassword.Size = new System.Drawing.Size(161, 26);
            this.txtNewPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNewPassword.StateCommon.Border.Rounding = 5;
            this.txtNewPassword.StateCommon.Content.Font = new System.Drawing.Font("Wingdings", 12F);
            this.txtNewPassword.TabIndex = 9;
            // 
            // lblNewPasswordConfirm
            // 
            this.lblNewPasswordConfirm.Location = new System.Drawing.Point(5, 50);
            this.lblNewPasswordConfirm.Name = "lblNewPasswordConfirm";
            this.lblNewPasswordConfirm.Size = new System.Drawing.Size(236, 33);
            this.lblNewPasswordConfirm.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPasswordConfirm.TabIndex = 12;
            this.lblNewPasswordConfirm.Values.Text = "Confirm new password:";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Location = new System.Drawing.Point(83, 18);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(158, 33);
            this.lblNewPassword.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.TabIndex = 10;
            this.lblNewPassword.Values.Text = "New password:";
            // 
            // pnlSetDetails
            // 
            this.pnlSetDetails.Controls.Add(this.kryptonLabel1);
            this.pnlSetDetails.Controls.Add(this.lblPDFFile);
            this.pnlSetDetails.Controls.Add(this.cmbDateTime);
            this.pnlSetDetails.Controls.Add(this.txtTitle);
            this.pnlSetDetails.Controls.Add(this.lblDate);
            this.pnlSetDetails.Controls.Add(this.lnkUploadSelectFile);
            this.pnlSetDetails.Controls.Add(this.lblTitle);
            this.pnlSetDetails.Controls.Add(this.btnSetDetailsNext);
            this.pnlSetDetails.Controls.Add(this.grpBarCode);
            this.pnlSetDetails.Location = new System.Drawing.Point(78, 29);
            this.pnlSetDetails.Name = "pnlSetDetails";
            this.pnlSetDetails.Padding = new System.Windows.Forms.Padding(10);
            this.pnlSetDetails.Size = new System.Drawing.Size(669, 404);
            this.pnlSetDetails.TabIndex = 3;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(375, 251);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(226, 21);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 9;
            this.kryptonLabel1.Values.Text = "* Date as it appears on the document";
            // 
            // lblPDFFile
            // 
            this.lblPDFFile.Location = new System.Drawing.Point(354, 23);
            this.lblPDFFile.Name = "lblPDFFile";
            this.lblPDFFile.Size = new System.Drawing.Size(170, 33);
            this.lblPDFFile.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDFFile.TabIndex = 8;
            this.lblPDFFile.Values.Text = "PDF attachment:";
            // 
            // cmbDateTime
            // 
            this.cmbDateTime.Location = new System.Drawing.Point(357, 225);
            this.cmbDateTime.Name = "cmbDateTime";
            this.cmbDateTime.Size = new System.Drawing.Size(274, 27);
            this.cmbDateTime.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbDateTime.StateCommon.Border.Rounding = 5;
            this.cmbDateTime.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDateTime.TabIndex = 7;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(355, 101);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(278, 83);
            this.txtTitle.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTitle.StateCommon.Border.Rounding = 5;
            this.txtTitle.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(355, 190);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(63, 33);
            this.lblDate.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.TabIndex = 4;
            this.lblDate.Values.Text = "Date:";
            // 
            // lnkUploadSelectFile
            // 
            this.lnkUploadSelectFile.Location = new System.Drawing.Point(530, 30);
            this.lnkUploadSelectFile.Name = "lnkUploadSelectFile";
            this.lnkUploadSelectFile.Size = new System.Drawing.Size(115, 26);
            this.lnkUploadSelectFile.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkUploadSelectFile.TabIndex = 3;
            this.lnkUploadSelectFile.Values.Text = "Select PDF file";
            this.lnkUploadSelectFile.LinkClicked += new System.EventHandler(this.lnkUploadSelectFile_LinkClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(355, 62);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(59, 33);
            this.lblTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Values.Text = "Title:";
            // 
            // btnSetDetailsNext
            // 
            this.btnSetDetailsNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetDetailsNext.Location = new System.Drawing.Point(525, 332);
            this.btnSetDetailsNext.Name = "btnSetDetailsNext";
            this.btnSetDetailsNext.Size = new System.Drawing.Size(132, 59);
            this.btnSetDetailsNext.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSetDetailsNext.StateCommon.Border.Rounding = 10;
            this.btnSetDetailsNext.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetDetailsNext.TabIndex = 0;
            this.btnSetDetailsNext.Values.Text = "Next";
            this.btnSetDetailsNext.Click += new System.EventHandler(this.btnSetDetailsNext_Click);
            // 
            // grpBarCode
            // 
            this.grpBarCode.Location = new System.Drawing.Point(13, 13);
            this.grpBarCode.Name = "grpBarCode";
            // 
            // grpBarCode.Panel
            // 
            this.grpBarCode.Panel.Controls.Add(this.pdfViewer);
            this.grpBarCode.Size = new System.Drawing.Size(335, 378);
            this.grpBarCode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grpBarCode.StateCommon.Border.Rounding = 10;
            this.grpBarCode.TabIndex = 1;
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
            this.pdfViewer.Size = new System.Drawing.Size(327, 370);
            this.pdfViewer.TabIndex = 0;
            this.pdfViewer.UseXPDF = false;
            // 
            // pnlPrint
            // 
            this.pnlPrint.Controls.Add(this.txtQRCode);
            this.pnlPrint.Controls.Add(this.lnkProcessAnother);
            this.pnlPrint.Controls.Add(this.lnkPrint);
            this.pnlPrint.Controls.Add(this.btnPrintFinish);
            this.pnlPrint.Location = new System.Drawing.Point(1007, 339);
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size(669, 404);
            this.pnlPrint.TabIndex = 3;
            // 
            // txtQRCode
            // 
            this.txtQRCode.Location = new System.Drawing.Point(143, 92);
            this.txtQRCode.Multiline = true;
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.Size = new System.Drawing.Size(347, 111);
            this.txtQRCode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtQRCode.StateCommon.Border.Rounding = 10;
            this.txtQRCode.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQRCode.TabIndex = 1;
            this.txtQRCode.Text = "<code>";
            this.txtQRCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lnkProcessAnother
            // 
            this.lnkProcessAnother.Location = new System.Drawing.Point(313, 349);
            this.lnkProcessAnother.Name = "lnkProcessAnother";
            this.lnkProcessAnother.Size = new System.Drawing.Size(206, 26);
            this.lnkProcessAnother.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkProcessAnother.TabIndex = 8;
            this.lnkProcessAnother.Values.Text = "Process another document";
            this.lnkProcessAnother.LinkClicked += new System.EventHandler(this.lnkProcessAnother_LinkClicked);
            // 
            // lnkPrint
            // 
            this.lnkPrint.Location = new System.Drawing.Point(250, 209);
            this.lnkPrint.Name = "lnkPrint";
            this.lnkPrint.Size = new System.Drawing.Size(149, 33);
            this.lnkPrint.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkPrint.TabIndex = 4;
            this.lnkPrint.Values.Text = "Print QR Code";
            this.lnkPrint.LinkClicked += new System.EventHandler(this.lnkPrint_LinkClicked);
            // 
            // btnPrintFinish
            // 
            this.btnPrintFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintFinish.Location = new System.Drawing.Point(525, 333);
            this.btnPrintFinish.Name = "btnPrintFinish";
            this.btnPrintFinish.Size = new System.Drawing.Size(132, 59);
            this.btnPrintFinish.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPrintFinish.StateCommon.Border.Rounding = 10;
            this.btnPrintFinish.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintFinish.TabIndex = 0;
            this.btnPrintFinish.Values.Text = "Finish";
            this.btnPrintFinish.Click += new System.EventHandler(this.btnPrintFinish_Click);
            // 
            // printDialog
            // 
            this.printDialog.AllowPrintToFile = false;
            this.printDialog.UseEXDialog = true;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(0, 0);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 494);
            this.Controls.Add(this.kryptonPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Document Validator (Build 04.14.2014)";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlStart)).EndInit();
            this.pnlStart.ResumeLayout(false);
            this.pnlStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLogin)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNewPassword)).EndInit();
            this.pnlNewPassword.ResumeLayout(false);
            this.pnlNewPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSetDetails)).EndInit();
            this.pnlSetDetails.ResumeLayout(false);
            this.pnlSetDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpBarCode.Panel)).EndInit();
            this.grpBarCode.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpBarCode)).EndInit();
            this.grpBarCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlPrint)).EndInit();
            this.pnlPrint.ResumeLayout(false);
            this.pnlPrint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnStart;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlStart;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblStartMessage;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlSetDetails;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSetDetailsNext;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup grpBarCode;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkUploadSelectFile;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlPrint;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPrintFinish;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker cmbDateTime;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPDFFile;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkPrint;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPassword;
        private System.Windows.Forms.PrintDialog printDialog;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkProcessAnother;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkChangePassword;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNewPasswordConfirm;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNewPasswordConfirm;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNewPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNewPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlNewPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkSetPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkReprint;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private PDFView.PDFViewer pdfViewer;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtQRCode;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lblVerify;
    }
}

