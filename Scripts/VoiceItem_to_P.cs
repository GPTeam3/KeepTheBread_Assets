using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
/*


public class VoiceItem_to_P : MonoBehaviour
{
    public Transform player;             // 플레이어를 따라가기 위한 플레이어의 Transform
    public float moveSpeed = 3.0f;       // 이동 속도
    public float detectionRange = 7.0f;  // 플레이어 감지 범위
    public float roamingRadius = 20.0f;  // 로밍 반경
    public float roamingDuration = 3.0f; // 로밍 지속 시간

    private Vector3 startPosition;       // 초기 위치
    private bool isChasing = false;     // 플레이어를 추격 중인지 여부

    private Vector3 randomRoamingPosition; // 로밍 위치를 저장하기 위한 변수
    private float roamingTimer = 0.0f;    // 로밍 타이머

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
        // 음성 인식기 초기화
        recognizer = new SpeechRecognizer();

        // 음성 인식 결과 리스너 등록
        recognizer.OnPhraseRecognized += OnPhraseRecognized;

        // 음성 인식 시작
        recognizer.Start();
    }

    void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        string spokenPhrase = args.text;

        Debug.Log("인식된 명령: " + spokenPhrase);

 
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
        if (enabled) // Enemy가 활성화된 경우에만 실행
        {
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);
            float loudness = GetAveragedVolume() * sensitivity;

            if (loudness > 7)
            {
                // 음성 감지로 인해 추격
                isChasing = true;
            }
            else
            {
                // 음성 감지하지 않으면 플레이어를 피해 가도록 코드 추가
                isChasing = false;
                Vector3 moveDirection = (player.position - transform.position).normalized;
                transform.position -= moveDirection * moveSpeed * Time.deltaTime;
            }

            if (isChasing)
            {
                // 기존 추격 코드
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
                // 음성 감지하지 않을 때도 이동 방향으로 얼굴을 맞춤
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