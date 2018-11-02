using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class BasicCubeController : MonoBehaviour, IInputClickHandler, IInputHandler
{
    public GameObject[] pieces;

    private int currentPiece = -1;

    private void Start()
    {
        InputManager.Instance.PushFallbackInputHandler(gameObject);
    }
    void OnEnable()
    {
        resetPieces();
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
    }
    public void OnInputDown(InputEventData eventData)
    { }
    public void OnInputUp(InputEventData eventData)
    {
        nextPiece();
    }

    private void resetPieces()
    {
        currentPiece = -1;
        updatePieces();
    }

    private void nextPiece()
    {
        if (currentPiece < pieces.Length - 1)
        {
            currentPiece++;
            updatePieces();
        } else
        {
            resetPieces();
        }
    }

    private void previousPiece()
    {
        if (currentPiece > 0)
        {
            currentPiece--;
            updatePieces();
        }
    }

    public void updatePieces()
    {
        Debug.Log("Showing piece #" + currentPiece);
        for (int i = 0; i <= currentPiece; ++i)
        {
            pieces[i].SetActive(true);
        }
        for (int i = currentPiece + 1; i < pieces.Length; ++i)
        {
            pieces[i].SetActive(false);
        }
    }
}