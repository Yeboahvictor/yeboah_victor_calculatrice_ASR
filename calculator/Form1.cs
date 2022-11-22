using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //this is the part for the Key7
        private void button2_Click(object sender, EventArgs e)
        {
            InsertTextvalue("7");
        }
        //this is the part for  key3
        private void button12_Click(object sender, EventArgs e)
        {
            InsertTextvalue("3");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CEButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = String.Empty;

            //clear the text area
            FocusInputText();

        }

        private void Reset_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DeleteTextValue();

            //clear the text area
            FocusInputText();
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            InsertTextvalue("/");


        }

        //this is the the part for the Various KEYS

        private void Key8_Click(object sender, EventArgs e)
        {
            InsertTextvalue("8");
        }
        //this is for key8
        private void Key9_Click(object sender, EventArgs e)
        {
            InsertTextvalue("9");
        }
        //this is for the multiply key
        private void Multiply_Click(object sender, EventArgs e)
        {
            InsertTextvalue("X");

        }
        //this is for the  key4
        private void Key4_Click(object sender, EventArgs e)
        {
            InsertTextvalue("4");
        }
        //this is for thekey5
        private void Key5_Click(object sender, EventArgs e)
        {
            InsertTextvalue("5");
        }
        //this is the for tje key6
        private void Key6_Click(object sender, EventArgs e)
        {
            InsertTextvalue("6");
        }
        //this is for the subtract key
        private void Subtract_Click(object sender, EventArgs e)
        {
            InsertTextvalue("-");

        }

        private void Key1_Click(object sender, EventArgs e)
        {
            InsertTextvalue("1");
        }

        private void Key2_Click(object sender, EventArgs e)
        {
            InsertTextvalue("2");
        }

        private void Add_Click(object sender, EventArgs e)
        {
            InsertTextvalue("+");

        }

        private void Key0_Click(object sender, EventArgs e)
        {
            InsertTextvalue("0");
        }

       
        private void Point_Click(object sender, EventArgs e)
        {
            InsertTextvalue(".");
        }

        private void Equal_sign_Click(object sender, EventArgs e)
        {
            CalculateEquation();
        }

       

        #region helpers

        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }

        private void InsertTextvalue(string value)
        {  //Remember selection start

            var selectionStart = this.UserInputText.SelectionStart; 
            
            //set new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);

            //restore selection start
            this.UserInputText.SelectionStart = selectionStart + value.Length;

            //set selection length to zero
            this.UserInputText.SelectionLength = 0;
        }


        //this is the method for deleting a text value
        private void DeleteTextValue()
        {


            if (this.UserInputText.Text.Length < this.UserInputText.SelectionStart + 1)
                return;
            //Remember selection start

            var selectionStart = this.UserInputText.SelectionStart;

            //delete
            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);

            //restore selection start
            this.UserInputText.SelectionStart = selectionStart ;

            //set selection length to zero
            this.UserInputText.SelectionLength = 0;
        }
        #endregion









        // this is the fuction for the final calculatioin
        private void CalculateEquation()
        {
           var userInput = this.UserInputText.Text;

            this.CalculationResultText.Text = ParseOperation();




            var result = ParseOperation();
        }

        private string ParseOperation()
        {
            try
            {
                //get user inpu
                var input = this.UserInputText.Text;

                //remove all spaces

                input = input.Replace(" ", "");


                var operation = new Operation();

                var leftSide = true;

                for (int i = 0; i < input.Length; i++)
                {
                    if("0123456789.".Any(c => input[i] == c))
                    {
                        if (leftSide)
                            operation.Leftside = AddNumberPart(operation.Leftside, input[i]);
                        else operation.Rightside = AddNumberPart(operation.Rightside, input[i]);
                    }

                    else if ("+-*/".Any(c => input[i] == c))
                    {
                        if(!leftSide)
                        {
                            var operatorType = GetOperationType(input[i]);
                        }


                        else
                        {
                            var operatorType = GetOperationType(input[i]);

                            if(operation.Leftside.Length == 0)
                            {

                            }
                        }
                    }
                }

                return String.Empty;
            }

            catch(Exception ex)
            {
                return $"Invalid Equation. {ex.Message}";
            }
        }

        private OperationType GetOperationType(char character)
        {
            switch (character)
            {
                case '+':
                    return OperationType.Add;
                    case '-':
                    return OperationType.Minus;
                    case '*':
                    return OperationType.Multiply;
                    case '/':
                    return OperationType.Divide;
                    default:
                    throw new InvalidOperationException($"unknown operator type{character}");
                    
            }
        }

        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            if (newCharacter == '.' && currentNumber.Contains('.'))
                throw new InvalidOperationException($"Number {currentNumber} already contains a . and cannot be added");
            return currentNumber + newCharacter;
        }
    }
}
