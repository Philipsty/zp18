﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * McDSL: VR Simulation One
 * Nolan Slade
 * Feb 14 2018
 * 
 * When the counter's trigger is entered / exited by a water droplet
 * we need to decrease and increase the payload amount. Essentially
 * tracks how much the user is carrying at all times.
 */
public class WaterDropletCounter : MonoBehaviour {

    public GameObject simManager;

	private void OnTriggerEnter (Collider col) {
        if (col.gameObject.tag == "Water")
            simManager.GetComponent<SimManager>().increasePayload(1);
    }

    private void OnTriggerExit (Collider col) {
        if (col.gameObject.tag == "Water")
            simManager.GetComponent<SimManager>().decreasePayload(1);
    }
}
