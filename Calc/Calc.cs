using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Calc
{
    public partial class mainForm : Form
    {
        float firstNum = 0, secondNum = 0, result;
        int operatorFlag = 0;
        Boolean isResult;
        Boolean isInputing; // Default value of Boolean is false in C#. 

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.displayLabel;
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(displayLabel.Text);
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String pasteText = Clipboard.GetText();
            float Num;
            bool isNum = float.TryParse(pasteText, out Num);    // 判断剪贴板中文本是否为数字
            if (isNum)
            {
                displayLabel.Text = pasteText.ToString();
            }
        }

        private void ViewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://kangod.diandian.com/post/2013-10-15/help-for-the-calculator");
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutCalcForm aboutCalcForm = new AboutCalcForm();
            aboutCalcForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckIfResult();    //若屏显是结果，清除之
            CheckIfZero();  //若屏显为字符0，清除之
            CheckIfInputing();  //若为假，清除屏显
            /* 新建isInputing变量原因：1)若operatorFlag非0时清屏，则点击"="后数字会直接附加到屏显之后；
             * 2)若不用此变量，buttonPuls()中改为 !isResult 时调用CalcResult()，则首次+(-* /)时不会调用CalcResult()置isResult为0，
             * 再点击数字键会附加在firstNum之后造成secondNum的错误输入(即使初始isResult置1，输入firstNum时也会点击数字键将其置false)
             */
            displayLabel.Text = displayLabel.Text + "1";
            this.ActiveControl = this.displayLabel; // 去掉得到焦点时的蓝色边框(丑)，顺便禁用了 Enter 键
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckIfResult();
            CheckIfZero();
            CheckIfInputing();
            displayLabel.Text = displayLabel.Text + "2";
            this.ActiveControl = this.displayLabel;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckIfResult();
            CheckIfZero();
            CheckIfInputing();
            displayLabel.Text = displayLabel.Text + "3";
            this.ActiveControl = this.displayLabel;
        }

        #region button 4~9
        private void button4_Click(object sender, EventArgs e)
        {
            CheckIfResult();
            CheckIfZero();
            CheckIfInputing();
            displayLabel.Text = displayLabel.Text + "4";
            this.ActiveControl = this.displayLabel;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CheckIfResult();
            CheckIfZero();
            CheckIfInputing();
            displayLabel.Text = displayLabel.Text + "5";
            this.ActiveControl = this.displayLabel;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CheckIfResult();
            CheckIfZero();
            CheckIfInputing();
            displayLabel.Text = displayLabel.Text + "6";
            this.ActiveControl = this.displayLabel;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CheckIfResult();
            CheckIfZero();
            CheckIfInputing();
            displayLabel.Text = displayLabel.Text + "7";
            this.ActiveControl = this.displayLabel;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CheckIfResult();
            CheckIfZero();
            CheckIfInputing();
            displayLabel.Text = displayLabel.Text + "8";
            this.ActiveControl = this.displayLabel;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CheckIfResult();
            CheckIfZero();
            CheckIfInputing();
            displayLabel.Text = displayLabel.Text + "9";
            this.ActiveControl = this.displayLabel;
        }
        #endregion

        private void button0_Click(object sender, EventArgs e)
        {
            CheckIfResult();
            CheckIfZero();
            CheckIfInputing();
            displayLabel.Text = displayLabel.Text + "0";
            this.ActiveControl = this.displayLabel;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (isResult == true)
            {
                displayLabel.Text = "0";
                isResult = false;
            }
            if (isInputing == false)
            {
                displayLabel.Text = "0";
                isInputing = true;
            }
            if (displayLabel.Text.IndexOf('.') == -1)
            {
                displayLabel.Text = displayLabel.Text + ".";
            }
            this.ActiveControl = this.displayLabel;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            /* 
             * 若isInputing=false则仅改变operatorFlag，避免换运算符时引起不需要的运算
             * eg. 依次按键 1 - + 2 = 得 3，"-" 作废
             * buttonResult()改变isResult和operatorFlag不改变isInputing 
             */
            if (isInputing)
            {
                isInputing = false;
                // 为实现连续运算，每次点击运算符时先计算出前面的结果
                if (operatorFlag != 0)
                {
                    CalcResult();
                }
                firstNum = Convert.ToSingle(displayLabel.Text);
            }
            operatorFlag = 1;
            this.ActiveControl = this.displayLabel;
        }

        #region button -*/
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (isInputing)
            {
                isInputing = false;
                if (operatorFlag != 0)
                {
                    CalcResult();
                }
                firstNum = Convert.ToSingle(displayLabel.Text);
            }
            operatorFlag = 2;
            this.ActiveControl = this.displayLabel;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (isInputing)
            {
                isInputing = false;
                if (operatorFlag != 0)
                {
                    CalcResult();
                }
                firstNum = Convert.ToSingle(displayLabel.Text);
            }
            operatorFlag = 3;
            this.ActiveControl = this.displayLabel;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (isInputing)
            {
                isInputing = false;
                if (operatorFlag != 0)
                {
                    CalcResult();
                }
                firstNum = Convert.ToSingle(displayLabel.Text);
            }
            operatorFlag = 4;
            this.ActiveControl = this.displayLabel;
        }
        #endregion 

        private void buttonResult_Click(object sender, EventArgs e)
        {
            CalcResult();
            operatorFlag = 0;   //若不置0，点击=后再点击+-/*时会使用置零前的运算符进行一次不需要的运算
            this.ActiveControl = this.displayLabel;
        }

        private void CalcResult()
        {
            secondNum = Convert.ToSingle(displayLabel.Text);

            switch (operatorFlag)
            {
                case 0:
                    result = secondNum; // operatorFlag = 0，此时不需进行与 firstNumber 的运算
                    break;
                case 1:
                    result = firstNum + secondNum;
                    break;
                case 2:
                    result = firstNum - secondNum;
                    break;
                case 3:
                    result = firstNum * secondNum;
                    break;
                case 4:
                    if (secondNum != 0)
                    {
                        result = firstNum / secondNum;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Divisor can not be 0. ");
                    }
                    break;
            }

            displayLabel.Text = result.ToString();
            isResult = true;
        }

        private void CheckIfResult()
        {
            if (isResult == true)
            {
                displayLabel.Text = "";
                isResult = false;
            }
        }

        // Called before num button to avoid display like "001"
        private void CheckIfZero()
        {
            if (displayLabel.Text == "0")
                displayLabel.Text = "";
        }

        private void CheckIfInputing()
        {
            if (isInputing == false)
            {
                displayLabel.Text = "";
                isInputing = true;
            }
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (displayLabel.Text.Length > 1)
            {
                displayLabel.Text = displayLabel.Text.Remove(displayLabel.Text.Length - 1);
            }
            else if (displayLabel.Text.Length == 1)
            {
                displayLabel.Text = "0";
            }
            this.ActiveControl = this.displayLabel;
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "0";
            this.ActiveControl = this.displayLabel;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "0";
            firstNum = 0;
            secondNum = 0;
            operatorFlag = 0;
            this.ActiveControl = this.displayLabel;
        }

        private void buttonChangeSign_Click(object sender, EventArgs e)
        {
            if (displayLabel.Text.IndexOf("-") == -1)
            {
                displayLabel.Text = "-" + displayLabel.Text;
            }
            else if (displayLabel.Text.IndexOf("-") >= 0)
            {
                displayLabel.Text = displayLabel.Text.Remove(0, 1);
            }
            this.ActiveControl = this.displayLabel;
        }

        private void buttonSquareRoot_Click(object sender, EventArgs e)
        {
            displayLabel.Text = Math.Sqrt(Convert.ToSingle(displayLabel.Text)).ToString();
            this.ActiveControl = this.displayLabel;
        }

        private void buttonPercentage_Click(object sender, EventArgs e)
        {
            float percentageNum = Convert.ToSingle(displayLabel.Text) / 100;
            displayLabel.Text = percentageNum.ToString();
            float tempNum = firstNum * percentageNum;
            displayLabel.Text = tempNum.ToString();
            CalcResult();
            this.ActiveControl = this.displayLabel;
            
        }

        private void buttonReciprocal_Click(object sender, EventArgs e)
        {
            if (displayLabel.Text != "0" && displayLabel.Text != "0.")
            {
                displayLabel.Text = (1 / Convert.ToSingle(displayLabel.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Cannot divide by zero. ");
            }
            this.ActiveControl = this.displayLabel;
        }

        private void mainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // All KeyPress Event of displayLabel is disabled, only needed event will occur. 
            //if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || (Keys)e.KeyChar == Keys.Decimal || (Keys)e.KeyChar == Keys.Back || (Keys)e.KeyChar == Keys.Escape || (Keys)e.KeyChar == Keys.Add || (Keys)e.KeyChar == Keys.Subtract || (Keys)e.KeyChar == Keys.Multiply || (Keys)e.KeyChar == Keys.Divide))
            //{
            //    e.Handled = true;
            //}
            int inputKey = (int)e.KeyChar;
            switch (inputKey)
            {
                // ASCII code table http://learn.akae.cn/media/images/app-encoding.ascii.png
                case 8:
                    buttonBackspace_Click(sender, e);
                    break;
                case 27:
                    buttonClear_Click(sender, e);
                    break;
                case 37:
                    buttonPercentage_Click(sender, e);
                    break;
                case 42:
                    buttonMultiply_Click(sender, e);
                    break;
                case 43:
                    buttonPlus_Click(sender, e);
                    break;
                case 45:
                    buttonMinus_Click(sender, e);
                    break;
                case 46:
                    buttonDot_Click(sender, e);
                    break;
                case 47:
                    buttonDivide_Click(sender, e);
                    break;
                #region number button
                case 48:
                    button0_Click(sender, e);
                    break;
                case 49:
                    button1_Click(sender, e);
                    break;
                case 50:
                    button2_Click(sender, e);
                    break;
                case 51:
                    button3_Click(sender, e);
                    break;
                case 52:
                    button4_Click(sender, e);
                    break;
                case 53:
                    button5_Click(sender, e);
                    break;
                case 54:
                    button6_Click(sender, e);
                    break;
                case 55:
                    button7_Click(sender, e);
                    break;
                case 56:
                    button8_Click(sender, e);
                    break;
                case 57:
                    button9_Click(sender, e);
                    break;
                #endregion
                case 61:
                    buttonResult_Click(sender, e);
                    break;
            }
        }
    }
}
