using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] [Range(0, 10)] float t;

    float randomUno;
    float randomDos;
    // Start is called before the first frame update
    void Start()
    {
         randomUno = Random.Range(0, 10);
         randomDos = Random.Range(0, 10);
    }


    void Update()
    {
       oscilarX();
      // oscilarDiagonal();
        //Noise();

    }
    private void oscilarX() {
        transform.position = new Vector3(Mathf.Sin(Time.time)*t,0);
    }

    private void oscilarDiagonal()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * t, Mathf.Sin(Time.time) * t);
    }

    private void Noise()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time + randomUno) * t, Mathf.Sin(Time.time + randomDos) * t);
    }
}