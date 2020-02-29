using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDisplay : MonoBehaviour
{
    public GameObject character;

    private static CharacterDisplay instance = null;
    public static CharacterDisplay Instance
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
        character = GameObject.Find("myChar");
    }
}
