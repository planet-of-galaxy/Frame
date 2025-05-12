using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 把测试者挂载到场景中 调用使用者的Test方法 观察有没有执行使用者的构造函数
// 如果有Log输出，说明单例类的构造函数被调用了
public class SingletonTester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         SingletonUser.Instance.Test();
    }
}
