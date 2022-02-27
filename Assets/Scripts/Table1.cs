using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Table1 : Collectable
{
    public Sprite ScrapTable1;
    public Sprite ArmTable1;
    private bool collected2;

    protected override void OnCollect()
    {

        if (!collected)
        {
            base.OnCollect();
            Debug.Log("Scrap Added!");

            GetComponent<SpriteRenderer>().sprite = ScrapTable1;
            Invoke("again", 4);

        }
        else if (collected2)
        {
            GetComponent<SpriteRenderer>().sprite = ArmTable1;

        }

    }
    void again()
    {
        collected2 = true;
    }
}
