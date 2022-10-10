using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInterface : Interface
{
    public string now_choice;
    public string choice1 = "조수화면";
    public string choice2 = "행성화면";

    private void Start()
    {
        now_choice = choice1;
    }

    public override void Up()
    {
        Debug.Log("메뉴업");
        if (now_choice == choice1) { now_choice = choice2; Debug.Log(now_choice); }
        else {now_choice = choice1; Debug.Log(now_choice);
    }

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
        Debug.Log(now_choice);
        if (now_choice == choice1) Debug.Log(now_choice);
        else interface_manager_comp.now = gameObject.GetComponent<PlanetInterface>();
    }

}
