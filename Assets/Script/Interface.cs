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
        Debug.Log("���� �������̽��� ���� Ű �Դϴ�!!!! �̰ž��ɴ���?????");
    }
    public virtual void Down()
    {
        Debug.Log("���� �������̽��� ���� Ű �Դϴ�!!!! �̰ž��ɴ���?????");
    }
    public virtual void Left()
    {
        Debug.Log("���� �������̽��� ���� Ű �Դϴ�!!!! �̰ž��ɴ���?????");
    }
    public virtual void Right()
    {
        Debug.Log("���� �������̽��� ���� Ű �Դϴ�!!!! �̰ž��ɴ���?????");
    }

    public virtual void A()
    {
        Debug.Log("���� �������̽��� ���� Ű �Դϴ�!!!! �̰ž��ɴ���?????");
    }

    public virtual void B()
    {
        Debug.Log("���� �������̽��� ���� Ű �Դϴ�!!!! �̰ž��ɴ���?????");
    }
    public virtual void O()
    {
        Debug.Log("���� �������̽��� ���� Ű �Դϴ�!!!! �̰ž��ɴ���?????");
    }
    public virtual void M()
    {
        Debug.Log("���� �������̽��� ���� Ű �Դϴ�!!!! �̰ž��ɴ���?????");
    }

}
