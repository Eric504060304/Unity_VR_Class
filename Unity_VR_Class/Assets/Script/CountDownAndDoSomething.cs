using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

/// <summary>
/// �˼ƭp��
/// �åB����{�Y��Ʊ�}
/// �Ҧp: ���}�C���B���s�C���B��ܿ��
/// </summary>
public class CountDownAndDoSomething : MonoBehaviour
{
    #region ���P�ݩ�
    [Header("�˼Ʈɶ�"), Range(1, 5)]
    public float countDownTime = 3;
    [Header("�˼ƫ�ƥ�")]
    public UnityEvent onTimeUp;
    [Header("����")]
    public Image imgBar;

    private float timeMax;



    /// <summary>
    /// �}�l�˼�: true �}�l�Bfalse ����
    /// �ݩʦbunity�i�H�P�ƥ�i�淾�q
    /// Unity Event �i�H�s��
    /// 1. ������骫��s�����󤺪� API
    /// 2. �s�����}��k�ȭ��G�L�Ϊ̤@�ӰѼơA�������������(������)
    /// 3. �s�����}�ݩʡG�������������(������)
    /// </summary>
    public bool startCountDown { get; set; }
    #endregion

    #region �˼ƥ\��
    //����ƥ�G�bStart �e����@��
    private void Awake()
    {
        timeMax = countDownTime;
    }

    private void Update()
    {
        CountDown();
    }

    /// <summary>
    /// �p�ɾ�
    /// </summary>
    private float timer;

    /// <summary>
    /// �˼ƭp�ɥ\��
    /// </summary>
    void CountDown()
    {
        if (startCountDown)                                 //�p�G �}�l�˼�
        {
            if (timer < countDownTime)                      // �p�G �p�ɾ� �p�� �˼Ʈɶ�
            {

                timer += Time.deltaTime;                    //�֥[�ɶ� (��Update���I�s)
            }
            else
            {
                onTimeUp.Invoke();                          //�_�h �p�ɾ� �j�󵥩� �˼Ʈɶ� �N�I�s�ƥ�
            }
            print("Timer"+(timer/timeMax));
            imgBar.fillAmount = timer / timeMax;            //���� = ��e�ɶ� / �̤j�ɶ�
        }
        else
        {
            timer = 0;                                      //�_�h �S���ݵ۫��s �N����
            imgBar.fillAmount = 0;                          //�����k�s
        }
    }
    #endregion

}
