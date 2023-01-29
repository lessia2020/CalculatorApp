using System;

using AppKit;
using Foundation;

namespace MyBasicCalculator
{
	public partial class ViewController : NSViewController
	{

        public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Do any additional setup after loading the view.
		}

		public override NSObject RepresentedObject {
			get {
				return base.RepresentedObject;
			}
			set {
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}

        float num1;
        float num2;
        float result;
        char operation;
        bool dec = false;

        private void changeLabel(int numPressed)
        {
            if (dec == true)
            {
                int decimalCount = 0;
                foreach (char c in Screen.StringValue)
                {
                    if (c == '.')
                    {
                        decimalCount++;
                    }
                }
                if (decimalCount < 1)
                {
                    Screen.StringValue = Screen.StringValue + ".";
                }
                dec = false;
            }
            else
            {
                if ((Screen.StringValue.Equals("0") == true && Screen.StringValue != null))
                {
                    Screen.StringValue = numPressed.ToString();
                }
                else if (Screen.StringValue.Equals("-0") == true)
                {
                    Screen.StringValue = "-" + numPressed.ToString();
                }
                else
                {
                    Screen.StringValue = Screen.StringValue + numPressed.ToString();
                }
            }
        }

        //the first line
        partial void ResetButton(NSButton sender)
        {
            Screen.StringValue = "0";
            num1 = 0;
            num2 = 0;
            result = 0;
            dec = false;
        }

        partial void PlusOrMinusButton(NSButton sender)
        {
            Screen.StringValue = "-" + Screen.StringValue;
        }
        //changes

        partial void SquareRoot(NSButton sender)
        {
            num1 = float.Parse(Screen.StringValue);
            if (num1 > 0)
            {
                double sqrt = Math.Sqrt(num1);
                Screen.StringValue = sqrt.ToString();
            }
        }

        //changes

        partial void DivisionButton(NSButton sender)
        {
            num1 = float.Parse(Screen.StringValue);
            operation = '/';
            Screen.StringValue = "";
        }

        //the second line
        partial void SevenButton(NSButton sender)
        {
            changeLabel(7);
        }

        partial void EightButton(NSButton sender)
        {
            changeLabel(8);
        }

        partial void NineButton(NSButton sender)
        {
            changeLabel(9);
        }

        partial void MultiplicationButton(NSButton sender)
        {
            num1 = float.Parse(Screen.StringValue);
            operation = '*';
            Screen.StringValue = "";
        }

        //the third line
        partial void FourButton(NSButton sender)
        {
            changeLabel(4);
        }

        partial void FiveButton(NSButton sender)
        {
            changeLabel(5);
        }

        partial void SixButton(NSButton sender)
        {
            changeLabel(6);
        }

        partial void MinusButton(NSButton sender)
        {
            num1 = float.Parse(Screen.StringValue);
            operation = '-';
            Screen.StringValue = "-";
        }

        //the fourth line
        partial void OneButton(NSButton sender)
        {
            changeLabel(1);
        }

        partial void TwoButton(NSButton sender)
        {
            changeLabel(2);
        }

        partial void ThreeButton(NSButton sender)
        {
            changeLabel(3);
        }

        partial void PlusButton(NSButton sender)
        {
            num1 = float.Parse(Screen.StringValue);
            operation = '+';
            result = result + num1;
            Screen.StringValue = "+";
        }


        //the fifth line
        partial void ZeroButton(NSButton sender)
        {
            changeLabel(0);
        }

        partial void EqualButton(NSButton sender)
        {
            result = 0;
            if (Screen.StringValue.Equals("0") == false)
            {
                switch (operation)
                {
                    case '+':
                        num2 = float.Parse(Screen.StringValue);
                        result = num1 + num2;
                        break;
                    case '-':
                        num2 = float.Parse(Screen.StringValue);
                        result = num1 - num2;
                        break;
                    case '/':
                        num2 = float.Parse(Screen.StringValue);
                        result = num1 / num2;
                        break;
                    case '*':
                        num2 = float.Parse(Screen.StringValue);
                        result = num1 * num2;
                        break;
                    default:
                        break;
                }
            }
            Screen.StringValue = result.ToString();
        }
    }
}
