/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceItem : MonoBehaviour
{
    public GameObject pigeon; // 비둘기 오브젝트
    private VoiceItem_to_P voiceitem_to_p; // 비둘기의 VoiceItem 스크립트 참조

    void Start()
    {
        voiceitem_to_p = pigeon.GetComponent<VoiceItem_to_P>(); // 비둘기 오브젝트에서 VoiceItem 스크립트를 가져옴
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 아이템 A를 플레이어가 먹었을 때
            // 비둘기의 음성 인식 시작
            voiceitem_to_p.StartVoiceRecognition();

            // 파괴하느너
            Destroy(gameObject);
        }
    }
}
*/