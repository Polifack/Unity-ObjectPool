using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject sphere;
    public GameObject cube;

    private int instances;

    void OnGUI()
    {
        // Make a background box
        GUI.Label(new Rect(0, 0, 500, 50), "Manten A para generar cubos");
        GUI.Label(new Rect(0, 15, 500, 50), "Manten S para generar esferas");

        GUI.Label(new Rect(0, 30, 500, 50), "Número de GameObjects: "+ instances);

    }

    private void Update()
    {
        instances = GameObject.FindGameObjectsWithTag("Instance").Length;

        if (Input.GetKey(KeyCode.A)) Instantiate(cube, new Vector3(0, 5, 0), Random.rotation);
        if (Input.GetKey(KeyCode.S)) Instantiate(sphere, new Vector3(0, 5, 0), Random.rotation);
    }
}
