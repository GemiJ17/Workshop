using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public InventoryPanel inventoryPanel;
    public void OpenInventoryPanel()
    {
        inventoryPanel.gameObject.SetActive(true);
        inventoryPanel.Onopen();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
    }
    public void CloseInventoryPanel()
    {
        inventoryPanel.gameObject.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
    }

    public float TimeCounter = 30f;
    public ItemData targetItem;
    public int targetAmount = 5;

    public TMP_Text TimeCounterText;
    public Image targetItemIcon;
    public TMP_Text TargetCurrentAmountText;

    public bool isPlayerWin = false;
    private void Start()
    {
        targetItemIcon.sprite = targetItem.itemIcon;
    }
    private void Update()
    {
        if (isPlayerWin)
            return;
        if (TimeCounter >0f)
        {
            TimeCounter -= Time.deltaTime;
            TimeCounterText.text = TimeCounter.ToString();
            TargetCurrentAmountText.text = "x " + (targetAmount - InventoryManager.instance.GetItemAmount(targetItem)).ToString();

            if(InventoryManager.instance.GetItemAmount(targetItem) >= targetAmount)
            {
                Debug.Log("Player Win");
            }
        }
        else
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
