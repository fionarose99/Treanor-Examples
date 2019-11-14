using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public Animator doubleJumpButtonAnimator;

	int acorns = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void shopButtonClicked()
	{
		if (acorns < 200) {
			doubleJumpButtonAnimator.SetTrigger("denied");
		}
	}
}
