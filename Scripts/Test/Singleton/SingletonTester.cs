using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �Ѳ����߹��ص������� ����ʹ���ߵ�Test���� �۲���û��ִ��ʹ���ߵĹ��캯��
// �����Log�����˵��������Ĺ��캯����������
public class SingletonTester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         SingletonUser.Instance.Test();
    }
}
