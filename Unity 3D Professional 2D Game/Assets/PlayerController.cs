using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private bool isGrounded;
	private float radius = 0.7f;
	private float force = 300;
	public Transform coinsParent;
	public Transform groundPoint;
	public LayerMask ground;
	public AudioSource audioSource;
	public AudioClip jump;
	public AudioClip coin;
	public AudioClip win;
	public Animator animator;
	public int coins;
	// public Game gameComponent;
	public TextMesh score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
