using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingCounterVisual : MonoBehaviour
{
    [SerializeField]
    private CuttingCounter cuttingCouter;

    private const string CUT = "Cut";

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        cuttingCouter.OnCut += CuttingCouter_OnCut;
    }

    private void CuttingCouter_OnCut(object sender, System.EventArgs e)
    {
        animator.SetTrigger(CUT);
    }

}
