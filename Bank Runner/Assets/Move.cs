using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace imports{
    public class Move : MonoBehaviour
    {


        public int speed = 0;

        // Update is called once per frame
        private void FixedUpdate() {
            transform.position+=new Vector3(0.1f,0,0)*Time.deltaTime*speed; 
        }
    }
}