using UnityEngine;

public class MatchBehavior : MonoBehaviour
{
    public ID idObj;

    private void onTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehavior>();
        if (tempObj = null)
            return;

        var otherID = tempObj.idObj;
        Debug.Log(otherID == idObj ? "Matched" : "No Match");
    }
}
