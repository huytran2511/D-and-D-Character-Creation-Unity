using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class JSONOutput : MonoBehaviour
{
    //public string CharName, CharRace, CharClass, CharAlignment;
    //public int CharCurXP, CharMaxXP, CharCurHP, CharMaxHP,
    //    CharArmorClass, CharSpeed;

    public TMP_InputField Name, CurXP, MaxXP, CurHP, MaxHP, ArmorClass, Speed, ItemList;
    public TMP_Dropdown Race, Class, Alignment;
    public TMP_Dropdown Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma;
    public TMP_Text OutputText;



    //public void SetChar()
    //{
    //    CharName = Name.text;
    //    CharRace = Race.options[Race.value].text;
    //    CharClass = Class.options[Class.value].text;
    //    CharAlignment = Alignment.options[Alignment.value].text;
    //    CharCurXP = int.Parse(CurXP.text);
    //    CharMaxXP = int.Parse(MaxXP.text);
    //    CharCurHP = int.Parse(CurHP.text);
    //    CharMaxHP = int.Parse(MaxHP.text);
    //    CharArmorClass = int.Parse(ArmorClass.text);
    //    CharSpeed = int.Parse(Speed.text);
    //}

    public void JSONString()
    {
        //CharacterGenerator myChar = new CharacterGenerator();
        //fText.text = "{Name: " + '\u0022' + myChar.CharName + '\u0022' + ", " +
        //    "Race: " + '\u0022' + myChar.CharRace + '\u0022' + ", " +
        //    "Class: " + '\u0022' + myChar.CharClass + '\u0022' + ", " +
        //    "Alignment: " + '\u0022' + myChar.CharAlignment + '\u0022' + ", " +
        //    "Current Exp: " + myChar.CharCurXP + ", " +
        //    "Max Exp: " + myChar.CharMaxXP + ", " +
        //    "Current HP: " + myChar.CharCurHP + ", " +
        //    "Max HP: " + myChar.CharMaxHP + ", " +
        //    "Armor Class: " + myChar.CharArmorClass + ", " +
        //    "Speed: " + myChar.CharSpeed + "} ";


        OutputText.text =
            "{\n    \u0022name\u0022: \u0022" + Name.text + "\u0022," +
            "\n    \u0022race\u0022: \u0022" + Race.options[Race.value].text + "\u0022," +
            "\n    \u0022class\u0022: \u0022" + Class.options[Class.value].text + "\u0022," +
            "\n    \u0022alignment\u0022: \u0022" + Alignment.options[Alignment.value].text + "\u0022," +
            "\n    \u0022currentXP\u0022: " + CurXP.text + "," +
            "\n    \u0022maxXP\u0022: " + MaxXP.text + "," +
            "\n    \u0022currentHP\u0022: " + CurHP.text + "," +
            "\n    \u0022maxHP\u0022: " + MaxHP.text + "," +
            "\n    \u0022armorclass\u0022: " + ArmorClass.text + "," +
            "\n    \u0022speed\u0022: " + Speed.text + "," +
            "\n    \u0022strength\u0022: " + Strength.options[Strength.value].text + "," +
            "\n    \u0022dexterity\u0022: " + Dexterity.options[Dexterity.value].text + "," +
            "\n    \u0022constitution\u0022: " + Constitution.options[Constitution.value].text + "," +
            "\n    \u0022intelligence\u0022: " + Intelligence.options[Intelligence.value].text + "," +
            "\n    \u0022wisdom\u0022: " + Wisdom.options[Wisdom.value].text + "," +
            "\n    \u0022charisma\u0022: " + Charisma.options[Charisma.value].text + "\n} ";

        Debug.Log(OutputText.text);
    }

    //public void SetName()
    //{
    //    CharName = Name.text;
    //}
    //public void SetRace()
    //{
    //    CharRace = Race.options[Race.value].text;
    //}
    //public void SetClass()
    //{
    //    CharClass = Class.options[Class.value].text;
    //}
    //public void SetAlignment()
    //{
    //    CharAlignment = Alignment.options[Alignment.value].text;
    //}
    //public void SetCurXP()
    //{
    //    CharCurXP = int.Parse(CurXP.text);
    //}
    //public void SetMaxXP()
    //{
    //    CharMaxXP = int.Parse(MaxXP.text);
    //}
    //public void SetCurHP()
    //{
    //    CharCurHP = int.Parse(CurHP.text);
    //}
    //public void SetMaxHP()
    //{
    //    CharMaxHP = int.Parse(MaxHP.text);
    //}
    //public void SetArmorClass()
    //{
    //    CharArmorClass = int.Parse(ArmorClass.text);
    //}
    //public void SetSpeed()
    //{
    //    CharSpeed = int.Parse(Speed.text);
    //}
    //public void SetItemList()
    //{
    //    // return a list type of Item List
    //}

    void Start()
    {

    }

}
