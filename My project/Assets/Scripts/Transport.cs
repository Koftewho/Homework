using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transport : MonoBehaviour
{
    public static Transport instance;
    public GameObject gameObjectToMove;

    private void Awake()
    {
        instance = this;
    }

    public void MoveGameObject()
    {
        int x = Random.Range(-5, 5);
        int z = Random.Range(-5, 5);
        gameObjectToMove.transform.position = new Vector3(x, 0, z);
    }
}
