using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if (!col.gameObject.CompareTag("Instance")) gameObject.SetActive(false);
    }
}
