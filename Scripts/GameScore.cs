using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScore : MonoBehaviour
{
    public float[] time;  //각 레벨 별로 남은 시간 저장
    public GameObject[] Level1_star;
    public GameObject[] Level2_star;
    public GameObject[] Level3_star;

    public bool Level_2 = false;
    public bool Level_3 = false;
    public GameObject Button_2;
    public GameObject Button_3;
    public GameObject Lock_2;
    public GameObject Lock_3;

    private void    Awake()
    {
        var objs = FindObjectsOfType<GameScore>();
        if (objs.Length == 1)
            DontDestroyOnLoad(gameObject);
        else
            Destroy(gameObject);

        // Level1_star[0] = GameObject.Find("Level1_Star").transform.Find("Level1_star1").gameObject;
        // Level1_star[1] = GameObject.Find("Level1_Star").transform.Find("Level1_star2").gameObject;
        // Level1_star[2] = GameObject.Find("Level1_Star").transform.Find("Level1_star3").gameObject;

        // Level2_star[0] = GameObject.Find("Level2_Star").transform.Find("Level2_star1").gameObject;
        // Level2_star[1] = GameObject.Find("Level2_Star").transform.Find("Level2_star2").gameObject;
        // Level2_star[2] = GameObject.Find("Level2_Star").transform.Find("Level2_star3").gameObject;

        // Level3_star[0] = GameObject.Find("Level3_Star").transform.Find("Level3_star1").gameObject;
        // Level3_star[1] = GameObject.Find("Level3_Star").transform.Find("Level3_star2").gameObject;
        // Level3_star[2] = GameObject.Find("Level3_Star").transform.Find("Level3_star3").gameObject;

        // Button_2 = GameObject.Find("LevelButton").transform.Find("Level2").gameObject;
        // Button_3 = GameObject.Find("LevelButton").transform.Find("Level3").gameObject;
        // Lock_2 = GameObject.Find("Lock2");
        // Lock_3 = GameObject.Find("Lock3");
    }
    // Start is called before the first frame update
    void Start()
    {
        // if(Level_2)
        // {
        //     Button_2.SetActive(true);
        //     Lock_2.SetActive(false);
        // }

        // if(Level_3)
        // {
        //     Button_3.SetActive(true);
        //     Lock_3.SetActive(false);
        // }

        // if (time[0] != 0)
        // {
        //     if (time[0] >= 120)
        //     {
        //         Level1_star[0].SetActive(true);
        //         Level1_star[1].SetActive(true);
        //         Level1_star[2].SetActive(true);
        //     }
        //     else if(time[0] >= 60)
        //     {
        //         Level1_star[0].SetActive(true);
        //         Level1_star[1].SetActive(true);
        //         Level1_star[2].SetActive(false);
        //     }
        //     else
        //     {
        //         Level1_star[0].SetActive(true);
        //         Level1_star[1].SetActive(false);
        //         Level1_star[2].SetActive(false);
        //     }
        // }
        // if (time[1] != 0)
        // {
        //     if (time[1] >= 120)
        //     {

        //     }
        //     else if(time[1] >= 60)
        //     {

        //     }
        //     else
        //     {
                
        //     }
        // }
        // if (time[2] != 0)
        // {
        //     if (time[2] >= 120)
        //     {

        //     }
        //     else if(time[2] >= 60)
        //     {

        //     }
        //     else
        //     {
                
        //     }
        // }
    }

    // Update is called once per frame
    void Update()
    {
        Level1_star[0] = GameObject.Find("Level1_Star").transform.Find("Level1_star1").gameObject;
        Level1_star[1] = GameObject.Find("Level1_Star").transform.Find("Level1_star2").gameObject;
        Level1_star[2] = GameObject.Find("Level1_Star").transform.Find("Level1_star3").gameObject;

        Level2_star[0] = GameObject.Find("Level2_Star").transform.Find("Level2_star1").gameObject;
        Level2_star[1] = GameObject.Find("Level2_Star").transform.Find("Level2_star2").gameObject;
        Level2_star[2] = GameObject.Find("Level2_Star").transform.Find("Level2_star3").gameObject;

        Level3_star[0] = GameObject.Find("Level3_Star").transform.Find("Level3_star1").gameObject;
        Level3_star[1] = GameObject.Find("Level3_Star").transform.Find("Level3_star2").gameObject;
        Level3_star[2] = GameObject.Find("Level3_Star").transform.Find("Level3_star3").gameObject;

        Button_2 = GameObject.Find("LevelButton").transform.Find("Level2").gameObject;
        Button_3 = GameObject.Find("LevelButton").transform.Find("Level3").gameObject;
        Lock_2 = GameObject.Find("Lock2");
        Lock_3 = GameObject.Find("Lock3");

        if(Level_2)
        {
            Button_2.SetActive(true);
            Lock_2.SetActive(false);
        }

        if(Level_3)
        {
            Button_3.SetActive(true);
            Lock_3.SetActive(false);
        }

        if (time[0] != 0)
        {
            if (time[0] >= 120)
            {
                Level1_star[0].SetActive(true);
                Level1_star[1].SetActive(true);
                Level1_star[2].SetActive(true);
            }
            else if(time[0] >= 60)
            {
                Level1_star[0].SetActive(true);
                Level1_star[1].SetActive(true);
            }
            else
            {
                Level1_star[0].SetActive(true);
            }
            Button_2.SetActive(true);
            Lock_2.SetActive(false);
        }
        if (time[1] != 0)
        {
            if (time[1] >= 120)
            {

            }
            else if(time[1] >= 60)
            {

            }
            else
            {
                
            }
            Button_3.SetActive(true);
            Lock_3.SetActive(false);
        }
        if (time[2] != 0)
        {
            if (time[2] >= 120)
            {

            }
            else if(time[2] >= 60)
            {

            }
            else
            {
                
            }
        }
    }
}
