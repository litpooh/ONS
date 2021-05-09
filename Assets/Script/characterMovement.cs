using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;
using UnityEngine.SceneManagement;

public class characterMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public static float speed = 10;
    private Rigidbody2D myRigidBody; 
    private Vector3 change;
    private Animator animator;
    public FloatValue currentHealth;
    public FloatValue currentSanity;
    public FloatValue currentMoney;
    public Signal healthSignal;
    public Signal sanitySignal;
    public Signal moneySignal;
    public Signal phoneSignal;
    public VectorValue startingPosition;
    public CustomArrayList phoneList;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        transform.position = startingPosition.initValue;
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        updateCharacterAndMove();
    }

    void updateCharacterAndMove(){
        if (change != Vector3.zero){
            MoveCharacter();
            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
            animator.SetBool("isWalking", true);
        }else{
            animator.SetBool("isWalking", false);
        }
    }

    void MoveCharacter(){
        change.Normalize();
        myRigidBody.MovePosition(
            transform.position + change * speed * Time.deltaTime
        );
    }

    public bool sanityFull(){
        return (currentSanity.runtimeValue == 100);
    }

    public bool healthFull(){
        return (currentHealth.runtimeValue == 100);
    }

    public double moneyAmount(){
        return (double) currentMoney.runtimeValue;
    }

    void changeHealth(double healthChange){
        if (currentHealth.runtimeValue < currentHealth.initValue || healthChange < 0){
            currentHealth.runtimeValue += (float) healthChange;
            healthSignal.Raise();
            if (currentHealth.runtimeValue < 0){
                SceneManager.LoadScene("Gameover");
            }
        }
    }

    void changeSanity(double sanityChange){
        if (currentSanity.runtimeValue < currentSanity.initValue || sanityChange < 0){
            currentSanity.runtimeValue += (float) sanityChange;
            sanitySignal.Raise();
            if (currentSanity.runtimeValue <= 0){
                SceneManager.LoadScene("Gameover");
            }
        }
    }

    void changeMoney(double moneyChange){
            currentMoney.runtimeValue += (float) moneyChange;
            moneySignal.Raise();
            if (currentMoney.runtimeValue <= 0){
                SceneManager.LoadScene("Gameover");
            }
    }

    void NewContactToPhone(string character)
    {
        phoneList.arList.Add(character);
        phoneSignal.Raise();
    }

    void OnEnable()
    {
        // Make the functions available to Lua: (Replace these lines with your own.)
        Lua.RegisterFunction("sanityFull", this, SymbolExtensions.GetMethodInfo(() => sanityFull()));
        Lua.RegisterFunction("healthFull", this, SymbolExtensions.GetMethodInfo(() => healthFull()));
        Lua.RegisterFunction("moneyAmount", this, SymbolExtensions.GetMethodInfo(() => moneyAmount()));
        Lua.RegisterFunction("changeHealth", this, SymbolExtensions.GetMethodInfo(() => changeHealth((double)0)));
        Lua.RegisterFunction("changeMoney", this, SymbolExtensions.GetMethodInfo(() => changeMoney((double)0)));
        Lua.RegisterFunction("changeSanity", this, SymbolExtensions.GetMethodInfo(() => changeSanity((double)0)));
        Lua.RegisterFunction("NewContactToPhone", this, SymbolExtensions.GetMethodInfo(() => NewContactToPhone("")));
    }

    void OnDisable()
    {
            // Remove the functions from Lua: (Replace these lines with your own.)
            Lua.UnregisterFunction("sanityFull");
            Lua.UnregisterFunction("healthFull");
            Lua.UnregisterFunction("moneyAmount");
            Lua.UnregisterFunction("changeHealth");
            Lua.UnregisterFunction("changeMoney");
            Lua.UnregisterFunction("changeSanity");
            Lua
    }
}
