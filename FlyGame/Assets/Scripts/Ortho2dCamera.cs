
using UnityEngine;


internal class Ortho2dCamera : MonoBehaviour
{
    [SerializeField] private bool uniform = true;
    [SerializeField] private bool autoSetUniform = false;
    [SerializeField] private Camera cameraObj;

    // Start is called before the first frame update
    private void Awake()
    {
        cameraObj.orthographic = true;

        if (uniform)
            SetUniform();
    }
    private void LateUpdate()
    {
        if (autoSetUniform && uniform)
            SetUniform();
    }
    private void SetUniform()
    {
        float orthographicSize = cameraObj.pixelHeight / 200;
        if (orthographicSize != cameraObj.orthographicSize)
            cameraObj.orthographicSize = orthographicSize;
    }
}
