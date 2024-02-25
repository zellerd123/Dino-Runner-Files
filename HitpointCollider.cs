using UnityEngine;

public class HitpointCollider : MonoBehaviour
{
    [SerializeField] Player pScript;
    [SerializeField] DinoWalkAnimation walk;
    [SerializeField] AudioClip audioClip;
    [SerializeField] ParticleSystem destruction;
    [SerializeField] AudioClip bubble;


    bool time = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject dino = GameObject.Find("Dino MC");
        walk = dino.GetComponent<DinoWalkAnimation>();
        pScript = dino.GetComponent<Player>();
       
        
        Debug.Log("Damage shown " + pScript.GetDamage());
        if (!pScript.GetDamage())
        {

            if (pScript.canMove)
            {
                AudioSource.PlayClipAtPoint(audioClip, Camera.main.transform.position);
            }
            Destroy(GameObject.Find("Heart " + ScoreSaver.score.currentHearts.ToString()));
            ScoreSaver.score.currentHearts--;
            walk.DamageInitializer();
            pScript.Damage();
        }
        else
        {
            AudioSource.PlayClipAtPoint(bubble, Camera.main.transform.position);
        }
       
        if (ScoreSaver.score.currentHearts == 0)
        {
            ScoreSaver.score.currentHearts = 3; 
        }
        if (destruction != null)
        {

            Debug.Log("this objects transform: " + this.transform);
            Instantiate(destruction, this.transform.position, this.transform.rotation);
            
        }

        if (tag != "Wall")
        {
            Destroy(gameObject);
        }
        if (tag == "Wall")
        {
            if (pScript.canMove)
            {
                Respawn(dino);
            }
        }  
    }

    private void Respawn(GameObject dino)
    {
        dino.transform.position = (new Vector2(-4.77f, -.5f));
    }

    public int GetCurrentHealth() { return ScoreSaver.score.currentHearts; }


}
