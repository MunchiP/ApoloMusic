using UnityEngine;

public class ObjectLook : MonoBehaviour
{
    public Transform playerCameraRoot;  // El transform que define la dirección de la cámara del jugador
    public Transform grabPoint;  // El Empty que definirá la posición de agarre
    public float grabRange = 3f;  // Rango para detectar objetos

    private GameObject heldObject;  // El objeto que estamos sosteniendo

    public GameObject image1;  // Imagen por defecto
    public GameObject image2;  // Imagen cuando hay un objeto válido en el alcance

    private Quaternion objectInitialRotation;  // Guardamos la rotación inicial del objeto

    void Update()
    {
        // Raycast para detectar objetos en el rango
        RaycastHit hitInfo;
        Ray ray = new Ray(playerCameraRoot.position, playerCameraRoot.forward);  // Raycast desde el PlayerCameraRoot

        if (Physics.Raycast(ray, out hitInfo, grabRange))
        {
            // Si el objeto tiene la etiqueta "Maceta" o "Agua"
            if (hitInfo.collider.CompareTag("Maceta") || hitInfo.collider.CompareTag("Agua"))
            {
                // Cambiar la imagen a image2 cuando está en el rango
                ChangeImage(true);

                // Si se hace clic, agarramos el objeto
                if (Input.GetMouseButtonDown(0))
                {
                    TryGrabObject(hitInfo.collider.gameObject);
                }
            }
            else
            {
                // Si no es un objeto válido, volvemos a la imagen por defecto
                ChangeImage(false);
            }
        }
        else
        {
            // Si no hay nada en el rango, volvemos a la imagen por defecto
            ChangeImage(false);
        }

        // Si estamos sosteniendo un objeto, lo seguimos con el Empty (grabPoint)
        if (heldObject)
        {
            heldObject.transform.position = grabPoint.position;  // El objeto se mueve al Empty
            heldObject.transform.rotation = objectInitialRotation;  // Mantiene su rotación original
        }

        // Soltar el objeto al soltar el clic
        if (Input.GetMouseButtonUp(0))
        {
            ReleaseObject();
        }
    }

    // Intentar agarrar el objeto
    void TryGrabObject(GameObject objectToGrab)
    {
        heldObject = objectToGrab;
        heldObject.transform.SetParent(grabPoint);  // El objeto sigue el Empty
        objectInitialRotation = heldObject.transform.rotation;  // Guardamos la rotación inicial del objeto
        heldObject.GetComponent<Rigidbody>().isKinematic = true;  // Desactivamos la física mientras lo sostenemos
    }

    // Soltar el objeto
    void ReleaseObject()
    {
        if (heldObject)
        {
            heldObject.transform.SetParent(null);  // Soltar el objeto
            heldObject.GetComponent<Rigidbody>().isKinematic = false;  // Reactivamos la física
            heldObject = null;
            ChangeImage(false);  // Volver a la imagen por defecto
        }
    }

    // Cambiar las imágenes
    void ChangeImage(bool isValid)
    {
        if (isValid)
        {
            image1.SetActive(false);  // Ocultar la imagen por defecto
            image2.SetActive(true);   // Mostrar la imagen válida
        }
        else
        {
            image1.SetActive(true);   // Mostrar la imagen por defecto
            image2.SetActive(false);  // Ocultar la imagen válida
        }
    }
}
