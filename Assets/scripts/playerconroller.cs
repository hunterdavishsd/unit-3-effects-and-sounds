using UnityEngine;

public class playerconroller : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpforce = 10;
    public float gravityModifier;
    public bool isonground = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isonground)
        {
            playerRb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            isonground = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        isonground = true;
    }
}
