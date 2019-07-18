using System.Collections;
using UnityEngine;


public class FlickeringLight : MonoBehaviour
{
    private UnityEngine.Experimental.Rendering.LWRP.Light2D _light;
    private const float _minFlickerSpeed = 0.1f;
    private const float _maxFlickerSpeed = 0.5f;

    private const float _minIntensity = 0.3f;
    private const float _maxIntensity = 1.0f;

    private const float _minRadius = 0.8f;
    private const float _maxRadius = 1.75f;

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
}
