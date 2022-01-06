using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider_player : MonoBehaviour
{
    Slider slider;
   
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        //  GameManager.Addlistener(ChangHp);

        EventSystem.AddLisener(EventEnum.ChangeHp, ChangeHp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangHp(int hp,int max_hp)
    {
        slider.maxValue = max_hp;
        slider.value = hp;
    }
    public void ChangeHp(object hp)
    {
        HP my_hp = (HP)hp;
        slider.maxValue = my_hp.max_hp;
        slider.value = my_hp.hp;
    }
}
