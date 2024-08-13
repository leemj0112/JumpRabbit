using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    private float JumpPower = 200; //���� �Ŀ�

    private Animator anim;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    internal void init() //�޼ҵ�
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetInteger("StateID", 1); //���� �غ� �ִϸ��̼�
        }
        if (Input.GetKey(KeyCode.Space))
        {
            JumpPower += 1; //���� �Ŀ� ����

        }

        else if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(Vector2.one * JumpPower); //����
            JumpPower = 0; //���� �Ŀ� �ʱ�ȭ

            anim.SetInteger("StateID", 2); //���� �ִϸ��̼�
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) //���� �� Velocity �� �ʱ�ȭ
    {
        rb.velocity = Vector2.zero;
        anim.SetInteger("StateID", 0); //���� �ִϸ��̼� �ʱ�ȭ
    }
}
