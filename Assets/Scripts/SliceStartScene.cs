﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(Rigidbody))]
public class SliceStartScene : MonoBehaviour
{
    public Material capMaterial;

    private void OnCollisionEnter(Collision collision)
    {
        Collider col = collision.collider;
        GameObject victim = collision.collider.gameObject;

        GameObject[] pieces = BLINDED_AM_ME.MeshCut.Cut(victim, transform.position, transform.right, capMaterial);

        if (!pieces[1].GetComponent<Rigidbody>())
        {
            pieces[1].AddComponent<Rigidbody>();
            MeshCollider temp = pieces[1].AddComponent<MeshCollider>();
            temp.convex = true;
        }

        Destroy(pieces[1], 1);

        if (col.CompareTag("startCube"))
        {
            SceneManager.LoadScene("GameScene");
        }

        
    }
}