using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
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

    private RandomCustomer randomCustomerScript; // RandomCustomer ��ũ��Ʈ ����

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        startPosition = transform.position;
        SetRandomRoamingPosition();

        // BreadCheck ������Ʈ�� ã�Ƽ� �� �Ʒ��� �ִ� RandomCustomer ��ũ��Ʈ�� ���������� ����
        GameObject breadCheckObject = player.Find("BreadCheck").gameObject;
        randomCustomerScript = breadCheckObject.GetComponent<RandomCustomer>();
    }

    void Update()
    {
        if (enabled) // Enemy�� Ȱ��ȭ�� ��쿡�� ����
        {
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);

            if (distanceToPlayer <= detectionRange && randomCustomerScript.mybread == true)
            {
                // �÷��̾���� �Ÿ��� 7 ������ �� ��� ����
                isChasing = true;

                // �÷��̾� ������ �ٶ󺸵��� ȸ��
                Vector3 lookDirection = (player.position - transform.position).normalized;
                transform.forward = lookDirection;
            }
            else
            {
                Vector3 moveDirection = (randomRoamingPosition - transform.position).normalized;
                transform.forward = moveDirection;
                Roam();
            }

            if (isChasing)
            {
                Vector3 moveDirection = (player.position - transform.position).normalized;
                transform.position += moveDirection * moveSpeed * Time.deltaTime;

                if (distanceToPlayer >= detectionRange)
                {
                    isChasing = false;
                    SetRandomRoamingPosition();
                    // �ι� ��ġ�� ���� �������� �ʾ����� �ʱ�ȭ
                }
            }
            else
            {
                // ���� ���� �ƴ� ���� �̵� �������� ���� ���߱�
                Vector3 moveDirection = (randomRoamingPosition - transform.position).normalized;
                transform.forward = moveDirection;
                Roam();
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") // Assuming the player has the "Player" tag
        {
            randomCustomerScript.mybread = false;
            randomCustomerScript.bread.SetActive(false);
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
}