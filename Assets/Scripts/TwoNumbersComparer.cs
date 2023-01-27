using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoNumbersComparer : MonoBehaviour
{
        [SerializeField] private Text TextAnswer;
        [SerializeField] private InputField inputFieldFirstNumber;
        [SerializeField] private InputField inputFieldSecondNumber;

        public void Comparer()
        {
            double a = Convert.ToInt32(inputFieldFirstNumber.text);
            double b = Convert.ToInt32(inputFieldSecondNumber.text);
                    if (a>b)
                {
                    TextAnswer.text = "a > b";

                } else if (a<b)
                {
                    TextAnswer.text = "a < b";
                } else
                {
                    TextAnswer.text = "a = b";
                }
        }
    
}
