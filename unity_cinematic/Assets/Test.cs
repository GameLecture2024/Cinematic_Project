using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(1f);

        Debug.Log("ȭ���� ��ο���");

        yield return new WaitForSeconds(1f);

        Debug.Log("ȭ���� �����");
    }



}
