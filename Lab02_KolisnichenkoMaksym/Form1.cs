using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_KolisnichenkoMaksym
{
    public partial class Form1 : Form
    {
        bool binaryEnter, hexEnter, decimalEnter;
        public Form1()
        {
            InitializeComponent();
            binaryEnter = true;
            BinaryEnter.Checked = true;
            DecViewP.Visible = false; HexViewP.Visible = false; BinViewP.Visible = false; DecViewKey.Visible = false; HexViewKey.Visible = false; BinViewKey.Visible = false; DecViewC.Visible = false; HexViewC.Visible = false; BinViewC.Visible = false;
            DecViewP1.Visible = false; HexViewP1.Visible = false; BinViewP1.Visible = false; DecViewKey1.Visible = false; HexViewKey1.Visible = false; BinViewKey1.Visible = false; DecViewC1.Visible = false; HexViewC1.Visible = false; BinViewC1.Visible = false;
        }

        private void button_XOR_Click(object sender, EventArgs e)
        {
            try
            {
                if(binaryEnter == true)
                {
                    if (textBox_Value.Text != "" && textBox_Key.Text != "")
                    {
                        string strP = textBox_Value.Text;
                        int intP = Convert.ToInt32(strP, 2);
                        string strKey = textBox_Key.Text;
                        int intKey = Convert.ToInt32(strKey, 2);
                        int intC = intP ^ intKey;
                        string strC = Convert.ToString(intC, 2);
                        textBox_Result.Text = strC;

                        //DecViewP.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 2), 10);
                        //HexViewP.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 2), 16);
                        //BinViewP.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 2), 2);

                        //DecViewKey.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 2), 10);
                        //HexViewKey.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 2), 16);
                        //BinViewKey.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 2), 2);

                        DecViewC.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Result.Text, 2), 10);
                        HexViewC.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Result.Text, 2), 16);
                        BinViewC.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Result.Text, 2), 2);

                        DecViewP.Visible = true; HexViewP.Visible = true; BinViewP.Visible = true; DecViewKey.Visible = true; HexViewKey.Visible = true; BinViewKey.Visible = true; DecViewC.Visible = true; HexViewC.Visible = true; BinViewC.Visible = true;

                        MessageBox.Show("Шифрування виконано");
                    }
                    else if (textBox_Value.Text == "" || textBox_Value.Text == "Введите значение")
                    {
                        MessageBox.Show("Введіть значення");
                    }
                    else if (textBox_Key.Text == "" || textBox_Key.Text == "Введите ключ")
                    {
                        MessageBox.Show("Введіть Ключ");
                    }
                    else
                    {
                        MessageBox.Show("Невірне значення або ключ");
                        textBox_Value.Text = "";
                        textBox_Key.Text = "";
                    }
                }
                if (hexEnter == true)
                {
                    if (textBox_Value.Text != "" && textBox_Key.Text != "")
                    {
                        string strP = textBox_Value.Text;
                        int intP = Convert.ToInt32(strP, 16);
                        string strKey = textBox_Key.Text;
                        int intKey = Convert.ToInt32(strKey, 16);
                        int intC = intP ^ intKey;
                        string strC = Convert.ToString(intC, 16);
                        textBox_Result.Text = strC;

                        //DecViewP.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 16), 10);
                        //HexViewP.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 16), 16);
                        //BinViewP.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 16), 2);

                        //DecViewKey.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 16), 10);
                        //HexViewKey.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 16), 16);
                        //BinViewKey.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 16), 2);

                        DecViewC.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Result.Text, 16), 10);
                        HexViewC.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Result.Text, 16), 16);
                        BinViewC.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Result.Text, 16), 2);

                        DecViewP.Visible = true; HexViewP.Visible = true; BinViewP.Visible = true; DecViewKey.Visible = true; HexViewKey.Visible = true; BinViewKey.Visible = true; DecViewC.Visible = true; HexViewC.Visible = true; BinViewC.Visible = true;

                        MessageBox.Show("Шифрування виконано");
                    }
                    else if (textBox_Value.Text == "" || textBox_Value.Text == "Введите значение")
                    {
                        MessageBox.Show("Введіть значення");
                    }
                    else if (textBox_Key.Text == "" || textBox_Key.Text == "Введите ключ")
                    {
                        MessageBox.Show("Введіть Ключ");
                    }
                    else
                    {
                        MessageBox.Show("Невірне значення або ключ");
                        textBox_Value.Text = "";
                        textBox_Key.Text = "";
                    }
                }
                if (decimalEnter == true)
                {
                    if (textBox_Value.Text != "" && textBox_Key.Text != "")
                    {
                        string strP = textBox_Value.Text;
                        int intP = Convert.ToInt32(strP, 10);
                        string strKey = textBox_Key.Text;
                        int intKey = Convert.ToInt32(strKey, 10);
                        int intC = intP ^ intKey;
                        string strC = Convert.ToString(intC, 10);
                        textBox_Result.Text = strC;

                        //DecViewP.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 10), 10);
                        //HexViewP.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 10), 16);
                        //BinViewP.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 10), 2);

                        //DecViewKey.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 10), 10);
                        //HexViewKey.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 10), 16);
                        //BinViewKey.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 10), 2);

                        DecViewC.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Result.Text, 10), 10);
                        HexViewC.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Result.Text, 10), 16);
                        BinViewC.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Result.Text, 10), 2);

                        DecViewP.Visible = true; HexViewP.Visible = true; BinViewP.Visible = true; DecViewKey.Visible = true; HexViewKey.Visible = true; BinViewKey.Visible = true; DecViewC.Visible = true; HexViewC.Visible = true; BinViewC.Visible = true;

                        MessageBox.Show("Шифрування виконано");
                    }
                    else if (textBox_Value.Text == "" || textBox_Value.Text == "Введите значение")
                    {
                        MessageBox.Show("Введіть значення");
                    }
                    else if (textBox_Key.Text == "" || textBox_Key.Text == "Введите ключ")
                    {
                        MessageBox.Show("Введіть Ключ");
                    }
                    else
                    {
                        MessageBox.Show("Невірне значення або ключ");
                        textBox_Value.Text = "";
                        textBox_Key.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Clean_Click(object sender, EventArgs e)
        {
            textBox_Value.Text = "";
            textBox_Key.Text = "";
            textBox_Result.Text = "";
            DecViewP.Visible = false; HexViewP.Visible = false; BinViewP.Visible = false; DecViewKey.Visible = false; HexViewKey.Visible = false; BinViewKey.Visible = false; DecViewC.Visible = false; HexViewC.Visible = false; BinViewC.Visible = false;
        }

        private void BinaryEnter_CheckedChanged(object sender, EventArgs e)
        {
            binaryEnter = true;
            hexEnter = false;
            decimalEnter = false;
        }

        private void button_XOR1_Click(object sender, EventArgs e)
        {
            try
            {
                if (binaryEnter == true)
                {
                    if (textBox_Value1.Text != "" && textBox_Key1.Text != "")
                    {
                        string strP = textBox_Value1.Text;
                        int intP = Convert.ToInt32(strP, 2);
                        string strKey = textBox_Key1.Text;
                        int intKey = Convert.ToInt32(strKey, 2);
                        int intC = intP ^ intKey;
                        string strC = Convert.ToString(intC, 2);
                        textBox_Result1.Text = strC;

                        //DecViewP1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 2), 10);
                        //HexViewP1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 2), 16);
                        //BinViewP1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 2), 2);

                        //DecViewKey1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 2), 10);
                        //HexViewKey1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 2), 16);
                        //BinViewKey1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 2), 2);

                        DecViewC1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Result1.Text, 2), 10);
                        HexViewC1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Result1.Text, 2), 16);
                        BinViewC1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Result1.Text, 2), 2);

                        DecViewP1.Visible = true; HexViewP1.Visible = true; BinViewP1.Visible = true; DecViewKey1.Visible = true; HexViewKey1.Visible = true; BinViewKey1.Visible = true; DecViewC1.Visible = true; HexViewC1.Visible = true; BinViewC1.Visible = true;

                        MessageBox.Show("Дешифрування виконано");
                    }
                    else if (textBox_Value1.Text == "" || textBox_Value1.Text == "Введите значение")
                    {
                        MessageBox.Show("Введіть значення");
                    }
                    else if (textBox_Key1.Text == "" || textBox_Key1.Text == "Введите ключ")
                    {
                        MessageBox.Show("Введіть Ключ");
                    }
                    else
                    {
                        MessageBox.Show("Невірне значення або ключ");
                        textBox_Value1.Text = "";
                        textBox_Key1.Text = "";
                    }
                }
                if (hexEnter == true)
                {
                    if (textBox_Value1.Text != "" && textBox_Key1.Text != "")
                    {
                        string strP = textBox_Value1.Text;
                        int intP = Convert.ToInt32(strP, 16);
                        string strKey = textBox_Key1.Text;
                        int intKey = Convert.ToInt32(strKey, 16);
                        int intC = intP ^ intKey;
                        string strC = Convert.ToString(intC, 16);
                        textBox_Result1.Text = strC;

                        //DecViewP1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 16), 10);
                        //HexViewP1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 16), 16);
                        //BinViewP1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 16), 2);

                        //DecViewKey1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 16), 10);
                        //HexViewKey1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 16), 16);
                        //BinViewKey1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 16), 2);

                        DecViewC1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Result1.Text, 16), 10);
                        HexViewC1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Result1.Text, 16), 16);
                        BinViewC1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Result1.Text, 16), 2);

                        DecViewP1.Visible = true; HexViewP1.Visible = true; BinViewP1.Visible = true; DecViewKey1.Visible = true; HexViewKey1.Visible = true; BinViewKey1.Visible = true; DecViewC1.Visible = true; HexViewC1.Visible = true; BinViewC1.Visible = true;

                        MessageBox.Show("Дешифрування виконано");
                    }
                    else if (textBox_Value1.Text == "" || textBox_Value1.Text == "Введите значение")
                    {
                        MessageBox.Show("Введіть значення");
                    }
                    else if (textBox_Key1.Text == "" || textBox_Key1.Text == "Введите ключ")
                    {
                        MessageBox.Show("Введіть Ключ");
                    }
                    else
                    {
                        MessageBox.Show("Невірне значення або ключ");
                        textBox_Value1.Text = "";
                        textBox_Key1.Text = "";
                    }
                }
                if (decimalEnter == true)
                {
                    if (textBox_Value1.Text != "" && textBox_Key1.Text != "")
                    {
                        string strP = textBox_Value1.Text;
                        int intP = Convert.ToInt32(strP, 10);
                        string strKey = textBox_Key1.Text;
                        int intKey = Convert.ToInt32(strKey, 10);
                        int intC = intP ^ intKey;
                        string strC = Convert.ToString(intC, 10);
                        textBox_Result1.Text = strC;

                        //DecViewP1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 10), 10);
                        //HexViewP1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 10), 16);
                        //BinViewP1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 10), 2);

                        //DecViewKey1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 10), 10);
                        //HexViewKey1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 10), 16);
                        //BinViewKey1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 10), 2);

                        DecViewC1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Result1.Text, 10), 10);
                        HexViewC1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Result1.Text, 10), 16);
                        BinViewC1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Result1.Text, 10), 2);

                        DecViewP1.Visible = true; HexViewP1.Visible = true; BinViewP1.Visible = true; DecViewKey1.Visible = true; HexViewKey1.Visible = true; BinViewKey1.Visible = true; DecViewC1.Visible = true; HexViewC1.Visible = true; BinViewC1.Visible = true;

                        MessageBox.Show("Дешифрування виконано");
                    }
                    else if (textBox_Value1.Text == "" || textBox_Value1.Text == "Введите значение")
                    {
                        MessageBox.Show("Введіть значення");
                    }
                    else if (textBox_Key1.Text == "" || textBox_Key1.Text == "Введите ключ")
                    {
                        MessageBox.Show("Введіть Ключ");
                    }
                    else
                    {
                        MessageBox.Show("Невірне значення або ключ");
                        textBox_Value1.Text = "";
                        textBox_Key1.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Clean1_Click(object sender, EventArgs e)
        {
            textBox_Value1.Text = "";
            textBox_Key1.Text = "";
            textBox_Result1.Text = "";
            DecViewP1.Visible = false; HexViewP1.Visible = false; BinViewP1.Visible = false; DecViewKey1.Visible = false; HexViewKey1.Visible = false; BinViewKey1.Visible = false; DecViewC1.Visible = false; HexViewC1.Visible = false; BinViewC1.Visible = false;
        }

        private void textBox_Key_Leave(object sender, EventArgs e)
        {
            if (textBox_Key.Text == "")
            {

            }
            else
            {
                DecViewKey.Visible = true; HexViewKey.Visible = true; BinViewKey.Visible = true;
                try
                {
                    if (binaryEnter == true)
                    {
                        DecViewKey.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 2), 10);
                        HexViewKey.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 2), 16);
                        BinViewKey.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 2), 2);
                    }
                    if (hexEnter == true)
                    {
                        DecViewKey.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 16), 10);
                        HexViewKey.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 16), 16);
                        BinViewKey.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 16), 2);
                    }
                    if (decimalEnter == true)
                    {
                        DecViewKey.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 10), 10);
                        HexViewKey.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 10), 16);
                        BinViewKey.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 10), 2);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void textBox_Value_Leave(object sender, EventArgs e)
        {
            if (textBox_Value.Text == "")
            {

            }
            else
            {
                DecViewP.Visible = true; HexViewP.Visible = true; BinViewP.Visible = true;
                try
                {
                    if (binaryEnter == true)
                    {
                        DecViewP.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 2), 10);
                        HexViewP.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 2), 16);
                        BinViewP.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 2), 2);
                    }
                    if (hexEnter == true)
                    {
                        DecViewP.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 16), 10);
                        HexViewP.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 16), 16);
                        BinViewP.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 16), 2);
                    }
                    if (decimalEnter == true)
                    {
                        DecViewP.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 10), 10);
                        HexViewP.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 10), 16);
                        BinViewP.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 10), 2);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void textBox_Value1_Leave(object sender, EventArgs e)
        {
            if (textBox_Value1.Text == "")
            {

            }
            else
            {
                DecViewP1.Visible = true; HexViewP1.Visible = true; BinViewP1.Visible = true;
                try
                {
                    if (binaryEnter == true)
                    {
                        DecViewP1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 2), 10);
                        HexViewP1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 2), 16);
                        BinViewP1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 2), 2);
                    }
                    if (hexEnter == true)
                    {
                        DecViewP1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 16), 10);
                        HexViewP1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 16), 16);
                        BinViewP1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 16), 2);
                    }
                    if (decimalEnter == true)
                    {
                        DecViewP1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 10), 10);
                        HexViewP1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 10), 16);
                        BinViewP1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 10), 2);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void textBox_Key1_Leave(object sender, EventArgs e)
        {
            if (textBox_Key1.Text == "")
            {

            }
            else
            {
                DecViewKey1.Visible = true; HexViewKey1.Visible = true; BinViewKey1.Visible = true;
                try
                {
                    if (binaryEnter == true)
                    {
                        DecViewKey1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 2), 10);
                        HexViewKey1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 2), 16);
                        BinViewKey1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 2), 2);
                    }
                    if (hexEnter == true)
                    {
                        DecViewKey1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 16), 10);
                        HexViewKey1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 16), 16);
                        BinViewKey1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 16), 2);
                    }
                    if (decimalEnter == true)
                    {
                        DecViewKey1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 10), 10);
                        HexViewKey1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 10), 16);
                        BinViewKey1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 10), 2);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DecimalEnter_CheckedChanged(object sender, EventArgs e)
        {
            decimalEnter = true;
            binaryEnter = false;
            hexEnter = false;
        }

        private void HEXEnter_CheckedChanged(object sender, EventArgs e)
        {
            hexEnter = true;
            binaryEnter = false;
            decimalEnter = false;
        }
    }
}
