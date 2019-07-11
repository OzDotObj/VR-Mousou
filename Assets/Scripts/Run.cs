using UnityEngine;

public class Run : MonoBehaviour
{
    GameObject aoi;
    Animator aoiAnimator;

    private void Start()
    {
        aoi = GameObject.Find("Aoi");
        aoiAnimator = aoi.GetComponent<Animator>();
    }

    private void Update()
    {
       OVRInput.Update();

        if (OVRInput.Get(OVRInput.Button.One) || Input.GetKey(KeyCode.R))
        {
            aoiAnimator.SetBool("isIdle", false);
            aoiAnimator.SetBool("isRun", true);
            Invoke("MoveFoward", 2.0f);
        } else {
            aoiAnimator.SetBool("isRun", false);
            aoiAnimator.SetBool("isIdle", true);
        }
    }

    void MoveFoward()
    {
        aoi.transform.Translate(0, 0, Time.deltaTime * 3);
        transform.Translate(0, 0, Time.deltaTime * 3);
    }
}