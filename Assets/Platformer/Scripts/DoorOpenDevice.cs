using UnityEngine;

public class DoorOpenDevice : MonoBehaviour
{
    [SerializeField] private Vector2 dPos;
    private bool _open;

    public void Operate()
    {
        if(_open)
            Close();
        else
            Open();
    }
    public void Open()
    {
        if(!_open)
        {
            transform.position += (Vector3)dPos;
            _open = true;
        }
    }
    public void Close()
    {
        if (_open)
        {
            transform.position -= (Vector3)dPos;
            _open = false;
        }
    }
}
