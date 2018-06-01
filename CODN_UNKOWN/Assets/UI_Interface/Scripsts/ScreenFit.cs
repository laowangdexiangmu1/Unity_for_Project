using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenFit : MonoBehaviour
{
    //定义X,Y向当前屏幕尺寸与制作尺寸的比例
    float rateX, rateY;
    private void Awake()
    {
        //计算X,Y向当前屏幕尺寸与制作尺寸的比例
        rateX = Screen.width / Const.OriginWidth;
        rateY = Screen.height / Const.OriginHeight;
    }
    private void Start()
    {
        //将获取的比例赋予总Panel实现屏幕的自适应
        transform.localScale = new Vector3(rateX, rateY, 1);
    }
}
