using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipaScript : MonoBehaviour
{
    float nilaiRandom;
    // Start is called before the first frame update
    void Start()
    {
        nilaiRandom = Random.Range(-3.41f, 2.56f);
        transform.position = new Vector2(transform.position.x, nilaiRandom);
    }

    // Update is called once per frame
    void Update()
    {
        // gerak ke kiri
        transform.position = Vector2.MoveTowards(transform.position,Vector2.left * 100, Time.deltaTime * 2);
    }
}
