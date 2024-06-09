using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public int gameState = 0;

    void Update()
    {
        HandlePortals();
    }

    // 게임 상태에 따라 포탈을 처리하는 메서드
    public void HandlePortals()
    {
        if (gameState == 45)
        {
            // 부모 오브젝트인 Class를 찾음
            GameObject Map = GameObject.Find("Map");
            GameObject NPC_1 = GameObject.Find("NPC_1");

            if (Map != null)
            {
                // Class 오브젝트의 자식들을 찾아서 포탈을 활성화시킴
                foreach (Transform child in Map.transform)
                {
                    if (child.gameObject.name == "Class")
                    {
                        child.gameObject.SetActive(false);
                    }
                }
            }
            else
            {
                Debug.LogError("부모 오브젝트를 찾을 수 없습니다.");
            }

            if (NPC_1 != null)
            {
                // Class 오브젝트의 자식들을 찾아서 포탈을 활성화시킴
                foreach (Transform child in NPC_1.transform)
                {
                    if (child.gameObject.name == "NPC_1_R")
                    {
                        child.gameObject.SetActive(false);
                    }
                }
            }
            else
            {
                Debug.LogError("부모 오브젝트를 찾을 수 없습니다.");
            }
        }
        if (gameState == 89)
        {
            GameObject hallway_1f = GameObject.Find("hallway_1f");
            GameObject NPC_2 = GameObject.Find("NPC_2");

            if (hallway_1f != null)
            {
                foreach (Transform child in hallway_1f.transform)
                {
                    if (child.gameObject.name == "UpStair_2f")
                    {
                        child.gameObject.SetActive(true);
                    }
                }
            }
            else
            {
                Debug.LogError("부모 오브젝트를 찾을 수 없습니다.");
            }
            if (NPC_2 != null)
            {
                // Class 오브젝트의 자식들을 찾아서 포탈을 활성화시킴
                foreach (Transform child in NPC_2.transform)
                {
                    if (child.gameObject.name == "NPC_2_R")
                    {
                        child.gameObject.SetActive(false);
                    }
                }
            }
            else
            {
                Debug.LogError("부모 오브젝트를 찾을 수 없습니다.");
            }
        }
        if (gameState == 97)
        {
            GameObject hallway_2f = GameObject.Find("hallway_2f");

            if (hallway_2f != null)
            {
                foreach (Transform child in hallway_2f.transform)
                {
                    if (child.gameObject.name == "UpStair_3f")
                    {
                        child.gameObject.SetActive(true);
                    }
                }
            }
            else
            {
                Debug.LogError("부모 오브젝트를 찾을 수 없습니다.");
            }
        }
    }
}
