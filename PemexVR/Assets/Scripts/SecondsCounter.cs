using System;
using UnityEngine;
using TMPro;                      

public class SecondsCounter : MonoBehaviour
{
    [SerializeField] private float seconds;
    [SerializeField] private bool isCounting;

    [Header("UI")]
    [SerializeField] private TextMeshProUGUI tmpText;

    private void Start()
    {
        StartCounting();
    }
    private void Update()
    {
        if (!isCounting) return;
        // Suma el tiempo real transcurrido entre frames
        seconds += Time.deltaTime;

        // Actualiza el texto en pantalla
        string formattedTime = GetFormattedTime();
        UpdateUIText(formattedTime);
    }
    private void UpdateUIText(string formattedTime)
    {
        
        if (tmpText != null)
            tmpText.text = formattedTime;
    }
    public void StopCounting()
    {
        isCounting = false;
    }
    public void StartCounting()
    {
        isCounting = true;
    }

    public string GetFormattedTime()
    {
        int minutes = Mathf.FloorToInt(seconds / 60);
        int secs = Mathf.FloorToInt(seconds % 60);
        return string.Format("{0:00}:{1:00}", minutes, secs);
    }
}