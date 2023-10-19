using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            // ��(Enemy)�� �����Ǹ� ������ �˸���
            EnemyController enemy = other.GetComponent<EnemyController>();
            if (enemy != null)
            {
                enemy.enabled = true;
            }
        }
        else
        {
            EnemyController enemy = other.GetComponent<EnemyController>();
            if (enemy = null)
            {
                enemy.enabled = false;
            }
        }
    }
}
