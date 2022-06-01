using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BorderManager : MonoBehaviour
{
    public class Count
    {
        public int minimum;
        public int maximum;

        public Count (int min, int max)
        {
            minimum = min;
            maximum = max;
        }
    }

    public int rows = 4;
    public int columns = 1;
    public GameObject[] variant; 

    private Transform boardHolder;
    private List <Vector3> gridPositions = new List<Vector3>();


    void Awake()
    {
        Instantiate(variant[Random.Range(0, variant.Length)]);
    }
}
