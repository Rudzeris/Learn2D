using UnityEngine;

public class TriggerDevice : MonoBehaviour
{
    [SerializeField] private DoorOpenDevice doorOpenDevice;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            doorOpenDevice.Open();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            doorOpenDevice.Close();
        }
    }
}
