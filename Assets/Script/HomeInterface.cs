using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HomeInterface : Interface
{

    public GameObject menu;

    public override void Up()
    {
        
    }
    public override void Down()
    {

    }
    public override void Left()
    {

    }
    public override void Right()
    {

    }

    public override void A()
    {

    }

    public override void B()
    {

    }
    public override void O()
    {

    }
    public override void M()
    {
        menu.SetActive(true);
        interface_manager_comp.now = gameObject.GetComponent<MenuInterface>();
    }

}
