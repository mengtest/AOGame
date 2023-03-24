using ET;
using Puerts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using static ET.DisposeActionComponent;

namespace AO
{
    public static class LoginModeSystem
    {
        [ObjectSystem]
        public class LoginModeComponentAwakeSystem : AwakeSystem<LoginModeComponent>
        {
            protected override void Awake(LoginModeComponent self)
            {

            }
        }

        /// <summary> ��¼ </summary>
        public static async Task Login(this LoginModeComponent self, string account, string password)
        {
            AOGame.ClientApp.AddComponent<LoadingModeComponent>();
            await ServerCall.C2G_LoginGate(new C2G_LoginGate() { Account = account, Password = password });
            AOGame.ClientApp.RemoveComponent<LoginModeComponent>();
            AOGame.ClientApp.AddComponent<LobbyModeComponent>();
            await TimerComponent.Instance.WaitAsync(1500);
            AOGame.ClientApp.RemoveComponent<LoadingModeComponent>();
        }
    }
}