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
        // == �� ���� ������ true
        // != �� ���� �ٸ��� true
        // > ���� ���� �� ũ�� true
        // < ������ ���� �� ũ�� true
        // >= ���� ���� ũ�ų� ������ true
        // <= ������ ���� �� ũ�ų� ������ true         
       if (gold > 50) //Debug.Log("���ӽ���");      //����Ƽ ����׿� �޼����� ���
        {
            Debug.Log("�������� ������ �� �ֽ��ϴ�.");
        }
       else if (gold == 40) // if�ȿ� ������ ���� �ƴ� �� �� ������ ���̶��
        {
            Debug.Log("��尡 40�� ���� �� �Դϴ�. 10 ��常 �� ������ ��� �־��!");
        }
       // else //if ���� ������ ���� �ƴ� ��
       // {
       //     Debug.Log("��尡 �����մϴ�.");
      //  }
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))                 //Debug.Log("���� ������"); //space�� ������ �� true
        {
            gold = gold + 10;                                          //gold�� 10�� �߰��Ѵ�
            Debug.Log("���� ��� : " + gold);                         //����Ƽ �ֿܼ� ���� gold���� ����ش�.
        }
    }
}
