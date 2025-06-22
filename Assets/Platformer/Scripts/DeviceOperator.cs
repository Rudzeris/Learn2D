using UnityEngine;

public class DeviceOperator : MonoBehaviour
{
    public float radius = 1.5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            Operate();
    }
    private void Operate()
    {
        Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, radius);

        foreach (var hit in hits)
        {
            var device = hit.GetComponent<DoorOpenDevice>();
            if (device != null)
                device.Operate();
        }
    }
}
