using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyME : MonoBehaviour
{
    public int lifeTime;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        
    }
}
