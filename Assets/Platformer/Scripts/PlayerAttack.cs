using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float distance = 1f; // Дистанция атаки
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // "Пустить луч вперед"
            RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position, transform.right, distance);
            // "Проверить, что луч попал в объект с тегом 'Destroy'"
            foreach (var hit in hits)
            {
                if (hit.collider.CompareTag("Destroy"))
                {
                    // "Если попал, уничтожить(или нанести урон, получив его компонент) объект"
                    Destroy(hit.collider.gameObject);
                    break; // "Выходим из цикла после первого попадания"
                }
            }
        }
    }
}
