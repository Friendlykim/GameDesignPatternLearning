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

IEnumerator Rotate() //������Ʈ������ ����� ��ɺ��� ��ũ��Ʈ�� ���� ���, ��ɺ��� �����ϱ� ����������
    {
        while(true)
        {
            transform.Rotate(90f * Vector3.up);

                yield return new WaitForSeconds(0.3f);
        }
    }
}
