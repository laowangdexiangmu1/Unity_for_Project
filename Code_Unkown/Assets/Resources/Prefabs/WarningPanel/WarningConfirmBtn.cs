using UnityEngine;
using UnityEngine.EventSystems;

public class WarningConfirmBtn : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Destroy(transform.parent.parent.gameObject);
    }
}
