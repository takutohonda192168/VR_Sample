using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoge : MonoBehaviour {

    private void Update()
    {
        // 左右への方向転換
        var h = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).x;
        transform.Rotate(0, h * 3f, 0);
        
    }
}

