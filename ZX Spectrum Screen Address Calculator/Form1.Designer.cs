namespace ZX_Spectrum_Screen_Address_Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.X_Position_decimal = new System.Windows.Forms.NumericUpDown();
            this.Y_Position_decimal = new System.Windows.Forms.NumericUpDown();
            this.X_Position_HEX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Y_Position_HEX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.screen_address_decimal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bitmask_decimal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bitmask_binary = new System.Windows.Forms.TextBox();
            this.screen_address_hex = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bitmask_hex = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.characterBlockX = new System.Windows.Forms.TextBox();
            this.characterBlockY = new System.Windows.Forms.TextBox();
            this.characterHexY = new System.Windows.Forms.TextBox();
            this.characterHexX = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.attributeDec = new System.Windows.Forms.TextBox();
            this.attributeHex = new System.Windows.Forms.TextBox();
            this.Ink_Color = new System.Windows.Forms.Button();
            this.Paper_Color = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Ink_Selection = new System.Windows.Forms.ListBox();
            this.Paper_Selection = new System.Windows.Forms.ListBox();
            this.bright_on = new System.Windows.Forms.CheckBox();
            this.flash_on = new System.Windows.Forms.CheckBox();
            this.Output_Color = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.attribute_out_BIN = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.attribute_out_DEC = new System.Windows.Forms.TextBox();
            this.attribute_out_HEX = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.attribute_out_OCT = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.Char_address_X = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.Char_address_Y = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.Char_address_Y_HEX = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.Char_address_X_HEX = new System.Windows.Forms.TextBox();
            this.char_attribute_address_HEX = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.char_attribute_address = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.pixel_address_block = new System.Windows.Forms.TextBox();
            this.pixel_address_block_HEX = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.X_Position_decimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_Position_decimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Char_address_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Char_address_Y)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pixel X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pixel Y";
            // 
            // X_Position_decimal
            // 
            this.X_Position_decimal.Location = new System.Drawing.Point(15, 20);
            this.X_Position_decimal.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.X_Position_decimal.Name = "X_Position_decimal";
            this.X_Position_decimal.Size = new System.Drawing.Size(51, 20);
            this.X_Position_decimal.TabIndex = 2;
            this.X_Position_decimal.ValueChanged += new System.EventHandler(this.X_Position_decimal_ValueChanged);
            // 
            // Y_Position_decimal
            // 
            this.Y_Position_decimal.Location = new System.Drawing.Point(15, 60);
            this.Y_Position_decimal.Maximum = new decimal(new int[] {
            191,
            0,
            0,
            0});
            this.Y_Position_decimal.Name = "Y_Position_decimal";
            this.Y_Position_decimal.Size = new System.Drawing.Size(51, 20);
            this.Y_Position_decimal.TabIndex = 3;
            this.Y_Position_decimal.ValueChanged += new System.EventHandler(this.Y_Position_decimal_ValueChanged);
            // 
            // X_Position_HEX
            // 
            this.X_Position_HEX.Location = new System.Drawing.Point(89, 20);
            this.X_Position_HEX.Name = "X_Position_HEX";
            this.X_Position_HEX.ReadOnly = true;
            this.X_Position_HEX.Size = new System.Drawing.Size(56, 20);
            this.X_Position_HEX.TabIndex = 4;
            this.X_Position_HEX.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pixel X Hex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pixel Y Hex";
            // 
            // Y_Position_HEX
            // 
            this.Y_Position_HEX.Location = new System.Drawing.Point(90, 60);
            this.Y_Position_HEX.Name = "Y_Position_HEX";
            this.Y_Position_HEX.ReadOnly = true;
            this.Y_Position_HEX.Size = new System.Drawing.Size(56, 20);
            this.Y_Position_HEX.TabIndex = 6;
            this.Y_Position_HEX.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Screen Address";
            // 
            // screen_address_decimal
            // 
            this.screen_address_decimal.Location = new System.Drawing.Point(177, 20);
            this.screen_address_decimal.Name = "screen_address_decimal";
            this.screen_address_decimal.ReadOnly = true;
            this.screen_address_decimal.Size = new System.Drawing.Size(79, 20);
            this.screen_address_decimal.TabIndex = 10;
            this.screen_address_decimal.Text = "16384";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Bit Mask Decimal";
            // 
            // bitmask_decimal
            // 
            this.bitmask_decimal.Location = new System.Drawing.Point(177, 60);
            this.bitmask_decimal.Name = "bitmask_decimal";
            this.bitmask_decimal.ReadOnly = true;
            this.bitmask_decimal.Size = new System.Drawing.Size(56, 20);
            this.bitmask_decimal.TabIndex = 11;
            this.bitmask_decimal.Text = "128";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Bit Mask Binary";
            // 
            // bitmask_binary
            // 
            this.bitmask_binary.Location = new System.Drawing.Point(364, 60);
            this.bitmask_binary.Name = "bitmask_binary";
            this.bitmask_binary.ReadOnly = true;
            this.bitmask_binary.Size = new System.Drawing.Size(56, 20);
            this.bitmask_binary.TabIndex = 13;
            this.bitmask_binary.Text = "10000000";
            // 
            // screen_address_hex
            // 
            this.screen_address_hex.Location = new System.Drawing.Point(280, 20);
            this.screen_address_hex.Name = "screen_address_hex";
            this.screen_address_hex.ReadOnly = true;
            this.screen_address_hex.Size = new System.Drawing.Size(79, 20);
            this.screen_address_hex.TabIndex = 16;
            this.screen_address_hex.Text = "#4000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Screen Address Hex";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Bit Mask Hex";
            // 
            // bitmask_hex
            // 
            this.bitmask_hex.Location = new System.Drawing.Point(280, 60);
            this.bitmask_hex.Name = "bitmask_hex";
            this.bitmask_hex.ReadOnly = true;
            this.bitmask_hex.Size = new System.Drawing.Size(56, 20);
            this.bitmask_hex.TabIndex = 17;
            this.bitmask_hex.Text = "#80";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(469, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "---------------------------------------------------------------------------------" +
                "-------------------------------------------------------------------------";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Character X dec";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(197, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Character Y dec";
            // 
            // characterBlockX
            // 
            this.characterBlockX.Location = new System.Drawing.Point(15, 100);
            this.characterBlockX.Name = "characterBlockX";
            this.characterBlockX.ReadOnly = true;
            this.characterBlockX.Size = new System.Drawing.Size(56, 20);
            this.characterBlockX.TabIndex = 22;
            this.characterBlockX.Text = "0";
            // 
            // characterBlockY
            // 
            this.characterBlockY.Location = new System.Drawing.Point(200, 100);
            this.characterBlockY.Name = "characterBlockY";
            this.characterBlockY.ReadOnly = true;
            this.characterBlockY.Size = new System.Drawing.Size(56, 20);
            this.characterBlockY.TabIndex = 23;
            this.characterBlockY.Text = "0";
            // 
            // characterHexY
            // 
            this.characterHexY.Location = new System.Drawing.Point(290, 100);
            this.characterHexY.Name = "characterHexY";
            this.characterHexY.ReadOnly = true;
            this.characterHexY.Size = new System.Drawing.Size(56, 20);
            this.characterHexY.TabIndex = 27;
            this.characterHexY.Text = "0";
            // 
            // characterHexX
            // 
            this.characterHexX.Location = new System.Drawing.Point(109, 100);
            this.characterHexX.Name = "characterHexX";
            this.characterHexX.ReadOnly = true;
            this.characterHexX.Size = new System.Drawing.Size(56, 20);
            this.characterHexX.TabIndex = 26;
            this.characterHexX.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(287, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Character Y Hex";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(106, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Character X Hex";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Attribute Address dec";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(127, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Attribute Address Hex";
            // 
            // attributeDec
            // 
            this.attributeDec.Location = new System.Drawing.Point(15, 140);
            this.attributeDec.Name = "attributeDec";
            this.attributeDec.ReadOnly = true;
            this.attributeDec.Size = new System.Drawing.Size(56, 20);
            this.attributeDec.TabIndex = 30;
            this.attributeDec.Text = "0";
            // 
            // attributeHex
            // 
            this.attributeHex.Location = new System.Drawing.Point(130, 140);
            this.attributeHex.Name = "attributeHex";
            this.attributeHex.ReadOnly = true;
            this.attributeHex.Size = new System.Drawing.Size(56, 20);
            this.attributeHex.TabIndex = 31;
            this.attributeHex.Text = "0";
            // 
            // Ink_Color
            // 
            this.Ink_Color.Location = new System.Drawing.Point(202, 385);
            this.Ink_Color.Name = "Ink_Color";
            this.Ink_Color.Size = new System.Drawing.Size(68, 21);
            this.Ink_Color.TabIndex = 32;
            this.Ink_Color.Text = "INK";
            this.Ink_Color.UseVisualStyleBackColor = true;
            // 
            // Paper_Color
            // 
            this.Paper_Color.Location = new System.Drawing.Point(119, 385);
            this.Paper_Color.Name = "Paper_Color";
            this.Paper_Color.Size = new System.Drawing.Size(68, 21);
            this.Paper_Color.TabIndex = 33;
            this.Paper_Color.Text = "PAPER";
            this.Paper_Color.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(214, 366);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Ink";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(130, 366);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Paper";
            // 
            // Ink_Selection
            // 
            this.Ink_Selection.FormattingEnabled = true;
            this.Ink_Selection.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Red",
            "Magenta",
            "Green",
            "Cyan",
            "Yellow",
            "White"});
            this.Ink_Selection.Location = new System.Drawing.Point(202, 415);
            this.Ink_Selection.Name = "Ink_Selection";
            this.Ink_Selection.Size = new System.Drawing.Size(68, 108);
            this.Ink_Selection.TabIndex = 36;
            this.Ink_Selection.SelectedIndexChanged += new System.EventHandler(this.Ink_Selection_SelectedIndexChanged);
            // 
            // Paper_Selection
            // 
            this.Paper_Selection.FormattingEnabled = true;
            this.Paper_Selection.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Red",
            "Magenta",
            "Green",
            "Cyan",
            "Yellow",
            "White"});
            this.Paper_Selection.Location = new System.Drawing.Point(119, 415);
            this.Paper_Selection.Name = "Paper_Selection";
            this.Paper_Selection.Size = new System.Drawing.Size(68, 108);
            this.Paper_Selection.TabIndex = 37;
            this.Paper_Selection.SelectedIndexChanged += new System.EventHandler(this.Paper_Selection_SelectedIndexChanged);
            // 
            // bright_on
            // 
            this.bright_on.AutoSize = true;
            this.bright_on.Location = new System.Drawing.Point(71, 365);
            this.bright_on.Name = "bright_on";
            this.bright_on.Size = new System.Drawing.Size(53, 17);
            this.bright_on.TabIndex = 40;
            this.bright_on.Text = "Bright";
            this.bright_on.UseVisualStyleBackColor = true;
            this.bright_on.CheckedChanged += new System.EventHandler(this.bright_on_CheckedChanged);
            // 
            // flash_on
            // 
            this.flash_on.AutoSize = true;
            this.flash_on.Location = new System.Drawing.Point(12, 365);
            this.flash_on.Name = "flash_on";
            this.flash_on.Size = new System.Drawing.Size(51, 17);
            this.flash_on.TabIndex = 41;
            this.flash_on.Text = "Flash";
            this.flash_on.UseVisualStyleBackColor = true;
            this.flash_on.CheckedChanged += new System.EventHandler(this.flash_on_CheckedChanged);
            // 
            // Output_Color
            // 
            this.Output_Color.Location = new System.Drawing.Point(9, 340);
            this.Output_Color.Name = "Output_Color";
            this.Output_Color.Size = new System.Drawing.Size(148, 21);
            this.Output_Color.TabIndex = 42;
            this.Output_Color.Text = "OUTPUT Color";
            this.Output_Color.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // attribute_out_BIN
            // 
            this.attribute_out_BIN.Location = new System.Drawing.Point(15, 405);
            this.attribute_out_BIN.Name = "attribute_out_BIN";
            this.attribute_out_BIN.ReadOnly = true;
            this.attribute_out_BIN.Size = new System.Drawing.Size(56, 20);
            this.attribute_out_BIN.TabIndex = 43;
            this.attribute_out_BIN.Text = "00111000";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 390);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "Color Binary";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 510);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 13);
            this.label20.TabIndex = 45;
            this.label20.Text = "Color Decimal";
            // 
            // attribute_out_DEC
            // 
            this.attribute_out_DEC.Location = new System.Drawing.Point(15, 525);
            this.attribute_out_DEC.Name = "attribute_out_DEC";
            this.attribute_out_DEC.ReadOnly = true;
            this.attribute_out_DEC.Size = new System.Drawing.Size(56, 20);
            this.attribute_out_DEC.TabIndex = 46;
            this.attribute_out_DEC.Text = "56";
            // 
            // attribute_out_HEX
            // 
            this.attribute_out_HEX.Location = new System.Drawing.Point(15, 445);
            this.attribute_out_HEX.Name = "attribute_out_HEX";
            this.attribute_out_HEX.ReadOnly = true;
            this.attribute_out_HEX.Size = new System.Drawing.Size(56, 20);
            this.attribute_out_HEX.TabIndex = 48;
            this.attribute_out_HEX.Text = "#38";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 430);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 13);
            this.label21.TabIndex = 47;
            this.label21.Text = "Color Hex";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // attribute_out_OCT
            // 
            this.attribute_out_OCT.Location = new System.Drawing.Point(15, 485);
            this.attribute_out_OCT.Name = "attribute_out_OCT";
            this.attribute_out_OCT.ReadOnly = true;
            this.attribute_out_OCT.Size = new System.Drawing.Size(56, 20);
            this.attribute_out_OCT.TabIndex = 51;
            this.attribute_out_OCT.Text = "0x70";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 470);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 13);
            this.label22.TabIndex = 50;
            this.label22.Text = "Color Octal";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 325);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(469, 13);
            this.label23.TabIndex = 52;
            this.label23.Text = "---------------------------------------------------------------------------------" +
                "-------------------------------------------------------------------------";
            // 
            // Char_address_X
            // 
            this.Char_address_X.Location = new System.Drawing.Point(15, 185);
            this.Char_address_X.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.Char_address_X.Name = "Char_address_X";
            this.Char_address_X.Size = new System.Drawing.Size(51, 20);
            this.Char_address_X.TabIndex = 54;
            this.Char_address_X.ValueChanged += new System.EventHandler(this.Char_address_X_ValueChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(13, 170);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(63, 13);
            this.label24.TabIndex = 53;
            this.label24.Text = "Character X";
            // 
            // Char_address_Y
            // 
            this.Char_address_Y.Location = new System.Drawing.Point(15, 225);
            this.Char_address_Y.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.Char_address_Y.Name = "Char_address_Y";
            this.Char_address_Y.Size = new System.Drawing.Size(51, 20);
            this.Char_address_Y.TabIndex = 56;
            this.Char_address_Y.ValueChanged += new System.EventHandler(this.Char_address_Y_ValueChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(14, 210);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 13);
            this.label25.TabIndex = 55;
            this.label25.Text = "Character Y";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(86, 210);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(61, 13);
            this.label26.TabIndex = 60;
            this.label26.Text = "Char Y Hex";
            // 
            // Char_address_Y_HEX
            // 
            this.Char_address_Y_HEX.Location = new System.Drawing.Point(90, 225);
            this.Char_address_Y_HEX.Name = "Char_address_Y_HEX";
            this.Char_address_Y_HEX.ReadOnly = true;
            this.Char_address_Y_HEX.Size = new System.Drawing.Size(56, 20);
            this.Char_address_Y_HEX.TabIndex = 59;
            this.Char_address_Y_HEX.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(87, 170);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(61, 13);
            this.label27.TabIndex = 58;
            this.label27.Text = "Char X Hex";
            // 
            // Char_address_X_HEX
            // 
            this.Char_address_X_HEX.Location = new System.Drawing.Point(89, 185);
            this.Char_address_X_HEX.Name = "Char_address_X_HEX";
            this.Char_address_X_HEX.ReadOnly = true;
            this.Char_address_X_HEX.Size = new System.Drawing.Size(56, 20);
            this.Char_address_X_HEX.TabIndex = 57;
            this.Char_address_X_HEX.Text = "0";
            // 
            // char_attribute_address_HEX
            // 
            this.char_attribute_address_HEX.Location = new System.Drawing.Point(15, 305);
            this.char_attribute_address_HEX.Name = "char_attribute_address_HEX";
            this.char_attribute_address_HEX.ReadOnly = true;
            this.char_attribute_address_HEX.Size = new System.Drawing.Size(79, 20);
            this.char_attribute_address_HEX.TabIndex = 64;
            this.char_attribute_address_HEX.Text = "#5800";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(12, 290);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(109, 13);
            this.label28.TabIndex = 63;
            this.label28.Text = "Attribute Address Hex";
            // 
            // char_attribute_address
            // 
            this.char_attribute_address.Location = new System.Drawing.Point(15, 265);
            this.char_attribute_address.Name = "char_attribute_address";
            this.char_attribute_address.ReadOnly = true;
            this.char_attribute_address.Size = new System.Drawing.Size(79, 20);
            this.char_attribute_address.TabIndex = 62;
            this.char_attribute_address.Text = "22528";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(12, 250);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(87, 13);
            this.label29.TabIndex = 61;
            this.label29.Text = "Attribute Address";
            // 
            // pixel_address_block
            // 
            this.pixel_address_block.Location = new System.Drawing.Point(177, 185);
            this.pixel_address_block.Multiline = true;
            this.pixel_address_block.Name = "pixel_address_block";
            this.pixel_address_block.ReadOnly = true;
            this.pixel_address_block.Size = new System.Drawing.Size(79, 115);
            this.pixel_address_block.TabIndex = 65;
            this.pixel_address_block.Text = "16384\r\n16640\r\n16896\r\n17152\r\n17408\r\n17664\r\n17920\r\n18176";
            // 
            // pixel_address_block_HEX
            // 
            this.pixel_address_block_HEX.Location = new System.Drawing.Point(280, 185);
            this.pixel_address_block_HEX.Multiline = true;
            this.pixel_address_block_HEX.Name = "pixel_address_block_HEX";
            this.pixel_address_block_HEX.ReadOnly = true;
            this.pixel_address_block_HEX.Size = new System.Drawing.Size(79, 116);
            this.pixel_address_block_HEX.TabIndex = 66;
            this.pixel_address_block_HEX.Text = "#4000\r\n#4100\r\n#4200\r\n#4300\r\n#4400\r\n#4500\r\n#4600\r\n#4700";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(172, 170);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(98, 13);
            this.label30.TabIndex = 67;
            this.label30.Text = "Pixel address block";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(274, 170);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(123, 13);
            this.label31.TabIndex = 68;
            this.label31.Text = "Pixel address block HEX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 551);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.pixel_address_block_HEX);
            this.Controls.Add(this.pixel_address_block);
            this.Controls.Add(this.char_attribute_address_HEX);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.char_attribute_address);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.Char_address_Y_HEX);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.Char_address_X_HEX);
            this.Controls.Add(this.Char_address_Y);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.Char_address_X);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.attribute_out_OCT);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.attribute_out_HEX);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.attribute_out_DEC);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.attribute_out_BIN);
            this.Controls.Add(this.Output_Color);
            this.Controls.Add(this.flash_on);
            this.Controls.Add(this.bright_on);
            this.Controls.Add(this.Paper_Selection);
            this.Controls.Add(this.Ink_Selection);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Paper_Color);
            this.Controls.Add(this.Ink_Color);
            this.Controls.Add(this.attributeHex);
            this.Controls.Add(this.attributeDec);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.characterHexY);
            this.Controls.Add(this.characterHexX);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.characterBlockY);
            this.Controls.Add(this.characterBlockX);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bitmask_hex);
            this.Controls.Add(this.screen_address_hex);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bitmask_binary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bitmask_decimal);
            this.Controls.Add(this.screen_address_decimal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Y_Position_HEX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.X_Position_HEX);
            this.Controls.Add(this.Y_Position_decimal);
            this.Controls.Add(this.X_Position_decimal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ZX Spectrum Display Calculator 0.45";
            ((System.ComponentModel.ISupportInitialize)(this.X_Position_decimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_Position_decimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Char_address_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Char_address_Y)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown X_Position_decimal;
        private System.Windows.Forms.NumericUpDown Y_Position_decimal;
        private System.Windows.Forms.TextBox X_Position_HEX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Y_Position_HEX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox screen_address_decimal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bitmask_decimal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bitmask_binary;
        private System.Windows.Forms.TextBox screen_address_hex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox bitmask_hex;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox characterBlockX;
        private System.Windows.Forms.TextBox characterBlockY;
        private System.Windows.Forms.TextBox characterHexY;
        private System.Windows.Forms.TextBox characterHexX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox attributeDec;
        private System.Windows.Forms.TextBox attributeHex;
        private System.Windows.Forms.Button Ink_Color;
        private System.Windows.Forms.Button Paper_Color;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox Ink_Selection;
        private System.Windows.Forms.ListBox Paper_Selection;
        internal System.Windows.Forms.CheckBox flash_on;
        private System.Windows.Forms.Button Output_Color;
        internal System.Windows.Forms.CheckBox bright_on;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox attribute_out_BIN;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox attribute_out_DEC;
        private System.Windows.Forms.TextBox attribute_out_HEX;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox attribute_out_OCT;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown Char_address_X;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown Char_address_Y;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox Char_address_Y_HEX;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox Char_address_X_HEX;
        private System.Windows.Forms.TextBox char_attribute_address_HEX;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox char_attribute_address;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox pixel_address_block;
        private System.Windows.Forms.TextBox pixel_address_block_HEX;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
    }
}

