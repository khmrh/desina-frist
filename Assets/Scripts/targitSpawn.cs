using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targitSpawn : MonoBehaviour
{
    public GameObject panelPrefeb;                  //���� ������(������Ʈ)

    public float generateTime = 3f;                 //�缺�� �ð�

    private float timer = 0;                       //����� �ð� ����� ����

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(panelPrefeb);                   //���� ������Ʈ�� Scene�� ������ �����Ѵ�
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;                                        //tiemr �������� deltaTime�� ���� ���� �ð� ����

        if (timer <= 0)                                                 //timer�� 0���� �۰ų� ���� ��
        {
            timer = generateTime;                                       //tiemr�� ����� �ð��� �־� �ʱ�ȭ

            float xPositsion = Random.Range(-10f, 10f);                 //-10~10 ������ ������ �Ǽ��Ф��� xPosition�� ����
            Vector3 newpos = new Vector3(xPositsion, 0, 0);             //������ ���Ӱ� ���� Position��
            Instantiate(panelPrefeb, newpos, Quaternion.identity);      //���� �������� newPos ��ġ�� ������
        }
    }
}
