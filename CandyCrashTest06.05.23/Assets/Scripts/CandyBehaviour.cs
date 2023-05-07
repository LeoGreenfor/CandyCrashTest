using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CandyBehaviour : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private int row;
    [SerializeField]
    private int collumn;

    [SerializeField]
    private CandyPlaceController controller;

    private Animator animator;

    public bool IsMatches = false;

    private void Start()
    {
        //controller = GameObject.FindGameObjectWithTag("Canvas").GetComponent<CandyPlaceController>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (this.GetComponent<Image>().sprite.name != "ball1")
        {
            FindMatches();
        }
        if (IsMatches)
        {

            DestroyCandy();
            AddScore(150);
            IsMatches = false;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (controller.IsFirstCandySelect)
        {
            controller.MakeStep(row, collumn);
            controller.IsFirstCandySelect = false;
        } else
        if (!controller.IsFirstCandySelect)
        {
            controller.currentCandyRow = row;
            controller.currentCandyCollumn = collumn;
            controller.IsFirstCandySelect = true;
        }

    }

    public void DestroyCandy()
    {
        animator.Play("DestroyCandy");
        StartCoroutine(Culldown());
        controller.SetRandomCandy(row, collumn);
        animator.Play("NewCandy");
    }

    private IEnumerator Culldown()
    {
        yield return new WaitForSeconds(40.0f);
        //yield return new WaitUntil(() => animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1f);
    }


    private void FindMatches()
    {
        if (collumn > 0 && collumn < controller.numberOfColumns - 1)
        {
            Image leftCandy1 = controller.candyImagesOnGrid[row, collumn - 1];
            Image rightCandy1 = controller.candyImagesOnGrid[row, collumn + 1];

            if (leftCandy1.sprite == this.GetComponent<Image>().sprite 
                && rightCandy1.sprite == this.GetComponent<Image>().sprite)
            {
                leftCandy1.GetComponent<CandyBehaviour>().IsMatches = true;
                rightCandy1.GetComponent<CandyBehaviour>().IsMatches = true;
                IsMatches = true;
            }
        }

        if (row > 0 && row < controller.numberOfRows - 1)
        {
            Image upCandy1 = controller.candyImagesOnGrid[row - 1, collumn];
            Image downCandy1 = controller.candyImagesOnGrid[row + 1, collumn];

            if (upCandy1.sprite == this.GetComponent<Image>().sprite
                && downCandy1.sprite == this.GetComponent<Image>().sprite)
            {
                upCandy1.GetComponent<CandyBehaviour>().IsMatches = true;
                downCandy1.GetComponent<CandyBehaviour>().IsMatches = true;
                IsMatches = true;
            }
        }
    }
    private void AddScore(int score)
    {
        score += int.Parse(controller.scoreText.text);
        controller.scoreText.text = score.ToString();
    }
}
