using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTile : MonoBehaviour
{
    public GameObject Tile;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "CandyBlue(Clone)")
        {
            Debug.Log("깔깔깔");
        }
    }
}
