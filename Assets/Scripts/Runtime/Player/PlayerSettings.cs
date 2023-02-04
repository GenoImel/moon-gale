﻿using MoonGale.Runtime.Utilities;
using UnityEngine;

namespace MoonGale.Runtime.Player
{
    [CreateAssetMenu(
        menuName = Constants.CreateAssetMenuName + "/Player Settings",
        fileName = "New " + nameof(PlayerSettings)
    )]
    internal sealed class PlayerSettings : ScriptableObject
    {
        [Header("Movement")]
        [Min(0f)]
        [SerializeField]
        private float maxMoveSpeed = 0.1f;

        [Min(0f)]
        [SerializeField]
        private float moveAcceleration = 2f;

        [Min(0f)]
        [SerializeField]
        private float stopAcceleration = 1f;

        [Header("Attacks")]
        [Min(0f)]
        [SerializeField]
        private float attackDurationSeconds = 0.3f;

        [Header("Attacks")]
        [Min(0f)]
        [SerializeField]
        private float attackCooldownSeconds = 0.3f;

        public float MaxMoveSpeed => maxMoveSpeed;

        public float MoveAcceleration => moveAcceleration;

        public float StopAcceleration => stopAcceleration;

        public float AttackDurationSeconds => attackDurationSeconds;

        public float AttackCooldownSeconds => attackCooldownSeconds;
    }
}
