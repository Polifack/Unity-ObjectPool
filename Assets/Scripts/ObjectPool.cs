using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Pooleable
{
    public int ammount;
    public GameObject gameObject;
    public Vector3 instanciationPosition;
}

public class ObjectPool : MonoBehaviour
{
    public Pooleable itemToPool;
    public static ObjectPool Instance;
    private List<GameObject> pooledObjects;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < itemToPool.ammount; i++)
        {
            GameObject obj = (GameObject)Instantiate(itemToPool.gameObject, itemToPool.instanciationPosition, Random.rotation);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }

    }

    public GameObject getObject()
    {
        //Iteramos sobre toda la lista buscando algun gameobject que no este asignado
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                pooledObjects[i].transform.position = itemToPool.instanciationPosition;
                return pooledObjects[i];
            }
        }
        return null;
    }
}
