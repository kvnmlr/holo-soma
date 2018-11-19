using HoloToolkit.Examples.InteractiveElements;
using HoloToolkit.Unity;
using HoloToolkit.Unity.SpatialMapping;
using System.Collections;
using System.Collections.Generic;
using UMTL.MixedReality;
using UnityEngine;

public class GameController : Singleton<GameController> {
    public GameObject loading;
    public GameObject menu;
    public GameObject soma;
    public GameObject workspace;
    public GameObject sample;


	// Use this for initialization
	void Start () {
        Debug.Log("Game Started");

        SoundManager.Instance.playOpen();

        loading.SetActive(true);
        soma.SetActive(false);
        menu.SetActive(false);
        workspace.SetActive(false);
        sample.SetActive(true);

        StartCoroutine(StartPlacement());
    }

    IEnumerator StartPlacement()
    {
        yield return new WaitForSeconds(7);
        SoundManager.Instance.playSuccess();
        SpatialMappingManager.Instance.DrawVisualMeshes = false;
        loading.SetActive(false);
        workspace.SetActive(true);
        sample.SetActive(true);
    }

    public void WorkspacePlaced()
    {
        Debug.Log("Workspace Placed");

        SoundManager.Instance.playOpen();

        loading.SetActive(false);
        menu.SetActive(true);
        sample.SetActive(false);
        workspace.SetActive(false);

        Destroy(workspace.GetComponent<TapToPlace>());
    }

    public void StartBasicRoutine ()
    {
        Debug.Log("Basic Routine");
        workspace.SetActive(true);
        soma.SetActive(true);
        menu.SetActive(false);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
