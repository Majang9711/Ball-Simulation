using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    public Text txt_distance;
    public Text txt_speed;
    public Text txt_time;
    public Text txt_angle;

    private float time = 0;


    void Update()
    {
        this._main();
    }

    void _main()
    {
      

        if (ball.instance.getEndLine() == true)
        {
            txt_time.text = "초(s) : " + time + "초";

            txt_speed.text = "속도(m/s) : " + setting.instance.getDistance() / time + "m/s";
        }
        else
        {
            time += Time.deltaTime;
            txt_time.text = "초(s) : " + time + "초";

            txt_distance.text = "거리(m) : " + setting.instance.getDistance() + "m";

            txt_angle.text = "경사면 각도 : " + setting.instance.getSlope() + "도";
        }
    }
}
