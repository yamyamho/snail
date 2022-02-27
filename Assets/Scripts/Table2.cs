using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Table2 : Collectable
{
    public Sprite ScrapTable2;
    public Sprite ArmTable2;
    private bool collected2;

    protected override void OnCollect()
    {

        if (!collected)
        {
            base.OnCollect();
            Debug.Log("Scrap Added!");

            GetComponent<SpriteRenderer>().sprite = ScrapTable2;
            Invoke("again", 4);
            
        }
         else if (collected2)
        {
             GetComponent<SpriteRenderer>().sprite = ArmTable2;
           
        }

    }
    void again()
    {
        collected2 = true;
    }
}
