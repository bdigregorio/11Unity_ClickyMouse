﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {
    private Rigidbody targetRigidbody;

    private float xBounds = 4.25f;
    private float ySpawnPos = -2.0f;
    private float minForce = 12.0f;
    private float maxForce = 15.0f;
    private float maxTorque = 10.0f;

    private void Start() {
        targetRigidbody = GetComponent<Rigidbody>();

        transform.position = RandomSpawnPos();
        targetRigidbody.AddForce(RandomForce(), ForceMode.Impulse);
        targetRigidbody.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse); 
    }

    private void OnMouseDown() {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other) {
        Destroy(gameObject);   
    }

    private Vector3 RandomSpawnPos() {
        return new Vector3(Random.Range(-xBounds, xBounds), ySpawnPos);
    }

    private Vector3 RandomForce() {
        return Vector3.up * Random.Range(minForce, maxForce);
    }

    private float RandomTorque() {
        return Random.Range(-maxTorque, maxTorque);
    }
}
