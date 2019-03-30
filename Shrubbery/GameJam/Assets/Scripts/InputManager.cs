using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager
{
    //Player1
    public static float MainHorizontal()
    {
        float r = 0.0f;
        r += Input.GetAxisRaw("1J_MainHorizontal");
        return Mathf.Clamp(r, -1.0f, 1.0f);
    }
    public static float MainVertical()
    {
        float r = 0.0f;
        r += Input.GetAxisRaw("1J_MainVertical");
        return Mathf.Clamp(r, -1.0f, 1.0f);
    }

    public static Vector3 MainJoystick()
    {
        return new Vector3(MainHorizontal(), 0, MainVertical());
    }

    public static bool AButton()
    {
        return Input.GetButtonDown("1A_Button");
    }

    public static bool BButton()
    {
        return Input.GetButtonDown("1B_Button");
    }

    public static bool XButton()
    {
        return Input.GetButtonDown("1X_Button");
    }

    public static bool YButton()
    {
        return Input.GetButtonDown("1Y_Button");
    }

    //Player2

    public static float MainHorizontalTwo()
    {
        float r = 0.0f;
        r += Input.GetAxisRaw("2J_MainHorizontal");
        return Mathf.Clamp(r, -1.0f, 1.0f);
    }
    public static float MainVerticalTwo()
    {
        float r = 0.0f;
        r += Input.GetAxisRaw("2J_MainVertical");
        return Mathf.Clamp(r, -1.0f, 1.0f);
    }

    public static Vector3 MainJoystickTwo()
    {
        return new Vector3(MainHorizontalTwo(), 0, MainVerticalTwo());
    }
    public static bool AButtonTwo()
    {
        return Input.GetButtonDown("2A_Button");
    }

    public static bool BButtonTwo()
    {
        return Input.GetButtonDown("2B_Button");
    }

    public static bool XButtonTwo()
    {
        return Input.GetButtonDown("2X_Button");
    }

    public static bool YButtonTwo()
    {
        return Input.GetButtonDown("2Y_Button");
    }

    //Player3
    public static float MainHorizontalThree()
    {
        float r = 0.0f;
        r += Input.GetAxisRaw("3J_MainHorizontal");
        return Mathf.Clamp(r, -1.0f, 1.0f);
    }
    public static float MainVerticalThree()
    {
        float r = 0.0f;
        r += Input.GetAxisRaw("3J_MainVertical");
        return Mathf.Clamp(r, -1.0f, 1.0f);
    }

    public static Vector3 MainJoystickThree()
    {
        return new Vector3(MainHorizontalThree(), 0, MainVerticalThree());
    }
    public static bool AButtonThree()
    {
        return Input.GetButtonDown("3A_Button");
    }

    public static bool BButtonThree()
    {
        return Input.GetButtonDown("3B_Button");
    }

    public static bool XButtonThree()
    {
        return Input.GetButtonDown("3X_Button");
    }

    public static bool YButtonThree()
    {
        return Input.GetButtonDown("3Y_Button");
    }

    //Player4
    public static float MainHorizontalFour()
    {
        float r = 0.0f;
        r += Input.GetAxisRaw("4J_MainHorizontal");
        return Mathf.Clamp(r, -1.0f, 1.0f);
    }
    public static float MainVerticalFour()
    {
        float r = 0.0f;
        r += Input.GetAxisRaw("4J_MainVertical");
        return Mathf.Clamp(r, -1.0f, 1.0f);
    }

    public static Vector3 MainJoystickFour()
    {
        return new Vector3(MainHorizontalFour(), 0, MainVerticalFour());
    }
    public static bool AButtonFour()
    {
        return Input.GetButtonDown("4A_Button");
    }

    public static bool BButtonFour()
    {
        return Input.GetButtonDown("4B_Button");
    }

    public static bool XButtonFour()
    {
        return Input.GetButtonDown("4X_Button");
    }

    public static bool YButtonFour()
    {
        return Input.GetButtonDown("4Y_Button");
    }

}
