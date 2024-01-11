using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoge2 : MonoBehaviour {

    private void Update()
    {
        // 上下への方向転換
        var h = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).y;
        transform.Rotate(0, 0,h * 3f);
        
    }
}

