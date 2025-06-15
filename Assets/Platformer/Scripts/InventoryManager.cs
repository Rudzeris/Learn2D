using TMPro;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private TMP_Text text; // Текстовое поле для отображения количества предметов
    [SerializeField] private uint itemCount = 0; // Количество предметов в инвентаре
    public static InventoryManager Instance { get; private set; }
    private void Start()
    {
        Instance = this;
    }
    public void AddItem()
    {
        itemCount++;
        text.text = $"Items: {itemCount}"; // Обновляем текстовое поле с количеством предметов
        Debug.Log("Предмет добавлен в инвентарь. Текущее количество: " + itemCount);
    }
}
