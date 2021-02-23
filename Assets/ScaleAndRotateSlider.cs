using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleAndRotateSlider : MonoBehaviour
{
    private Slider scaleSlider;
    private Slider rotateSlider;
    public float scaleMinValue = 1f;
    public float scaleMaxValue = 5f;
    public float rotMinValue;
    public float rotMaxValue;
    GameObject sword;
    GameObject penny;
    GameObject zombie;

    buttonScript bS;

    public bool pC;

    void Start()
    {
        GameObject bt = GameObject.Find("Button");
        bS = bt.GetComponent<buttonScript>();

        scaleSlider = GameObject.Find("ScaleSlider").GetComponent<Slider>();
        scaleSlider.minValue = scaleMinValue;
        scaleSlider.maxValue = scaleMaxValue;

        scaleSlider.onValueChanged.AddListener(ScaleSliderUpdate);

        rotateSlider = GameObject.Find("RotateSlider").GetComponent<Slider>();
        rotateSlider.minValue = rotMinValue;
        rotateSlider.maxValue = rotMaxValue;

        rotateSlider.onValueChanged.AddListener(RotateSliderUpdate);

        sword = GameObject.Find("Heavy_Full_Metal_Sword");
        penny = GameObject.Find("Penny");
        zombie = GameObject.Find("Zombie@Z_Run_InPlace");

        //sword.transform.localScale = new Vector3(1, 1, 1);
        //penny.transform.localScale = new Vector3(100, 3, 100);
        //zombie.transform.localScale = new Vector3(1, 1, 1);


        

    }

    private void Update()
    {
        pC = bS.pp;
    }

    void ScaleSliderUpdate(float value)
    {
        if(pC == false)
        {
            transform.localScale = new Vector3(value / 100, value / 100, value / 100);
        }      
        else
        {
            transform.localScale = new Vector3(value, value / 100, value);
        }
        //if(bS.ss == true || bS.zz == true)
        //{
        //    transform.localScale = new Vector3(value / 100, value / 100, value / 100);
        //}
        //else if(bS.pp == true)
        //{
        //    transform.localScale = new Vector3(value, value / 100, value);
        //}

    }

    void RotateSliderUpdate(float value)
    {
        transform.localEulerAngles = new Vector3(transform.rotation.x, value, transform.rotation.z);
    }
}
