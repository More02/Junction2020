using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ImageProgressBar : MonoBehaviour
{
	public UnityEvent onBarFilled;
	// Время в секундах необходимое для заполнения Progressbar'а
	public float timeToFill = 1.0f;

	// Переменная, куда будет сохранена ссылка на компонент Image
	// текущего объекта, который является ProgressBar'ом
	private Image progressBarImage = null;
	public Coroutine barFillCoroutine = null;

	public GameObject cam;
	public GameObject body;
	private string prevStr = "Home";

	void Start()
	{
		// Получаем ссылку на компонент Image текущего объекта при
		// помощи метода GetComponent<>();
		progressBarImage = GetComponent<Image>();

		// Если у данного объекта нет компонента Image выводим ошибку
		// в консоль
		if (progressBarImage == null)
		{
			Debug.LogError("There is no referenced image on this component!");
		}

		// Создаём контроллер для события наведения указателя на объект
		EventTrigger eventTrigger = gameObject.transform.parent.gameObject.AddComponent<EventTrigger>();

		EventTrigger.Entry pointerEnter = new EventTrigger.Entry();
		pointerEnter.eventID = EventTriggerType.PointerEnter;
		pointerEnter.callback.AddListener((eventData) => { StartFillingProgressBar(); });
		eventTrigger.triggers.Add(pointerEnter);

		EventTrigger.Entry pointerExit = new EventTrigger.Entry();
		pointerExit.eventID = EventTriggerType.PointerExit;
		pointerExit.callback.AddListener((eventData) => { StopFillingProgressBar(); });
		eventTrigger.triggers.Add(pointerExit);
	}

	void StartFillingProgressBar()
	{
		barFillCoroutine = StartCoroutine("Fill");
	}

	void StopFillingProgressBar()
	{
		StopCoroutine(barFillCoroutine);
		progressBarImage.fillAmount = 0.0f;
	}

	IEnumerator Fill()
	{
		float startTime = Time.time;
		float overTime = startTime + timeToFill;

		while (Time.time < overTime)
		{
			progressBarImage.fillAmount = Mathf.Lerp(0, 1, (Time.time - startTime) / timeToFill);
			yield return null;
		}

		progressBarImage.fillAmount = 0.0f;

		cam.transform.position = new Vector3(transform.position.x, 25.854f, transform.position.z);

		string str = transform.parent.gameObject.name;

		if (str.Equals("Home"))
		{
			if (prevStr.Equals(str))
			{
				Application.Quit();
			}
			else
			{
				prevStr = str;
			}
		}

		if (str.Equals("Forest"))
		{
			if (prevStr.Equals(str))
			{
				SceneManager.LoadScene("Assets/FreeVegetation-LowPolyNature/Demo/TerrainScene.unity");
			}
			else
			{
				prevStr = str;
			}
		}

		if (str.Equals("Flight 1"))
		{
			if (prevStr.Equals(str))
			{
				SceneManager.LoadScene("Assets/LowPolyLandscape/Maps/Example_Terrain.unity");
			}
			else
			{
				prevStr = str;
			}
		}

		if (str.Equals("Fire"))
		{
			if (prevStr.Equals(str))
			{
				SceneManager.LoadScene("Assets/LowPolyLandscape/Maps/Example_Night.unity");
			}
			else
			{
				prevStr = str;
			}
		}

		if (str.Equals("Sand"))
		{
			if (prevStr.Equals(str))
			{
				SceneManager.LoadScene("Assets/Scenes/Beach.unity");
			}
			else
			{
				prevStr = str;
			}
		}

		if (str.Equals("Flight 2"))
		{
			if (prevStr.Equals(str))
			{
				SceneManager.LoadScene("Assets/Scenes/SceneForPlaneLast.unity");
			}
			else
			{
				prevStr = str;
			}
		}

		if (onBarFilled != null)
		{
			onBarFilled.Invoke();
		}
	}
}