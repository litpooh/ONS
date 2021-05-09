using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public Transform target;
    public float smoothing;
    public Animator animator;
    public FloatValue currentStat;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (transform.position != target.position){
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        }
    }

   /*public void updateSanityForCamera(){
        if (currentStat < 60){
            animator.SetBool("drunk", true);
        }
        if (currentStat >= 60){
            animator.SetBool("drunk", false);
        }
    }*/
}
