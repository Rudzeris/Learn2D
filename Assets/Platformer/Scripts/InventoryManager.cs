using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private uint itemCount = 0; // Количество предметов в инвентаре
    public static InventoryManager Instance { get; private set; }
    private void Start()
    {
        Instance = this;
    }
    public void AddItem()
    {
        itemCount++;
        Debug.Log("Предмет добавлен в инвентарь. Текущее количество: " + itemCount);
    }
}
