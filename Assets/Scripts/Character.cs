using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string charName, charRace, charClass, charAlignment;
    public int charCurXP, charMaxXP, charCurHP, charMaxHP,
        charArmorClass, charSpeed;

    public string CharName
    {
        get { return charName; }
        set { charName = value; }
    }
    public string CharRace
    {
        get { return charRace; }
        set { charRace = value; }
    }
    public string CharClass
    {
        get { return charClass; }
        set { charClass = value; }
    }
    public string CharAlignment
    {
        get { return charAlignment; }
        set { charAlignment = value; }
    }
    public int CharCurXP
    {
        get { return charCurXP; }
        set { charCurXP = value; }
    }
    public int CharMaxXP
    {
        get { return charMaxXP; }
        set { charMaxXP = value; }
    }
    public int CharCurHP
    {
        get { return charCurHP; }
        set { charCurHP = value; }
    }
    public int CharMaxHP
    {
        get { return charMaxHP; }
        set { charMaxHP = value; }
    }
    public int CharArmorClass
    {
        get { return charArmorClass; }
        set { charArmorClass = value; }
    }
    public int CharSpeed
    {
        get { return charSpeed; }
        set { charSpeed = value; }
    }

}
