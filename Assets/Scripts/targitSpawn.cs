using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targitSpawn : MonoBehaviour
{
    public GameObject panelPrefeb;                  //과녁 프리팹(오브젝트)

    public float generateTime = 3f;                 //재성성 시간

    private float timer = 0;                       //재생성 시간 저장용 변수

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(panelPrefeb);                   //과녁 오브젝트를 Scene의 원점에 생성한다
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;                                        //tiemr 변수에서 deltaTime을 빼서 지난 시간 측정

        if (timer <= 0)                                                 //timer가 0보다 작거나 같을 떄
        {
            timer = generateTime;                                       //tiemr에 재생성 시간을 넣어 초기화

            float xPositsion = Random.Range(-10f, 10f);                 //-10~10 사이의 랜덤한 실수압ㄱ을 xPosition에 대입
            Vector3 newpos = new Vector3(xPositsion, 0, 0);             //과녁이 새롭게 생길 Position값
            Instantiate(panelPrefeb, newpos, Quaternion.identity);      //과녁 프리팹을 newPos 위치에 생성함
        }
    }
}
