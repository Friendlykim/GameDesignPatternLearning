using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum MOVE2
{
    MOVE_RIGHT,
    MOVE_LEFT
}

public class MoveAct : MonoBehaviour
{

    MOVE2 move2 = MOVE2.MOVE_RIGHT;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Moveing());
    }

    IEnumerator Moveing()//콤포넌트패턴을 사용해 기능별로 스크립트를 나눈 모습, 기능별로 수정하기 용이해진다
    {
        while(true)
        {
            if(transform.position.x < -4)
            {
                move2 = MOVE2.MOVE_RIGHT;
            }
            else if(transform.position.x > 4)
            {
                move2 = MOVE2.MOVE_LEFT;
            }

            if(move2==MOVE2.MOVE_RIGHT)
            {
                transform.Translate(1f * Vector3.right, Space.World);
            }
            else
            {
                transform.Translate(-1f * Vector3.right, Space.World);
            }

            yield return new WaitForSeconds(0.5f);
        }
    }
}
