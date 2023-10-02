using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectShow : MonoBehaviour
{
    [SerializeField] private List<GameObject> listObjectShow;
    private int indext = 1;
    [SerializeField] GameObject particleVFX;

    private void Start()
    {
        foreach (Transform tr in transform)
        {
            tr.gameObject.SetActive(false);
            listObjectShow.Add(tr.gameObject);
        }
        listObjectShow[0].SetActive(true);
    }
    public void CheckAndShow()
    {
        if(indext >0) listObjectShow[indext-1].SetActive(false);
        listObjectShow[indext].SetActive(true);
        GameObject explosion = Instantiate(particleVFX, transform.position, transform.rotation);
        Destroy(explosion, .75f);
        indext++;
        if(indext == listObjectShow.Count)
            GameManager.Instance.CheckLevelUp();
    }
}
