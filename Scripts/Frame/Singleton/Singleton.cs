using System;
using UnityEngine;

/// <summary>
/// ���̳�MonoBehaviour�ĵ�����
/// �̳иõ��������������乹�캯���н��г�ʼ��
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class Singleton<T> : IResetable where T : Singleton<T>
{
    private static T _instance;
    // ����������
    protected readonly static object lockObj = new object();
    public static T Instance {
        get
        {
            // ˫�����ж� ��ֹ���̷߳������ɶ��ʵ��
            if (_instance == null)
            {
                lock (lockObj) {
                    if (_instance == null)
                        _instance = Activator.CreateInstance(typeof(T), true) as T;
                }
            }
            return _instance;
        }
    }
    // �����������жϵ������Ƿ��Ѿ�ʵ����
    public static bool isInstantiated { get => _instance != null; }
    protected Singleton() {}
    // �ýӿ��������õ����� ������ʱ�����
    public abstract void Reset();
}
