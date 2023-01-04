using UnityEngine;

public class LogicObjectMainScene : MonoBehaviour
{
    public bool isPosition;
    public bool isRotation;
    public bool isScale;

    float xRotation;


    // Update is called once per frame
    void Update()
    {
        if (isPosition)
        {
            transform.position = transform.position + new Vector3(0.0f, 0.0f, 2.0f) * Time.deltaTime;
        }
        if (isRotation)
        {
            xRotation += Time.deltaTime * -5;
            transform.rotation = Quaternion.Euler(xRotation, 0, 0);
        }
        if (isScale)
        {
            transform.localScale = transform.localScale + new Vector3(1.5f, 1.5f, 1.5f) * Time.deltaTime;
        }
    }
}
