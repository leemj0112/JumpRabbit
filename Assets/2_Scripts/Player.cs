using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    private float JumpPower = 200; //점프 파워

    private Animator anim;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    internal void init() //메소드
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetInteger("StateID", 1); //점프 준비 애니메이션
        }
        if (Input.GetKey(KeyCode.Space))
        {
            JumpPower += 1; //점프 파워 저장

        }

        else if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(Vector2.one * JumpPower); //점프
            JumpPower = 0; //점프 파워 초기화

            anim.SetInteger("StateID", 2); //점프 애니메이션
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) //접촉 시 Velocity 값 초기화
    {
        rb.velocity = Vector2.zero;
        anim.SetInteger("StateID", 0); //점프 애니메이션 초기화
    }
}
