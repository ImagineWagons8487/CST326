using System;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class CameraScript : MonoBehaviour
{
    private Vector3 originalPos;
    public float shakeMagnitude = .5f;
    public float shakeFrequency;
    private Vector3 maxShake;
    private Vector3 maxAngularShake = Vector3.one * 2;

    private float recoverySpeed = 1.5f;

    private int traumaExp = 2;
    private float trauma = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalPos = this.gameObject.transform.position;
        shakeFrequency = 25;
        maxShake = Vector3.one * shakeMagnitude;
    }

    // Update is called once per frame
    void Update()
    {
        float shake = Mathf.Pow(trauma, traumaExp);
        transform.localPosition = new Vector3(
            maxShake.x * Mathf.PerlinNoise(0, Time.time * shakeFrequency) * 2 - 1, 
            maxShake.y * Mathf.PerlinNoise(1, Time.time * shakeFrequency) * 2 - 1, 
            maxShake.z * Mathf.PerlinNoise(2, Time.time * shakeFrequency) * 2 - 1
            ) * shake;
        transform.localRotation = Quaternion.Euler(new Vector3(
            maxAngularShake.x * Mathf.PerlinNoise(3, Time.time * shakeFrequency) * 2 - 1,
            maxAngularShake.y * Mathf.PerlinNoise(4, Time.time * shakeFrequency) * 2 - 1,
            maxAngularShake.z * Mathf.PerlinNoise(5, Time.time * shakeFrequency) * 2 - 1
        ) * shake);
        trauma = Mathf.Clamp01(trauma - recoverySpeed * Time.deltaTime);
    }
}
