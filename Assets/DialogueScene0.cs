using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene0 : MonoBehaviour {
	public int primeInt = 1; // This integer drives game progress!
	public Text PlayerName;
	public Text PlayerSpeech;
	public Text Char1name;
	public Text Char1speech;
	public Text Char2name;
	public Text Char2speech;
	public GameObject dialogue;
	public GameObject ArtChar1; //kaget
	public GameObject ArtChar2; //marah
	public GameObject ArtChar3; //netral
	public GameObject ArtChar4; //khawatir
	public GameObject ArtChar5; //senyum mata tutup
	public GameObject ArtBG1;
	public GameObject ArtBG2;
	public GameObject Choice1a;
	public GameObject Choice1b;
	public GameObject Choice1c;
	public GameObject NextScene1Button;
	public GameObject nextButton;
	//public GameObject gameHandler;
	//public AudioSource audioSource;
	private bool allowSpace = true;

	void Start(){ // initial visibility settings
		dialogue.SetActive(false);
		ArtChar1.SetActive(false);
		ArtChar2.SetActive(false);
		ArtChar3.SetActive(false);
		ArtChar4.SetActive(false);
		ArtChar5.SetActive(false);
		ArtBG1.SetActive(false);
		ArtBG2.SetActive(true);
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		Choice1c.SetActive(false);
		NextScene1Button.SetActive(false);
		nextButton.SetActive(true);
	}

	void Update(){ // use spacebar as Next button
		if (allowSpace == true){
		if (Input.GetKeyDown("space")){
			if (primeInt==501 || primeInt==402) Choice1cFunct();
			else talking();

			// talking();
			//space hanya diatributkan ke talking, jadi kalau coba spacebar buat choice1c, gak bakal bisa
			}
		}
	}

	//scene 1, 2
	public void talking(){ // main story function. Players hit next to progress to next int
		primeInt = primeInt + 1;
		if (primeInt == 1){
			// AudioSource.Play();
		}
		else if (primeInt == 2){
			dialogue.SetActive(true);
			PlayerName.text = "???";
			PlayerSpeech.text = "[.....]? [.....]";
			Char1name.text = "";
			Char1speech.text = "";
		}
		else if (primeInt ==3){
			PlayerName.text = "???";
			PlayerSpeech.text = "[.....]? [.....]?";
			Char1name.text = "";
			Char1speech.text = "";
		}
		else if (primeInt == 4){
			PlayerName.text = "???";
			PlayerSpeech.text = "[.....]?";
			Char1name.text = "";
			Char1speech.text = "";
		}
		else if (primeInt == 5){
			PlayerName.text = "???";
			PlayerSpeech.text = "[.....]!!!";
			Char1name.text = "";
			Char1speech.text = "";
		}
		else if (primeInt == 6){
			ArtBG1.SetActive(true);
			ArtBG2.SetActive(false);
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "WAAAAAAA!!!!!!!";
			Char1name.text = "";
			Char1speech.text = "";
		}
		else if (primeInt ==7){
			ArtChar1.SetActive(true);
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "Temen";
			Char1speech.text = "WAAAAAAA???!!";
		}
		else if (primeInt ==8){
			ArtChar2.SetActive(true);
			ArtChar1.SetActive(false);
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "Temen";
			Char1speech.text = "Kamu ngapain sih bangun-bangun langsung teriak!? Bikin kaget orang aja!";
		}
		else if (primeInt ==9){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "... Loh?";
			Char1name.text = "";
			Char1speech.text = "";
		}
		else if (primeInt ==10){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "........";
			Char1name.text = "";
			Char1speech.text = "";
		}
		else if (primeInt ==11){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Tadi itu..)";
			Char1name.text = "";
			Char1speech.text = "";
		}
		else if (primeInt ==12){
			ArtChar2.SetActive(false);
			ArtChar3.SetActive(true);
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "Temen";
			Char1speech.text = "... Habis mimpi buruk kah?";
		}
		else if (primeInt ==13){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "Iya.. aku enggak bisa inget sih sebenernya aku mimpi apa barusan.";
			Char1name.text = "";
			Char1speech.text = "";
		}
		else if (primeInt ==14){
			ArtChar3.SetActive(false);
			ArtChar4.SetActive(true);
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "Temen";
			Char1speech.text = "Ahahah! Mimpi kan, emang biasa begitu. Bangun-bangun, eh, langsung lupa.";
		}

		//dialogue overload
		else if (primeInt ==15){
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "Temen";
			Char1speech.text = "Tapi kalo tadi mimpi buruk, untung aja cuma mimpi.";
		}
		else if (primeInt ==16){
			ArtChar4.SetActive(false);
			ArtChar5.SetActive(true);
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "Temen";
			Char1speech.text = "Bakal serem kan, kalo mimpi buruk beneran kejadian...";
		}
		else if (primeInt ==17){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Iya ya, untungnya cuma mimpi...)";
			Char1name.text = "";
			Char1speech.text = "";
		}
		else if (primeInt ==18){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Aku memang enggak ingat tadi mimpi apa, tapi...)";
			Char1name.text = "";
			Char1speech.text = "";
		}
		else if (primeInt ==19){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Aku rasa kalau mimpi tadi benar-benar terjadi di dunia nyata, bakal gawat banget.)";
			Char1name.text = "";
			Char1speech.text = "";
		}
		else if (primeInt ==20){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(... Syukurlah, cuma mimpi.)";
			Char1name.text = "";
			Char1speech.text = "";
		}
		else if (primeInt == 21){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "Oh iya [Temen], daripada itu...";
			Char1name.text = "";
			Char1speech.text = "";
		}
		else if (primeInt == 22){
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "";
			Char1speech.text = "";
			// Turn off "Next" button, turn on "Choice" buttons
			nextButton.SetActive(false);
			allowSpace = false;
			Choice1a.SetActive(true); // function Choice1aFunct()
			Choice1b.SetActive(true); // function Choice1bFunct()
		}

		// ENCOUNTER AFTER CHOICE #1
		//scene 3
		else if (primeInt == 400){
			ArtChar5.SetActive(false);
			ArtChar3.SetActive(true);
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "Temen";
			Char1speech.text = "Jam setengah delapan. Emang kenapa?";
		}

		else if (primeInt == 401){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "Udah jam segitu? Kok masih di sini!?";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt == 402){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "Praktikum kamu kan, hari ini jam 7 di FMIPA basah!!!";
			Char1name.text = "";
			Char1speech.text = "";
			nextButton.SetActive(false);
			allowSpace=true;
			Choice1c.SetActive(true); // function Choice1cFunct()
		}

		//scene 4
		else if (primeInt == 500){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = " Hari ini kan kamu praktikumnya jauh!";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt == 501){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "Kalau jam segini belum berangkat, nanti telat loh ke FMIPA basah!!!";
			Char1name.text = "";
			Char1speech.text = "";
			nextButton.SetActive(false);
			allowSpace=true;
			Choice1c.SetActive(true); // function Choice1cFunct()
			}

			//scene 5
			else if (primeInt == 24){
				PlayerName.text = "";
				PlayerSpeech.text = "";
				Char1name.text = "Temen";
				Char1speech.text = "Praktikumku di FMIPA basah kan, hari Kamis, hari interdept. Sekarang hari Rabu.";
				}

			else if (primeInt == 25){
				PlayerName.text = "Kamu";
				PlayerSpeech.text = "Ahh, hari ini hari Rabu ya? Kukira hari Kamis...";
				Char1name.text = "";
				Char1speech.text = "";
				}

			else if (primeInt == 26){
				ArtChar4.SetActive(false);
				ArtChar3.SetActive(true);
				PlayerName.text = "";
				PlayerSpeech.text = "";
				Char1name.text = "Temen";
				Char1speech.text = "Tumben-tumbennya kamu lupa soal hari gini.";
				}

			else if (primeInt == 27){
				ArtChar3.SetActive(false);
				ArtChar4.SetActive(true);
				PlayerName.text = "";
				PlayerSpeech.text = "";
				Char1name.text = "Temen";
				Char1speech.text = "Kamu enggak apa-apa kan? Jangan-jangan kamu sakit atau semacamnya...";
				}

			else if (primeInt == 28){
				PlayerName.text = "Kamu";
				PlayerSpeech.text = "Ahahah, aku enggak apa-apa kok, cuma rasanya agak lelah aja...";
				Char1name.text = "";
				Char1speech.text = "";
				}

			else if (primeInt == 29){
				PlayerName.text = "Kamu";
				PlayerSpeech.text = "Kek, hari berasa lama banget? Mungkin karena itu, aku ngira sekarang udah Kamis...";
				Char1name.text = "";
				Char1speech.text = "";
				}

			else if (primeInt == 30){
				ArtChar4.SetActive(false);
				ArtChar3.SetActive(true);
				PlayerName.text = "";
				PlayerSpeech.text = "";
				Char1name.text = "Temen";
				Char1speech.text = "Hmmm, oke deh kalau gitu.";
				}

			else if (primeInt == 31){
				ArtChar3.SetActive(false);
				ArtChar4.SetActive(true);
				PlayerName.text = "";
				PlayerSpeech.text = "";
				Char1name.text = "Temen";
				Char1speech.text = "Tapi, jaga-jaga kamu istirahat aja dulu, mumpung kelasmu masih siang.";
				}

			else if (primeInt == 32){
				PlayerName.text = "";
				PlayerSpeech.text = "";
				Char1name.text = "Temen";
				Char1speech.text = "Oke deh, aku lanjut tidur lagi aja dulu... Makasih sarannya ya.";
				}

			else if (primeInt == 33){
				PlayerName.text = "";
				PlayerSpeech.text = "";
				Char1name.text = "";
				Char1speech.text = "";
				ArtBG1.SetActive(false);
				ArtBG2.SetActive(true);
				ArtChar4.SetActive(false);
				nextButton.SetActive(false);
				allowSpace = false;
				NextScene1Button.SetActive(true);
				}
		}

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
	public void Choice1aFunct(){
		PlayerName.text = "Kamu";
		PlayerSpeech.text = "Sekarang jam berapa ya?";
		Char1name.text = "";
		Char1speech.text = "";
		primeInt = 399;
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		nextButton.SetActive(true);
		allowSpace = true;
	}

	public void Choice1bFunct(){
		PlayerName.text = "Kamu";
		PlayerSpeech.text = "Kok kamu belum berangkat?";
		Char1name.text = "";
		Char1speech.text = "";
		primeInt = 499;
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		nextButton.SetActive(true);
		allowSpace = true;
	}

	public void Choice1cFunct(){
		ArtChar5.SetActive(false);
		ArtChar3.SetActive(false);
		ArtChar4.SetActive(true);
		PlayerName.text = "";
		PlayerSpeech.text = "";
		Char1name.text = "Temen";
		Char1speech.text = "Kamu masih teler habis bangun tidur, ya?";
		primeInt = 23;
		Choice1c.SetActive(false);
		nextButton.SetActive(true);
		allowSpace = true;
	}

	public void SceneChange2a(){
		SceneManager.LoadScene("scene1");
	}
}
