using UnityEngine;

public class ReverseGravity : MonoBehaviour
{
    public Rigidbody GorillaPlayer;
    public string HandTag = "HandTag";
    private bool NewRotation = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(HandTag))
        {
            Flip();
        }
    }

    private void Update()
    {
        if (!NewRotation)
        {
            GorillaPlayer.AddForce(Vector3.up * Physics.gravity.magnitude * 2, ForceMode.Acceleration);
        }
    }

    public void Flip()
    {
        NewRotation = !NewRotation;
        GorillaPlayer.rotation = NewRotation ? Quaternion.identity : Quaternion.Euler(180, 0, 0);
    }
}