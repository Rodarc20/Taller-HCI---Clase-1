using UnityEngine;

public class ZonaReducir : MonoBehaviour {
    public void OnTriggerEnter(Collider other){
        GameObject player = other.gameObject;
        if(player.layer == LayerMask.NameToLayer("Jugador")){
            MoveCube moveCube = player.GetComponent<MoveCube>();
            if(!moveCube.pequeno){
                player.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
                player.transform.position = new Vector3 (player.transform.position.x, 0.25f, player.transform.position.z);
                moveCube.pequeno = true;
            }
        }
    }
}