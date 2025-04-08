using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RayCastShooter : MonoBehaviour
{   
    public ParticleSystem flashEftect;                                   //발사 이펙트 변수 선언

    // 탄창 관련 변수 선언
    public int magazineCapacity = 30;                                            //탄창의 크기
    private int currentAmmo;                                                    //현재 총알 갯수

    public TextMeshProUGUI ammoUI;                                                  //초앙ㄹ 갯수를 나타낼 TMP선언

    //재장전 기능 변수 선언

    public Image reloadingUI;                                                       //재장전 UI
    public float reloadTime = 2f;                                                   //재장전시간
    private float timer = 0;                                                        //시간 확인용 타이머
    private bool isReloading = false;                                               //재장전 확인요 ㅇbool변수

    //사운드 출력 기능 변수 선언
    public AudioSource audioSource;
    public AudioClip audioClip;
    void Start()
    {
        audioSource.PlayOneShot(audioClip);
        currentAmmo = magazineCapacity;                                         //현재 총알의 갯수를 탄창의 크기만큼
        //ammoUI.text = currentAmmo + "/" + magazineCapacity;
        ammoUI.text = $"{currentAmmo}/{magazineCapacity}/";                     //현재 총알 갯수를 ui에 표시

        reloadingUI.gameObject.SetActive(false);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && currentAmmo > 0 && isReloading == false)                      //현재 총알이 0개보다 클 때
        {
            audioSource.PlayOneShot (audioClip);
            currentAmmo--;                                                       //총알을 1개 소비한다
            flashEftect.Play();                                                //이펙트 재생    
            ammoUI.text = $"{currentAmmo}/{magazineCapacity}";                 //현재 총알 갯수를 ui에 표시(총알 소비수 표시!!!!!)
            ShootRay();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            isReloading = true;
            reloadingUI.gameObject.SetActive(true);
        }

        if (isReloading == true)
        {
            Reloading();
        }
    }

    //레이를 발사하는 함수

    void ShootRay()
    {
        Ray ray = new Ray(transform.position, transform.forward);              //발사할 Ray의 시작점. 방향지정(메인 카메라에서 중앙)
        RaycastHit hit;                                                       //Ray를 맞은 대상의 정보를 저장할 저장소

        if (Physics.Raycast(ray, out hit))                                    //Raycast의 반환형은 bool로, Ray를 맞았다면 true로 변환
        {
            Destroy(hit.collider.gameObject);                                //맞은 대상 오브젝트 제거
        }
    }

   void Reloading()
    {
        timer += Time.deltaTime;

        reloadingUI.fillAmount = timer / reloadTime;

        if (timer >= reloadTime)
        {
            timer = 0;
            isReloading = false;
            currentAmmo = magazineCapacity;                                      //총알을 채워준다
            ammoUI.text = $"{currentAmmo}/{magazineCapacity}";                 //현재 총알 갯수를 ui에 표시(총알 소비수 표시!!!!!)
            reloadingUI.gameObject.SetActive(false);
        }
    }
}
