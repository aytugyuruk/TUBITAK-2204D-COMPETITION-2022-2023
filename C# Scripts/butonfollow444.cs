using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butontakip444 : MonoBehaviour
{
    public GameObject target;
    private void Start()
    {
        transform.position = new Vector2(0, -3.8f);
    }
    void Update()
    {
        if (camerafollowww.aktif)
        {
            transform.position = new Vector2(target.transform.position.x - 4.3f, transform.position.y);
        }

    }
}
