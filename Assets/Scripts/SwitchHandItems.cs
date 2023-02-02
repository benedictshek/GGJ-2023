using UnityEngine;

public class SwitchHandItems : MonoBehaviour
{
    [SerializeField] private GameObject flashLight;
    [SerializeField] private GameObject camera;

    private void Start()
    {
        flashLight.SetActive(false);
        camera.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            flashLight.SetActive(true);
            camera.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            flashLight.SetActive(false);
            camera.SetActive(true);
        }
    }
}
