using System;

namespace Lab2._2.Models
{
    public class CalcModel
    {
        public string first { get; set; }
        public string second { get; set; }
        public string sign { get; set; }
        public int result;

        public bool show = false;
        public bool divNull;
        public bool Empty;
        public bool Unknown;
        public void calculation()
        {
            char signChar = Convert.ToChar(sign);
            divNull = false;
            Unknown = false;
            int temp;
            if (int.TryParse(first, out temp) && int.TryParse(second, out temp))
            {
                Empty = false;
            }
            else
            {
                Empty = true;
                return;
            }
            int firstNum = Int32.Parse(first);
            int secondNum = Int32.Parse(second);
            switch (signChar)
            {
                case '+':
                    result = firstNum + secondNum;
                    break;
                case '-':
                    result = firstNum - secondNum;
                    break;
                case '*':
                    result = firstNum * secondNum;
                    break;
                case '/':
                    if (secondNum == 0)
                        divNull = true;
                    else
                        result = firstNum / secondNum;
                    break;
                default:
                    Unknown = true;
                    break;
            }

        }
    }
}