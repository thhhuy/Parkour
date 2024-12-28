using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunkerDoor : MonoBehaviour
{
    public static BunkerDoor Instance;
    Animator anim;
    public bool isOpen;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        DoorAnim();
    }
    void DoorAnim()
    {
        anim.SetBool("Door", isOpen);
    }
    public void OpenDoorSound()
    {
        SoundManager.Instance.PlaySoundAtPosition(SoundManager.Instance.DoorOpen, transform.position);
    }
    public void CloseDoorSound()
    {
        SoundManager.Instance.PlaySoundAtPosition(SoundManager.Instance.DoorClose, transform.position);
    }
}
