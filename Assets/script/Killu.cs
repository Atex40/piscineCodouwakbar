using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Killu : MonoBehaviour {

    public void OnCollisionEnter (Collision collision)
    {
        Pawn player = collision.gameObject.GetComponentInParent<Pawn>();
        if(player)
        {
            player.Kill();
            SceneManager.LoadScene("Scene kevin");
        }
    }
}
