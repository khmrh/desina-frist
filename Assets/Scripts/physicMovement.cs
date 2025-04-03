using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicMovement : MonoBehaviour
{
    public float moveSpeed = 20f; //이동속도
    public float jumpForce = 5f;

    public Rigidbody rb;                        //Rigidbooy 컴포넌트를 받아올 변수

    private bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //이동처리
        float moveX = Input.GetAxis("Horizontal"); //좌우 이동
        float moveY = Input.GetAxis("Vertical");  //앞뒤 이동

        Vector3 moveDirecction = new Vector3(moveX, 0, moveY).normalized;      //이동 방향 벡터

        //Rigidboody에 힘을 주어 이동
        rb.MovePosition(transform.position +  moveDirecction * moveSpeed * Time.deltaTime);

        //점프처리
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)              //&&연산자 a가 참이고 b도 참일때 / \\ or연산자 a또는 b가 참일때
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void OnCollisionStay(Collision collision)           //물체가 충돌중 일 떄
    {
        isGrounded = true;      //바닥에 닿았다고 체크
    }

    private void OnCollisionExit(Collision collision)       //물체가 서로 떨어질때
    {
        isGrounded = false;
    }
}
