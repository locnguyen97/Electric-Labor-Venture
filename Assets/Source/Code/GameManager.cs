using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    

    private int startIndex = 0;

    private int currentIndex;
    [SerializeField] private List<ObjectShow> listObjectShow;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        currentIndex = startIndex;
    }

    public ObjectShow GetCurrentObjectShow()
    {
        return listObjectShow[currentIndex ];
    }
    
    public void CheckLevelUp()
    {
        currentIndex += 1;
        
        StartCoroutine(LevelUp());
    }
    IEnumerator LevelUp()
    {
        yield return new WaitForSeconds(1);
        var list = FindObjectsOfType<ObjectPress>(true);
        foreach (var obj in list)
        {
            obj.Reset();
        }
        if (currentIndex == 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

            currentIndex = 0;
        }

    }
    
}
