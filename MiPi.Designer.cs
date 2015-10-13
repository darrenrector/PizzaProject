namespace PizzaProject
{
    partial class frmMiPi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMiPi));
            this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
            this.lblCityError = new System.Windows.Forms.Label();
            this.lblAddressError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblPhoneNbrError = new System.Windows.Forms.Label();
            this.mtbZipCode = new System.Windows.Forms.MaskedTextBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.grpOrderInfo = new System.Windows.Forms.GroupBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblMaxQuanity = new System.Windows.Forms.Label();
            this.nudQuanity = new System.Windows.Forms.NumericUpDown();
            this.lblQuanity = new System.Windows.Forms.Label();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkHamburger = new System.Windows.Forms.CheckBox();
            this.chkOnions = new System.Windows.Forms.CheckBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkBlackOlives = new System.Windows.Forms.CheckBox();
            this.chkGreenOlives = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.picPizza = new System.Windows.Forms.PictureBox();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.cboPayment = new System.Windows.Forms.ComboBox();
            this.grpPricing = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.chkMute = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.tmrDT = new System.Windows.Forms.Timer(this.components);
            this.grpCustomerInfo.SuspendLayout();
            this.grpOrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuanity)).BeginInit();
            this.grpToppings.SuspendLayout();
            this.grpSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).BeginInit();
            this.grpPayment.SuspendLayout();
            this.grpPricing.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomerInfo
            // 
            this.grpCustomerInfo.Controls.Add(this.lblCityError);
            this.grpCustomerInfo.Controls.Add(this.lblAddressError);
            this.grpCustomerInfo.Controls.Add(this.lblNameError);
            this.grpCustomerInfo.Controls.Add(this.lblPhoneNbrError);
            this.grpCustomerInfo.Controls.Add(this.mtbZipCode);
            this.grpCustomerInfo.Controls.Add(this.cboState);
            this.grpCustomerInfo.Controls.Add(this.txtCity);
            this.grpCustomerInfo.Controls.Add(this.txtAddress2);
            this.grpCustomerInfo.Controls.Add(this.txtAddress1);
            this.grpCustomerInfo.Controls.Add(this.txtName);
            this.grpCustomerInfo.Controls.Add(this.mtbPhone);
            this.grpCustomerInfo.Controls.Add(this.lblZipCode);
            this.grpCustomerInfo.Controls.Add(this.lblState);
            this.grpCustomerInfo.Controls.Add(this.lblCity);
            this.grpCustomerInfo.Controls.Add(this.lblAddress2);
            this.grpCustomerInfo.Controls.Add(this.lblAddress1);
            this.grpCustomerInfo.Controls.Add(this.lblName);
            this.grpCustomerInfo.Controls.Add(this.lblPhone);
            this.grpCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerInfo.Location = new System.Drawing.Point(12, 111);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Size = new System.Drawing.Size(280, 493);
            this.grpCustomerInfo.TabIndex = 0;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Customer &Information";
            this.grpCustomerInfo.Enter += new System.EventHandler(this.grpCustomerInfo_Enter);
            // 
            // lblCityError
            // 
            this.lblCityError.AutoEllipsis = true;
            this.lblCityError.AutoSize = true;
            this.lblCityError.BackColor = System.Drawing.Color.Transparent;
            this.lblCityError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCityError.Location = new System.Drawing.Point(77, 255);
            this.lblCityError.Name = "lblCityError";
            this.lblCityError.Size = new System.Drawing.Size(96, 20);
            this.lblCityError.TabIndex = 17;
            this.lblCityError.Text = "Invalid City";
            // 
            // lblAddressError
            // 
            this.lblAddressError.AutoEllipsis = true;
            this.lblAddressError.AutoSize = true;
            this.lblAddressError.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAddressError.Location = new System.Drawing.Point(77, 161);
            this.lblAddressError.Name = "lblAddressError";
            this.lblAddressError.Size = new System.Drawing.Size(132, 20);
            this.lblAddressError.TabIndex = 16;
            this.lblAddressError.Text = "Invalid Address";
            // 
            // lblNameError
            // 
            this.lblNameError.AutoEllipsis = true;
            this.lblNameError.AutoSize = true;
            this.lblNameError.BackColor = System.Drawing.Color.Transparent;
            this.lblNameError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNameError.Location = new System.Drawing.Point(77, 113);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(112, 20);
            this.lblNameError.TabIndex = 15;
            this.lblNameError.Text = "Invalid Name";
            this.lblNameError.Click += new System.EventHandler(this.lblNameError_Click);
            // 
            // lblPhoneNbrError
            // 
            this.lblPhoneNbrError.AutoEllipsis = true;
            this.lblPhoneNbrError.AutoSize = true;
            this.lblPhoneNbrError.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNbrError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPhoneNbrError.Location = new System.Drawing.Point(77, 64);
            this.lblPhoneNbrError.Name = "lblPhoneNbrError";
            this.lblPhoneNbrError.Size = new System.Drawing.Size(184, 20);
            this.lblPhoneNbrError.TabIndex = 14;
            this.lblPhoneNbrError.Text = "Invalid Phone Number";
            this.lblPhoneNbrError.Click += new System.EventHandler(this.lblPhoneNbrError_Click);
            // 
            // mtbZipCode
            // 
            this.mtbZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbZipCode.Location = new System.Drawing.Point(96, 327);
            this.mtbZipCode.Mask = "00000-9999";
            this.mtbZipCode.Name = "mtbZipCode";
            this.mtbZipCode.Size = new System.Drawing.Size(77, 22);
            this.mtbZipCode.TabIndex = 13;
            this.mtbZipCode.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbZipCode.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbZipCode_MaskInputRejected);
            this.mtbZipCode.Validating += new System.ComponentModel.CancelEventHandler(this.mtbZipCode_Validating);
            // 
            // cboState
            // 
            this.cboState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(96, 281);
            this.cboState.MaxDropDownItems = 10;
            this.cboState.MaxLength = 2;
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(47, 24);
            this.cboState.TabIndex = 11;
            this.cboState.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(96, 230);
            this.txtCity.MaxLength = 25;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(178, 22);
            this.txtCity.TabIndex = 9;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            this.txtCity.Leave += new System.EventHandler(this.txtCity_Leave);
            // 
            // txtAddress2
            // 
            this.txtAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.Location = new System.Drawing.Point(96, 183);
            this.txtAddress2.MaxLength = 25;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(178, 22);
            this.txtAddress2.TabIndex = 7;
            this.txtAddress2.TextChanged += new System.EventHandler(this.txtAddress2_TextChanged);
            // 
            // txtAddress1
            // 
            this.txtAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.Location = new System.Drawing.Point(96, 136);
            this.txtAddress1.MaxLength = 25;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(178, 22);
            this.txtAddress1.TabIndex = 5;
            this.txtAddress1.TextChanged += new System.EventHandler(this.txtAddress1_TextChanged);
            this.txtAddress1.Leave += new System.EventHandler(this.txtAddress1_Leave);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(96, 89);
            this.txtName.MaxLength = 25;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 22);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // mtbPhone
            // 
            this.mtbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPhone.Location = new System.Drawing.Point(96, 42);
            this.mtbPhone.Mask = "(999) 000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(133, 22);
            this.mtbPhone.TabIndex = 1;
            this.mtbPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbPhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbPhone_MaskInputRejected);
            this.mtbPhone.Leave += new System.EventHandler(this.mtbPhone_Leave);
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(6, 330);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(69, 16);
            this.lblZipCode.TabIndex = 12;
            this.lblZipCode.Text = "Zipcode:";
            this.lblZipCode.Click += new System.EventHandler(this.lblZipCode_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(6, 284);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(48, 16);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "State:";
            this.lblState.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(6, 233);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(38, 16);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "&City:";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.Location = new System.Drawing.Point(6, 186);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(78, 16);
            this.lblAddress2.TabIndex = 6;
            this.lblAddress2.Text = "Address2:";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.Location = new System.Drawing.Point(6, 139);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(78, 16);
            this.lblAddress1.TabIndex = 4;
            this.lblAddress1.Text = "Address1:";
            this.lblAddress1.Click += new System.EventHandler(this.lblAddress1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(6, 45);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(56, 16);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone:";
            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // grpOrderInfo
            // 
            this.grpOrderInfo.Controls.Add(this.lblNumber);
            this.grpOrderInfo.Controls.Add(this.lblMaxQuanity);
            this.grpOrderInfo.Controls.Add(this.nudQuanity);
            this.grpOrderInfo.Controls.Add(this.lblQuanity);
            this.grpOrderInfo.Controls.Add(this.grpToppings);
            this.grpOrderInfo.Controls.Add(this.grpSize);
            this.grpOrderInfo.Controls.Add(this.lblOrderNumber);
            this.grpOrderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderInfo.Location = new System.Drawing.Point(318, 111);
            this.grpOrderInfo.Name = "grpOrderInfo";
            this.grpOrderInfo.Size = new System.Drawing.Size(268, 493);
            this.grpOrderInfo.TabIndex = 1;
            this.grpOrderInfo.TabStop = false;
            this.grpOrderInfo.Text = "Or&der Information";
            // 
            // lblNumber
            // 
            this.lblNumber.Location = new System.Drawing.Point(182, 22);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(57, 22);
            this.lblNumber.TabIndex = 7;
            this.lblNumber.Text = "0001";
            // 
            // lblMaxQuanity
            // 
            this.lblMaxQuanity.AutoSize = true;
            this.lblMaxQuanity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxQuanity.Location = new System.Drawing.Point(184, 453);
            this.lblMaxQuanity.Name = "lblMaxQuanity";
            this.lblMaxQuanity.Size = new System.Drawing.Size(70, 16);
            this.lblMaxQuanity.TabIndex = 6;
            this.lblMaxQuanity.Text = "(Max. 10)";
            // 
            // nudQuanity
            // 
            this.nudQuanity.Location = new System.Drawing.Point(125, 451);
            this.nudQuanity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudQuanity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuanity.Name = "nudQuanity";
            this.nudQuanity.Size = new System.Drawing.Size(50, 26);
            this.nudQuanity.TabIndex = 3;
            this.nudQuanity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQuanity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuanity
            // 
            this.lblQuanity.AutoSize = true;
            this.lblQuanity.Location = new System.Drawing.Point(41, 452);
            this.lblQuanity.Name = "lblQuanity";
            this.lblQuanity.Size = new System.Drawing.Size(75, 20);
            this.lblQuanity.TabIndex = 5;
            this.lblQuanity.Text = "&Quanity:";
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.chkMushrooms);
            this.grpToppings.Controls.Add(this.chkHamburger);
            this.grpToppings.Controls.Add(this.chkOnions);
            this.grpToppings.Controls.Add(this.chkPineapple);
            this.grpToppings.Controls.Add(this.chkHam);
            this.grpToppings.Controls.Add(this.chkBlackOlives);
            this.grpToppings.Controls.Add(this.chkGreenOlives);
            this.grpToppings.Controls.Add(this.chkPepperoni);
            this.grpToppings.Controls.Add(this.chkSausage);
            this.grpToppings.Controls.Add(this.chkCheese);
            this.grpToppings.Location = new System.Drawing.Point(39, 148);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(200, 287);
            this.grpToppings.TabIndex = 4;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "&Toppings ($1.00)";
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushrooms.Location = new System.Drawing.Point(39, 259);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(106, 20);
            this.chkMushrooms.TabIndex = 9;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkHamburger
            // 
            this.chkHamburger.AutoSize = true;
            this.chkHamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHamburger.Location = new System.Drawing.Point(39, 233);
            this.chkHamburger.Name = "chkHamburger";
            this.chkHamburger.Size = new System.Drawing.Size(104, 20);
            this.chkHamburger.TabIndex = 8;
            this.chkHamburger.Text = "Hamburger";
            this.chkHamburger.UseVisualStyleBackColor = true;
            this.chkHamburger.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // chkOnions
            // 
            this.chkOnions.AutoSize = true;
            this.chkOnions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnions.Location = new System.Drawing.Point(39, 207);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Size = new System.Drawing.Size(75, 20);
            this.chkOnions.TabIndex = 7;
            this.chkOnions.Text = "Onions";
            this.chkOnions.UseVisualStyleBackColor = true;
            this.chkOnions.CheckedChanged += new System.EventHandler(this.chkOnions_CheckedChanged);
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPineapple.Location = new System.Drawing.Point(39, 181);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(98, 20);
            this.chkPineapple.TabIndex = 6;
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            this.chkPineapple.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHam.Location = new System.Drawing.Point(39, 155);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(59, 20);
            this.chkHam.TabIndex = 5;
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            this.chkHam.CheckedChanged += new System.EventHandler(this.chkHam_CheckedChanged);
            // 
            // chkBlackOlives
            // 
            this.chkBlackOlives.AutoSize = true;
            this.chkBlackOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBlackOlives.Location = new System.Drawing.Point(39, 129);
            this.chkBlackOlives.Name = "chkBlackOlives";
            this.chkBlackOlives.Size = new System.Drawing.Size(114, 20);
            this.chkBlackOlives.TabIndex = 4;
            this.chkBlackOlives.Text = "Black Olives";
            this.chkBlackOlives.UseVisualStyleBackColor = true;
            this.chkBlackOlives.CheckedChanged += new System.EventHandler(this.chkBlackOlives_CheckedChanged);
            // 
            // chkGreenOlives
            // 
            this.chkGreenOlives.AutoSize = true;
            this.chkGreenOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenOlives.Location = new System.Drawing.Point(39, 103);
            this.chkGreenOlives.Name = "chkGreenOlives";
            this.chkGreenOlives.Size = new System.Drawing.Size(117, 20);
            this.chkGreenOlives.TabIndex = 3;
            this.chkGreenOlives.Text = "&Green Olives";
            this.chkGreenOlives.UseVisualStyleBackColor = true;
            this.chkGreenOlives.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPepperoni.Location = new System.Drawing.Point(39, 77);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(99, 20);
            this.chkPepperoni.TabIndex = 2;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            this.chkPepperoni.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSausage.Location = new System.Drawing.Point(39, 51);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(89, 20);
            this.chkSausage.TabIndex = 1;
            this.chkSausage.Text = "Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            this.chkSausage.CheckedChanged += new System.EventHandler(this.chkSausage_CheckedChanged);
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCheese.Location = new System.Drawing.Point(39, 25);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(80, 20);
            this.chkCheese.TabIndex = 0;
            this.chkCheese.Text = "C&heese";
            this.chkCheese.UseVisualStyleBackColor = true;
            this.chkCheese.CheckedChanged += new System.EventHandler(this.chkCheese_CheckedChanged);
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.radLarge);
            this.grpSize.Controls.Add(this.radMedium);
            this.grpSize.Controls.Add(this.radSmall);
            this.grpSize.Location = new System.Drawing.Point(39, 47);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(200, 96);
            this.grpSize.TabIndex = 3;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Si&ze";
            // 
            // radLarge
            // 
            this.radLarge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radLarge.AutoSize = true;
            this.radLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLarge.Location = new System.Drawing.Point(38, 75);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(128, 20);
            this.radLarge.TabIndex = 2;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "Large ($12.00) ";
            this.radLarge.UseVisualStyleBackColor = true;
            this.radLarge.CheckedChanged += new System.EventHandler(this.radLarge_CheckedChanged);
            // 
            // radMedium
            // 
            this.radMedium.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radMedium.AutoSize = true;
            this.radMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMedium.Location = new System.Drawing.Point(38, 50);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(138, 20);
            this.radMedium.TabIndex = 1;
            this.radMedium.TabStop = true;
            this.radMedium.Text = "Medium ($10.00)";
            this.radMedium.UseVisualStyleBackColor = true;
            this.radMedium.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radSmall
            // 
            this.radSmall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radSmall.AutoSize = true;
            this.radSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSmall.Location = new System.Drawing.Point(38, 25);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(115, 20);
            this.radSmall.TabIndex = 0;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "Small ($8.00)";
            this.radSmall.UseVisualStyleBackColor = true;
            this.radSmall.CheckedChanged += new System.EventHandler(this.radSmall_CheckedChanged);
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(53, 22);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(131, 20);
            this.lblOrderNumber.TabIndex = 0;
            this.lblOrderNumber.Text = "Order Number: ";
            // 
            // picPizza
            // 
            this.picPizza.Image = ((System.Drawing.Image)(resources.GetObject("picPizza.Image")));
            this.picPizza.Location = new System.Drawing.Point(606, 111);
            this.picPizza.Name = "picPizza";
            this.picPizza.Size = new System.Drawing.Size(268, 131);
            this.picPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPizza.TabIndex = 2;
            this.picPizza.TabStop = false;
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.cboPayment);
            this.grpPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPayment.Location = new System.Drawing.Point(606, 259);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(225, 60);
            this.grpPayment.TabIndex = 3;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Pa&yment";
            // 
            // cboPayment
            // 
            this.cboPayment.DisplayMember = "Cash";
            this.cboPayment.FormattingEnabled = true;
            this.cboPayment.Items.AddRange(new object[] {
            "Cash",
            "Check",
            "Visa",
            "Mastercard",
            "American Express"});
            this.cboPayment.Location = new System.Drawing.Point(6, 23);
            this.cboPayment.Name = "cboPayment";
            this.cboPayment.Size = new System.Drawing.Size(176, 28);
            this.cboPayment.TabIndex = 0;
            // 
            // grpPricing
            // 
            this.grpPricing.Controls.Add(this.txtTotal);
            this.grpPricing.Controls.Add(this.txtTax);
            this.grpPricing.Controls.Add(this.txtSubtotal);
            this.grpPricing.Controls.Add(this.lblTotal);
            this.grpPricing.Controls.Add(this.lblTax);
            this.grpPricing.Controls.Add(this.lblSubtotal);
            this.grpPricing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPricing.Location = new System.Drawing.Point(606, 336);
            this.grpPricing.Name = "grpPricing";
            this.grpPricing.Size = new System.Drawing.Size(225, 150);
            this.grpPricing.TabIndex = 4;
            this.grpPricing.TabStop = false;
            this.grpPricing.Text = "P&ricing";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(78, 102);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(139, 26);
            this.txtTotal.TabIndex = 7;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(78, 58);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(139, 26);
            this.txtTax.TabIndex = 6;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(78, 21);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(139, 26);
            this.txtSubtotal.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(24, 108);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 16);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total:";
            this.lblTotal.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(34, 64);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(38, 16);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "Tax:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(3, 29);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(69, 16);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.chkMute);
            this.grpActions.Controls.Add(this.btnClose);
            this.grpActions.Controls.Add(this.btnReset);
            this.grpActions.Controls.Add(this.btnAccept);
            this.grpActions.Controls.Add(this.btnPrice);
            this.grpActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpActions.Location = new System.Drawing.Point(606, 515);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(658, 89);
            this.grpActions.TabIndex = 5;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actio&ns";
            // 
            // chkMute
            // 
            this.chkMute.AutoSize = true;
            this.chkMute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMute.Location = new System.Drawing.Point(485, 37);
            this.chkMute.Name = "chkMute";
            this.chkMute.Size = new System.Drawing.Size(75, 28);
            this.chkMute.TabIndex = 4;
            this.chkMute.Text = "M&ute";
            this.chkMute.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(355, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 53);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Cl&ose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(240, 25);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 53);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "R&eset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(125, 25);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(92, 53);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPrice
            // 
            this.btnPrice.Location = new System.Drawing.Point(10, 25);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(92, 53);
            this.btnPrice.TabIndex = 0;
            this.btnPrice.Text = "&Price";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.Location = new System.Drawing.Point(900, 9);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(392, 27);
            this.lblDateTime.TabIndex = 6;
            this.lblDateTime.Click += new System.EventHandler(this.lblDateTime_Click);
            // 
            // lblFile
            // 
            this.lblFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.Location = new System.Drawing.Point(9, 9);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(35, 17);
            this.lblFile.TabIndex = 7;
            this.lblFile.Text = "&File";
            this.lblFile.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(50, 9);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(70, 17);
            this.lblPayment.TabIndex = 8;
            this.lblPayment.Text = "Pay&ment";
            this.lblPayment.Click += new System.EventHandler(this.lblPayment_Click);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCompanyName.Font = new System.Drawing.Font("Papyrus", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.Crimson;
            this.lblCompanyName.Location = new System.Drawing.Point(473, 9);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(341, 86);
            this.lblCompanyName.TabIndex = 9;
            this.lblCompanyName.Text = "MiPi Pizzeria";
            this.lblCompanyName.Click += new System.EventHandler(this.lblCompanyName_Click);
            // 
            // tmrDT
            // 
            this.tmrDT.Enabled = true;
            this.tmrDT.Interval = 1000;
            this.tmrDT.Tick += new System.EventHandler(this.tmrDT_Tick);
            // 
            // frmMiPi
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1294, 612);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpPricing);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.picPizza);
            this.Controls.Add(this.grpOrderInfo);
            this.Controls.Add(this.grpCustomerInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMiPi";
            this.Text = "MiPi Order Entry Program";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMiPi_Load);
            this.grpCustomerInfo.ResumeLayout(false);
            this.grpCustomerInfo.PerformLayout();
            this.grpOrderInfo.ResumeLayout(false);
            this.grpOrderInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuanity)).EndInit();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).EndInit();
            this.grpPayment.ResumeLayout(false);
            this.grpPricing.ResumeLayout(false);
            this.grpPricing.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomerInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.GroupBox grpOrderInfo;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.MaskedTextBox mtbZipCode;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.PictureBox picPizza;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkHamburger;
        private System.Windows.Forms.CheckBox chkOnions;
        private System.Windows.Forms.CheckBox chkPineapple;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.CheckBox chkBlackOlives;
        private System.Windows.Forms.CheckBox chkGreenOlives;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkSausage;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.Label lblMaxQuanity;
        private System.Windows.Forms.NumericUpDown nudQuanity;
        private System.Windows.Forms.Label lblQuanity;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.ComboBox cboPayment;
        private System.Windows.Forms.GroupBox grpPricing;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.CheckBox chkMute;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblCompanyName;
        public System.Windows.Forms.Timer tmrDT;
        private System.Windows.Forms.Label lblPhoneNbrError;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblAddressError;
        private System.Windows.Forms.Label lblCityError;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
    }
}

