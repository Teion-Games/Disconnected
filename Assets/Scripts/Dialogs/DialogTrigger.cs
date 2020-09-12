using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour {
	
	[Tooltip("Aqui você escreve as sentenças que deseja que o npc fale e o nome dele enois")]
	[SerializeField]
	private Dialogue dialog;
	public Dialogue _dialog { get{ return dialog;} set{dialog = value;}}
	[Tooltip("Portrait da pessoa que aparecerá do lado do diálogo, esse field é uma sprite e deve ser pego da pasta de sprites")]
	[SerializeField] private Sprite portrait;
	[SerializeField] 
	[Tooltip("O collider que sera destruido caso seja um dialogo que só vá ser playado uma vez, mesmo que a maria volte para o lugar depois [na mesma run]")]
	private Collider2D dialogCollider;
	GameMaster gm;

	private void Start() 
	{
		gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		TriggerDialog();
	}
	public void TriggerDialog()
	{
		FindObjectOfType<DialogManager>().StartDialog(_dialog, portrait);
		RemoveDialog();
	}

	void RemoveDialog()
	{
		foreach (GameObject dialog in gm.dialogList)
		{
			if(dialog == this.gameObject)
			{
				gm.dialogList.Remove(dialog);
			}
		}
		gameObject.SetActive(false);
	}
}
