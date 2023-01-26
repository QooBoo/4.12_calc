using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Newtonsoft.Json.Linq;

//public class CalculatorScript_2 : MonoBehaviour
//{


//        [SerializeField] private Text TextAnswer;
//        [SerializeField] private InputField inputFieldFirstNumber;
//        [SerializeField] private InputField inputFieldSecondNumber;


//        [SerializeField] private Button ButtonCalcAddition;
//        [SerializeField] private Button ButtonCalcSubtraction;
//        [SerializeField] private Button ButtonCalcMultiplication;
//        [SerializeField] private Button ButtonCalcDivision;


//    double a;
//    double b;
//    double value;

//        private void Start()
//        {
//            TextAnswer.text = "Ответ";

//        }


//    //вариант калькулятора 2(перейди в сцену_2)- выполняет действие много раз,
//    //скрипт зацеплен на канвас и обозначены кнопки.
//    //все работает через функцию онкликбаттон


//    public void onClickedButtonCalcAddition()
//    {

//        if (inputFieldFirstNumber.text == null)
//        {
//            TextAnswer.text = "Введите число 1";

//        } else if (inputFieldSecondNumber.text == null)
//        {
//            TextAnswer.text = "Введите число 2";
//        }
//        else {
//            double a = Convert.ToInt32(inputFieldFirstNumber.text);
//            double b = Convert.ToInt32(inputFieldSecondNumber.text);

//        }


//    }


//            public static double sum(double a, double b)
//        {
//            return a + b;
//        }


//        public static double razn(double a, double b)
//        {
//            return a - b;
//        }

//        public static double umnog(double a, double b)
//        {
//            return a * b;
//        }

//        public static double del(double a, double b)
//        {
//            return a / b;
//        }


//}


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
