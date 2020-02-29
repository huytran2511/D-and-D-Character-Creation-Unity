using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RollDice : MonoBehaviour
{
    public TMP_Text Output1;
    public TMP_Text Output2;
    public TMP_Text Output3;
    public TMP_Text Output4;
    public TMP_Text Output5;
    public TMP_Text OutputTotal;

    public int[] Roll = new int[5];
    public int total;
    public List<int> Total;

    void Start()
    {
        
    }
    public void DiceRoll()
    {
        int first = 0, second = 0, third = 0;
        for(int i = 0; i < 5; i++)
        {
            Roll[i] = Random.Range(1, 7);
        }
        for(int j = 0; j < 5; j++)
        {
            if(Roll[j] > first)
            {
                third = second;
                second = first;
                first = Roll[j];
            }
            else if (Roll[j] > second)
            {
                third = second;
                second = Roll[j];

            }
            else if (Roll[j] > third)
            {
                third = Roll[j];
            }
        }
        total = first + second + third;
        Output1.text = Roll[0].ToString();
        Output2.text = Roll[1].ToString();
        Output3.text = Roll[2].ToString();
        Output4.text = Roll[3].ToString();
        Output5.text = Roll[4].ToString();
        OutputTotal.text = total.ToString();
    }
}
