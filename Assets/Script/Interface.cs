using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interface : MonoBehaviour
{

    protected InterfaceManagerComp interface_manager_comp;

    void Start()
    {
        interface_manager_comp = gameObject.GetComponent<InterfaceManagerComp>();
    }

    public virtual void Up()
    {
        Debug.Log("현재 인터페이스에 없는 키 입니다!!!! 이거어케눌름?????");
    }
    public virtual void Down()
    {
        Debug.Log("현재 인터페이스에 없는 키 입니다!!!! 이거어케눌름?????");
    }
    public virtual void Left()
    {
        Debug.Log("현재 인터페이스에 없는 키 입니다!!!! 이거어케눌름?????");
    }
    public virtual void Right()
    {
        Debug.Log("현재 인터페이스에 없는 키 입니다!!!! 이거어케눌름?????");
    }

    public virtual void A()
    {
        Debug.Log("현재 인터페이스에 없는 키 입니다!!!! 이거어케눌름?????");
    }

    public virtual void B()
    {
        Debug.Log("현재 인터페이스에 없는 키 입니다!!!! 이거어케눌름?????");
    }
    public virtual void O()
    {
        Debug.Log("현재 인터페이스에 없는 키 입니다!!!! 이거어케눌름?????");
    }
    public virtual void M()
    {
        Debug.Log("현재 인터페이스에 없는 키 입니다!!!! 이거어케눌름?????");
    }

}
