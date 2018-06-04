using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// 版娘的脚本，用于关闭UI界面（点击空白处关闭盒子奖励界面）
/// </summary>
public class Boxes_CardsUI_Close : MonoBehaviour, IPointerClickHandler 
{
    public GameObject[] BoxPanels;
    public Sprite normalSprite;
    public Sprite smileSprite;

    Image currentImage;
    Text warningText;

    private void Start()
    {
        currentImage = GetComponent<Image>();
        warningText = transform.GetComponentInChildren<Text>();
    }

    private void Update()
    {
        if (BoxPanels[0].activeSelf || BoxPanels[1].activeSelf)
        {
            currentImage.sprite = smileSprite;
            warningText.enabled = true;
        }
        else
        {
            currentImage.sprite = normalSprite;
            warningText.enabled = false;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        for (int i = 0; i < BoxPanels.Length; i++)
        {
            BoxPanels[i].SetActive(false);
        }
    }
}
