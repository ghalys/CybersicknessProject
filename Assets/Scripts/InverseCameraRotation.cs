using UnityEngine;
using UnityEngine.XR;

public class InverseCameraRotation : MonoBehaviour
{
    private Camera mainCamera;
    
    private void Start()
    {
        mainCamera = GetComponent<Camera>();
    }

    private void Update()
    {
        if (XRSettings.enabled)
        {
            // Obtenez la rotation de la tête de l'utilisateur.
            Quaternion headRotation = InputTracking.GetLocalRotation(XRNode.Head);

            // Inversez la rotation de la tête.
            Quaternion invertedRotation = Quaternion.Inverse(headRotation);

            // Appliquez la rotation inversée à la caméra.
            mainCamera.transform.localRotation = invertedRotation;
        }
    }
}
