using UnityEngine;

public class DeviceOperator : MonoBehaviour
{
    public float distance = 1.5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            Operate();
    }
    private void Operate()
    {
        RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position, transform.right, distance);

        foreach (var hit in hits)
        {
            var device = hit.collider.GetComponent<DoorOpenDevice>();
            if (device != null)
                device.Operate();
        }
    }
}
