using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public static bool isItemShoes;
    public float isItemShoes_Time;
    float ItemShoes_Start;
    public GameObject Shoes_L;
    public GameObject Shoes_R;


    public static bool isItemShield;
    public float isItemShield_Time;
    float ItemShield_Start;

    public GameObject Shield;


    public static bool isItemVoice;
    public float isItemVoice_Time;
    float ItemVoice_Start;
    public GameObject Voice;

    void Start()
    {
        isItemShoes = false;
        isItemShield = false;
        isItemVoice = false;

        Shoes_L.SetActive(false);
        Shoes_R.SetActive(false);

        Shield.SetActive(false);
        Voice.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - ItemShoes_Start > isItemShoes_Time)
        {
            isItemShoes = false;
            Shoes_L.SetActive(false);
            Shoes_R.SetActive(false);
        }
        if (Time.time - ItemShield_Start > isItemShield_Time)
        {
            isItemShield = false;
            Shield.SetActive(false);

        }

        if (Time.time - ItemVoice_Start > isItemVoice_Time)
        {
            isItemVoice = false;
            Voice.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Shoe"))// Shoe 아이템과 충돌했을 때
        {
            Destroy(collision.gameObject); // 충돌한 아이템 제거
            isItemShoes = true;
            Shoes_L.SetActive(true);
            Shoes_R.SetActive(true);
            ItemShoes_Start = Time.time;

            // moveSpeed = 10f;
            // StartCoroutine(ResetMoveSpeedAfterDuration(15.0f));

        }

        if (collision.transform.CompareTag("Shield"))
        {
            Destroy(collision.gameObject);
            isItemShield = true;
            Shield.SetActive(true);
            ItemShield_Start = Time.time;
            // 충돌한 아이템 제거
            // Debug.Log("Shield");
            // jumpForce = 6f;
            // StartCoroutine(ResetJumpForceAfterDuration(15.0f));

        }


        if (collision.transform.CompareTag("Voice"))// Shoe 아이템과 충돌했을 때
        {
            Destroy(collision.gameObject); // 충돌한 아이템 제거
            isItemVoice = true;
            Voice.SetActive(true);
            ItemVoice_Start = Time.time;

            // Debug.Log("Voice");


            // float loudness = detector.GetLoudnessFromMicrophone() * loudnessSensibility;
            // if (loudness < threshold)
            // 	loudness = 0;

            // // Assuming you have a reference to the EnemyController script on the same GameObject
            // EnemyController enemyController = GetComponent<EnemyController>();

            // if (enemyController != null)
            // {
            // 	// Set the IsChasing variable in the EnemyController script
            // 	enemyController.isChasing = loudness > 5;
            // 	transform.localScale = Vector3.Lerp(minScale, maxScale, loudness);

            // 	// 추가: 'VoiceItem'과 충돌 처리가 완료되면 'VoiceItem'을 비활성화
            // 	collision.gameObject.gameObject.SetActive(false);
            // }
        }
    }
}
