
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SizeChange : MonoBehaviour
{

    /*Vector3 temp;
   //public float size = 1;
    public static Slider MySlider;
    public Text ValueOfSlider;

    // Update is called once per frame
    void Update()
    {
        
        //ValueOfSlider.text = MySlider.value.ToString("f2"); // float with two decimals
        
    }

    public void AdjustSize(Vector3 newSize)
    {
        //temp = newSize;

        //temp = transform.localScale;

        newSize.x = MySlider.value;
        newSize.y = MySlider.value;
        newSize.z = MySlider.value;
    }*/

    public GameObject Watermelon;
    public void Slider_changed(float newValue)
    {
        //Vector3 pos = Watermelon.transform.localScale;
        //pos.x
        Watermelon.transform.localScale += new Vector3(newValue, newValue, newValue);

    }
    void Update()
    {
       
    }
}