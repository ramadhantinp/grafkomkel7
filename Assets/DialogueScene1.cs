using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene1 : MonoBehaviour {
	public int primeInt = 1; // This integer drives game progress!
	public Text PlayerName;
	public Text PlayerSpeech;
	public Text Char1name;
	public Text Char1speech;
	public GameObject dialogue;
	public GameObject ArtChar1; //kaget
	public GameObject ArtChar2; //marah
	public GameObject ArtChar3; //netral
	public GameObject ArtChar4; //khawatir
	public GameObject ArtChar5; //senyum mata tutup
	public GameObject ArtHantu1;
	public GameObject ArtHantu2;
	public GameObject ArtHantu3;
	public GameObject ArtHantu4;
	public GameObject ArtHantu5;
	public GameObject ArtBG1; //hitam
	public GameObject ArtBG2; //asrama pagi
	public GameObject ArtBG3; //kelas siang
	public GameObject ArtBG4; //kelas malam
	public GameObject ArtBG5; //lorong
	public GameObject ArtBG6; //jalan
	public GameObject ArtBG7; //asrama malam
	public GameObject CGmalam1;
	public GameObject CGmalam2;
	public GameObject Choice1a;
	public GameObject Choice1b;
	public GameObject Choice2a;
	public GameObject Choice2b;
	public GameObject Choice3a;
	public GameObject Choice3b;
	public GameObject Choice4;
	public GameObject NextScene1Button;
	public GameObject NextScene2Button;
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
		ArtHantu1.SetActive(false);
		ArtHantu2.SetActive(false);
		ArtHantu3.SetActive(false);
		ArtHantu4.SetActive(false);
		ArtHantu5.SetActive(false);
		ArtBG1.SetActive(false);
		ArtBG2.SetActive(false);
		ArtBG3.SetActive(true);
		ArtBG4.SetActive(false);
		ArtBG5.SetActive(false);
		ArtBG6.SetActive(false);
		ArtBG7.SetActive(false);
		CGmalam1.SetActive(false);
		CGmalam2.SetActive(false);
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		Choice2a.SetActive(false);
		Choice2b.SetActive(false);
		Choice3a.SetActive(false);
		Choice3b.SetActive(false);
		Choice4.SetActive(false);
		NextScene1Button.SetActive(false);
		NextScene2Button.SetActive(false);
		nextButton.SetActive(true);
	}

	void Update(){ // use spacebar as Next button
		if (allowSpace == true){
		if (Input.GetKeyDown("space")){
			if (primeInt==888) Choice4Funct();
		 	else talking();
			}
		}
	}

	//scene 6
	public void talking(){ // main story function. Players hit next to progress to next int
		primeInt = primeInt + 1;
		if (primeInt == 1){
			// AudioSource.Play();
		}
		else if (primeInt == 2){
			dialogue.SetActive(true);
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Soal mimpi semalam, aku penasaran...)";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt ==3){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "Aku enggak ingat apa-apa dan nggak tahu apa-apa.";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt == 4){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "Harusnya itu hal biasa karena mimpi memang sering dilupain.";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt == 5){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "Tapi...";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt == 6){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(... Rasanya, ada yang aneh.)";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt ==7){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Tapi itu kan... cuma mimpi...)";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt ==8){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Pasti... bakal...)";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt ==9){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(... baik-baik... aja kok...)";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt ==10){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Zzzzzzz........)";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt ==11){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "Zzzz...........";
			Char1name.text = "";
			Char1speech.text = "";
		}
		else if (primeInt ==12){
			ArtBG3.SetActive(false);
			ArtBG2.SetActive(true);
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "............";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt ==13){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "........";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt ==14){
			ArtBG2.SetActive(false);
			ArtBG4.SetActive(true);
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "....!!!!!";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt ==15){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Gelap banget... Tadi aku ketiduran!?)";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt ==16){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Jam berapa sih emang sekarang...?)";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt ==17){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "Jam 8 malam!? Tidurku kok bisa nyenyak banget sampai bablasnya sejauh ini!?";
			Char1name.text = "";
			Char1speech.text = "";
		}
		else if (primeInt ==18){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "Daripada itu, mending aku buru-buru ke asrama, nanti keburu jamal!";
			Char1name.text = "";
			Char1speech.text = "";
		}
		else if (primeInt ==19){
			ArtBG4.SetActive(false);
			ArtBG2.SetActive(true);
			PlayerName.text = "";
			PlayerSpeech.text = "Krieett... Drap drap drap drap...";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt ==20){
			ArtBG2.SetActive(false);
			ArtBG4.SetActive(true);
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "... Eh?";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt == 21){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "Di sini memang udah malem, tapi biasanya departemen masih rame sama orang ngumpul.";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt ==22){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "Tapi kok, ini sepi banget ya? Apa pada nongkrong di tempat lain?";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt == 23){
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "";
			Char1speech.text = "";
			// Turn off "Next" button, turn on "Choice" buttons
			nextButton.SetActive(false);
			allowSpace = false;
			Choice1a.SetActive(true);
			Choice1b.SetActive(true);
		}

		//scene 7
		else if (primeInt == 200){
			ArtBG2.SetActive(false);
			ArtBG5.SetActive(true);
			ArtHantu1.SetActive(true);
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Ah, ada orang! Ternyata memang nongkrongnya di tempat lain, ya.)";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt == 201){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Tapi kok, dia sendirian?)";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt == 202){
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "???";
			Char1speech.text = "..............";
		}

		else if (primeInt == 203){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Apa dia nyasar ya? Gedung kampus ini kan, emang ngebingungin.)";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt == 204){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Masuk di mana, eh, keluarnya di mana. Mirip pintu ke mana saja.)";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt == 205){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Kusamper aja kali ya, siapa tau bisa bantu.)";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt == 206){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Tapi orang itu.. Aku enggak tau kenapa, tapi rasanya ada yang aneh.)";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt == 207){
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "";
			Char1speech.text = "";
			nextButton.SetActive(false);
			allowSpace=false;
			Choice2a.SetActive(true);
			Choice2b.SetActive(true);
		}

		//scene 8
		else if (primeInt == 300){
			ArtBG2.SetActive(false);
			ArtBG6.SetActive(true);
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Hari ini rasanya aneh banget, ya. Bisa-bisanya aku ketiduran selama itu.)";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt == 301){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Enggak ada yang bangunin pula!)";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt == 302){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Gedung fakultas juga rasanya aneh.)";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt == 303){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "... Loh?";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt == 304){
			ArtHantu1.SetActive(true);
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Ada orang di lantai 2.. Dia lagi apa ya, sendirian di situ?)";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt == 305){
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "???";
			Char1speech.text = "..................";
		}

		else if (primeInt == 306){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Apa orang nyasar ya? Apa dia mau kumpul organisasi, tapi nyasar?)";
			Char1name.text = "";
			Char1speech.text = "";
		}

		else if (primeInt == 307){
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "";
			Char1speech.text = "";
			nextButton.SetActive(false);
			allowSpace=false;
			Choice2a.SetActive(true);
			Choice2b.SetActive(true);
			}

		//scene 9
		else if (primeInt == 667){
			ArtBG2.SetActive(false);
			ArtBG5.SetActive(true);
			ArtHantu1.SetActive(true);
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "Permisi mba... Mba nyasar lagi nyari yang kumpul-kumpul organisasikah?";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 668){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "Mungkin bisa aku bantu.";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 669){
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "???";
			Char1speech.text = "........";
			}

		else if (primeInt == 670){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "Atau baru kelar kumpul? Kalau mba anak PPKU juga, mau ke asrama bareng nggak?";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 671){
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "???";
			Char1speech.text = "........";
			}

		else if (primeInt == 672){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "... Mba?";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 673){
			ArtHantu1.SetActive(false);
			ArtHantu2.SetActive(true);
			PlayerSpeech.gameObject.GetComponentInParent<shaker>().ChangeShake(1f);
			PlayerName.text = "???";
			PlayerSpeech.text = "Kkkhh... kkkhhhhe...";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 674){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "HIII...!!!";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 675){
			ArtHantu2.SetActive(false);
			ArtHantu3.SetActive(true);
			PlayerSpeech.gameObject.GetComponentInParent<shaker>().ChangeShake(2f);
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "KYAAAAAAA!!!";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 676){
			ArtHantu3.SetActive(false);
			ArtHantu4.SetActive(true);
			PlayerName.text = "Kamu";
			PlayerSpeech.gameObject.GetComponentInParent<shaker>().ChangeShake(3f);
			PlayerSpeech.text = "AAAAAAAAAAAAAAAAAAAAAAAA!!!!!";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 677){
			ArtHantu4.SetActive(false);
			ArtHantu5.SetActive(true);
			PlayerSpeech.gameObject.GetComponentInParent<shaker>().ChangeShake(4f);
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "AAAAAA!!!!!";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 678){
			ArtBG2.SetActive(true);
			ArtHantu5.SetActive(false);
			ArtBG5.SetActive(false);
			PlayerName.text = "Kamu";
			PlayerSpeech.text = ".........";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 679){
			ArtBG2.SetActive(false);
			ArtBG1.SetActive(true);
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "WAAAAAAAA!!!!!";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 680){
			ArtChar1.SetActive(true);
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "Temen";
			Char1speech.text = "WAAAAAAA???!!!";
			}

		else if (primeInt == 681){
			ArtChar1.SetActive(false);
			ArtChar2.SetActive(true);
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "Temen";
			Char1speech.text = "Kamu ngapain sih, bangun-bangun langsung teriak!? Bikin kaget aja!";
			}

		else if (primeInt == 682){
			PlayerSpeech.gameObject.GetComponentInParent<shaker>().ChangeShake(0f);
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "........";
			Char1name.text = "";
			Char1speech.text = "";
			}

		//blackout
		else if (primeInt == 683){
			ArtChar2.SetActive(false);
			ArtBG2.SetActive(true);
			ArtBG1.SetActive(false);
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "... Loh?";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 684){
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "";
			Char1speech.text = "";
				}

		//scene 10
		else if (primeInt == 400){
			ArtBG2.SetActive(true);
			ArtBG6.SetActive(false);
			ArtHantu1.SetActive(false);
			PlayerName.text = "";
			PlayerSpeech.text = "Tep tep tep... Huff...";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 401){
			ArtBG2.SetActive(false);
			ArtBG7.SetActive(true);
			PlayerName.text = "";
			PlayerSpeech.text = "Tok tok tok... Kriettt... Ceklek!";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 402){
			ArtChar3.SetActive(true);
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "Assalamualaikum...";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 403){
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "Temen";
			Char1speech.text = "Waalaikumussalam... Tumben baru pulang?";
			}

		else if (primeInt == 404){
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "Temen";
			Char1speech.text = "Biasanya habis kelar kelas siang, kamu langsung balik ke asrama.";
			}

		else if (primeInt == 405){
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "";
			Char1speech.text = "";
			nextButton.SetActive(false);
			allowSpace=false;
			Choice3a.SetActive(true);
			Choice3b.SetActive(true);
			}

		//scene 11
		else if (primeInt == 500){
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "Temen";
			Char1speech.text = "Bisa gitu ya, nugas keasikan...";
			}

		else if (primeInt == 501){
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "Temen";
			Char1speech.text = "Hmm, okelah kalau begitu. Aku mau kerkom ke kamar sebelah dulu.";
			}

		else if (primeInt == 502){
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "Temen";
			Char1speech.text = "Kalau mau tidur duluan, kunci aja ya. Aku bawa kunci kok.";
			nextButton.SetActive(false);
			Choice4.SetActive(true);
			}

		//scene 12
		else if (primeInt == 600){
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "Temen";
			Char1speech.text = "'Yaa gitu deh,' Gimana maksudnya...";
			nextButton.SetActive(true);
			allowSpace=true;
			}

		else if (primeInt == 601){
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "Temen";
			Char1speech.text = "Dahlah, aku mau kerkom dulu di kamar sebelah.";
			}

		else if (primeInt == 602){
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "Temen";
			Char1speech.text = "Nanti kalau mau tidur duluan, kunci aja ya. Aku bawa kunci kok.";
			nextButton.SetActive(false);
			Choice4.SetActive(true);
			}

		//scene 13
		else if (primeInt == 889){
			ArtChar4.SetActive(false);
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "";
			Char1speech.text = "Srek srek... Tap tap tap... Kriettt... Ceklek!";
			}

		else if (primeInt == 890){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(... Tidur sekarang aja, deh. Ganti baju dulu, gerah.)";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 891){
			ArtBG2.SetActive(true);
			ArtBG7.SetActive(false);
			ArtChar3.SetActive(false);
			PlayerName.text = "";
			PlayerSpeech.text = "Kriet... Srek srek srek... Sruk!";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 892){
			ArtBG2.SetActive(false);
			CGmalam1.SetActive(true);
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Kejadian hari ini bener-bener aneh, ya. Berasa gak nyata banget.)";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 893){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Sebenernya aku pengen tau lebih lanjut, tapi...)";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 894){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Rasanya, sebaiknya, lebih baik aku enggak cari tahu.)";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 895){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Ada hal yang memang lebih baik enggak diketahuin sama sekali.)";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 896){
			CGmalam1.SetActive(false);
			CGmalam2.SetActive(true);
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "(Aku anggap aja kejadian hari ini salah satunya.)";
			Char1name.text = "";
			Char1speech.text = "";
			}
			//blackout
		else if (primeInt == 897){
			CGmalam2.SetActive(false);
			ArtBG2.SetActive(true);
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "Dengan begitu, aku tertidur dengan lelap karena lelah.";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 898){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "Besoknya, aku terbangun sendirian di asrama.";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 899){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "Teman sekamarku sudah berangkat duluan untuk praktikum pagi.";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 900){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "Aku pun juga bersiap-siap untuk kuliah di CCR.";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 901){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "Setelahnya, aku tidak pernah mengalami kejadian aneh seeperti itu lagi.";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 902){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "Namun, tentu saja kejadian kemarin akan terus terukir jelas dalam ingatanku.";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 903){
			PlayerName.text = "Kamu";
			PlayerSpeech.text = "Bersamaan dengan rasa penasaranku yang berusaha kukubur dalam-dalam.";
			Char1name.text = "";
			Char1speech.text = "";
			}

		else if (primeInt == 904){
			PlayerName.text = "";
			PlayerSpeech.text = "";
			Char1name.text = "";
			Char1speech.text = "";
			}
		}

	//scene 7
	public void Choice1aFunct(){
		ArtBG4.SetActive(false);
		ArtBG2.SetActive(true);
		PlayerName.text = "";
		PlayerSpeech.text = "Drap drap drap drap...";
		Char1name.text = "";
		Char1speech.text = "";
		primeInt = 199;
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		nextButton.SetActive(true);
		allowSpace = true;
	}

	//scene 8
	public void Choice1bFunct(){
		ArtBG4.SetActive(false);
		ArtBG2.SetActive(true);
		PlayerName.text = "";
		PlayerSpeech.text = "Drap drap drap drap...";
		Char1name.text = "";
		Char1speech.text = "";
		primeInt = 299;
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		nextButton.SetActive(true);
		allowSpace = true;
	}

	//scene 9
	public void Choice2aFunct(){
		primeInt = 666;
		ArtHantu1.SetActive(false);
		ArtBG6.SetActive(false);
		ArtBG5.SetActive(false);
		ArtBG2.SetActive(true);
		PlayerName.text = "";
		PlayerSpeech.text = "Tep tep tep tep...";
		Char1name.text = "";
		Char1speech.text = "";
		Choice2a.SetActive(false);
		Choice2b.SetActive(false);
		nextButton.SetActive(true);
		allowSpace = true;
	}

	//scene 10
	public void Choice2bFunct(){
		PlayerName.text = "Kamu";
		PlayerSpeech.text = "... Sebaiknya aku buru-buru pulang aja deh.";
		Char1name.text = "";
		Char1speech.text = "";
		primeInt = 399;
		Choice2a.SetActive(false);
		Choice2b.SetActive(false);
		nextButton.SetActive(true);
		allowSpace = true;
	}

	//scene 11
	public void Choice3aFunct(){
		primeInt = 499;
		ArtChar5.SetActive(false);
		ArtChar3.SetActive(false);
		ArtChar4.SetActive(true);
		PlayerName.text = "Kamu";
		PlayerSpeech.text = "Tadi aku habis nongkrong di A2 soalnya. Eh, keasikan tugas, hehe.";
		Char1name.text = "";
		Char1speech.text = "";
		Choice3a.SetActive(false);
		Choice3b.SetActive(false);
		nextButton.SetActive(true);
		allowSpace = true;
	}

	//scene 12
	public void Choice3bFunct(){
		PlayerName.text = "Kamu";
		PlayerSpeech.text = "Yaa... Gitu deh, hehehe.";
		Char1name.text = "";
		Char1speech.text = "";
		primeInt = 599;
		Choice3a.SetActive(false);
		Choice3b.SetActive(false);
		nextButton.SetActive(true);
		allowSpace = true;

	}

	//scene13
	public void Choice4Funct(){
		PlayerName.text = "Kamu";
		PlayerSpeech.text = "Oke sip, semangat nugasnya ya.";
		Char1name.text = "";
		Char1speech.text = "";
		primeInt = 888;
		nextButton.SetActive(true);
		allowSpace = true;
		Choice4.SetActive(false);
	}

	public void SceneChange2a(){
		// SceneManager.LoadScene("Scene2a");
	}
	public void SceneChange2b(){
		// SceneManager.LoadScene("Scene2b");
	}
}
