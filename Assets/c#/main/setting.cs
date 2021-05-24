using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class setting : MonoBehaviour
{

    public static setting instance;

    public float distance = 100; //거리 m기준임(z)
    public float slope = 10f; //x축 기준 경사각도
    public float ball_mass = 1f; //공의 질량

    public GameObject ball;
    public GameObject cube;

    public Rigidbody rb;

    void Awake()
    {
        this.Mass();

        this.Slope();

        this.Distance();

        if (!instance)
            instance = this;
    }

    public float getDistance()
    {
        return distance;
    }

    public float getBallMass()
    {
        return ball_mass;
    }

    public float getSlope()
    {
        return slope;
    }

    void Mass()//볼 질량
    {
        rb = ball.GetComponent<Rigidbody>();
        rb.mass = ball_mass;
    }

    void Slope() //경사각도
    {
        Quaternion rotate = cube.transform.rotation;
        cube.transform.rotation = Quaternion.Euler(slope, 0, 0);
    }

    void Distance() //거리
    {
        Vector3 localScalee = cube.transform.localScale;
        cube.transform.localScale = new Vector3(localScalee.x, localScalee.y + 1, distance);
    }

}
