
using UnityEngine;
using UnityEngine.Events;   //�ޥ� �ƥ� �R�W�Ŷ�

/// <summary>
/// VR���ʪ���
/// 1. VR �`���I�ݨ즹���� Enter
/// 2. VR �`���I�ݨ�����}������ Exit
/// 3. VR �`���I�ݨ즹������I�郎�ʫ��s Click
/// </summary>
public class VRInteractionObject : MonoBehaviour
{
    /// <summary>
    /// 1. �ޥ� Events �R�W�Ŷ�
    /// 2. �w�qUnity Event �������ó]���}
    /// 3. �Q�n���榹�ƥ�
    /// </summary>
    [Header("�ƥ�: �ݨ�B���}�P�I��"),Space(10)]
    public UnityEvent onEnter;
    public UnityEvent onExit;
    public UnityEvent onClick;

    /// <summary>
    /// VR �`���I�ݨ즹���� Enter
    /// </summary>
    public void OnPointerEnter()
    {
        print("�`���I�ݨ�");
        onEnter.Invoke();
    }
    /// <summary>
    /// VR �`���I�ݨ�����}������ Exit
    /// </summary>
    public void OnPointerExit()
    {
        print("�`���I���}");
        onExit.Invoke();
    }
    /// <summary>
    /// VR �`���I�ݨ즹������I�郎�ʫ��s Click
    /// </summary>
    public void OnPointerClick()
    {
        print("�`���I�I��");
        onClick.Invoke();
    }
}
