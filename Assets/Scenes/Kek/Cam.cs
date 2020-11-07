using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    bool moveRight, moveLeft; // просто значения влево/вправо - [b]необязательны[/b]
    Transform selfTransform, mainCamTransform; //сохраняем трансформ нашего объекта и камеры
    [SerializeField]
    Camera mainView;    //вешаем сюда нашу камеру
    Vector3 wantedPosition;
    void Start()
    {
        mainCamTransform = mainView.transform;
        selfTransform = transform;
        StartCoroutine(coUpdate());
    }

    IEnumerator coUpdate()
    {

        while (true)
        {

            wantedPosition = transform.position;
            mainCamTransform.position = Vector3.Lerp(mainCamTransform.position, wantedPosition, Time.deltaTime * 5.0f); //плавно сдвигает камеру. В нашем случае по X

            yield return 0;
        }
    }
}
