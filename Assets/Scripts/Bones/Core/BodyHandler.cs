﻿using UnityEngine;

namespace Bones.Core
{
    /// <summary>
    /// Handles the differents parts of the body to generate a skeleton
    /// </summary>
    public sealed class BodyHandler : MonoBehaviour
    {
        #region Unity Fields

        [Header("Settings")]
        [SerializeField]
        [Tooltip("Epsilon for the distance between two bones")]
        private float _epsilon;

        [Header("Head")]
        [SerializeField]
        [Tooltip("Head mesh of a humanoid")]
        private Mesh _head;

        [Header("Body")]
        [SerializeField]
        [Tooltip("Body mesh of a humanoid")]
        private Mesh _body;

        [Header("Entire left arm")]
        [SerializeField]
        [Tooltip("Left upper arm mesh of a humanoid")]
        private Mesh _leftUpperArm;

        [SerializeField]
        [Tooltip("Left forearm mesh of a humanoid")]
        private Mesh _leftForearm;

        [SerializeField]
        [Tooltip("Left hand mesh of a humanoid")]
        private Mesh _leftHand;

        [Header("Entire right arm")]
        [SerializeField]
        [Tooltip("Right upper arm mesh of a humanoid")]
        private Mesh _rightUpperArm;

        [SerializeField]
        [Tooltip("Right forearm mesh of a humanoid")]
        private Mesh _rightForearm;

        [SerializeField]
        [Tooltip("Right hand mesh of a humanoid")]
        private Mesh _rightHand;

        [Header("Entire left leg")]
        [SerializeField]
        [Tooltip("Left leg mesh of a humanoid")]
        private Mesh _leftLeg;

        [SerializeField]
        [Tooltip("Left foreleg mesh of a humanoid")]
        private Mesh _leftForeleg;

        [SerializeField]
        [Tooltip("Left foot mesh of a humanoid")]
        private Mesh _leftFoot;

        [Header("Entire right leg")]
        [SerializeField]
        [Tooltip("Right leg mesh of a humanoid")]
        private Mesh _rightLeg;

        [SerializeField]
        [Tooltip("Right foreleg mesh of a humanoid")]
        private Mesh _rightForeleg;

        [SerializeField]
        [Tooltip("Right foot mesh of a humanoid")]
        private Mesh _rightFoot;

        #endregion

        #region Public Methods

        /// <summary>
        /// Creates a skeleton with the given mesh parts
        /// </summary>
        public void GenerateSkeleton()
        {
            Skeleton skeleton = new GameObject("Skeleton").AddComponent<Skeleton>();

            skeleton.Initialize(
                this._head,
                this._body,
                this._leftUpperArm,
                this._leftForearm,
                this._leftHand,
                this._rightUpperArm,
                this._rightForearm,
                this._rightHand,
                this._leftLeg,
                this._leftForeleg,
                this._leftFoot,
                this._rightLeg,
                this._rightForeleg,
                this._rightFoot,
                this._epsilon * this._epsilon
            );
        }

        #endregion
    }
}
