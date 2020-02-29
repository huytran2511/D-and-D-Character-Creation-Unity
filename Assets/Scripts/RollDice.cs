using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RollDice : MonoBehaviour
{
    public TMP_Text Output1, Output2, Output3, Output4, Output5, OutputTotal;
    public TMP_Text StrMod, DexMod, ConMod, IntMod, WisMod, ChaMod;
    public TMP_Dropdown Str, Dex, Con, Int, Wis, Cha;

    public float[] Roll = new float[5];
    public float total;
    public List<float> Total;

    private static RollDice instance = null;
    public static RollDice Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(transform.root.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(transform.root.gameObject);
    }
    void Start()
    {
        Total = new List<float>();
    }
    public void DiceRoll()
    {
        float first = 0, second = 0, third = 0;
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
        if(Total.Count < 6)
        {
            Total.Add(total);
            Output1.text = Roll[0].ToString();
            Output2.text = Roll[1].ToString();
            Output3.text = Roll[2].ToString();
            Output4.text = Roll[3].ToString();
            Output5.text = Roll[4].ToString();
            OutputTotal.text = total.ToString();
        }

        StrMod.text = "+2";
        DexMod.text = "+2";
        ConMod.text = "+2";
        IntMod.text = "+2";
        WisMod.text = "+2";
        ChaMod.text = "+2";

        List<string> options = new List<string>();
        if(Str.options.Count < 6)
        {
            options.Add(Total[Total.Count - 1].ToString());
            Str.AddOptions(options);
            Dex.AddOptions(options);
            Con.AddOptions(options);
            Int.AddOptions(options);
            Wis.AddOptions(options);
            Cha.AddOptions(options);
        }
            
    }
}
