using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UnityChanController : MonoBehaviour {

	private Animator myAnimator;
	private Rigidbody myRigidbody;
	private float forwardForce = 800.0f;

	private float turnForce = 500.0f;
	private float upForce = 500f;
	private float movableRange = 3.4f;
	private float coefficient = 0.95f;

	private bool isEnd = false;

	private GameObject stateText;
	private GameObject scoreText;
	private int score = 0;

	private bool isLButtonDown = false;//左ボタン
	private bool isRButtonDown = false;//右ボタン


	// Use this for initialization
	void Start () {
		//Animatorっていうコンポーネントってある？
		this.myAnimator = GetComponent <Animator>();
		this.myAnimator.SetFloat ("Speed", 1);//??
		this.myRigidbody = GetComponent <Rigidbody> ();

		this.stateText = GameObject.Find ("GameResultText");
		this.scoreText = GameObject.Find ("ScoreText");
	}

	// Update is called once per frame
	void Update () {
		if (this.isEnd) {
			this.forwardForce *= this.coefficient;
			this.turnForce *= this.coefficient;
			this.upForce *= this.coefficient;
			this.myAnimator.speed *= this.coefficient;
		}
		// (this.transform.forward * this.forwardForce);の意味は？
		this.myRigidbody.AddForce (this.transform.forward * this.forwardForce);

		if ((Input.GetKey (KeyCode.LeftArrow) || this.isLButtonDown) && -this.movableRange < this.transform.position.x) {
			this.myRigidbody.AddForce (-this.turnForce, 0, 0);
		} else if ((Input.GetKey (KeyCode.RightArrow) || this.isRButtonDown )&& this.transform.position.x < this.movableRange) {
			this.myRigidbody.AddForce (this.turnForce, 0, 0);
		}

		if (this.myAnimator.GetCurrentAnimatorStateInfo (0).IsName ("Jump")) {
			this.myAnimator.SetBool ("Jump", false);//SetBoolとは
		}

		if (Input.GetKeyDown (KeyCode.Space) && this.transform.position.y < 0.5f) {
			this.myAnimator.SetBool ("Jump", true);
			this.myRigidbody.AddForce (this.transform.up * this.upForce);
		}
	}

	void OnTriggerEnter(Collider other) {//「OnTriggerEnter」関数は、自分のColliderが他のオブジェクトのColliderと接触した時に呼ばれる関数
		Debug.Log(tag);
			if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag") { //otherの意味
				this.isEnd = true;
			this.stateText.GetComponent<Text> ().text = "GAME OVER";
			}

			if (other.gameObject.tag == "GoalTag") {
			this.isEnd = true;
			this.stateText.GetComponent<Text> ().text = "CLEAR!";
			}
		    if (other.gameObject.tag == "CoinTag") {
			Destroy (other.gameObject);

			this.score += 10;
			Debug.Log (score);
			this.scoreText.GetComponent<Text>().text = "Score" + this.score + "pt";

			GetComponent<ParticleSystem> ().Play ();//並びがわからん。　　　GetComponent関数を使ってParticleSystemコンポーネントを取得し、Play関数を呼び出しています。
			Destroy (other.gameObject);
            }
     }
	public void GetMyJumpButtonDown(){
		if(this.transform.position.y < 0.5f){
			this.myAnimator.SetBool ("Jump", true);
			this.myRigidbody.AddForce (this.transform.up * this.upForce);
}
	}
	public void GetMyLeftButtonDown(){
		this.isLButtonDown = true;//isの意味//この辺の意味
	}
	public void GetMyLeftBottonUp(){     
		this.isLButtonDown = false;
	}
	public void GetMyRightBottonDown(){
		this.isRButtonDown = true;
	}
	public void GetMyRightBottonUp(){
		this.isRButtonDown = false;
	}
}


//isendの意味

//particleができてない
//scoreが出てこない
//コインがあたったかどうか
//「None Function」をクリックし、「UnityChanController」→「GetMyLeftButtonDown()」を選択してください。以上で、左移動ボタンを押した時に呼び出す関数の設定ができました。
//speedが遅い
