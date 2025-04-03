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

    //레이를 발사하는 함수

    void ShootRay()
    {
        Ray ray = new Ray(transform.position, transform.forward);        //발사할 Ray의 시작점. 방향지정(메인 카메라에서 중앙)
        RaycastHit hit;                                                     //Ray를 맞은 대상의 정보를 저장할 저장소

        if (Physics.Raycast(ray, out hit))                                  //Raycast의 반환형은 bool로, Ray를 맞았다면 true로 변환
        {
            Destroy(hit.collider.gameObject);                               //맞은 대상 오브젝트 제거
        }
    }
}
