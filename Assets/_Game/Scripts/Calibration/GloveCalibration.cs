using UnityEngine;

public class GloveCalibration : MonoBehaviour
{
    [SerializeField] private VRfreeGlove m_vrFreeGlove = null;

    // Use this for initialization
    private void Start()
    {
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        m_vrFreeGlove.showCalibrationPose();
    }

    // Call this function when the hand is ready to be adjusted
    public void CompleteCalibrationStep()
    {
        m_vrFreeGlove.hideCalibrationPose();
        m_vrFreeGlove.calibrate();
        Camera.main.clearFlags = CameraClearFlags.Skybox;

        //Load the last scene
        MyGameManager._instance.GetComponent<GloverSceneManager>().LoadLastScene();
    }
}
