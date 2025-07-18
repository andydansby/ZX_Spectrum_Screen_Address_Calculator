﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/// code by Andy Dansby

namespace ZX_Spectrum_Screen_Address_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            Ink_Selection.SelectedIndex = 0;
            Paper_Selection.SelectedIndex = 7;
            
        }

        public static class Globals
        {
            public static int brightBit = 0;
            public static int flashBit = 0;
            public static int paperBits = 0;
            public static int inkBits = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Source Calculator for the ZX Spectrum" + "\n" + "to calculate the Screen address and Attribute mask" + "\n" + "Written by: Andy Dansby" + "\n\n" + "source available at" + "\n" + "github.com/andydansby/ZX_Spectrum_Screen_Address_Calculator");
        }


    /// <summary>
    /// Calculator
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="address"></param>
    /// <param name="bitMask"></param>
    
        private void GetScreenAddressAndBit(int x, int y, out ushort address, out byte bitMask)
        {
            int baseAddress = 0x4000;
            int row = (y & 0xC0) << 5;
            int line = (y & 0x07) << 8;
            int block = (y & 0x38) << 2;
            int column = x >> 3;

            address = (ushort)(baseAddress + row + line + block + column);
            bitMask = (byte)(1 << (7 - (x & 0x07)));
        }

        private int GetAttributeAddress(int x, int y)
        {
            return 0x5800 + (y / 8) * 32 + (x / 8);
        }

        private void X_Position_decimal_ValueChanged(object sender, EventArgs e)
        {
            //read numericUpDown
            int decimalValueX = (int)X_Position_decimal.Value;
            int decimalValueY = (int)Y_Position_decimal.Value;

            //convert it to hex
            string hexValue = Convert.ToString(decimalValueX, 16);
            //write text
            X_Position_HEX.Text = hexValue;

            int x = decimalValueX;
            int y = decimalValueY;

            ushort address;
            byte mask;
            //convert it to ZX Spectrum display address and bitmask
            GetScreenAddressAndBit(x, y, out address, out mask);

            // Display the result in textbox
            //output decimal
            screen_address_decimal.Text = address.ToString();
            bitmask_decimal.Text = mask.ToString();

            //convert it to hex
            screen_address_hex.Text = "#" + address.ToString("X4");
            bitmask_hex.Text = "#" + mask.ToString("X2");

            //convert bit mask to binary
            string binaryMask = Convert.ToString(mask, 2).PadLeft(8, '0');
            //display it in textbox
            bitmask_binary.Text = binaryMask;

            //convert pixel address to character block
            characterBlockX.Text = Convert.ToString(x / 8);

            //convert character block to hex
            characterHexX.Text = "#" + (x/8).ToString("X2");

            //convert pixel position to attribute address
            int attrAddr = GetAttributeAddress(x, y);
            attributeDec.Text = attrAddr.ToString();
            attributeHex.Text = "#" + attrAddr.ToString("X2");
        }

        private void Y_Position_decimal_ValueChanged(object sender, EventArgs e)
        {
            //read numericUpDown
            int decimalValueX = (int)X_Position_decimal.Value;
            int decimalValueY = (int)Y_Position_decimal.Value;

            //convert it to hex
            string hexValue = Convert.ToString(decimalValueY, 16);
            //write text
            Y_Position_HEX.Text = hexValue;

            int x = decimalValueX;
            int y = decimalValueY;

            ushort address;
            byte mask;
            //convert it to ZX Spectrum display address and bitmask
            GetScreenAddressAndBit(x, y, out address, out mask);

            // Display the result in textbox
            //output decimal
            screen_address_decimal.Text = address.ToString();
            bitmask_decimal.Text = mask.ToString();

            //convert it to hex
            screen_address_hex.Text = "#" + address.ToString("X4");
            bitmask_hex.Text = "#" + mask.ToString("X2");

            //convert bit mask to binary
            string binaryMask = Convert.ToString(mask, 2).PadLeft(8, '0');
            bitmask_binary.Text = binaryMask;

            //convert pixel address to character block
            characterBlockY.Text = Convert.ToString(y / 8);
            characterHexY.Text = "#" + (y / 8).ToString("X2");

            //convert pixel position to attribute address
            int attrAddr = GetAttributeAddress(x, y);
            attributeDec.Text = attrAddr.ToString();
            attributeHex.Text = "#" + attrAddr.ToString("X2");
        }

        //https://en.wikipedia.org/wiki/ZX_Spectrum_graphic_modes


/*
F	B	P2	P1	P0	I2	I1	I0
INK
Black 0		000000 = 0
Blue 1		000001 = 1
Red 2		000010 = 2
Magenta 3	000011 = 3
Green 4		000100 = 4
Cyan  5		000101 = 5
Yellow 6	000110 = 6
White 7		000111 = 7

PAPER
Black 0		000000 = 0 
Blue 1		001000 = 8
Red 2		010000 = 16
Magenta 3	011000 = 24
Green 4		100000 = 32
Cyan  5		101000 = 40
Yellow 6	110000 = 48
White 7		111000 = 56
*/


        /// <summary>
        /// Attributes
        /// https://www.overtakenbyevents.com/lets-talk-about-the-zx-specrum-screen-layout/
        /// 128   064   032     016     008     004     002     001
        /// FL    BR    P2      P1      P0      I2      I1      I0
        /// </summary>
        private void UpdateInkColor()
        {
            /// BLACK
            if (bright_on.Checked == false && Ink_Selection.SelectedItem.ToString() == "Black")
            {
                Ink_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                Ink_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                Output_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                Globals.inkBits = 0;
                Globals.brightBit = 0;
            }
            /// BLACK
            if (bright_on.Checked == true && Ink_Selection.SelectedItem.ToString() == "Black")
            {
                Ink_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                Ink_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                Output_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                Globals.inkBits = 0;
                Globals.brightBit = 64;
            }

            /// BLUE DARK
            if (bright_on.Checked == false && Ink_Selection.SelectedItem.ToString() == "Blue")
            {
                Ink_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#0100CE");
                Ink_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                Output_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0100CE");
                Globals.inkBits = 1;
                Globals.brightBit = 0;
            }
            /// BLUE BRIGHT
            if (bright_on.Checked == true && Ink_Selection.SelectedItem.ToString() == "Blue")
            {
                Ink_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#0200FD");
                Ink_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                Output_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0200FD");
                Globals.inkBits = 1;
                Globals.brightBit = 64;
            }

            /// RED DARK
            if (bright_on.Checked == false && Ink_Selection.SelectedItem.ToString() == "Red")
            {
                Ink_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#CF0100");
                Ink_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                Output_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#CF0100");
                Globals.inkBits = 2;
                Globals.brightBit = 0;
            }
            /// RED BRIGHT
            if (bright_on.Checked == true && Ink_Selection.SelectedItem.ToString() == "Red")
            {
                Ink_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0201");
                Ink_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                Output_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF0201");
                Globals.inkBits = 2;
                Globals.brightBit = 64;
            }

            /// MAGNETA DARK
            if (bright_on.Checked == false && Ink_Selection.SelectedItem.ToString() == "Magenta")
            {
                Ink_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#CF01CE");
                Ink_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                Output_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#CF01CE");
                Globals.inkBits = 3;
                Globals.brightBit = 0;
            }
            /// MAGNETA BRIGHT
            if (bright_on.Checked == true && Ink_Selection.SelectedItem.ToString() == "Magenta")
            {
                Ink_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF02FD");
                Ink_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                Output_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF02FD");
                Globals.inkBits = 3;
                Globals.brightBit = 64;
            }
            /// GREEN DARK
            if (bright_on.Checked == false && Ink_Selection.SelectedItem.ToString() == "Green")
            {
                Ink_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#00CF15");
                Ink_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                Output_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#00CF15");
                Globals.inkBits = 4;
                Globals.brightBit = 0;
            }
            /// GREEN BRIGHT
            if (bright_on.Checked == true && Ink_Selection.SelectedItem.ToString() == "Green")
            {
                Ink_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#00FF1C");
                Ink_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                Output_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#00FF1C");
                Globals.inkBits = 4;
                Globals.brightBit = 64;
            }
            /// CYAN DARK
            if (bright_on.Checked == false && Ink_Selection.SelectedItem.ToString() == "Cyan")
            {
                Ink_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#01CFCF");
                Ink_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                Output_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#01CFCF");
                Globals.inkBits = 5;
                Globals.brightBit = 0;
            }
            /// CYAN BRIGHT
            if (bright_on.Checked == true && Ink_Selection.SelectedItem.ToString() == "Cyan")
            {
                Ink_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#02FFFF");
                Ink_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                Output_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#02FFFF");
                Globals.inkBits = 5;
                Globals.brightBit = 64;
            }

            /// YELLOW DARK
            if (bright_on.Checked == false && Ink_Selection.SelectedItem.ToString() == "Yellow")
            {
                Ink_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#CFCF15");
                Ink_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                Output_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#CFCF15");
                Globals.inkBits = 6;
                Globals.brightBit = 0;
            }
            /// YELLOW BRIGHT
            if (bright_on.Checked == true && Ink_Selection.SelectedItem.ToString() == "Yellow")
            {
                Ink_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFF1D");
                Ink_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                Output_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFF1D");
                Globals.inkBits = 6;
                Globals.brightBit = 64;
            }

            /// WHITE DARK
            if (bright_on.Checked == false && Ink_Selection.SelectedItem.ToString() == "White")
            {
                Ink_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#CFCFCF");
                Ink_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                Output_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#CFCFCF");
                Globals.inkBits = 7;
                Globals.brightBit = 0;
            }
            /// WHITE BRIGHT
            if (bright_on.Checked == true && Ink_Selection.SelectedItem.ToString() == "White")
            {
                Ink_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                Ink_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                Output_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                Globals.inkBits = 7;
                Globals.brightBit = 64;
            }
        }

        private void UpdatePaperColor()
        {
            /// BLACK
            if (bright_on.Checked == false && Paper_Selection.SelectedItem.ToString() == "Black")
            {
                Paper_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                Paper_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                Output_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                Globals.paperBits = 0;
                Globals.brightBit = 0;
            }
            /// BLACK
            if (bright_on.Checked == true && Paper_Selection.SelectedItem.ToString() == "Black")
            {
                Paper_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                Paper_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                Output_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                Globals.paperBits = 0;
                Globals.brightBit = 64;
            }
            
            /// BLUE DARK
            if (bright_on.Checked == false && Paper_Selection.SelectedItem.ToString() == "Blue")
            {
                Paper_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#0100CE");
                Paper_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                Output_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#0100CE");
                Globals.paperBits = 8;
                Globals.brightBit = 0;
            }
            /// BLUE BRIGHT
            if (bright_on.Checked == true && Paper_Selection.SelectedItem.ToString() == "Blue")
            {
                Paper_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#0200FD");
                Paper_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                Output_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#0200FD");
                Globals.paperBits = 8;
                Globals.brightBit = 64;
            }
            
            /// RED DARK
            if (bright_on.Checked == false && Paper_Selection.SelectedItem.ToString() == "Red")
            {
                Paper_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#CF0100");
                Paper_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                Output_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#CF0100");
                Globals.paperBits = 16;
                Globals.brightBit = 0;
            }
            /// RED BRIGHT
            if (bright_on.Checked == true && Paper_Selection.SelectedItem.ToString() == "Red")
            {
                Paper_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0201");
                Paper_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                Output_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0201");
                Globals.paperBits = 16;
                Globals.brightBit = 64;
            }
            
            /// MAGNETA DARK
            if (bright_on.Checked == false && Paper_Selection.SelectedItem.ToString() == "Magenta")
            {
                Paper_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#CF01CE");
                Paper_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                Output_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#CF01CE");
                Globals.paperBits = 24;
                Globals.brightBit = 0;
            }
            /// MAGNETA BRIGHT
            if (bright_on.Checked == true && Paper_Selection.SelectedItem.ToString() == "Magenta")
            {
                Paper_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF02FD");
                Paper_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                Output_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF02FD");
                Globals.paperBits = 24;
                Globals.brightBit = 64;
            }
            
            /// GREEN DARK
            if (bright_on.Checked == false && Paper_Selection.SelectedItem.ToString() == "Green")
            {
                Paper_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#00CF15");
                Paper_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                Output_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#00CF15");
                Globals.paperBits = 32;
                Globals.brightBit = 0;
            }
            /// GREEN BRIGHT
            if (bright_on.Checked == true && Paper_Selection.SelectedItem.ToString() == "Green")
            {
                Paper_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#00FF1C");
                Paper_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                Output_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#00FF1C");
                Globals.paperBits = 32;
                Globals.brightBit = 64;
            }
            
            /// CYAN DARK
            if (bright_on.Checked == false && Paper_Selection.SelectedItem.ToString() == "Cyan")
            {
                Paper_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#01CFCF");
                Paper_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                Output_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#01CFCF");
                Globals.paperBits = 40;
                Globals.brightBit = 0;
            }
            /// CYAN BRIGHT
            if (bright_on.Checked == true && Paper_Selection.SelectedItem.ToString() == "Cyan")
            {
                Paper_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#02FFFF");
                Paper_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                Output_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#02FFFF");
                Globals.paperBits = 40;
                Globals.brightBit = 64;
            }
            
            /// YELLOW DARK
            if (bright_on.Checked == false && Paper_Selection.SelectedItem.ToString() == "Yellow")
            {
                Paper_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#CFCF15");
                Paper_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                Output_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#CFCF15");
                Globals.paperBits = 48;
                Globals.brightBit = 0;
            }
            /// YELLOW BRIGHT
            if (bright_on.Checked == true && Paper_Selection.SelectedItem.ToString() == "Yellow")
            {
                Paper_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFF1D");
                Paper_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                Output_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFF1D");
                Globals.paperBits = 48;
                Globals.brightBit = 64;
            }
            
            /// WHITE DARK
            if (bright_on.Checked == false && Paper_Selection.SelectedItem.ToString() == "White")
            {
                Paper_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#CFCFCF");
                Paper_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                Output_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#CFCFCF");
                Globals.paperBits = 56;
                Globals.brightBit = 0;
            }
            /// WHITE BRIGHT
            if (bright_on.Checked == true && Paper_Selection.SelectedItem.ToString() == "White")
            {
                Paper_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                Paper_Color.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                Output_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                Globals.paperBits = 56;
                Globals.brightBit = 64;
            }
        }

        private void Ink_Selection_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInkColor();
            attributeBits();
        }

        private void Paper_Selection_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePaperColor();
            attributeBits();
        }

        private void bright_on_CheckedChanged(object sender, EventArgs e)
        {
            UpdateInkColor();
            UpdatePaperColor();
            attributeBits();
        }

        private void attributeBits()
        {
            int outputBits = Globals.flashBit + Globals.brightBit + Globals.paperBits + Globals.inkBits;

            //attribute_out_DEC
            //attribute_out_BIN

            // Display the result in textbox
            //output decimal
            attribute_out_DEC.Text = outputBits.ToString();

            //convert it to hex
            attribute_out_HEX.Text = "#" + outputBits.ToString("X2");
            //bitmask_hex.Text = "#" + mask.ToString("X2");

            //convert it to binary
            string binaryMask = Convert.ToString(outputBits, 2).PadLeft(8, '0');
            attribute_out_BIN.Text = binaryMask;

            //convert it to Octal
            attribute_out_OCT.Text = "0x" + Convert.ToString(outputBits, 8);

            // Display the result in textbox
            //output decimal
            //screen_address_decimal.Text = address.ToString();
            //bitmask_decimal.Text = mask.ToString();

            //convert it to hex
            //screen_address_hex.Text = "#" + address.ToString("X4");
            //bitmask_hex.Text = "#" + mask.ToString("X2");
        }

        /// Flasher
        private void flash_on_CheckedChanged(object sender, EventArgs e)
        {
            if (flash_on.Checked)
            {
                //MessageBox.Show("Timer On");
                timer1.Start();
                Globals.flashBit = 128;
            }
            else
            {
                //MessageBox.Show("Timer Off");
                timer1.Stop();
                Output_Color.BackColor = Paper_Color.BackColor;
                Output_Color.ForeColor = Ink_Color.BackColor;
                Globals.flashBit = 0;
            }
            attributeBits();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var originalPaper = Paper_Color.BackColor;
            var originalInk = Ink_Color.BackColor;

            var oppositeInk = Paper_Color.BackColor;
            var oppositePaper = Ink_Color.BackColor;

            if (flash_on.Checked == true)
            {
                if (Output_Color.BackColor == originalPaper)
                {
                    Output_Color.BackColor = oppositePaper;
                    Output_Color.ForeColor = oppositeInk;
                }
                else
                {
                    Output_Color.BackColor = originalPaper;
                    Output_Color.ForeColor = originalInk;
                }
            }
        }

        /// <summary>
        /// Calculator 2
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="address"></param>
        /// <param name="bitMask"></param>
        private int characterAttributeAddress(int x, int y)
        {
            return 0x5800 + y * 32 + x;
        }


        /*
        private void GetScreenAddressAndBit(int x, int y, out ushort address, out byte bitMask)
        {
            int baseAddress = 0x4000;
            int row = (y & 0xC0) << 5;
            int line = (y & 0x07) << 8;
            int block = (y & 0x38) << 2;
            int column = x >> 3;

            address = (ushort)(baseAddress + row + line + block + column);
            bitMask = (byte)(1 << (7 - (x & 0x07)));
        }
        */

        public static int GetScreenAddress(int pixelX, int pixelY)
        {
            // ZX Spectrum screen address layout:
            // Bits 13-11: row block (rows 0–7, 8–15, etc.)
            // Bits 10-8:  line within block (0–7)
            // Bits 7-5:   character row within block (0–7)
            // Bits 4-0:   column (0–31)
            //int pixelX = charX * 8;
            //int pixelY = charY * 8;

            // Start of screen memory
            int baseAddress = 0x4000;
            int row = (pixelY & 0xC0) << 5;
            int line = (pixelY & 0x07) << 8;
            int block = (pixelY & 0x38) << 2;
            int column = pixelX >> 3;

            ushort address = (ushort)(baseAddress + row + line + block + column);

            return address;
        }

        /*
        public static int GetScreenAddress(int charX, int charY)
        {
            // ZX Spectrum screen address layout:
            // Bits 13-11: row block (rows 0–7, 8–15, etc.)
            // Bits 10-8:  line within block (0–7)
            // Bits 7-5:   character row within block (0–7)
            // Bits 4-0:   column (0–31)
            int pixelX = charX * 8;
            int pixelY = charY * 8;

            // Start of screen memory
            int baseAddress = 0x4000;
            int row = (pixelY & 0xC0) << 5;
            int line = (pixelY & 0x07) << 8;
            int block = (pixelY & 0x38) << 2;
            int column = pixelX >> 3;

            ushort address = (ushort)(baseAddress + row + line + block + column);

            return address;
        }*/

        /*public static int GetScreenAddress(int charX, int charY)
        {
            int pixelX = charX * 8;
            int pixelY = charY * 8;

            // Start of screen memory
            int address = 0x4000;

            // ZX Spectrum screen address layout:
            // Bits 13-11: row block (rows 0–7, 8–15, etc.)
            // Bits 10-8:  line within block (0–7)
            // Bits 7-5:   character row within block (0–7)
            // Bits 4-0:   column (0–31)

            address |= (pixelY & 0xC0) << 5;  // bits 7-6 (row block)
            address |= (pixelY & 0x07) << 8;  // bits 2-0 (line within 8-line character block)
            address |= (pixelY & 0x38) << 2;  // bits 5-3 (character row within block)
            address |= pixelX >> 3;          // column (0–31)

            return address;
        }*/

        private void Char_address_X_ValueChanged(object sender, EventArgs e)
        {
            int address = (int)Char_address_X.Value;
            int pixel_X = (int)Char_address_X.Value * 8;
            int pixel_Y = (int)Char_address_Y.Value * 8;
            int charX = (int)Char_address_X.Value;
            int charY = (int)Char_address_Y.Value;

            //convert it to hex
            Char_address_X_HEX.Text = "#" + address.ToString("X2");

            //calculate attribute address
            //to fix
            int output = characterAttributeAddress(charX, charY);
            char_attribute_address.Text = output.ToString();

            //convert address to HEX
            //to fix
            char_attribute_address_HEX.Text = "#" + output.ToString("X4");
            
            //calculate addresses
            int address1 = GetScreenAddress(pixel_X, pixel_Y);
            int address2 = GetScreenAddress(pixel_X, pixel_Y + 1);
            int address3 = GetScreenAddress(pixel_X, pixel_Y + 2);
            int address4 = GetScreenAddress(pixel_X, pixel_Y + 3);
            int address5 = GetScreenAddress(pixel_X, pixel_Y + 4);
            int address6 = GetScreenAddress(pixel_X, pixel_Y + 5);
            int address7 = GetScreenAddress(pixel_X, pixel_Y + 6);
            int address8 = GetScreenAddress(pixel_X, pixel_Y + 7);

            //print address as decimal number
            pixel_address_block.Clear();
            pixel_address_block.AppendText(string.Format("{0}\r\n", address1));
            pixel_address_block.AppendText(string.Format("{0}\r\n", address2));
            pixel_address_block.AppendText(string.Format("{0}\r\n", address3));
            pixel_address_block.AppendText(string.Format("{0}\r\n", address4));
            pixel_address_block.AppendText(string.Format("{0}\r\n", address5));
            pixel_address_block.AppendText(string.Format("{0}\r\n", address6));
            pixel_address_block.AppendText(string.Format("{0}\r\n", address7));
            pixel_address_block.AppendText(string.Format("{0}\r", address8));
            //convert address to HEX
            pixel_address_block_HEX.Clear();
            pixel_address_block_HEX.AppendText(string.Format("#{0:X4}\r\n", address1));
            pixel_address_block_HEX.AppendText(string.Format("#{0:X4}\r\n", address2));
            pixel_address_block_HEX.AppendText(string.Format("#{0:X4}\r\n", address3));
            pixel_address_block_HEX.AppendText(string.Format("#{0:X4}\r\n", address4));
            pixel_address_block_HEX.AppendText(string.Format("#{0:X4}\r\n", address5));
            pixel_address_block_HEX.AppendText(string.Format("#{0:X4}\r\n", address6));
            pixel_address_block_HEX.AppendText(string.Format("#{0:X4}\r\n", address7));
            pixel_address_block_HEX.AppendText(string.Format("#{0:X4}\r", address8));
        }

        private void Char_address_Y_ValueChanged(object sender, EventArgs e)
        {
            int address = (int)Char_address_Y.Value;
            int pixel_X = (int)Char_address_X.Value * 8;
            int pixel_Y = (int)Char_address_Y.Value * 8;
            int charX = (int)Char_address_X.Value;
            int charY = (int)Char_address_Y.Value;

            //convert it to hex
            Char_address_Y_HEX.Text = "#" + address.ToString("X2");

            //calculate attribute address
            int output = characterAttributeAddress(charX, charY);
            char_attribute_address.Text = output.ToString();

            //convert address to HEX
            char_attribute_address_HEX.Text = "#" + output.ToString("X4");

            //calculate addresses
            int address1 = GetScreenAddress(pixel_X, pixel_Y);
            int address2 = GetScreenAddress(pixel_X, pixel_Y + 1);
            int address3 = GetScreenAddress(pixel_X, pixel_Y + 2);
            int address4 = GetScreenAddress(pixel_X, pixel_Y + 3);
            int address5 = GetScreenAddress(pixel_X, pixel_Y + 4);
            int address6 = GetScreenAddress(pixel_X, pixel_Y + 5);
            int address7 = GetScreenAddress(pixel_X, pixel_Y + 6);
            int address8 = GetScreenAddress(pixel_X, pixel_Y + 7);

            //print address as decimal number
            pixel_address_block.Clear();
            pixel_address_block.AppendText(string.Format("{0}\r\n", address1));
            pixel_address_block.AppendText(string.Format("{0}\r\n", address2));
            pixel_address_block.AppendText(string.Format("{0}\r\n", address3));
            pixel_address_block.AppendText(string.Format("{0}\r\n", address4));
            pixel_address_block.AppendText(string.Format("{0}\r\n", address5));
            pixel_address_block.AppendText(string.Format("{0}\r\n", address6));
            pixel_address_block.AppendText(string.Format("{0}\r\n", address7));
            pixel_address_block.AppendText(string.Format("{0}\r", address8));
            //convert address to HEX
            pixel_address_block_HEX.Clear();
            pixel_address_block_HEX.AppendText(string.Format("#{0:X4}\r\n", address1));
            pixel_address_block_HEX.AppendText(string.Format("#{0:X4}\r\n", address2));
            pixel_address_block_HEX.AppendText(string.Format("#{0:X4}\r\n", address3));
            pixel_address_block_HEX.AppendText(string.Format("#{0:X4}\r\n", address4));
            pixel_address_block_HEX.AppendText(string.Format("#{0:X4}\r\n", address5));
            pixel_address_block_HEX.AppendText(string.Format("#{0:X4}\r\n", address6));
            pixel_address_block_HEX.AppendText(string.Format("#{0:X4}\r\n", address7));
            pixel_address_block_HEX.AppendText(string.Format("#{0:X4}\r", address8));
        }






    }
}
