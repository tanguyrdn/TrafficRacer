using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;
    public float DistanceSwipe;
    private Vector2 StartPositionSwipe;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Update()
    {
#if UNITY_ANDROID || UNITY_IOS
        if (Input.touchCount > 0)
        {
            foreach (Touch t in Input.touches)
            {
                Debug.Log(t.position);
                if (t.position.x > Screen.width / 2)
                {
                    //touch droite
                }
                else
                {
                    //touch gauche
                }

                /*Debug.Log(t.phase); 
                
                if (t.phase == TouchPhase.Began)
                {
                    StartPositionSwipe = t.position;
                }
                
                if (t.phase == TouchPhase.Ended || t.phase == TouchPhase.Canceled)
                {
                    float d = Vector2.Distance(StartPositionSwipe, t.position);
                    if (d > DistanceSwipe)
                    {
                        //Swipe action
                    }
                }*/
            }
        }
#endif
    }
}