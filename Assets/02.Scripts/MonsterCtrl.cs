﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterCtrl : MonoBehaviour
{
    private Transform monsterTr;    //몬스터의 Transform
    private Transform playerTr;     //주인공의 Transform
    private NavMeshAgent agent;     //네브메시에이젼트 컴포넌트
    private Animator anim;          //메카님 에니메이터 컴포넌트

    void Start()
    {
        //monsterTr = this.gameObject.GetComponent<Transform>();
        monsterTr = transform;
        playerTr  = GameObject.FindGameObjectWithTag("PLAYER").GetComponent<Transform>();
        agent     = GetComponent<NavMeshAgent>();
        anim      = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
