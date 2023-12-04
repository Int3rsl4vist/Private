
using UnityEditor;
using UnityEngine;


public class ObstacleSpawner : MonoBehaviour
{
    public GameObject prekazka;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Debug.Log("Mouse Position: " + mousePosition);
            Vector3 instantiationPosition = mousePosition - Camera.main.transform.position;
            Debug.Log("Instantiation Position: " + instantiationPosition);
            Instantiate(prekazka, instantiationPosition, Quaternion.identity);
        }
    }
}
/*Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out RaycastHit info))*/

