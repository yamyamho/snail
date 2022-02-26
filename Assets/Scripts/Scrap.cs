using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrap : Collectable
{
    public Sprite none;

    protected override void OnCollect()
    {

        if (!collected)
        {
            base.OnCollect();
            Debug.Log("Scrap Collected!");

            GetComponent<SpriteRenderer>().sprite = none;
        }

    }
}
