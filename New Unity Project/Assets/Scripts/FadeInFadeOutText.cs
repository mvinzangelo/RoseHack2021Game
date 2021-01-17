﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInFadeOutText : MonoBehaviour
{
    // can ignore the update, it's just to make the coroutines get called for example
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            TextStart();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            TextEnd();
        }
    }
    public void TextStart()
    {
        StartCoroutine(FadeTextToFullAlpha(1f, GetComponent<Text>()));
    }

    public void TextEnd()
    {
        StartCoroutine(FadeTextToZeroAlpha(1f, GetComponent<Text>()));
    }

    public IEnumerator FadeTextToFullAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
    }

    public IEnumerator FadeTextToZeroAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }
}
