using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicMovement : MonoBehaviour
{
    public float moveSpeed = 20f; //�̵��ӵ�
    public float jumpForce = 5f;

    public Rigidbody rb;                        //Rigidbooy ������Ʈ�� �޾ƿ� ����

    private bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�̵�ó��
        float moveX = Input.GetAxis("Horizontal"); //�¿� �̵�
        float moveY = Input.GetAxis("Vertical");  //�յ� �̵�

        Vector3 moveDirecction = new Vector3(moveX, 0, moveY).normalized;      //�̵� ���� ����

        //Rigidboody�� ���� �־� �̵�
        rb.MovePosition(transform.position +  moveDirecction * moveSpeed * Time.deltaTime);

        //����ó��
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)              //&&������ a�� ���̰� b�� ���϶� / \\ or������ a�Ǵ� b�� ���϶�
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void OnCollisionStay(Collision collision)           //��ü�� �浹�� �� ��
    {
        isGrounded = true;      //�ٴڿ� ��Ҵٰ� üũ
    }

    private void OnCollisionExit(Collision collision)       //��ü�� ���� ��������
    {
        isGrounded = false;
    }
}
