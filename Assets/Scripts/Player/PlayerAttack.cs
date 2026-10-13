using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] fireballs;
    [SerializeField] private AudioClip fireballSound;

    private Animator anim;
    private PlayerMovement playerMovement;
    private float cooldownTimer = Mathf.Infinity;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && cooldownTimer > attackCooldown && playerMovement.canAttack())
            Attack();

        cooldownTimer += Time.deltaTime;
    }

    private void Attack()
    {
        int fireballIndex = FindFireball();
        if (fireballIndex < 0 || firePoint == null)
            return;

        GameObject fireball = fireballs[fireballIndex];
        if (fireball == null)
            return;

        SoundManager.instance.PlaySound(fireballSound);
        anim.SetTrigger("attack");
        cooldownTimer = 0;

        fireball.transform.position = firePoint.position;
        Projectile projectile = fireball.GetComponent<Projectile>();
        if (projectile == null)
        {
            Debug.LogWarning("Fireball prefab is missing the Projectile component.", fireball);
            fireball.SetActive(false);
            return;
        }

        projectile.SetDirection(Mathf.Sign(transform.localScale.x));
    }

    private int FindFireball()
    {
        if (fireballs == null)
            return -1;

        for (int i = 0; i < fireballs.Length; i++)
        {
            if (fireballs[i] != null && !fireballs[i].activeInHierarchy)
                return i;
        }
        return -1;
    }
}