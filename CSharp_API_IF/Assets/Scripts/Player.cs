using UnityEngine;

public class Player: MonoBehaviour
{
    public Animator air;

    /// <summary>
    /// 角色走路:走路動畫
    /// </summary>
    private void Walk()
    {
       bool key = Input.GetKey(KeyCode.W);
        air.SetBool("走路開關",key);
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        Walk();
    }

}
