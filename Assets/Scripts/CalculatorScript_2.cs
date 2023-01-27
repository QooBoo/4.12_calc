using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CalculatorScript_2 : MonoBehaviour
{
    [SerializeField] private Text TextAnswer;
    [SerializeField] private InputField inputFieldFirstNumber;
    [SerializeField] private InputField inputFieldSecondNumber;

    double a;
    double b;

    private void Start()
    {
        TextAnswer.text = "О";
    }

    //математические действия
    public double CalcSum(double a, double b)
    {
        return a + b;
    }
    public double CalcRazn(double a, double b)
    {
        return a - b;
    }
    public double CalcUmn(double a, double b)
    {
        return a * b;
    }
    public double CalcDel(double a, double b)
    {
        return a / b;
    }

    //вывод ответа функций при нажатии кнопок
    public void BtnSum_Click()
    {
        TextAnswer.text = Convert.ToString(CalcSum(Convert.ToDouble(inputFieldFirstNumber.text), Convert.ToDouble(inputFieldSecondNumber.text)));
    }
    public void BtnRazn_Click()
    {
        TextAnswer.text = Convert.ToString(CalcRazn(Convert.ToDouble(inputFieldFirstNumber.text), Convert.ToDouble(inputFieldSecondNumber.text)));
    }
    public void BtnUmn_Click()
    {
        TextAnswer.text = Convert.ToString(CalcUmn(Convert.ToDouble(inputFieldFirstNumber.text), Convert.ToDouble(inputFieldSecondNumber.text)));
    }
    public void BtnDel_Click()
    {
        TextAnswer.text = Convert.ToString(CalcDel(Convert.ToDouble(inputFieldFirstNumber.text), Convert.ToDouble(inputFieldSecondNumber.text)));
    }

}
