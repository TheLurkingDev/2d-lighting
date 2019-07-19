using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform _transform;
    private AudioSource _audioSource;

    [SerializeField]
    private AudioClip _footstepSound;

    private float _footStepSoundAudioScale = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        _transform = this.gameObject.transform;
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                _transform.Translate(Vector3.up);
                _audioSource.PlayOneShot(_footstepSound, _footStepSoundAudioScale);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                _transform.Translate(Vector3.down);
                _audioSource.PlayOneShot(_footstepSound, _footStepSoundAudioScale);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                _transform.Translate(Vector3.left);
                _audioSource.PlayOneShot(_footstepSound, _footStepSoundAudioScale);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                _transform.Translate(Vector3.right);
                _audioSource.PlayOneShot(_footstepSound, _footStepSoundAudioScale);
            }
        }
    }
}
