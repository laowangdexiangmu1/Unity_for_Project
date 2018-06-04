using UnityEngine;
using DG.Tweening;

public class MenuBtnClickedEvent : MonoBehaviour
{
    public Transform Store, Dormitory, Warehouse, Mission, Option;

    public void OnStoreBtnClicked()
    {
        Store.DOScale(new Vector3(1, 1, 1), 0.2f);
    }

    public void OnDormitoryBtnClicked()
    {
        //Dormitory.DOScale(new Vector3(1, 1, 1), 0.1f);
    }

    public void OnWarehouseBtnClicked()
    {
        //Warehouse.DOScale(new Vector3(1, 1, 1), 0.1f);
    }

    public void OnMissionBtnClicked()
    {
        //Mission.DOScale(new Vector3(1, 1, 1), 0.1f);
    }

    public void OnOptionBtnClicked()
    {
        //Option.DOScale(new Vector3(1, 1, 1), 0.1f);
    }

    /// <summary>
    /// 返回主界面按钮专用
    /// </summary>
    public void ReturnToMainScreen()
    {
        Transform[] btns = new Transform[] { Store }; //  , Dormitory, Warehouse, Mission, Option

        for (int i = 0; i < btns.Length; i++)
        {
            if (btns[i].localScale == new Vector3(0, 0, 0))
            {
                break;
            }
            else
            {
                btns[i].localScale = new Vector3(0, 0, 0);
            }
        }
    }
}
