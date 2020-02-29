using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class JSONOutput : MonoBehaviour
{
    public TMP_Text OutputText;
    Character myChar;

    private static JSONOutput instance = null;
    public static JSONOutput Instance
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
        myChar = GetComponent<Character>();
    }
    public void JSONString()
    {
        OutputText.text = 
            "{\n    \u0022name\u0022: \u0022" + myChar.charName + "\u0022," +
            "\n    \u0022race\u0022: \u0022" + myChar.charRace + "\u0022," +
            "\n    \u0022class\u0022: \u0022" + myChar.charClass + "\u0022," +
            "\n    \u0022alignment\u0022: \u0022" + myChar.charAlignment + "\u0022," +
            "\n    \u0022currentXP\u0022: " + myChar.charCurXP + "," +
            "\n    \u0022maxXP\u0022: " + myChar.charMaxXP + "," +
            "\n    \u0022currentHP\u0022: " + myChar.charCurHP + "," +
            "\n    \u0022maxHP\u0022: " + myChar.charMaxHP + "," +
            "\n    \u0022armorclass\u0022: " + myChar.charArmorClass + "," +
            "\n    \u0022speed\u0022: " + myChar.charSpeed + "," +
            "\n    \u0022strength\u0022: " + myChar.charStr + "," +
            "\n    \u0022dexterity\u0022: " + myChar.charDex + "," +
            "\n    \u0022constitution\u0022: " + myChar.charCon + "," +
            "\n    \u0022intelligence\u0022: " + myChar.charInt + "," +
            "\n    \u0022wisdom\u0022: " + myChar.charWis + "," +
            "\n    \u0022charisma\u0022: " + myChar.charCha + "\n} ";
    }
}
