using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�ӵ����� �Ź� ������ 
public class SpeedUpItem : Item
{   

    //4���� ���ǵ��  ������ �����
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
