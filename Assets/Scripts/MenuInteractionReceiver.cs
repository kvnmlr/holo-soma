﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using HoloToolkit.Unity;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.Receivers;
using HoloToolkit.Unity.InputModule;

namespace UMTL.MixedReality
{
    public class MenuInteractionReceiver : InteractionReceiver
    {
        void Start()
        {
        }

        protected override void FocusEnter(GameObject obj, PointerSpecificEventData eventData)
        {
            if (obj != null)
            {
                Debug.Log(obj.name + " : FocusEnter");
            }
        }

        protected override void FocusExit(GameObject obj, PointerSpecificEventData eventData)
        {
            if (obj != null)
            {
                Debug.Log(obj.name + " : FocusExit");
            }
        }

        protected override void InputDown(GameObject obj, InputEventData eventData)
        {
            if (obj != null)
            {
                Debug.Log(obj.name + " : InputDown");
            }
        }

        protected override void InputUp(GameObject obj, InputEventData eventData)
        {
            if (obj != null)
            {
                Debug.Log(obj.name + " : InputUp");
                switch (obj.name)
                {
                    case "BasicCubeButton":
                        Debug.Log("Starting Basic Cube Demo");
                        GameController.Instance.StartBasicRoutine();
                        break;
                    case "LargeCubeButton":
                        Debug.Log("Starting Basic Cube Demo");
                        GameController.Instance.StartBasicRoutine();
                        break;
                    case "FancyCubeButton":
                        Debug.Log("Starting Basic Cube Demo");
                        GameController.Instance.StartBasicRoutine();
                        break;
                    case "BasicMenuButton":
                        Debug.Log("Starting Basic Cube Demo");
                        GameController.Instance.WorkspacePlaced();
                        break;
                    default:
                        break;
                }
            }
        }

        protected override void InputClicked(GameObject obj, InputClickedEventData eventData)
        {
            if (obj != null)
            {
                Debug.Log(obj.name + " : InputClicked");
            }
        }
    }
}