using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogManager : MonoBehaviour {

	[Tooltip("Caixa de texto do nome no painel de dialogo")]
	[SerializeField]
	private TMP_Text nameText;
	[Tooltip("Caixa de texto do dialogo na caixa de dialogo")]
	[SerializeField] 
	private TMP_Text dialogText;
	[Tooltip("Campo de Image na caixa de dialogo")]
	[SerializeField] private Image portrait;
	private Queue<string> sentences;
	float savePSpeed, saveJPspeed;
	[Tooltip("animator da caixa de dialogo")]
	[SerializeField] 
	private Animator animator;
	[Tooltip("Painel")]
	[SerializeField] 
	private GameObject painel;
	bool _isDialog;
	public bool isDialog { get{ return _isDialog;} }

	private void Awake() {
		_isDialog=false;
	}
	void Start () {
		_isDialog=false;
		sentences=new Queue<string>();
	}

	public void StartDialog(Dialogue dialog, Sprite image)
	{
		_isDialog=true;
		painel.SetActive(true);
		if(FindObjectOfType<PlayerMovment>()._speed !=0) savePSpeed = FindObjectOfType<PlayerMovment>()._speed;
		if (FindObjectOfType<PlayerMovment>()._jumpVel != 0) saveJPspeed = FindObjectOfType<PlayerMovment>()._jumpVel;
		FindObjectOfType<PlayerMovment>()._jumpVel =0;
		FindObjectOfType<PlayerMovment>()._speed =0;
		animator.SetBool("isOpen", true);
		nameText.text=dialog.name;
		portrait.sprite=image;
		sentences.Clear();

		foreach(string sentence in dialog.sentences)
		{
			sentences.Enqueue(sentence);
		}
		DisplayNextSentence();
	}

	public void DisplayNextSentence()
	{
		if(sentences.Count == 0)
		{
			EndDialog();
			return;
		}

		string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));

	}

	IEnumerator TypeSentence(string sentence)
	{
		dialogText.text="";
		foreach(char letter in sentence.ToCharArray())
		{
			dialogText.text+=letter;
			yield return null;
		}
	}

	void EndDialog()
	{
		FindObjectOfType<PlayerMovment>()._speed = savePSpeed;
		FindObjectOfType<PlayerMovment>()._jumpVel= saveJPspeed;
		animator.SetBool("isOpen", false);
		painel.SetActive(false);
		_isDialog=false;
	}
}
