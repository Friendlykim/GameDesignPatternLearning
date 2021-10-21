using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAct : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Rotate());
    }

IEnumerator Rotate() //콤포넌트패턴을 사용해 기능별로 스크립트를 나눈 모습, 기능별로 수정하기 용이해진다
    {
        while(true)
        {
            transform.Rotate(90f * Vector3.up);

                yield return new WaitForSeconds(0.3f);
        }
    }
}
