using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCurves : MonoBehaviour
{

    [SerializeField] GameObject obj;
    [SerializeField] int samples;
    [SerializeField] [Range(0, 1)] float separationFactor;
    [SerializeField] [Range(0, 10)] float altura;
    [SerializeField] [Range(0, 10)] float t;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < samples; i++)
        {
            var child = Instantiate(obj, transform);
            child.transform.localPosition = new Vector3(i*0.3f, Mathf.Sin(i*0.3f), 0);
        }


    }

    // Update is called once per frame
    void Update()
    {
        int i = 0;
        foreach (Transform child in transform) {
            float x = i * separationFactor;
            child.localPosition = new Vector3(x, altura * Mathf.Sin((x*t)+ Time.time), 0);
            ++i;

        }
    }
}
