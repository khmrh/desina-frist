using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VasicVariables : MonoBehaviour
{
    public int gold = 0;                    //������ ,//�� �ּ��ΰ� �̹� �˰��ִ� ���, �ٽ� �˾Ƶ���
    public float Hp = 100.0f;               //�Ǽ��� (�Ҽ����� �ִ� ����, ���� 'f' �ʼ�
    public string playerName = "ȫ�浿";   //���ڿ� (������ ����)
    private bool isAlive = true;            //���� (��/������ ��Ÿ��) true/false
    


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("���ӽ���");      //����Ƽ ����׿� �޼����� ���
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("���� ������");
    }
}
