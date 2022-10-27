using UnityEngine;

namespace ConsoleApp
{
    public class MyScript : MonoBehaviour
    {
        private void FixedUpdate()
        {
        }

        private void Update()
        {
            Debug.Log(tag == "tag1");
        }
    }
}
