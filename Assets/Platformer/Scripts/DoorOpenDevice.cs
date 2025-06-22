using UnityEngine;

public class DoorOpenDevice : MonoBehaviour
{
    [SerializeField] private Vector2 dPos;
    private bool _open;

    public void Operate()
    {
        Vector3 pos;
        if (_open)
            pos = transform.position - (Vector3)dPos;
        else
            pos = transform.position + (Vector3)dPos;

        transform.position = pos;
        _open = !_open;
    }
}
