using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private uint itemCount = 0; // ���������� ��������� � ���������
    public static InventoryManager Instance { get; private set; }
    private void Start()
    {
        Instance = this;
    }
    public void AddItem()
    {
        itemCount++;
        Debug.Log("������� �������� � ���������. ������� ����������: " + itemCount);
    }
}
