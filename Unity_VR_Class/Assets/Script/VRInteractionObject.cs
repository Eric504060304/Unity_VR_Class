
using UnityEngine;
using UnityEngine.Events;   //引用 事件 命名空間

/// <summary>
/// VR互動物件
/// 1. VR 注視點看到此物件 Enter
/// 2. VR 注視點看到後離開此物件 Exit
/// 3. VR 注視點看到此物件並點選互動按鈕 Click
/// </summary>
public class VRInteractionObject : MonoBehaviour
{
    /// <summary>
    /// 1. 引用 Events 命名空間
    /// 2. 定義Unity Event 類型欄位並設公開
    /// 3. 想要執行此事件
    /// </summary>
    [Header("事件: 看到、離開與點擊"),Space(10)]
    public UnityEvent onEnter;
    public UnityEvent onExit;
    public UnityEvent onClick;

    /// <summary>
    /// VR 注視點看到此物件 Enter
    /// </summary>
    public void OnPointerEnter()
    {
        print("注視點看到");
        onEnter.Invoke();
    }
    /// <summary>
    /// VR 注視點看到後離開此物件 Exit
    /// </summary>
    public void OnPointerExit()
    {
        print("注視點離開");
        onExit.Invoke();
    }
    /// <summary>
    /// VR 注視點看到此物件並點選互動按鈕 Click
    /// </summary>
    public void OnPointerClick()
    {
        print("注視點點擊");
        onClick.Invoke();
    }
}
