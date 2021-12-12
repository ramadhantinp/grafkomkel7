using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shaker: MonoBehaviour {

        public float shakeAmount = 0f;
        private Vector3 initialPosition;

        void Start () {
                initialPosition = this.transform.position;
        }

        void Update () {
                this.transform.position = Random.insideUnitSphere * shakeAmount + initialPosition;
        }

       public void ChangeShake (float newAmount) {
                shakeAmount = newAmount;
       }
}
