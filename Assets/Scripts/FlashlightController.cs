using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    [SerializeField] private new Light light;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            audioSource.Play();
            light.enabled = !light.enabled;
        }
    }
}
