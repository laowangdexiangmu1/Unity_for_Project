using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

/// <summary>
/// 抽英雄的盒子的脚本
/// </summary>
public class Boxes_CardsUI_Show : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject BoxPanel;     //点击该脚本物体显示的UI

    RectTransform herosBoxRect;     //该脚本物体的 RectTransform 组件
    Vector3 originalScale;          //该脚本物体的原始大小
    Vector3 clickedScale;           //该脚本物体被点击后的大小

    private void Start()
    {
        herosBoxRect = GetComponent<RectTransform>();
        originalScale = herosBoxRect.localScale;
        clickedScale = new Vector3(1.5f, 1.5f, 0);
    }

    /// <summary>
    /// 鼠标点下
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerDown(PointerEventData eventData)
    {
        herosBoxRect.localScale = clickedScale;
    }

    /// <summary>
    /// 鼠标抬起
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerUp(PointerEventData eventData)
    {
        herosBoxRect.localScale = originalScale;
        BoxPanel.SetActive(true); 
    }
}
