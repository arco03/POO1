using UnityEngine;
using UnityEngine.UI;


namespace Enviroment
{

    public class BackgroundMovement : MonoBehaviour
    {
        [SerializeField] private RawImage img;
        [SerializeField] private float y, x;

        private void Update()
        {
            img.uvRect = new Rect(img.uvRect.position + new Vector2(x, y) * Time.deltaTime, img.uvRect.size);
        }
    }
}