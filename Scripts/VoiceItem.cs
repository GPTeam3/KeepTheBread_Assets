/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceItem : MonoBehaviour
{
    public GameObject pigeon; // ��ѱ� ������Ʈ
    private VoiceItem_to_P voiceitem_to_p; // ��ѱ��� VoiceItem ��ũ��Ʈ ����

    void Start()
    {
        voiceitem_to_p = pigeon.GetComponent<VoiceItem_to_P>(); // ��ѱ� ������Ʈ���� VoiceItem ��ũ��Ʈ�� ������
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // ������ A�� �÷��̾ �Ծ��� ��
            // ��ѱ��� ���� �ν� ����
            voiceitem_to_p.StartVoiceRecognition();

            // �ı��ϴ���
            Destroy(gameObject);
        }
    }
}
*/