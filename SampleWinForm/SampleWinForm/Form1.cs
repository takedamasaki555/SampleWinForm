using System;
using System.Windows.Forms;

namespace SampleWinForm
{
    public partial class Form1 : Form
    {
        #region Constants
        private const char ZERO = '0';
        private const char NINE = '9';
        private const char BACKSPACE = '\b';
        private const string MSG_OPERALTOR_IS_NOT_SELECTED = "計算方法を選択してください";
        private const string MSG_NUMBER1_IS_NOT_INTEGER = "一つ目の入力が数字ではありません";
        private const string MSG_NUMBER2_IS_NOT_INTEGER = "二つ目の入力が数字ではありません";
        private const string MSG_CANNOT_DIVIDE_BY_ZERO = "ゼロで割ることはできません";
        #endregion

        #region Fields
        private Calculator calculator = new Calculator();
        #endregion

        #region Initializers
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region EventHandlers
        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = isCancelKeyPress(e.KeyChar);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (isEmptyOperator()) return;
            if (isInvalidNumber1()) return;
            if (isInvalidNumber2()) return;

            txtAnswer.Text = calculate(int.Parse(txtNumber1.Text), int.Parse(txtNumber2.Text));
        }
        #endregion

        #region Validations
        private bool isCancelKeyPress(char key)
        {
            return (key < ZERO || key > NINE) && key != BACKSPACE;
        }

        private bool isEmptyOperator()
        {
            if (cmbOperator.SelectedIndex >= 0) return false;
            MessageBox.Show(MSG_OPERALTOR_IS_NOT_SELECTED);
            return true;
        }

        private bool isInvalidNumber1()
        {
            var number1 = 0;
            if (int.TryParse(txtNumber1.Text, out number1)) return false;
            MessageBox.Show(MSG_NUMBER1_IS_NOT_INTEGER);
            return true;
        }

        private bool isInvalidNumber2()
        {
            var number2 = 0;
            var isInteger = int.TryParse(txtNumber2.Text, out number2);

            if (!isInteger)
            {
                MessageBox.Show(MSG_NUMBER2_IS_NOT_INTEGER);
                return true;
            }
            else if (cmbOperator.SelectedIndex == 3 && number2 == 0)
            {
                MessageBox.Show(MSG_CANNOT_DIVIDE_BY_ZERO);
                return true;
            }
            return false;
        }
        #endregion

        #region calculations
        private string calculate(int number1, int number2)
        {
            switch (cmbOperator.SelectedIndex)
            {
                case 0:
                    return calculator.Add(number1, number2).ToString();
                case 1:
                    return calculator.Subtract(number1, number2).ToString();
                case 2:
                    return calculator.Multiply(number1, number2).ToString();
                case 3:
                    return calculator.Divide(number1, number2).ToString();
                default:
                    return string.Empty;
            }
        }
        #endregion
    }
}