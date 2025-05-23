using UnityEngine;

public class Pelaaja2 : MonoBehaviour
{

    public float speed = 5f;
    //public float jumpHeight = 2f;
    public float gravity = 9.81f;


    private CharacterController controller;
    private Vector3 velocity;
    private bool isGrounded;

    public float PowerTime = 5;
    public float PowerTime2 = 10;




    void Start()
    {
        controller = GetComponent<CharacterController>();
    }


    void Update()
    {
        isGrounded = controller.isGrounded;

        float moveX = Input.GetAxis("Player2Horizontal");
        float moveZ = Input.GetAxis("Player2Vertical");
        //uudet lisäykset
        Vector3 move = new Vector3(moveX, 0, moveZ);
        //tasta eteenpain ei
        //Vector3 move = transform.right * moveX + transform.forward * moveZ;

        if (Pistelaskuri.Instance.Player2poweri == 1)
        {
            speed = 10f;
            controller.Move(move * speed * Time.deltaTime);

            //Pitaa lisata jokin aika kunnes se palaa normaaliksi
            PowerTime -= Time.deltaTime;
            if (PowerTime < 0)
            {
                Pistelaskuri.Instance.Player2poweri = 0;
                PowerTime = 5;
                speed = 5f;
            }


        }
        else
        {
            speed = 5;
            controller.Move(move * speed * Time.deltaTime);
        }



        //if (Pistelaskuri.Instance.onKuolematon == true)
        //{
        //    PowerTime2 -= Time.deltaTime;

        //    if (PowerTime2 <= 0)
        //    {
        //        Pistelaskuri.Instance.poweri2 = 0;
        //        Pistelaskuri.Instance.onKuolematon = false;
        //        PowerTime2 = 10;
        //    }
        //}



        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }


        //if (Input.GetButtonDown("Jump") && isGrounded)
        //{
        //    velocity.y = Mathf.Sqrt(jumpHeight * 2f * gravity);
        //}
        //uudet lisäykset
        if (move != Vector3.zero)
        {
            transform.forward = move;
        }
        //tasta eteenpain ei

        velocity.y -= gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);


    }
}

