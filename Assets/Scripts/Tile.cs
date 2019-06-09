using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tile : MonoBehaviour
{
    public Vector3 m_punch;
    public float m_duration;
    //public Vector3 TileTransform;
    
    /*private void Start()
    {
        this.transform.position = TileTransform;
    }*/

    void OnMouseDown()
    {
        transform.DOPunchScale(m_punch, m_duration);
    }
}
