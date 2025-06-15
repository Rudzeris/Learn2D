using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            // ����� ����� �������� ������ ��� ��������� ������� ��������
            // ��������, ��������� ���� ������ ��� ������������ ������
            Debug.Log("������� ��������!");

            //InventoryManager.Instance.AddItem(); // ��������� ������� � ���������

            // ������� ������� ����� �������
            Destroy(gameObject);
        }
    }
}
