using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNum : MonoBehaviour
{
    public int  num1;
    public int  num2;
    public int  num3;
    public int  num4;
    public int  num5;
    // Start is called before the first frame update
    void Start()
    {
        num1 = Random.Range(0, 5);
        num2 = Random.Range(0, 4);
        num3 = Random.Range(0, 49);
        num4 = Random.Range(0, 5);
        num5 = Random.Range(0, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
