using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(1f);

        Debug.Log("화면이 어두워짐");

        yield return new WaitForSeconds(1f);

        Debug.Log("화면이 밝아짐");
    }



}
