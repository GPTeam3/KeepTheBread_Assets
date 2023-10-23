using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player;             // �÷��̾ ���󰡱� ���� �÷��̾��� Transform
    public Transform grandma;            // ��ѱ� �ҸӴϸ� ���󰡱� ���� Grandma�� Transform
    public float moveSpeed = 3.0f;       // �̵� �ӵ�
    public float detectionRange = 7.0f;  // �÷��̾� ���� ����
    public float roamingRadius = 20.0f;  // �ι� �ݰ�
    public float roamingDuration = 3.0f; // �ι� ���� �ð�

    private Vector3 startPosition;       // �ʱ� ��ġ
    public bool isChasing = false;     // �÷��̾ �߰� ������ ����
    private bool grandmaChasing = false;  // grandma�� �߰� ������ ����

    private Vector3 randomRoamingPosition; // �ι� ��ġ�� �����ϱ� ���� ����
    private float roamingTimer = 0.0f;    // �ι� Ÿ�̸�

    private RandomCustomer randomCustomerScript; // RandomCustomer ��ũ��Ʈ ����

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        grandma = GameObject.FindGameObjectWithTag("Grandma").transform;
        startPosition = transform.position;
        SetRandomRoamingPosition();

        // BreadCheck ������Ʈ�� ã�Ƽ� �� �Ʒ��� �ִ� RandomCustomer ��ũ��Ʈ�� ���������� ����
        GameObject breadCheckObject = player.Find("BreadCheck").gameObject;
        randomCustomerScript = breadCheckObject.GetComponent<RandomCustomer>();
    }

    void Update()
    {
        float distanceToGrandma = Vector3.Distance(transform.position, grandma.position);
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (enabled) // Enemy�� Ȱ��ȭ�� ��쿡�� ����
        {
            // Player�� Grandma�� ��ġ ���� �Ÿ� ���
            bool playerInRange = distanceToPlayer <= detectionRange && randomCustomerScript.mybread && !ItemManager.isItemShield && !CheckSound.isSoundLoud == true;
            bool grandmaInRange = distanceToGrandma <= detectionRange;

            if (playerInRange && !grandmaInRange)
            {
                // Player�� �����Ǿ��� �� �÷��̾� ����
                isChasing = true;
                grandmaChasing = false;

                // �ٶ󺸴� ����
                Vector3 lookDirection = (player.position - transform.position).normalized;
                transform.forward = lookDirection;
            }
            else if (!playerInRange && grandmaInRange)
            {
                // Grandma�� �����Ǿ��� �� Grandma ����
                isChasing = false;
                grandmaChasing = true;

                Vector3 lookDirection = (grandma.position - transform.position).normalized;
                transform.forward = lookDirection;
            }
            else if (playerInRange && grandmaInRange)
            {
                // Player�� Grandma ��� �����Ǿ��� �� Player ����
                isChasing = true;
                grandmaChasing = false;

                Vector3 lookDirection = (player.position - transform.position).normalized;
                transform.forward = lookDirection;
            }
            else
            {
                // ��� ���� ������ ������ ���� �� ���� �ι�
                isChasing = false;
                grandmaChasing = false;
                Vector3 moveDirection = (randomRoamingPosition - transform.position).normalized;
                transform.forward = moveDirection;
                Roam();
            }

            if (isChasing) // �Ѿư��� ����
            {
                PlayerChasing();

                if (distanceToPlayer >= detectionRange)
                {
                    isChasing = false;
                    SetRandomRoamingPosition();
                }
            }
            else if (grandmaChasing)
            {
                GrandmaChasing();

                if (distanceToGrandma >= detectionRange)
                {
                    grandmaChasing = false;
                    SetRandomRoamingPosition();
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

    void PlayerChasing()
    {
        Vector3 moveDirection = (player.position - transform.position).normalized;
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }

    void GrandmaChasing()
    {
        float distanceToGrandma = Vector3.Distance(transform.position, grandma.position);

        // Grandma���� �Ÿ��� ���� �� �̻��� ��쿡�� Grandma�� ����
        if (distanceToGrandma > 0.5f)
        {
            Vector3 moveDirection = (grandma.position - transform.position).normalized;
            transform.position += moveDirection * moveSpeed * Time.deltaTime;
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
