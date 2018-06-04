using UnityEngine;
using UnityEngine.UI;

public class SwitchPanel : MonoBehaviour
{
    //记录登陆和注册界面
    GameObject LoginPanel;
    GameObject RegisterPanel;

    //记录用于切换界面的注册按钮和返回按钮
    Button LoginPaneRegisterBtn;
    Button RegisterPanelCancelBtn;

    private void Awake()
    {
        LoginPanel = transform.Find("Login_Panel").gameObject;
        RegisterPanel = transform.Find("Register_Panel").gameObject;

        LoginPaneRegisterBtn = GameObject.FindWithTag("regSWitch").GetComponent<Button>();
        RegisterPanelCancelBtn = GameObject.FindWithTag("LogSwitch").GetComponent<Button>();

        LoginPaneRegisterBtn.onClick.AddListener(
            ()=>
            {
                LoginPanel.SetActive(false);
                RegisterPanel.SetActive(true);
            }
            );

        RegisterPanelCancelBtn.onClick.AddListener(
            () =>
            {
                LoginPanel.SetActive(true);
                RegisterPanel.SetActive(false);
            }
            );
    }

    private void Start()
    {
        LoginPanel.SetActive(true);
        RegisterPanel.SetActive(false);
    }
}
