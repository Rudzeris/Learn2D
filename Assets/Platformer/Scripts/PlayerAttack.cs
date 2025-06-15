using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float distance = 1f; // ��������� �����
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // "������� ��� ������"
            RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position, transform.right, distance);
            // "���������, ��� ��� ����� � ������ � ����� 'Destroy'"
            foreach (var hit in hits)
            {
                if (hit.collider.CompareTag("Destroy"))
                {
                    // "���� �����, ����������(��� ������� ����, ������� ��� ���������) ������"
                    Destroy(hit.collider.gameObject);
                    break; // "������� �� ����� ����� ������� ���������"
                }
            }
        }
    }
}
