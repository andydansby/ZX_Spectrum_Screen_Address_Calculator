using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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




        private void X_Position_decimal_ValueChanged(object sender, EventArgs e)
        {
            int decimalValueX = (int)X_Position_decimal.Value;
            int decimalValueY = (int)Y_Position_decimal.Value;

            string hexValue = Convert.ToString(decimalValueX, 16);
            X_Position_HEX.Text = hexValue;

            int x = decimalValueX;
            int y = decimalValueY;

            ushort address;
            byte mask;
            GetScreenAddressAndBit(x, y, out address, out mask);

            // Display the result somewhere on your form
            //output decimal
            screen_address_decimal.Text = address.ToString();
            bitmask_decimal.Text = mask.ToString();

            //output hex
            screen_address_hex.Text = "#" + address.ToString("X4");
            bitmask_hex.Text = "#" + mask.ToString("X2");

            string binaryMask = Convert.ToString(mask, 2).PadLeft(8, '0');
            bitmask_binary.Text = binaryMask;
        }

        private void Y_Position_decimal_ValueChanged(object sender, EventArgs e)
        {
            int decimalValueX = (int)X_Position_decimal.Value;
            int decimalValueY = (int)Y_Position_decimal.Value;

            string hexValue = Convert.ToString(decimalValueY, 16);
            Y_Position_HEX.Text = hexValue;

            int x = decimalValueX;
            int y = decimalValueY;

            ushort address;
            byte mask;
            GetScreenAddressAndBit(x, y, out address, out mask);

            // Display the result somewhere on your form
            //output decimal
            screen_address_decimal.Text = address.ToString();
            bitmask_decimal.Text = mask.ToString();

            //output hex
            screen_address_hex.Text = "#" + address.ToString("X4");
            bitmask_hex.Text = "#" + mask.ToString("X2");

            string binaryMask = Convert.ToString(mask, 2).PadLeft(8, '0');
            bitmask_binary.Text = binaryMask;
        }
    }
}
