﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterimagePooler : MonoBehaviour
{
    [SerializeField]
    private GameObject afterimagePrefab;

    private Queue<GameObject> availableObjects = new Queue<GameObject>();

    public static AfterimagePooler Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        GrowPool();
    }

    void GrowPool()
    {
        for(int i = 0; i < 10; i++)
        {
            var instanceToAdd = Instantiate(afterimagePrefab);
            instanceToAdd.transform.SetParent(transform);
            AddToPool(instanceToAdd);
        }
    }

    public void AddToPool(GameObject _instance)
    {
        _instance.SetActive(false);
        availableObjects.Enqueue(_instance);
    }

    public GameObject GetFromPool()
    {
        if(availableObjects.Count == 0)
        {
            GrowPool();
        }
        var instance = availableObjects.Dequeue();
        instance.SetActive(true);
        return instance;
    }
}
