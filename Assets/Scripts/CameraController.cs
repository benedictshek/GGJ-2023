using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class CameraController : MonoBehaviour
{
    [SerializeField] private PostProcessVolume postProcessVolume;

    private bool isUsingCamera;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if(!isUsingCamera) return;
            postProcessVolume.enabled = !postProcessVolume.enabled;
        }
    }
    
    public void EnableCamera()
    {
        isUsingCamera = true;
    }
    
    public void DisableCamera()
    {
        isUsingCamera = false;
        postProcessVolume.enabled = false;
    }
}
