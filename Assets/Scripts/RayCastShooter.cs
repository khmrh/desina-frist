using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastShooter : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootRay();
        }
    }

    //���̸� �߻��ϴ� �Լ�

    void ShootRay()
    {
        Ray ray = new Ray(transform.position, transform.forward);        //�߻��� Ray�� ������. ��������(���� ī�޶󿡼� �߾�)
        RaycastHit hit;                                                     //Ray�� ���� ����� ������ ������ �����

        if (Physics.Raycast(ray, out hit))                                  //Raycast�� ��ȯ���� bool��, Ray�� �¾Ҵٸ� true�� ��ȯ
        {
            Destroy(hit.collider.gameObject);                               //���� ��� ������Ʈ ����
        }
    }
}
