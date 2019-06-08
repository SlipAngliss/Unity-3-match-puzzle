﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tile : MonoBehaviour
{
    public Vector3 m_punch;
    public float m_duration;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        transform.DOPunchScale(m_punch, m_duration);

        Debug.Log("Tile.OnMouseDown");
    }
}
