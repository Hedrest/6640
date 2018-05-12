﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeThrower : MonoBehaviour {

    public float throwForce = 1f;
    public GameObject grenadePrefab;

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(1))
        {
            GameObject grenade = Instantiate(grenadePrefab, transform.position, transform.rotation);
            Rigidbody rb = grenade.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * throwForce, ForceMode.VelocityChange);
        }
	}
}
