﻿using UnityEngine;
using System.Collections;

public class SingleDoorShootdown : MonoBehaviour {

    Animator animator;
    int doorHealth;

    GraveyardDataManager graveyardDataManager;

    void Start()
    {
        animator = GetComponent<Animator>();
        doorHealth = 100;
        graveyardDataManager = GraveyardDataManager.GetInstance();
    }

    void Update()
    {
        if (doorHealth <= 0)
        {
            animator.SetBool("OpenAndBreak", true);
            animator.SetBool("FalldownIdle", true);

            if (this.gameObject.name == "SingleDoor") { graveyardDataManager.OutsideSingleDoorBroken = true; }
            if (this.gameObject.name == "SingleDoor (1)") { graveyardDataManager.InsideSingleDoorBroken = true; }
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet") && doorHealth > 0)
        {
            doorHealth -= 10;
            Debug.Log("DoorHealth " + doorHealth);
        }
    }
}
