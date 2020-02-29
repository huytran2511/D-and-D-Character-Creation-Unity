using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CharacterGenerator : Character
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

    public CharacterGenerator()
    {
        charName = Name.text;
        charRace = Race.options[Race.value].text;
        charClass = Class.options[Class.value].text;
        charAlignment = Alignment.options[Alignment.value].text;
        charCurXP = int.Parse(CurXP.text);
        charMaxXP = int.Parse(MaxXP.text);
        charCurHP = int.Parse(CurHP.text);
        charMaxHP = int.Parse(MaxHP.text);
        charArmorClass = int.Parse(ArmorClass.text);
        charSpeed = int.Parse(Speed.text);
    }
    void Start()
    {

    }
    public void JSONString()
    {
        CharacterGenerator myChar = new CharacterGenerator();
        string a = "{Name: " + '\u0022' + myChar.charName + '\u0022' + ", " +
            "Race: " + '\u0022' + myChar.charRace + '\u0022' + ", " +
            "Class: " + '\u0022' + myChar.charClass + '\u0022' + ", " +
            "Alignment: " + '\u0022' + myChar.charAlignment + '\u0022' + ", " +
            "Current Exp: " + myChar.charCurXP + ", " +
            "Max Exp: " + myChar.charMaxXP + ", " +
            "Current HP: " + myChar.charCurHP + ", " +
            "Max HP: " + myChar.charMaxHP + ", " +
            "Armor Class: " + myChar.charArmorClass + ", " +
            "Speed: " + myChar.charSpeed + "} ";


        //string a = "{Name: " + '\u0022' + Name.text + '\u0022' + ", " +
        //    "Race: " + '\u0022' + Race.options[Race.value].text + '\u0022' + ", " +
        //    "Class: " + '\u0022' + Class.options[Class.value].text + '\u0022' + ", " +
        //    "Alignment: " + '\u0022' + Alignment.options[Alignment.value].text + '\u0022' + ", " +
        //    "Current Exp: " + CurXP.text + ", " +
        //    "Max Exp: " + MaxXP.text + ", " +
        //    "Current HP: " + CurHP.text + ", " +
        //    "Max HP: " + MaxHP.text + ", " +
        //    "Armor Class: " + ArmorClass.text + ", " +
        //    "Speed: " + Speed.text + "} ";

        Debug.Log(a);
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

}
