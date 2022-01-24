using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WordList
{
    [SerializeField] TextAsset words;
    [SerializeField] TypeOfWord _wordType;
    readonly List<string> loadedWords = new List<string>();

    public TypeOfWord WordType => _wordType;

    public void InitWordList()
    {
        if (words == null) return;
        string[] allWords = words.text.ToLower().Trim().Split();
        foreach (var w in allWords)
            if (w != "")
                loadedWords.Add(w);
        Utils.Shuffle(loadedWords);
    }

    public string GetRandomWord() => loadedWords[Random.Range(0, loadedWords.Count)];

    public string GetWordAtIndex(int index) => loadedWords[Mathf.Clamp(index, 0, loadedWords.Count - 1)];
}