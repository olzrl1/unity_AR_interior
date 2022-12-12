using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create : MonoBehaviour
{
    public GameObject obj;
    public int btn_count = -1;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            CreateOBJ();
        }
    }
    public void CreateOBJ(){
        ++btn_count;
        Debug.Log(btn_count);

        if(btn_count == 0){  //생성
            Instantiate(obj, new Vector3(0, -1, 2), Quaternion.identity);
        }

        else if(btn_count == 1){  //삭제
            Destroy(GameObject.Find(gameObject.name + "(Clone)"));
            btn_count = -1 ;
        }
    }
}