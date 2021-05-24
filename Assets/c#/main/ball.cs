using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public static ball instance;

    public GameObject target_obj;
    public bool onEnd = false; //공이 엔드라인에 도달했는가

    void Awake() //시작시 공의 위치를 사작점에 맞춰준다.
    {
        if (!instance)
            instance = this;
               
    }

    void Start()
    {
        Vector3 pos = target_obj.transform.position;
        transform.position = new Vector3(pos.x, pos.y + 1, pos.z);
    }

    public bool getEndLine()
    {
        return onEnd;
    }

   

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "endLine")
        {
            onEnd = true;
        }
    }

}
