using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killu : MonoBehaviour {

    public void OnCollisionEnter (Collision collision)
    {
        Pawn player = collision.gameObject.GetComponentInParent<Pawn>();
        if(player)
        {
            player.kill();
        }
    }
}
