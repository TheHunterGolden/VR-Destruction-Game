namespace VRTK
{
    using UnityEngine;

    public class ShootingButtonController : VRTK_InteractableObject
    {
        public override void OnInteractableObjectUsed(InteractableObjectEventArgs e)
        {
            base.OnInteractableObjectUsed(e);
            gameObject.GetComponent<Animator>().enabled = true;
        }
    }
}


