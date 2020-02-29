using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Character : MonoBehaviour
{
    public TMP_InputField Name, CurXP, MaxXP, CurHP, MaxHP, ArmorClass, Speed;
    public TMP_Dropdown Race, Class, Alignment;
    public TMP_Dropdown Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma;

    public string charName, charRace, charClass, charAlignment;
    public int charCurXP, charMaxXP, charCurHP, charMaxHP, charArmorClass, charSpeed;
    public int charStr, charDex, charCon, charInt, charWis, charCha;

    private static Character instance = null;
    public static Character Instance
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
    public void SaveChar()
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
        charStr = int.Parse(Strength.options[Strength.value].text) + 2;
        charDex = int.Parse(Dexterity.options[Dexterity.value].text) + 2;
        charCon = int.Parse(Constitution.options[Constitution.value].text) + 2;
        charInt = int.Parse(Intelligence.options[Intelligence.value].text) + 2;
        charWis = int.Parse(Wisdom.options[Wisdom.value].text) + 2;
        charCha = int.Parse(Charisma.options[Charisma.value].text) + 2;
    }
}
