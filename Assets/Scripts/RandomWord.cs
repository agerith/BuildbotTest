using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class RandomWord : MonoBehaviour {

	List<string> listWord;
	public Text text;

	void Start()
	{
		listWord = new List<string>();
		string[] lines = System.IO.File.ReadAllLines(@"D:\MesDocuments\Documents\ISART DIGITAL\GP3_2014-2015\RandomWord\Assets\Words.txt");
		foreach (string line in lines)
		{
			string[] word = line.Split('\t');
			listWord.Add(word[0]);
		}
	}


	public void ClickRandom()
	{
		int number = Random.Range (0, listWord.Count);
		text.text = listWord [number];
	}
}
