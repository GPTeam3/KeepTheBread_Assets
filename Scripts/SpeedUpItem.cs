using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//속도증가 신발 아이템 
public class SpeedUpItem : Item
{   

    //4초후 스피드업  아이템 사라짐
    public override void DestroyAfterTime()
    {
        Invoke("DestroyObject", 4.0f);
    }


    public override void RunItem()
    {

    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
