using UnityEngine;

public class Sheping : MonoBehaviour
{
   
    [SerializeField] private Animator _cameraAnimator;

    private const string _cameraNameAnim = "Camera";

    public void ShakingCamera()
    {
        _cameraAnimator.Play(_cameraNameAnim);
    }
}
