using System;
using DG.Tweening;
using UnityEngine;

public class SwitchHandItems : MonoBehaviour
{
    [SerializeField] private GameObject flashLight;
    [SerializeField] private GameObject camera;

    [SerializeField] private Transform itemHideTransform;

    private Vector3 flashLightShowPos;
    private Vector3 cameraShowPos;

    [SerializeField] private float showItemDuration;

    private FlashlightController flashlightController;

    private void Awake()
    {
        flashlightController = flashLight.GetComponent<FlashlightController>();
    }

    private void Start()
    {
        //flashLight.SetActive(false);
        //camera.SetActive(false);

        flashLightShowPos = flashLight.transform.localPosition;
        cameraShowPos = camera.transform.localPosition;

        camera.transform.DOLocalMove(itemHideTransform.localPosition, showItemDuration);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //flashLight.SetActive(true);
            //camera.SetActive(false);
            
            var itemHideLocalPosition = itemHideTransform.localPosition;
            flashLight.transform.DOLocalMove(flashLightShowPos, showItemDuration).From(itemHideLocalPosition);
            camera.transform.DOLocalMove(itemHideLocalPosition, showItemDuration).From(cameraShowPos);
            
            flashlightController.EnableFlashLight();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //flashLight.SetActive(false);
            //camera.SetActive(true);

            var itemHideLocalPosition = itemHideTransform.localPosition;
            flashLight.transform.DOLocalMove(itemHideLocalPosition, showItemDuration).From(flashLightShowPos);
            camera.transform.DOLocalMove(cameraShowPos, showItemDuration).From(itemHideLocalPosition);
            
            flashlightController.DisableFlashLight();
        }
    }
}
