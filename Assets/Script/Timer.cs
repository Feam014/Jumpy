using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float currenttime = 0f;
    float startingtime = 60f;

    public GameObject youscore;

    public Animator animator;

    [SerializeField] Text countdown;
    [SerializeField] Text countie;

    // Start is called before the first frame update
    void Start()
    {
        currenttime = startingtime;
        youscore.SetActive(false);
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {

        currenttime -= 1 * Time.deltaTime;
        countdown.text = currenttime.ToString("0.00");

        if (currenttime <= 0)
        {
            countdown.text = currenttime.ToString("0");
            currenttime = 0;
            StartCoroutine(FieldsPro());
        }
    }

    IEnumerator FieldsPro()
    {
        animator.SetBool("PanelSwipe", true);

        yield return new WaitForSeconds(0);

        animator.SetBool("PanelSwipe", false);

        animator.SetBool("PanelEnd", true);

        yield return new WaitForSeconds(2);

        animator.SetBool("PanelEnd", false);

        animator.SetBool("Finish", true);

        youscore.SetActive(true);

        Time.timeScale = 0f;
    }
}
