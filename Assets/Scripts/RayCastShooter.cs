using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RayCastShooter : MonoBehaviour
{   
    public ParticleSystem flashEftect;                                   //�߻� ����Ʈ ���� ����

    // źâ ���� ���� ����
    public int magazineCapacity = 30;                                            //źâ�� ũ��
    private int currentAmmo;                                                    //���� �Ѿ� ����

    public TextMeshProUGUI ammoUI;                                                  //�ʾӤ� ������ ��Ÿ�� TMP����

    //������ ��� ���� ����

    public Image reloadingUI;                                                       //������ UI
    public float reloadTime = 2f;                                                   //�������ð�
    private float timer = 0;                                                        //�ð� Ȯ�ο� Ÿ�̸�
    private bool isReloading = false;                                               //������ Ȯ�ο� ��bool����

    //���� ��� ��� ���� ����
    public AudioSource audioSource;
    public AudioClip audioClip;
    void Start()
    {
        audioSource.PlayOneShot(audioClip);
        currentAmmo = magazineCapacity;                                         //���� �Ѿ��� ������ źâ�� ũ�⸸ŭ
        //ammoUI.text = currentAmmo + "/" + magazineCapacity;
        ammoUI.text = $"{currentAmmo}/{magazineCapacity}/";                     //���� �Ѿ� ������ ui�� ǥ��

        reloadingUI.gameObject.SetActive(false);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && currentAmmo > 0 && isReloading == false)                      //���� �Ѿ��� 0������ Ŭ ��
        {
            audioSource.PlayOneShot (audioClip);
            currentAmmo--;                                                       //�Ѿ��� 1�� �Һ��Ѵ�
            flashEftect.Play();                                                //����Ʈ ���    
            ammoUI.text = $"{currentAmmo}/{magazineCapacity}";                 //���� �Ѿ� ������ ui�� ǥ��(�Ѿ� �Һ�� ǥ��!!!!!)
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

    //���̸� �߻��ϴ� �Լ�

    void ShootRay()
    {
        Ray ray = new Ray(transform.position, transform.forward);              //�߻��� Ray�� ������. ��������(���� ī�޶󿡼� �߾�)
        RaycastHit hit;                                                       //Ray�� ���� ����� ������ ������ �����

        if (Physics.Raycast(ray, out hit))                                    //Raycast�� ��ȯ���� bool��, Ray�� �¾Ҵٸ� true�� ��ȯ
        {
            Destroy(hit.collider.gameObject);                                //���� ��� ������Ʈ ����
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
            currentAmmo = magazineCapacity;                                      //�Ѿ��� ä���ش�
            ammoUI.text = $"{currentAmmo}/{magazineCapacity}";                 //���� �Ѿ� ������ ui�� ǥ��(�Ѿ� �Һ�� ǥ��!!!!!)
            reloadingUI.gameObject.SetActive(false);
        }
    }
}
