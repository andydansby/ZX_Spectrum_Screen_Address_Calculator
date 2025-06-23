using System;
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
        }

        
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
    }
}
