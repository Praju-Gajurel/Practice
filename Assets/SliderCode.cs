using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderCode : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider MySlider;
    public Text Praju;


    void Update()
    {
        Praju.text = MySlider.value.ToString("F2");
        



    }
}
