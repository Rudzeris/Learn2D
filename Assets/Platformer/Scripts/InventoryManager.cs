using TMPro;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private TMP_Text text; // ��������� ���� ��� ����������� ���������� ���������
    [SerializeField] private uint itemCount = 0; // ���������� ��������� � ���������
    public static InventoryManager Instance { get; private set; }
    private void Start()
    {
        Instance = this;
    }
    public void AddItem()
    {
        itemCount++;
        text.text = $"Items: {itemCount}"; // ��������� ��������� ���� � ����������� ���������
        Debug.Log("������� �������� � ���������. ������� ����������: " + itemCount);
    }
}
