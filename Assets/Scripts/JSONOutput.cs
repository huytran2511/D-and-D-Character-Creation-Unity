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

    public TMP_InputField Name;
    public TMP_Dropdown Race;
    public TMP_Dropdown Class;
    public TMP_Dropdown Alignment;
    public TMP_InputField CurXP;
    public TMP_InputField MaxXP;
    public TMP_InputField CurHP;
    public TMP_InputField MaxHP;
    public TMP_InputField ArmorClass;
    public TMP_InputField Speed;
    public TMP_InputField ItemList;
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


        OutputText.text = "{Name: " + '\u0022' + Name.text + '\u0022' + ", " +
            "Race: " + '\u0022' + Race.options[Race.value].text + '\u0022' + ", " +
            "Class: " + '\u0022' + Class.options[Class.value].text + '\u0022' + ", " +
            "Alignment: " + '\u0022' + Alignment.options[Alignment.value].text + '\u0022' + ", " +
            "Current Exp: " + CurXP.text + ", " +
            "Max Exp: " + MaxXP.text + ", " +
            "Current HP: " + CurHP.text + ", " +
            "Max HP: " + MaxHP.text + ", " +
            "Armor Class: " + ArmorClass.text + ", " +
            "Speed: " + Speed.text + "} ";

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
