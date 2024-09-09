using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoToScene : MonoBehaviour
{
    public string sceneName; // Name of the scene to load after the video

    private VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();

        // Register event to detect when the video finishes
        videoPlayer.loopPointReached += OnVideoFinished;
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        // Load the specified scene after video finishes
        SceneManager.LoadScene(sceneName);
    }
}
