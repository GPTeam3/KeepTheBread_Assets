using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using System;

public class RandomCustomer : MonoBehaviour
{
    [System.Serializable]
    public class    arr
    {
        public GameObject[] customer = new GameObject[3];
    }

    public arr[] MCCustomer = new arr[5];
    public arr[] WHCustomer = new arr[4];
    public arr[] MHCustomer = new arr[49];
    public arr[] BSCustomer = new arr[5];
    public arr[] DGCustomer = new arr[5];

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

        MCCustomer[num1].customer[0].SetActive(false);
        MCCustomer[num1].customer[1].SetActive(true);
        MCCustomer[num1].customer[1].tag = "mc";
        MCCustomer[num1].customer[2].SetActive(true);

        WHCustomer[num2].customer[0].SetActive(false);
        WHCustomer[num2].customer[1].SetActive(true);
        WHCustomer[num2].customer[1].tag = "wh";
        WHCustomer[num2].customer[2].SetActive(true);

        MHCustomer[num3].customer[0].SetActive(false);
        MHCustomer[num3].customer[1].SetActive(true);
        MHCustomer[num3].customer[1].tag = "mh";
        MHCustomer[num3].customer[2].SetActive(true);

        BSCustomer[num4].customer[0].SetActive(false);
        BSCustomer[num4].customer[1].SetActive(true);
        BSCustomer[num4].customer[1].tag = "bs";
        BSCustomer[num4].customer[2].SetActive(true);

        DGCustomer[num5].customer[0].SetActive(false);
        DGCustomer[num5].customer[1].SetActive(true);
        DGCustomer[num5].customer[1].tag = "dg";
        DGCustomer[num5].customer[2].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
