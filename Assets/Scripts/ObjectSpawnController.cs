using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectSpawnController : MonoBehaviour
{
    [SerializeField]
    public GameObject prefab;

    private bool IsActive;

    private Guid ButtonId;

    public ObjectSpawnController()
    {
        ButtonId = Guid.NewGuid();
        SpawnObject.SpawnControllers.Add(this);
    }

    public void OnClick()
    {
        this.IsActive = !this.IsActive;

        var activeSpawns = SpawnObject.SpawnControllers.Where(x => x.IsActive);
        if (this.IsActive)
        {
                  
        foreach (var spawn in activeSpawns.Where(x => x.ButtonId != this.ButtonId))
        {
                spawn.IsActive = false;
        }
        }
    }

    void Update()
    {
        if (this.IsActive && Input.GetMouseButtonDown(0))
        {
            print("Is Active!");
            SpawnGameObject();
        }
        else
        {
            print("Is Inactive!");
        }
    }

    public void SpawnGameObject()
    {

        var currentCameraPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));         
        Instantiate(this.prefab, currentCameraPosition, Quaternion.identity);     
    }

    }

