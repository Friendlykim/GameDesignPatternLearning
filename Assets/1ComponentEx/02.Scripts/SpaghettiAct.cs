using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum MOVE1
{
    MOVE_RIGHT,
    MOVE_LEFT
}

public class SpaghettiAct : MonoBehaviour
{
    GameObject player1;
    GameObject player2;
    MOVE1 move1 = MOVE1.MOVE_RIGHT;

    // Start is called before the first frame update
    void Start()
    {
        player1 = GameObject.Find("Player1") as GameObject;
        player2 = GameObject.Find("Player2") as GameObject;

        StartCoroutine(MixedAct());
    }

    IEnumerator MixedAct() //스파게티로 짠 코드는 여러 기능이 한 스크립트에 모여있어 기능별로 수정하기 불편하다
    {
        while(true)
        {
            player1.transform.Rotate(90f * Vector3.up);
            player2.transform.Rotate(90f * Vector3.up);

            if(player1.transform.position.x < -4)
            {
                move1 = MOVE1.MOVE_RIGHT;
            }
            else if(player1.transform.position.x > 4)
            {
                move1 = MOVE1.MOVE_LEFT;
            }

            if(move1==MOVE1.MOVE_RIGHT)
            {
                player1.transform.Translate(1f * Vector3.right, Space.World);
                player2.transform.Translate(-1f * Vector3.right, Space.World);
            }
            else
            {
                player1.transform.Translate(-1f * Vector3.right, Space.World);
                player2.transform.Translate(1f * Vector3.right, Space.World);
            }
            //Debug.Log("실행됨");
            yield return new WaitForSeconds(0.5f);
        }
    }
}
