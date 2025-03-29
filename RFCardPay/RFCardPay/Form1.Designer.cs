namespace RFCardPay
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnResetApplication = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cmbBluetoothSec = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnFilterOperations = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chcPurchase = new System.Windows.Forms.CheckBox();
            this.chcAddFuns = new System.Windows.Forms.CheckBox();
            this.btnListOperations = new System.Windows.Forms.Button();
            this.btnLoReadCard = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtLoCardNo = new System.Windows.Forms.TextBox();
            this.OperationsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDeleteCard = new System.Windows.Forms.Button();
            this.btnUpdateCard = new System.Windows.Forms.Button();
            this.txtUpdBalance = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txUpdPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtUpdNameSurname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtRfidNumber = new System.Windows.Forms.TextBox();
            this.btnAddCard = new System.Windows.Forms.Button();
            this.btnAcrdReadCard = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.CardsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.txtUpProductPrice = new System.Windows.Forms.TextBox();
            this.txtUpProductName = new System.Windows.Forms.TextBox();
            this.btnSendProductsToDevice = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddFndReadCard = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddFundsRFID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddFunds = new System.Windows.Forms.Button();
            this.txtAmountToAdd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtShowBalance = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFndQryReadCard = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCheckCardBalance = new System.Windows.Forms.Button();
            this.txtCheckBalanceRFID = new System.Windows.Forms.TextBox();
            this.OperationsBkyDataGridView = new System.Windows.Forms.DataGridView();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardsDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsBkyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1175, 643);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnResetApplication);
            this.tabPage1.Controls.Add(this.btnDisconnect);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.Controls.Add(this.cmbBluetoothSec);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1167, 609);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HomePage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnResetApplication
            // 
            this.btnResetApplication.Location = new System.Drawing.Point(911, 546);
            this.btnResetApplication.Name = "btnResetApplication";
            this.btnResetApplication.Size = new System.Drawing.Size(238, 55);
            this.btnResetApplication.TabIndex = 5;
            this.btnResetApplication.Text = "Reset Application";
            this.btnResetApplication.UseVisualStyleBackColor = true;
            this.btnResetApplication.Click += new System.EventHandler(this.btnResetApplication_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(460, 387);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(238, 55);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(529, 226);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(112, 21);
            this.label18.TabIndex = 2;
            this.label18.Text = "Choose Device";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(460, 313);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(238, 55);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cmbBluetoothSec
            // 
            this.cmbBluetoothSec.FormattingEnabled = true;
            this.cmbBluetoothSec.Location = new System.Drawing.Point(460, 262);
            this.cmbBluetoothSec.Name = "cmbBluetoothSec";
            this.cmbBluetoothSec.Size = new System.Drawing.Size(238, 29);
            this.cmbBluetoothSec.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.OperationsDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1167, 609);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Operations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dtpEndDate);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.dtpStartDate);
            this.groupBox8.Controls.Add(this.btnFilterOperations);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox8.Location = new System.Drawing.Point(8, 253);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(302, 248);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(17, 131);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(215, 29);
            this.dtpEndDate.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label17.Location = new System.Drawing.Point(15, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 21);
            this.label17.TabIndex = 10;
            this.label17.Text = "End Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(17, 54);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(215, 29);
            this.dtpStartDate.TabIndex = 3;
            // 
            // btnFilterOperations
            // 
            this.btnFilterOperations.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnFilterOperations.Location = new System.Drawing.Point(17, 189);
            this.btnFilterOperations.Name = "btnFilterOperations";
            this.btnFilterOperations.Size = new System.Drawing.Size(264, 42);
            this.btnFilterOperations.TabIndex = 9;
            this.btnFilterOperations.Text = "Filter";
            this.btnFilterOperations.UseVisualStyleBackColor = true;
            this.btnFilterOperations.Click += new System.EventHandler(this.btnFilterOperations_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label16.Location = new System.Drawing.Point(15, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 21);
            this.label16.TabIndex = 2;
            this.label16.Text = "Start Date";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chcPurchase);
            this.groupBox7.Controls.Add(this.chcAddFuns);
            this.groupBox7.Controls.Add(this.btnListOperations);
            this.groupBox7.Controls.Add(this.btnLoReadCard);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.txtLoCardNo);
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox7.Location = new System.Drawing.Point(8, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(302, 231);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            // 
            // chcPurchase
            // 
            this.chcPurchase.AutoSize = true;
            this.chcPurchase.Checked = true;
            this.chcPurchase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chcPurchase.Location = new System.Drawing.Point(169, 119);
            this.chcPurchase.Name = "chcPurchase";
            this.chcPurchase.Size = new System.Drawing.Size(92, 25);
            this.chcPurchase.TabIndex = 11;
            this.chcPurchase.Text = "Purchase";
            this.chcPurchase.UseVisualStyleBackColor = true;
            // 
            // chcAddFuns
            // 
            this.chcAddFuns.AutoSize = true;
            this.chcAddFuns.Checked = true;
            this.chcAddFuns.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chcAddFuns.Location = new System.Drawing.Point(25, 119);
            this.chcAddFuns.Name = "chcAddFuns";
            this.chcAddFuns.Size = new System.Drawing.Size(103, 25);
            this.chcAddFuns.TabIndex = 10;
            this.chcAddFuns.Text = "Add Funds";
            this.chcAddFuns.UseVisualStyleBackColor = true;
            // 
            // btnListOperations
            // 
            this.btnListOperations.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnListOperations.Location = new System.Drawing.Point(21, 164);
            this.btnListOperations.Name = "btnListOperations";
            this.btnListOperations.Size = new System.Drawing.Size(264, 42);
            this.btnListOperations.TabIndex = 9;
            this.btnListOperations.Text = "List";
            this.btnListOperations.UseVisualStyleBackColor = true;
            this.btnListOperations.Click += new System.EventHandler(this.btnListOperations_Click);
            // 
            // btnLoReadCard
            // 
            this.btnLoReadCard.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLoReadCard.Location = new System.Drawing.Point(169, 46);
            this.btnLoReadCard.Name = "btnLoReadCard";
            this.btnLoReadCard.Size = new System.Drawing.Size(130, 29);
            this.btnLoReadCard.TabIndex = 7;
            this.btnLoReadCard.Text = "Read RFID Card";
            this.btnLoReadCard.UseVisualStyleBackColor = true;
            this.btnLoReadCard.Click += new System.EventHandler(this.btnLoReadCard_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label19.Location = new System.Drawing.Point(13, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 21);
            this.label19.TabIndex = 2;
            this.label19.Text = "Card Number";
            // 
            // txtLoCardNo
            // 
            this.txtLoCardNo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLoCardNo.Location = new System.Drawing.Point(14, 46);
            this.txtLoCardNo.Name = "txtLoCardNo";
            this.txtLoCardNo.Size = new System.Drawing.Size(149, 29);
            this.txtLoCardNo.TabIndex = 0;
            // 
            // OperationsDataGridView
            // 
            this.OperationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OperationsDataGridView.Location = new System.Drawing.Point(316, 6);
            this.OperationsDataGridView.Name = "OperationsDataGridView";
            this.OperationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OperationsDataGridView.Size = new System.Drawing.Size(836, 595);
            this.OperationsDataGridView.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.CardsDataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1167, 609);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Add Card";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDeleteCard);
            this.groupBox5.Controls.Add(this.btnUpdateCard);
            this.groupBox5.Controls.Add(this.txtUpdBalance);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txUpdPhoneNumber);
            this.groupBox5.Controls.Add(this.txtUpdNameSurname);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox5.Location = new System.Drawing.Point(8, 341);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(291, 280);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Update Card";
            // 
            // btnDeleteCard
            // 
            this.btnDeleteCard.Location = new System.Drawing.Point(144, 217);
            this.btnDeleteCard.Name = "btnDeleteCard";
            this.btnDeleteCard.Size = new System.Drawing.Size(93, 42);
            this.btnDeleteCard.TabIndex = 10;
            this.btnDeleteCard.Text = "Delete";
            this.btnDeleteCard.UseVisualStyleBackColor = true;
            this.btnDeleteCard.Click += new System.EventHandler(this.btnDeleteCard_Click);
            // 
            // btnUpdateCard
            // 
            this.btnUpdateCard.Location = new System.Drawing.Point(24, 217);
            this.btnUpdateCard.Name = "btnUpdateCard";
            this.btnUpdateCard.Size = new System.Drawing.Size(96, 42);
            this.btnUpdateCard.TabIndex = 9;
            this.btnUpdateCard.Text = "Update";
            this.btnUpdateCard.UseVisualStyleBackColor = true;
            this.btnUpdateCard.Click += new System.EventHandler(this.btnUpdateCard_Click);
            // 
            // txtUpdBalance
            // 
            this.txtUpdBalance.Location = new System.Drawing.Point(21, 176);
            this.txtUpdBalance.Name = "txtUpdBalance";
            this.txtUpdBalance.Size = new System.Drawing.Size(215, 29);
            this.txtUpdBalance.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "Balance";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 21);
            this.label13.TabIndex = 3;
            this.label13.Text = "Phone Number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 21);
            this.label14.TabIndex = 2;
            this.label14.Text = "Name Surname";
            // 
            // txUpdPhoneNumber
            // 
            this.txUpdPhoneNumber.Location = new System.Drawing.Point(21, 108);
            this.txUpdPhoneNumber.Name = "txUpdPhoneNumber";
            this.txUpdPhoneNumber.Size = new System.Drawing.Size(215, 29);
            this.txUpdPhoneNumber.TabIndex = 1;
            // 
            // txtUpdNameSurname
            // 
            this.txtUpdNameSurname.Location = new System.Drawing.Point(21, 47);
            this.txtUpdNameSurname.Name = "txtUpdNameSurname";
            this.txtUpdNameSurname.Size = new System.Drawing.Size(215, 29);
            this.txtUpdNameSurname.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPhoneNumber);
            this.groupBox2.Controls.Add(this.txtRfidNumber);
            this.groupBox2.Controls.Add(this.btnAddCard);
            this.groupBox2.Controls.Add(this.btnAcrdReadCard);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtBalance);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNameSurname);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 338);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Card";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(21, 109);
            this.txtPhoneNumber.Mask = "(999) 000-0000";
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(215, 29);
            this.txtPhoneNumber.TabIndex = 11;
            // 
            // txtRfidNumber
            // 
            this.txtRfidNumber.Enabled = false;
            this.txtRfidNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtRfidNumber.Location = new System.Drawing.Point(21, 240);
            this.txtRfidNumber.Name = "txtRfidNumber";
            this.txtRfidNumber.Size = new System.Drawing.Size(130, 29);
            this.txtRfidNumber.TabIndex = 10;
            // 
            // btnAddCard
            // 
            this.btnAddCard.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddCard.Location = new System.Drawing.Point(25, 281);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(212, 42);
            this.btnAddCard.TabIndex = 9;
            this.btnAddCard.Text = "Save";
            this.btnAddCard.UseVisualStyleBackColor = true;
            this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
            // 
            // btnAcrdReadCard
            // 
            this.btnAcrdReadCard.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAcrdReadCard.Location = new System.Drawing.Point(157, 240);
            this.btnAcrdReadCard.Name = "btnAcrdReadCard";
            this.btnAcrdReadCard.Size = new System.Drawing.Size(132, 29);
            this.btnAcrdReadCard.TabIndex = 7;
            this.btnAcrdReadCard.Text = "Read RFID Card";
            this.btnAcrdReadCard.UseVisualStyleBackColor = true;
            this.btnAcrdReadCard.Click += new System.EventHandler(this.btnAcrdReadCard_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(22, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Card Number";
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBalance.Location = new System.Drawing.Point(21, 176);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(215, 29);
            this.txtBalance.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(21, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(21, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(21, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name Surname";
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNameSurname.Location = new System.Drawing.Point(21, 46);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(215, 29);
            this.txtNameSurname.TabIndex = 0;
            // 
            // CardsDataGridView
            // 
            this.CardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CardsDataGridView.Location = new System.Drawing.Point(305, 6);
            this.CardsDataGridView.Name = "CardsDataGridView";
            this.CardsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CardsDataGridView.Size = new System.Drawing.Size(856, 594);
            this.CardsDataGridView.TabIndex = 0;
            this.CardsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CardsDataGridView_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.btnSendProductsToDevice);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.ProductsDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1167, 609);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add Product";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDeleteProduct);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.btnUpdateProduct);
            this.groupBox6.Controls.Add(this.txtUpProductPrice);
            this.groupBox6.Controls.Add(this.txtUpProductName);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox6.Location = new System.Drawing.Point(3, 265);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(299, 253);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Update Product";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDeleteProduct.Location = new System.Drawing.Point(137, 186);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(104, 41);
            this.btnDeleteProduct.TabIndex = 6;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 21);
            this.label11.TabIndex = 5;
            this.label11.Text = "Product Price";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label15.Location = new System.Drawing.Point(25, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 21);
            this.label15.TabIndex = 4;
            this.label15.Text = "Product Name";
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUpdateProduct.Location = new System.Drawing.Point(25, 186);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(104, 41);
            this.btnUpdateProduct.TabIndex = 3;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // txtUpProductPrice
            // 
            this.txtUpProductPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUpProductPrice.Location = new System.Drawing.Point(25, 126);
            this.txtUpProductPrice.Name = "txtUpProductPrice";
            this.txtUpProductPrice.Size = new System.Drawing.Size(215, 29);
            this.txtUpProductPrice.TabIndex = 1;
            // 
            // txtUpProductName
            // 
            this.txtUpProductName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUpProductName.Location = new System.Drawing.Point(25, 58);
            this.txtUpProductName.Name = "txtUpProductName";
            this.txtUpProductName.Size = new System.Drawing.Size(215, 29);
            this.txtUpProductName.TabIndex = 0;
            // 
            // btnSendProductsToDevice
            // 
            this.btnSendProductsToDevice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSendProductsToDevice.Location = new System.Drawing.Point(8, 526);
            this.btnSendProductsToDevice.Name = "btnSendProductsToDevice";
            this.btnSendProductsToDevice.Size = new System.Drawing.Size(287, 75);
            this.btnSendProductsToDevice.TabIndex = 2;
            this.btnSendProductsToDevice.Text = "Send Products To Device";
            this.btnSendProductsToDevice.UseVisualStyleBackColor = true;
            this.btnSendProductsToDevice.Click += new System.EventHandler(this.btnSendProductsToDevice_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Controls.Add(this.txtProductPrice);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 253);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Product Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product Name";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddProduct.Location = new System.Drawing.Point(25, 191);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(215, 41);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtProductPrice.Location = new System.Drawing.Point(25, 126);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(215, 29);
            this.txtProductPrice.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtProductName.Location = new System.Drawing.Point(25, 58);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(215, 29);
            this.txtProductName.TabIndex = 0;
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Location = new System.Drawing.Point(309, 6);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsDataGridView.Size = new System.Drawing.Size(852, 595);
            this.ProductsDataGridView.TabIndex = 0;
            this.ProductsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDataGridView_CellClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.Controls.Add(this.groupBox3);
            this.tabPage5.Controls.Add(this.OperationsBkyDataGridView);
            this.tabPage5.Location = new System.Drawing.Point(4, 30);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1167, 609);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Add Funds";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddFndReadCard);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtAddFundsRFID);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btnAddFunds);
            this.groupBox4.Controls.Add(this.txtAmountToAdd);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox4.Location = new System.Drawing.Point(8, 263);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(282, 319);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add Funds";
            // 
            // btnAddFndReadCard
            // 
            this.btnAddFndReadCard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFndReadCard.Location = new System.Drawing.Point(156, 51);
            this.btnAddFndReadCard.Name = "btnAddFndReadCard";
            this.btnAddFndReadCard.Size = new System.Drawing.Size(123, 29);
            this.btnAddFndReadCard.TabIndex = 8;
            this.btnAddFndReadCard.Text = "Read RFID Card";
            this.btnAddFndReadCard.UseVisualStyleBackColor = true;
            this.btnAddFndReadCard.Click += new System.EventHandler(this.btnAddFndReadCard_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(9, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "RFID Card No";
            // 
            // txtAddFundsRFID
            // 
            this.txtAddFundsRFID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAddFundsRFID.Location = new System.Drawing.Point(8, 51);
            this.txtAddFundsRFID.Name = "txtAddFundsRFID";
            this.txtAddFundsRFID.Size = new System.Drawing.Size(142, 29);
            this.txtAddFundsRFID.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(9, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 21);
            this.label9.TabIndex = 5;
            this.label9.Text = "Amount";
            // 
            // btnAddFunds
            // 
            this.btnAddFunds.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddFunds.Location = new System.Drawing.Point(17, 162);
            this.btnAddFunds.Name = "btnAddFunds";
            this.btnAddFunds.Size = new System.Drawing.Size(244, 41);
            this.btnAddFunds.TabIndex = 2;
            this.btnAddFunds.Text = "Add Funds";
            this.btnAddFunds.UseVisualStyleBackColor = true;
            this.btnAddFunds.Click += new System.EventHandler(this.btnAddFunds_Click);
            // 
            // txtAmountToAdd
            // 
            this.txtAmountToAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAmountToAdd.Location = new System.Drawing.Point(11, 113);
            this.txtAmountToAdd.Name = "txtAmountToAdd";
            this.txtAmountToAdd.Size = new System.Drawing.Size(175, 29);
            this.txtAmountToAdd.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtShowBalance);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnFndQryReadCard);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnCheckCardBalance);
            this.groupBox3.Controls.Add(this.txtCheckBalanceRFID);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.Location = new System.Drawing.Point(4, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 247);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Check Balance";
            // 
            // txtShowBalance
            // 
            this.txtShowBalance.Enabled = false;
            this.txtShowBalance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtShowBalance.Location = new System.Drawing.Point(76, 178);
            this.txtShowBalance.Name = "txtShowBalance";
            this.txtShowBalance.Size = new System.Drawing.Size(184, 29);
            this.txtShowBalance.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.Location = new System.Drawing.Point(16, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "Balance";
            // 
            // btnFndQryReadCard
            // 
            this.btnFndQryReadCard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFndQryReadCard.Location = new System.Drawing.Point(161, 61);
            this.btnFndQryReadCard.Name = "btnFndQryReadCard";
            this.btnFndQryReadCard.Size = new System.Drawing.Size(122, 29);
            this.btnFndQryReadCard.TabIndex = 5;
            this.btnFndQryReadCard.Text = "Read RFID Card";
            this.btnFndQryReadCard.UseVisualStyleBackColor = true;
            this.btnFndQryReadCard.Click += new System.EventHandler(this.btnFndQryReadCard_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(8, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "RFID Card No";
            // 
            // btnCheckCardBalance
            // 
            this.btnCheckCardBalance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCheckCardBalance.Location = new System.Drawing.Point(16, 106);
            this.btnCheckCardBalance.Name = "btnCheckCardBalance";
            this.btnCheckCardBalance.Size = new System.Drawing.Size(244, 41);
            this.btnCheckCardBalance.TabIndex = 2;
            this.btnCheckCardBalance.Text = "Check Card Balance";
            this.btnCheckCardBalance.UseVisualStyleBackColor = true;
            this.btnCheckCardBalance.Click += new System.EventHandler(this.btnCheckCardBalance_Click);
            // 
            // txtCheckBalanceRFID
            // 
            this.txtCheckBalanceRFID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCheckBalanceRFID.Location = new System.Drawing.Point(6, 61);
            this.txtCheckBalanceRFID.Name = "txtCheckBalanceRFID";
            this.txtCheckBalanceRFID.Size = new System.Drawing.Size(152, 29);
            this.txtCheckBalanceRFID.TabIndex = 0;
            // 
            // OperationsBkyDataGridView
            // 
            this.OperationsBkyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OperationsBkyDataGridView.Location = new System.Drawing.Point(308, 10);
            this.OperationsBkyDataGridView.Name = "OperationsBkyDataGridView";
            this.OperationsBkyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OperationsBkyDataGridView.Size = new System.Drawing.Size(853, 572);
            this.OperationsBkyDataGridView.TabIndex = 1;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM5";
            this.serialPort1.RtsEnable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RFCardPay.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(460, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 91);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 644);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "RFCardPay";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardsDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsBkyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.Button btnSendProductsToDevice;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddCard;
        private System.Windows.Forms.Button btnAcrdReadCard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.DataGridView CardsDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRfidNumber;
        private System.Windows.Forms.DataGridView OperationsDataGridView;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddFunds;
        private System.Windows.Forms.TextBox txtAmountToAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCheckCardBalance;
        private System.Windows.Forms.TextBox txtCheckBalanceRFID;
        private System.Windows.Forms.DataGridView OperationsBkyDataGridView;
        private System.Windows.Forms.Button btnAddFndReadCard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddFundsRFID;
        private System.Windows.Forms.Button btnFndQryReadCard;
        private System.Windows.Forms.TextBox txtShowBalance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnUpdateCard;
        private System.Windows.Forms.TextBox txtUpdBalance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txUpdPhoneNumber;
        private System.Windows.Forms.TextBox txtUpdNameSurname;
        private System.Windows.Forms.Button btnDeleteCard;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.TextBox txtUpProductPrice;
        private System.Windows.Forms.TextBox txtUpProductName;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnListOperations;
        private System.Windows.Forms.Button btnLoReadCard;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtLoCardNo;
        private System.Windows.Forms.CheckBox chcPurchase;
        private System.Windows.Forms.CheckBox chcAddFuns;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnFilterOperations;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbBluetoothSec;
        private System.Windows.Forms.Button btnConnect;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.MaskedTextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnResetApplication;
    }
}

