namespace ERP.Forms.Master
{
    partial class SuppliersFrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SupplierNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GSTINCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSupplier = new System.Windows.Forms.TextBox();
            this.labelItemSupplier = new System.Windows.Forms.Label();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.textBoxGSTIN = new System.Windows.Forms.TextBox();
            this.labelGSTIN = new System.Windows.Forms.Label();
            this.textBoxLegalName = new System.Windows.Forms.TextBox();
            this.labelLegalName = new System.Windows.Forms.Label();
            this.labelTaxpayerType = new System.Windows.Forms.Label();
            this.comboBoxTaxpayerType = new System.Windows.Forms.ComboBox();
            this.textBoxAddress1 = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxActive = new System.Windows.Forms.ComboBox();
            this.labelActive = new System.Windows.Forms.Label();
            this.textBoxPAN = new System.Windows.Forms.TextBox();
            this.labelPAN = new System.Windows.Forms.Label();
            this.textBoxWebsite = new System.Windows.Forms.TextBox();
            this.labelWebsite = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxMobile = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelMobile = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.textBoxStateCode = new System.Windows.Forms.TextBox();
            this.labelStateCode = new System.Windows.Forms.Label();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.labelState = new System.Windows.Forms.Label();
            this.labelPIN = new System.Windows.Forms.Label();
            this.textBoxPIN = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxAddress2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierNameCol,
            this.GSTINCol,
            this.CityCol,
            this.MobileCol});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 161);
            this.dataGridView1.TabIndex = 28;
            // 
            // SupplierNameCol
            // 
            this.SupplierNameCol.HeaderText = "Supplier Name";
            this.SupplierNameCol.Name = "SupplierNameCol";
            this.SupplierNameCol.ReadOnly = true;
            // 
            // GSTINCol
            // 
            this.GSTINCol.HeaderText = "GSTIN";
            this.GSTINCol.Name = "GSTINCol";
            this.GSTINCol.ReadOnly = true;
            // 
            // CityCol
            // 
            this.CityCol.HeaderText = "City";
            this.CityCol.Name = "CityCol";
            this.CityCol.ReadOnly = true;
            // 
            // MobileCol
            // 
            this.MobileCol.HeaderText = "Mobile";
            this.MobileCol.Name = "MobileCol";
            this.MobileCol.ReadOnly = true;
            // 
            // textBoxSupplier
            // 
            this.textBoxSupplier.Location = new System.Drawing.Point(80, 38);
            this.textBoxSupplier.Name = "textBoxSupplier";
            this.textBoxSupplier.Size = new System.Drawing.Size(390, 20);
            this.textBoxSupplier.TabIndex = 16;
            // 
            // labelItemSupplier
            // 
            this.labelItemSupplier.AutoSize = true;
            this.labelItemSupplier.Location = new System.Drawing.Point(12, 41);
            this.labelItemSupplier.Name = "labelItemSupplier";
            this.labelItemSupplier.Size = new System.Drawing.Size(45, 13);
            this.labelItemSupplier.TabIndex = 20;
            this.labelItemSupplier.Text = "Supplier";
            // 
            // iconButtonSave
            // 
            this.iconButtonSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconButtonSave.IconColor = System.Drawing.Color.Black;
            this.iconButtonSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSave.IconSize = 30;
            this.iconButtonSave.Location = new System.Drawing.Point(632, 234);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Size = new System.Drawing.Size(75, 45);
            this.iconButtonSave.TabIndex = 26;
            this.iconButtonSave.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(713, 234);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 45);
            this.iconButton1.TabIndex = 28;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // textBoxGSTIN
            // 
            this.textBoxGSTIN.Location = new System.Drawing.Point(80, 12);
            this.textBoxGSTIN.Name = "textBoxGSTIN";
            this.textBoxGSTIN.Size = new System.Drawing.Size(319, 20);
            this.textBoxGSTIN.TabIndex = 33;
            // 
            // labelGSTIN
            // 
            this.labelGSTIN.AutoSize = true;
            this.labelGSTIN.Location = new System.Drawing.Point(12, 15);
            this.labelGSTIN.Name = "labelGSTIN";
            this.labelGSTIN.Size = new System.Drawing.Size(40, 13);
            this.labelGSTIN.TabIndex = 34;
            this.labelGSTIN.Text = "GSTIN";
            // 
            // textBoxLegalName
            // 
            this.textBoxLegalName.Location = new System.Drawing.Point(80, 64);
            this.textBoxLegalName.Name = "textBoxLegalName";
            this.textBoxLegalName.Size = new System.Drawing.Size(390, 20);
            this.textBoxLegalName.TabIndex = 35;
            // 
            // labelLegalName
            // 
            this.labelLegalName.AutoSize = true;
            this.labelLegalName.Location = new System.Drawing.Point(12, 67);
            this.labelLegalName.Name = "labelLegalName";
            this.labelLegalName.Size = new System.Drawing.Size(64, 13);
            this.labelLegalName.TabIndex = 36;
            this.labelLegalName.Text = "Legal Name";
            // 
            // labelTaxpayerType
            // 
            this.labelTaxpayerType.AutoSize = true;
            this.labelTaxpayerType.Location = new System.Drawing.Point(480, 15);
            this.labelTaxpayerType.Name = "labelTaxpayerType";
            this.labelTaxpayerType.Size = new System.Drawing.Size(78, 13);
            this.labelTaxpayerType.TabIndex = 38;
            this.labelTaxpayerType.Text = "Taxpayer Type";
            // 
            // comboBoxTaxpayerType
            // 
            this.comboBoxTaxpayerType.FormattingEnabled = true;
            this.comboBoxTaxpayerType.Items.AddRange(new object[] {
            "Regular",
            "Composition"});
            this.comboBoxTaxpayerType.Location = new System.Drawing.Point(564, 12);
            this.comboBoxTaxpayerType.Name = "comboBoxTaxpayerType";
            this.comboBoxTaxpayerType.Size = new System.Drawing.Size(215, 21);
            this.comboBoxTaxpayerType.TabIndex = 39;
            // 
            // textBoxAddress1
            // 
            this.textBoxAddress1.Location = new System.Drawing.Point(80, 90);
            this.textBoxAddress1.Name = "textBoxAddress1";
            this.textBoxAddress1.Size = new System.Drawing.Size(390, 20);
            this.textBoxAddress1.TabIndex = 40;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(12, 93);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 41;
            this.labelAddress.Text = "Address";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxActive);
            this.panel1.Controls.Add(this.labelActive);
            this.panel1.Controls.Add(this.textBoxPAN);
            this.panel1.Controls.Add(this.labelPAN);
            this.panel1.Controls.Add(this.textBoxWebsite);
            this.panel1.Controls.Add(this.labelWebsite);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.textBoxMobile);
            this.panel1.Controls.Add(this.textBoxPhone);
            this.panel1.Controls.Add(this.labelMobile);
            this.panel1.Controls.Add(this.labelPhone);
            this.panel1.Controls.Add(this.comboBoxCountry);
            this.panel1.Controls.Add(this.labelCountry);
            this.panel1.Controls.Add(this.textBoxStateCode);
            this.panel1.Controls.Add(this.labelStateCode);
            this.panel1.Controls.Add(this.comboBoxState);
            this.panel1.Controls.Add(this.labelState);
            this.panel1.Controls.Add(this.labelPIN);
            this.panel1.Controls.Add(this.textBoxPIN);
            this.panel1.Controls.Add(this.labelCity);
            this.panel1.Controls.Add(this.textBoxCity);
            this.panel1.Controls.Add(this.textBoxAddress2);
            this.panel1.Controls.Add(this.labelAddress);
            this.panel1.Controls.Add(this.textBoxAddress1);
            this.panel1.Controls.Add(this.comboBoxTaxpayerType);
            this.panel1.Controls.Add(this.labelTaxpayerType);
            this.panel1.Controls.Add(this.labelLegalName);
            this.panel1.Controls.Add(this.textBoxLegalName);
            this.panel1.Controls.Add(this.labelGSTIN);
            this.panel1.Controls.Add(this.textBoxGSTIN);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.iconButtonSave);
            this.panel1.Controls.Add(this.labelItemSupplier);
            this.panel1.Controls.Add(this.textBoxSupplier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 289);
            this.panel1.TabIndex = 27;
            // 
            // comboBoxActive
            // 
            this.comboBoxActive.FormattingEnabled = true;
            this.comboBoxActive.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxActive.Location = new System.Drawing.Point(632, 207);
            this.comboBoxActive.Name = "comboBoxActive";
            this.comboBoxActive.Size = new System.Drawing.Size(156, 21);
            this.comboBoxActive.TabIndex = 66;
            // 
            // labelActive
            // 
            this.labelActive.AutoSize = true;
            this.labelActive.Location = new System.Drawing.Point(589, 210);
            this.labelActive.Name = "labelActive";
            this.labelActive.Size = new System.Drawing.Size(37, 13);
            this.labelActive.TabIndex = 65;
            this.labelActive.Text = "Active";
            // 
            // textBoxPAN
            // 
            this.textBoxPAN.Location = new System.Drawing.Point(564, 41);
            this.textBoxPAN.Name = "textBoxPAN";
            this.textBoxPAN.Size = new System.Drawing.Size(184, 20);
            this.textBoxPAN.TabIndex = 64;
            // 
            // labelPAN
            // 
            this.labelPAN.AutoSize = true;
            this.labelPAN.Location = new System.Drawing.Point(480, 41);
            this.labelPAN.Name = "labelPAN";
            this.labelPAN.Size = new System.Drawing.Size(29, 13);
            this.labelPAN.TabIndex = 63;
            this.labelPAN.Text = "PAN";
            // 
            // textBoxWebsite
            // 
            this.textBoxWebsite.Location = new System.Drawing.Point(80, 248);
            this.textBoxWebsite.Name = "textBoxWebsite";
            this.textBoxWebsite.Size = new System.Drawing.Size(390, 20);
            this.textBoxWebsite.TabIndex = 62;
            // 
            // labelWebsite
            // 
            this.labelWebsite.AutoSize = true;
            this.labelWebsite.Location = new System.Drawing.Point(12, 251);
            this.labelWebsite.Name = "labelWebsite";
            this.labelWebsite.Size = new System.Drawing.Size(46, 13);
            this.labelWebsite.TabIndex = 61;
            this.labelWebsite.Text = "Website";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(80, 222);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(391, 20);
            this.textBoxEmail.TabIndex = 60;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 225);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(36, 13);
            this.labelEmail.TabIndex = 59;
            this.labelEmail.Text = "E-Mail";
            // 
            // textBoxMobile
            // 
            this.textBoxMobile.Location = new System.Drawing.Point(324, 196);
            this.textBoxMobile.Name = "textBoxMobile";
            this.textBoxMobile.Size = new System.Drawing.Size(146, 20);
            this.textBoxMobile.TabIndex = 58;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(80, 196);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(146, 20);
            this.textBoxPhone.TabIndex = 57;
            // 
            // labelMobile
            // 
            this.labelMobile.AutoSize = true;
            this.labelMobile.Location = new System.Drawing.Point(287, 199);
            this.labelMobile.Name = "labelMobile";
            this.labelMobile.Size = new System.Drawing.Size(38, 13);
            this.labelMobile.TabIndex = 56;
            this.labelMobile.Text = "Mobile";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(12, 199);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(38, 13);
            this.labelPhone.TabIndex = 54;
            this.labelPhone.Text = "Phone";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "The Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo, Democratic Republic of the",
            "Congo, Republic of the",
            "Costa Rica",
            "Côte d’Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor (Timor-Leste)",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "The Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea, North",
            "Korea, South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia, Federated States of",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar (Burma)",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Macedonia",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Sudan, South",
            "Suriname",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.comboBoxCountry.Location = new System.Drawing.Point(80, 171);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(146, 21);
            this.comboBoxCountry.TabIndex = 53;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(12, 176);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCountry.TabIndex = 52;
            this.labelCountry.Text = "Country";
            // 
            // textBoxStateCode
            // 
            this.textBoxStateCode.Location = new System.Drawing.Point(564, 168);
            this.textBoxStateCode.Name = "textBoxStateCode";
            this.textBoxStateCode.Size = new System.Drawing.Size(74, 20);
            this.textBoxStateCode.TabIndex = 51;
            // 
            // labelStateCode
            // 
            this.labelStateCode.AutoSize = true;
            this.labelStateCode.Location = new System.Drawing.Point(480, 171);
            this.labelStateCode.Name = "labelStateCode";
            this.labelStateCode.Size = new System.Drawing.Size(60, 13);
            this.labelStateCode.TabIndex = 49;
            this.labelStateCode.Text = "State Code";
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "Other",
            "Andaman and Nicobar Islands",
            "Andhra Pradesh",
            "Arunachal Pradesh",
            "Assam",
            "Bihar",
            "Chandigarh",
            "Chhattisgarh",
            "Dadra and Nagar Haveli and Daman and Diu",
            "Delhi",
            "Goa",
            "Gujarat",
            "Haryana",
            "Himachal Pradesh",
            "Jammu and Kashmir",
            "Jharkhand",
            "Karnataka",
            "Kerala",
            "Ladakh",
            "Lakshadweep",
            "Madhya Pradesh",
            "Maharashtra",
            "Manipur",
            "Meghalaya",
            "Mizoram",
            "Nagaland",
            "Odisha",
            "Puducherry",
            "Punjab",
            "Rajasthan",
            "Sikkim",
            "Tamil Nadu",
            "Telangana",
            "Tripura",
            "Uttar Pradesh",
            "Uttarakhand",
            "West Bengal"});
            this.comboBoxState.Location = new System.Drawing.Point(325, 168);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(146, 21);
            this.comboBoxState.TabIndex = 48;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(287, 171);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(32, 13);
            this.labelState.TabIndex = 47;
            this.labelState.Text = "State";
            // 
            // labelPIN
            // 
            this.labelPIN.AutoSize = true;
            this.labelPIN.Location = new System.Drawing.Point(287, 145);
            this.labelPIN.Name = "labelPIN";
            this.labelPIN.Size = new System.Drawing.Size(25, 13);
            this.labelPIN.TabIndex = 46;
            this.labelPIN.Text = "PIN";
            // 
            // textBoxPIN
            // 
            this.textBoxPIN.Location = new System.Drawing.Point(324, 142);
            this.textBoxPIN.Name = "textBoxPIN";
            this.textBoxPIN.Size = new System.Drawing.Size(146, 20);
            this.textBoxPIN.TabIndex = 45;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(12, 145);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 44;
            this.labelCity.Text = "City";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(80, 142);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(146, 20);
            this.textBoxCity.TabIndex = 43;
            // 
            // textBoxAddress2
            // 
            this.textBoxAddress2.Location = new System.Drawing.Point(80, 116);
            this.textBoxAddress2.Name = "textBoxAddress2";
            this.textBoxAddress2.Size = new System.Drawing.Size(390, 20);
            this.textBoxAddress2.TabIndex = 42;
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Suppliers";
            this.Text = "Suppliers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSupplier;
        private System.Windows.Forms.Label labelItemSupplier;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox textBoxGSTIN;
        private System.Windows.Forms.Label labelGSTIN;
        private System.Windows.Forms.TextBox textBoxLegalName;
        private System.Windows.Forms.Label labelLegalName;
        private System.Windows.Forms.Label labelTaxpayerType;
        private System.Windows.Forms.ComboBox comboBoxTaxpayerType;
        private System.Windows.Forms.TextBox textBoxAddress1;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPIN;
        private System.Windows.Forms.TextBox textBoxPIN;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxAddress2;
        private System.Windows.Forms.TextBox textBoxStateCode;
        private System.Windows.Forms.Label labelStateCode;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.TextBox textBoxMobile;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxWebsite;
        private System.Windows.Forms.Label labelWebsite;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPAN;
        private System.Windows.Forms.Label labelPAN;
        private System.Windows.Forms.ComboBox comboBoxActive;
        private System.Windows.Forms.Label labelActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GSTINCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileCol;
    }
}