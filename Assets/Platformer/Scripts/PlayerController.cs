using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 250f;

    private Animator animator;
    private Rigidbody2D body;
    private Collider2D myCollider;
    private bool isRun = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
    }

    void FixedUpdate()
    {
        float dx = Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;

        isRun = Mathf.Abs(dx) >= 0.2;
        animator.SetBool("isRun", isRun);

        if(dx<0)
            transform.localScale = new Vector3(-1, 1, 1);
        else if(dx>0)
            transform.localScale = new Vector3(1, 1, 1);

        bool grounded = false;
        Vector3 max = myCollider.bounds.max;
        Vector3 min = myCollider.bounds.min;
        Vector2 point1 = new Vector2(max.x-0.1f, min.y - 0.2f);
        Vector2 point2 = new Vector2(min.x+0.1f, min.y - 0.2f);
        Collider2D hit = Physics2D.OverlapArea(point1, point2);
        if (hit != null) grounded = true;
        if (grounded && Input.GetKeyDown(KeyCode.Space))// Прыжок
            body.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);

        body.velocity = new Vector2(dx, body.velocity.y);
    }
}
