using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalFinal : Collidable
{
    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "snel_player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Final");
        }
    }
}
