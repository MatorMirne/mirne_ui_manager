using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceManagerComp : MonoBehaviour
{
    public Interface now;

    void Start()
    {
        now = gameObject.GetComponent<HomeInterface>();
    }

    public void Up()
    {
        Debug.Log("������");
        now.Up();
    }
    public void Down()
    {

    }
    public void Left()
    {

    }
    public void Right()
    {

    }

    public void A()
    {

    }
    public void B()
    {

    }
    public void O()
    {

    }
    public void M()
    {
        Debug.Log("�޴�����");
        now.M();
    }
}
