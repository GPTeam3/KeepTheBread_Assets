using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
/*


public class VoiceItem_to_P : MonoBehaviour
{
    public Transform player;             // �÷��̾ ���󰡱� ���� �÷��̾��� Transform
    public float moveSpeed = 3.0f;       // �̵� �ӵ�
    public float detectionRange = 7.0f;  // �÷��̾� ���� ����
    public float roamingRadius = 20.0f;  // �ι� �ݰ�
    public float roamingDuration = 3.0f; // �ι� ���� �ð�

    private Vector3 startPosition;       // �ʱ� ��ġ
    private bool isChasing = false;     // �÷��̾ �߰� ������ ����

    private Vector3 randomRoamingPosition; // �ι� ��ġ�� �����ϱ� ���� ����
    private float roamingTimer = 0.0f;    // �ι� Ÿ�̸�

    private AudioSource _audio;

    public float sensitivity = 100;
    public float loudness = 0;

    //  public GameObject Movie1;
    //  public GameObject Movie2;
    private bool isFlying = false;

    private SpeechRecognizer recognizer;


    void VoiceRecognitionStart()
    {
        _audio = GetComponent<AudioSource>();

        player = GameObject.FindGameObjectWithTag("Player").transform;
        startPosition = transform.position;
        SetRandomRoamingPosition();
    }

    void VoiceRecognitionStart()
    {
        // ���� �νı� �ʱ�ȭ
        recognizer = new SpeechRecognizer();

        // ���� �ν� ��� ������ ���
        recognizer.OnPhraseRecognized += OnPhraseRecognized;

        // ���� �ν� ����
        recognizer.Start();
    }

    void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        string spokenPhrase = args.text;

        Debug.Log("�νĵ� ���: " + spokenPhrase);

 
    }

    void OnDestroy()
    {
        if (recognizer != null)
        {
            recognizer.OnPhraseRecognized -= OnPhraseRecognized;
            recognizer.Stop();
            recognizer.Dispose();
        }
    }

    void Update()
    {
        if (enabled) // Enemy�� Ȱ��ȭ�� ��쿡�� ����
        {
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);
            float loudness = GetAveragedVolume() * sensitivity;

            if (loudness > 7)
            {
                // ���� ������ ���� �߰�
                isChasing = true;
            }
            else
            {
                // ���� �������� ������ �÷��̾ ���� ������ �ڵ� �߰�
                isChasing = false;
                Vector3 moveDirection = (player.position - transform.position).normalized;
                transform.position -= moveDirection * moveSpeed * Time.deltaTime;
            }

            if (isChasing)
            {
                // ���� �߰� �ڵ�
                Vector3 moveDirection = (player.position - transform.position).normalized;
                transform.position += moveDirection * moveSpeed * Time.deltaTime;

                if (distanceToPlayer >= detectionRange)
                {
                    isChasing = false;
                    SetRandomRoamingPosition();
                }
            }
            else
            {
                // ���� �������� ���� ���� �̵� �������� ���� ����
                Vector3 moveDirection = (randomRoamingPosition - transform.position).normalized;
                transform.forward = moveDirection;
                Roam();
            }
        }
    }






    void SetRandomRoamingPosition()
    {
        randomRoamingPosition = startPosition + new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)) * roamingRadius;
    }

    void Roam()
    {
        roamingTimer += Time.deltaTime;
        if (roamingTimer >= roamingDuration)
        {
            SetRandomRoamingPosition();
            roamingTimer = 0.0f;
        }

        transform.position = Vector3.MoveTowards(transform.position, randomRoamingPosition, moveSpeed * Time.deltaTime);
    }


    float GetAveragedVolume()
    {
        float[] data = new float[256];
        float a = 0;
        _audio.GetOutputData(data, 0);
        foreach (float s in data)
        {
            a += Mathf.Abs(s);
        }
        return a / 256;
    }



}
*/