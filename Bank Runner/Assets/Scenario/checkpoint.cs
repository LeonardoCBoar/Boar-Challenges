﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.name != "Player") return;
        other.gameObject.GetComponent<Player>().getPoint();
    }
}
