using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class TrumpController : MonoBehaviour
{

    public Rigidbody rb;
    private float speed = 4f;
    private Animation anim;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animation>();
    }

    void Update()
    {
        float x = CrossPlatformInputManager.GetAxis("Horizontal");
        float y = CrossPlatformInputManager.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0, y);
        rb.velocity = movement * speed;

        if (x != 0 && y != 0)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(x, y) * Mathf.Rad2Deg, transform.eulerAngles.z);
        }

        if (x != 0 || y != 0)
        {
            anim.Play("Walk");
        }
        else
        {
            anim.Play("Idel");
        }
    }
}
