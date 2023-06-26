using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    public int PaperCollected = 0;
    public GameObject PhoneGO;
    public GameObject WinScreen;
    public GameObject DeathScreen;
    bool Won = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Collect()
    {
        PaperCollected++;
        if (PaperCollected >= 5)
        {
            PhoneGO.GetComponent<Phone>().Collected = true;
        }
    }

    public void Win()
    {
        WinScreen.SetActive(true);
        Won = true;
    }

    public void Die()
    {
        if (Won == false)
        {
            DeathScreen.SetActive(true);
        }
        
    }
}
