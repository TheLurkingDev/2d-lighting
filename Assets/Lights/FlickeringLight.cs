using System.Collections;
using UnityEngine;


public class FlickeringLight : MonoBehaviour
{
    private UnityEngine.Experimental.Rendering.LWRP.Light2D _light;
    private const float _minFlickerSpeed = 0.1f;
    private const float _maxFlickerSpeed = 0.5f;

    private const float _minIntensity = 0.3f;
    private const float _maxIntensity = 1.0f;

    private const float _minRadius = 1.2f;
    private const float _maxRadius = 2.75f;

    [SerializeField]
    private Sprite[] _lightCookies;

    private bool _waiting;

    private void Start()
    {
        _light = GetComponentInChildren<UnityEngine.Experimental.Rendering.LWRP.Light2D>();
    }

    private void FixedUpdate()
    {
        if(!_waiting)
        {
            StartCoroutine(WaitAndFlicker());
        }        
    }

    IEnumerator WaitAndFlicker()
    {
        _waiting = true;
        yield return new WaitForSeconds(RandomFlickerInterval());
        _light.intensity = RandomIntensity();
        _light.pointLightOuterRadius = RandomRadius();        
        _waiting = false;
    }

    private float RandomFlickerInterval()
    {
        return Random.Range(_minFlickerSpeed, _maxFlickerSpeed);
    }

    private float RandomIntensity()
    {
        return Random.Range(_minIntensity, _maxIntensity);
    }

    private float RandomRadius()
    {
        return Random.Range(_minRadius, _maxRadius);
    }

    /// <summary>
    /// Not used. Property currently only has a 'getter'.
    /// </summary>
    /// <returns></returns>
    private Sprite RandomLightCookie()
    {
        var maxArrayCount = _lightCookies.Length - 1;
        return _lightCookies[Random.Range(0, maxArrayCount)];
    }
}
