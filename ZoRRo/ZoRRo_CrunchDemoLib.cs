using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;

public class ZoRRo_CrunchDemoLib: MonoBehaviour
{
    public string m_randomWords;
    public int m_minChar = 5;
    public int m_maxChar = 30;
    public string m_additionalCharacter = "()àç'(!§";
    public string m_alphabetMultiCast = "ABCDEFGHIJKLMNOPQRSTUVWXYZAbcdefghijklmnopqrstuvwxyz";
    public string m_alphabetCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public string m_alphabetIgnoreCase = "abcdefghijklmnopqrstuvwxyz";
    public string m_number = "0123456789";


    public string m_allPossibility;

    public string m_listFusionA;


    public char[] m_words;


    //ELoi Eoli   1 > 2
    public void Permutation(int whatToPermuteIndex, int withWhoIndex, out string newText)
    {
        char tmp = m_words[whatToPermuteIndex];
        m_words[whatToPermuteIndex] = m_words[withWhoIndex];
        m_words[withWhoIndex] = tmp;
        newText = m_words.ToString();
    }

    private void Start()
    {
        StartCoroutine(GenerateAllPossibilities());
    }

    void Update()
    {
        GenerateRandomAlphaNum(out m_randomWords, m_minChar, m_maxChar);
    }

    [ContextMenu("Generate random")]
    public void GenerateRandomAlphaNum(out string text, int min = 5, int max = 30)
    {
        //System.Random r = new System.Random(DateTime.Now.Millisecond);



        int n = UnityEngine.Random.Range(min, max);

        string randomString = m_alphabetMultiCast + m_number + m_additionalCharacter;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            sb.Append(randomString[UnityEngine.Random.Range(0, randomString.Length - 1)]);
        }
        text = sb.ToString();


    }
    public string m_path ="" ;
    [ContextMenu("Generate random")]
    public IEnumerator GenerateAllPossibilities()
    {
        File.WriteAllText(m_path, "");
        for (int i = 0; i < m_listFusionA.Length; i++)
        {
            for (int k = 0; k < m_listFusionA.Length; k++)
            {
                for (int d = 0; d < m_listFusionA.Length; d++)
                {
                    for (int j = 0; j < m_listFusionA.Length; j++)
                    {
                        m_allPossibility = "" +
                        m_listFusionA[i]
                        + m_listFusionA[k]
                        + m_listFusionA[d]
                        + m_listFusionA[j];
                        File.AppendAllText(m_path, m_allPossibility + "\n");
                        yield return new WaitForSeconds(0.1f);
                    }
                }
            }
        }

    }
}






