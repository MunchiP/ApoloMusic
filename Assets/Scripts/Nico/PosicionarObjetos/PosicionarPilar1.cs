using UnityEngine;

public class PosicionarPilar1 : MonoBehaviour
{
     public string objectName;
    void OnTriggerEnter(Collider other)
    {
        // Solo aceptar el objeto si es una maceta y no tiene padre
        if (other.CompareTag("Maceta") && other.transform.parent == null)
        {
            // Posicionar el objeto en el targetTransform
            //other.transform.position = transform.position;
            other.transform.position = new Vector3 (transform.position.x, transform.position.y+.1f, transform.position.z);
            other.transform.rotation = Quaternion.identity;
            objectName = other.gameObject.name;
            Debug.Log("Nombre de la planta: " + objectName);
            Debug.Log("Matera posicionada en: " + transform.name);
        }
    }

    void OnTriggerExit(Collider other)
    {
       objectName = "";
       Debug.Log(objectName+ " eso");
    }
}