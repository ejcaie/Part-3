using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Building : MonoBehaviour
{
    public Transform tomb;
    public Transform pumpkin1;
    public Transform pumpkin2;
    public float tombinterpolation;
    public float pump1interpolation;
    public float pump2interpolation;
    void Start()
    {
        StartCoroutine(Build());
    }
    IEnumerator Build()
    {
        StartCoroutine(BuildTomb());
        yield return null;
        StartCoroutine(BuildPumpkin1());
        yield return null;
        StartCoroutine (BuildPumpkin2());
    }
    IEnumerator BuildTomb()
    {
        yield return new WaitForSeconds(1f);
        while (tombinterpolation < 1)
        {
            tombinterpolation += Time.deltaTime;
            tomb.transform.localScale = Vector2.Lerp(Vector2.zero, Vector2.one, tombinterpolation);
            yield return null;
        }
    }
    IEnumerator BuildPumpkin1()
    {
        yield return new WaitForSeconds(1.5f);
        while (pump1interpolation < 1)
        {
            pump1interpolation += Time.deltaTime;
            pumpkin1.transform.localScale = Vector2.Lerp(Vector2.zero, Vector2.one, pump1interpolation);
            yield return null;
        }
    }
    IEnumerator BuildPumpkin2()
    {
        yield return new WaitForSeconds(2f);
        while (pump2interpolation < 1)
        {
            pump2interpolation += Time.deltaTime;
            pumpkin2.transform.localScale = Vector2.Lerp(Vector2.zero, Vector2.one, pump2interpolation);
            yield return null;
        }
    }
}
