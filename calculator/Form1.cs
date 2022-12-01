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

            FocusInputText();
        }
        //this is the part for  key3
        private void button12_Click(object sender, EventArgs e)
        {
            InsertTextvalue("3");

            FocusInputText();
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
            FocusInputText();



        }

        //this is the the part for the Various KEYS

        private void Key8_Click(object sender, EventArgs e)
        {
            InsertTextvalue("8");
            FocusInputText();
        }
        //this is for key8
        private void Key9_Click(object sender, EventArgs e)
        {
            InsertTextvalue("9");
            FocusInputText();
        }
        //this is for the multiply key
        private void Multiply_Click(object sender, EventArgs e)
        {
            InsertTextvalue("X");
            FocusInputText();

        }
        //this is for the  key4
        private void Key4_Click(object sender, EventArgs e)
        {
            InsertTextvalue("4");
            FocusInputText();
        }
        //this is for thekey5
        private void Key5_Click(object sender, EventArgs e)
        {
            InsertTextvalue("5");
            FocusInputText();
        }
        //this is the for tje key6
        private void Key6_Click(object sender, EventArgs e)
        {
            InsertTextvalue("6");
            FocusInputText();
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

       

        #region function helpers

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
           

            this.CalculationResultText.Text = ParseOperation();
            FocusInputText();


        }

        private string ParseOperation()
        {
            try
            {
                //get users equation input
                var input = this.UserInputText.Text;

                //remove all spaces

                input = input.Replace(" ", "");

                //Loop throgh each character of the iput
                var operation = new Operation();

                var leftside = true;

                for (int i = 0; i < input.Length; i++)
                {

                    //check if the current character is a number
                    if ("0123456789.".Any(c => input[i] == c))
                    {
                        if (leftside)
                            operation.Leftside = AddNumberPart(operation.Leftside, input[i]);
                        else
                            operation.Rightside = AddNumberPart(operation.Rightside, input[i]);
                    }

                    else if ("+-*/".Any(c => input[i] == c))
                    {
                        if (!leftside)
                        {
                            var operatorType = GetOperationType(input[i]);

                            if (operation.Rightside.Length == 0)
                            {
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator (+ * / or more than one -) specified without an right side number");

                                // If we got here, the operator type is a minus, and there is no left number currently, so add the minus to the number
                                operation.Rightside += input[i];
                            }

                            else
                            {
                                // Calculate previous equation and set to the left side
                                operation.Leftside = CalculateOperation(operation);

                                // Set new operator
                                operation.OperationType = operatorType;

                                // Clear the previous right number
                                operation.Rightside = string.Empty;
                            }

                        }
                        else
                        {
                            var operatorType = GetOperationType(input[i]);

                            if (operation.Leftside.Length == 0)
                            {
                                //avoiding negative numbers
                                if (operatorType != OperationType.Minus)

                                    throw new InvalidOperationException($"more than one negative operator");
                                operation.Leftside += input[i];
                            }

                            else
                            {
                                operation.OperationType = operatorType;
                                leftside = false;
                            }
                        }
                    }
                }

                return CalculateOperation(operation);

            }

            catch (Exception ex)
            {
                return $"Invalid equation. {ex.Message}";
            }
            //this is when to calcilate after the parsing

        }
           
        // calculates an opertion nad returns the results

        private string CalculateOperation(Operation operation)
        {
            // storing the number values of the string repesentatives

            double left = 0;
            double right = 0;

            //check if we have a valid left side number
            if(string.IsNullOrEmpty(operation.Leftside) || !double.TryParse(operation.Leftside, out left))

                    throw new InvalidOperationException($"left side of the operator is not a number.{operation.Leftside}");

            //check if we have a valid right side number

            if (string.IsNullOrEmpty(operation.Rightside) || !double.TryParse(operation.Rightside, out right))

                throw new InvalidOperationException($"left side of the operator is not a number.{operation.Rightside}");

            try
            {
                switch(operation.OperationType)
                {
                    case OperationType.Add:
                        return(left + right).ToString();

                    case OperationType.Minus:
                        return (left - right).ToString();

                    case OperationType.Multiply:
                        return (left * right).ToString();

                    case OperationType.Divide:
                        return (left / right).ToString();
                    default:
                        throw new InvalidOperationException($"unknown operation type");
                }

            }

            catch(Exception ex)
            {
                throw new InvalidOperationException($"failed to calculate operation { operation.Leftside} {operation.OperationType} {operation.Rightside}. { ex.Message}");
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
            //checking if there is a new character
            if (newCharacter == '.' && currentNumber.Contains('.'))
                throw new InvalidOperationException($"Number {currentNumber} already contains a . and another cannot be added");
            return currentNumber + newCharacter;
        }
    }
}
