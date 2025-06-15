using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            // Здесь можно добавить логику для обработки подбора предмета
            // Например, увеличить счет игрока или активировать эффект
            Debug.Log("Предмет подобран!");

            //InventoryManager.Instance.AddItem(); // Добавляем предмет в инвентарь

            // Удаляем предмет после подбора
            Destroy(gameObject);
        }
    }
}
