using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shopsystem : MonoBehaviour
{
    public int money;
    public int wechsel;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Sword2Text", 0);
        PlayerPrefs.SetInt("Sword3Text", 0);
        PlayerPrefs.SetInt("Sword4Text", 0);
        if (PlayerPrefs.GetInt("Sword2Text", 0) == 1)
        {
            Text2.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Sword3Text", 0) == 1)
        {
            Text3.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Sword4Text", 0) == 1)
        {
            Text4.SetActive(false);
        }

        wechsel = PlayerPrefs.GetInt("wechsel", 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Sword1()
    {
        wechsel = 1;
        PlayerPrefs.SetInt("wechsel", wechsel);
    }

    public void Sword2()
    {
        money = PlayerPrefs.GetInt("Money", 0);
        if (PlayerPrefs.GetInt("Sword2Text", 0) < 1)
        {
            if (money - 100 >= 0)
            {
                Text2.SetActive(false);
                money -= 100;
                PlayerPrefs.SetInt("Money", money); 
                PlayerPrefs.SetInt("Sword2Text", 1);
            }
        }
        if (PlayerPrefs.GetInt("Sword2Text", 0) == 1) 
        {
            wechsel = 2;
            PlayerPrefs.SetInt("wechsel", wechsel);
        }
    }

    public void Sword3()
    {
        money = PlayerPrefs.GetInt("Money", 0);
        if (PlayerPrefs.GetInt("Sword3Text", 0) < 1)
        {
            if (money - 500 >= 0)
            {
                Text3.SetActive(false);
                money -= 500;
                PlayerPrefs.SetInt("Money", money); 
                PlayerPrefs.SetInt("Sword3Text", 1);
            }
        }
        if (PlayerPrefs.GetInt("Sword3Text", 0) == 1) 
        {
            wechsel = 3;
            PlayerPrefs.SetInt("wechsel", wechsel);
        }
    }

    public void Sword4()
    {
        money = PlayerPrefs.GetInt("Money", 0);
        if (PlayerPrefs.GetInt("Sword4Text", 0) < 1)
        {
            if (money - 1000 >= 0)
            {
                Text4.SetActive(false);
                money -= 1000;
                PlayerPrefs.SetInt("Money", money); 
                PlayerPrefs.SetInt("Sword4Text", 1);
            }
        }
        if (PlayerPrefs.GetInt("Sword4Text", 0) == 1) 
        {
            wechsel = 4;
            PlayerPrefs.SetInt("wechsel", wechsel);
        }
    }
}
