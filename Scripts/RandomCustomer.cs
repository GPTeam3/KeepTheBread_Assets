using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RandomCustomer : MonoBehaviour
{
    [Serializable]
    public class    arr
    {
        public GameObject[] customer = new GameObject[3];
    }

    public arr[] MCCustomer = new arr[5];
    public arr[] WHCustomer = new arr[4];
    public arr[] MHCustomer = new arr[49];
    public arr[] BSCustomer = new arr[5];
    public arr[] DGCustomer = new arr[5];

    RandomNum randomscript;

    // public GameObject[,] array = new GameObject[5, 3];

    // Start is called before the first frame update
    void Start()
    {
        randomscript = GameObject.Find("Player").GetComponent<RandomNum>();
        MCCustomer[randomscript.num1].customer[0].SetActive(false);
        MCCustomer[randomscript.num1].customer[1].SetActive(true);
        MCCustomer[randomscript.num1].customer[2].SetActive(true);

        WHCustomer[randomscript.num2].customer[0].SetActive(false);
        WHCustomer[randomscript.num2].customer[1].SetActive(true);
        WHCustomer[randomscript.num2].customer[2].SetActive(true);

        MHCustomer[randomscript.num3].customer[0].SetActive(false);
        MHCustomer[randomscript.num3].customer[1].SetActive(true);
        MHCustomer[randomscript.num3].customer[2].SetActive(true);

        BSCustomer[randomscript.num4].customer[0].SetActive(false);
        BSCustomer[randomscript.num4].customer[1].SetActive(true);
        BSCustomer[randomscript.num4].customer[2].SetActive(true);

        DGCustomer[randomscript.num1].customer[0].SetActive(false);
        DGCustomer[randomscript.num1].customer[1].SetActive(true);
        DGCustomer[randomscript.num1].customer[2].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
